using System.ServiceModel;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace WCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "SendMessage" в коде и файле конфигурации.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service2 : IService2
    {
        List<ServerUser> users = new List<ServerUser>();

        public void Connect(string user_name)
        {
            ServerUser user = new ServerUser()
            {
                user_name = user_name,
                operationContext = OperationContext.Current
            };
            users.Add(user);

            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query = $"update Users set status = 'в сети' where user_name = '{user_name}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public void Disconnect(string user_name)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].user_name == user_name)
                {
                    users.RemoveAt(i);

                    SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
                    connection.Open();

                    string query = $"update Users set status = 'не в сети' where user_name = '{user_name}'";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public string SendMessageFriend(string message, string sender, string recipient, DateTime dateTime)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query = $"insert into FriendMessages(sender_id, recipient_id, message, message_date, status) " +
                           $"values((select user_id from Users where user_name = '{sender}'), (select user_id from Users where user_name = '{recipient}'), " +
                           $"'{message}', '{dateTime}', 'не прочитано')";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 1)
            {
                answer = "сообщение отправлено";

                for (int i = 0; i < users.Count; i++) if (users[i].user_name == recipient) users[i].operationContext.GetCallbackChannel<IService2CallBack>().SendMessageFriendCallBack(message, sender, dateTime);
            }
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public string SendMessageInRoom(int room_id, string sender_name, string message, DateTime dateTime)
        {
            string answer = "";
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query = $"insert into RoomMessages(room_id, sender_id, message, message_date) " +
                           $"values({room_id}, (select user_id from Users where user_name = '{sender_name}'), '{message}', '{dateTime}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 1)
            {
                answer = "сообщение отправлено";

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                query = $"select Users.user_name from RoomMembers " +
                        $"join Users on RoomMembers.user_id = Users.user_id " +
                        $"where RoomMembers.room_id = {room_id} and RoomMembers.status != 'забанен' and Users.user_name != '{sender_name}'";
                cmd = new SqlCommand(query, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    for (int i = 0; i < users.Count; i++)
                    {
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            if (users[i].user_name == table.Rows[j][0].ToString())
                            {
                                users[i].operationContext.GetCallbackChannel<IService2CallBack>().SendMessageInRoomCallBack(room_id, sender_name, message, dateTime);
                                break;
                            }
                        }
                    }
                }
            }
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public string ban(int room_id, string user_name, string game)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query = $"update RoomMembers set status = 'забанен' " +
                           $"where room_id = {room_id} " +
                           $"and user_id = (select user_id from Users where user_name = '{user_name}');\r\n" +
                           $"update Rooms set members_current = members_current - 1 where room_id = {room_id};";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 2) answer = "пользователь забанен";
            else answer = "ошибка";
            try
            {
                for (int i = 0; i < users.Count; i++) if (users[i].user_name == user_name) users[i].operationContext.GetCallbackChannel<IService2CallBack>().banCallBack(room_id, game);
            }
            catch { }

            connection.Close();
            return answer;
        }
    }
}
