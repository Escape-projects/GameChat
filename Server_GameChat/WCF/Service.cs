using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System;

namespace WCF
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service" в коде и файле конфигурации.
    public class Service : IService
    {
        public string login(string Email, string password)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select Email from Users where Email = '{Email}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                table = new DataTable();
                query = $"select Email, password from Users where Email = '{Email}' and password = '{password}'";
                cmd = new SqlCommand(query, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (table.Rows.Count > 0) answer = "вход";
                else answer = "неправильный пароль";
            }
            else answer = "неверный Email";

            connection.Close();
            return answer;
        }

        public string accountCheckForReg(string userName, string Email)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select user_name from Users where user_name = '{userName}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                table = new DataTable();
                query = $"select Email from Users where Email = '{Email}'";
                cmd = new SqlCommand(query, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (table.Rows.Count == 0) answer = "аккаунта не существует";
                else answer = "Email занят";
            }
            else answer = "Имя занято";

            connection.Close();
            return answer;
        }

        public string Reg(string userName, string Email, string password)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query = $"insert into Users(user_name, Email, password, status) values('{userName}', '{Email}', '{password}', 'не всети')";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 1) answer = "аккаунт зарегистрирован";
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public string getAccount(string Email)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select user_name, Email, password from Users where Email = '{Email}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0) answer = $"{table.Rows[0][0].ToString()} {table.Rows[0][1].ToString()} {table.Rows[0][2].ToString()}";
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public string FriendAdd(string userNameSender, string userNameRecipient)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select * from Users where user_name = '{userNameRecipient}'";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                adapter = new SqlDataAdapter();
                table = new DataTable();
                query = $"select userSender_id, userRecipient_id, status from Friends where userSender_id = (select user_id from Users where user_name = '{userNameSender}') " +
                        $"and userRecipient_id = (select user_id from Users where user_name = '{userNameRecipient}')";
                cmd = new SqlCommand(query, connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    query = $"select userSender_id, userRecipient_id, status from Friends where userSender_id = (select user_id from Users where user_name = '{userNameRecipient}') " +
                            $"and userRecipient_id = (select user_id from Users where user_name = '{userNameSender}')";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    table = new DataTable();
                    adapter.Fill(table);
                    if (table.Rows.Count == 0)
                    {
                        query = $"insert into Friends(userSender_id, userRecipient_id, status) values((select user_id from users where user_name = '{userNameSender}'), " +
                                $"(select user_id from users where user_name = '{userNameRecipient}'), 'отправлено')";
                        cmd = new SqlCommand(query, connection);
                        if (cmd.ExecuteNonQuery() == 1) answer = "приглашение отправленно";
                        else answer = "ошибка";
                    }
                    else if (table.Rows[0][2].ToString() != "принято")
                    {
                        query = $"update Friends set status = 'принято' where userSender_id = (select user_id from Users where user_name = '{userNameRecipient}') " +
                                $"and userRecepient_id = (select user_id from Users where user_name = '{userNameSender}')";
                        cmd = new SqlCommand(query, connection);
                        if (cmd.ExecuteNonQuery() == 1) answer = "пользователь добавлен в друзья";
                        else answer = "ошибка";
                    }
                    else answer = "пользователь уже находится в друзьях";
                }
                else
                {
                    if (table.Rows[0][2].ToString() == "принято") answer = "пользователь уже находится в друзьях";
                    else answer = "приглашение уже отправлено";
                }
            }
            else answer = "такого пользователя не существует";

            connection.Close();
            return answer;
        }

        public List<string> getFriendList(string userName, string type)
        {
            List<string> answer = new List<string>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query;
            SqlCommand cmd;

            switch (type)
            {
                case "отправленные приглашения":
                    query = $"select user_name from Users join Friends on Users.user_id = Friends.userRecipient_id where userSender_id = " +
                            $"(select user_id from Users where user_name = '{userName}') and friends.status = 'отправлено'";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        for (int i = 0; i < table.Rows.Count; i++) answer.Add(table.Rows[i][0].ToString());
                    }
                break;

                case "полученные приглашения":
                    query = $"select user_name from Users join Friends on Users.user_id = Friends.userSender_id where userRecipient_id = " +
                            $"(select user_id from Users where user_name = '{userName}') and friends.status = 'отправлено'";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        for (int i = 0; i < table.Rows.Count; i++) answer.Add(table.Rows[i][0].ToString());
                    }
                break;

                case "все друзья":
                    query = $"select user_name from Users " +
                            $"join Friends on Users.user_id = Friends.userRecipient_id where userSender_id = (select user_id from Users where user_name = '{userName}') and friends.status = 'принято' " +
                            $"union " +
                            $"select user_name from Users " +
                            $"join Friends on Users.user_id = Friends.userSender_id where userRecipient_id = (select user_id from Users where user_name = '{userName}') and friends.status = 'принято'";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        for (int i = 0; i < table.Rows.Count; i++) answer.Add(table.Rows[i][0].ToString());
                    }
                break;

                case "друзья в сети":
                    query = $"select user_name from Users " +
                            $"join Friends on Users.user_id = Friends.userRecipient_id where userSender_id = (select user_id from Users where user_name = '{userName}') and friends.status = 'принято' and Users.status = 'в сети' " +
                            $"union " +
                            $"select user_name from Users " +
                            $"join Friends on Users.user_id = Friends.userSender_id where userRecipient_id = (select user_id from Users where user_name = '{userName}') and friends.status = 'принято' and Users.status = 'в сети'";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        for (int i = 0; i < table.Rows.Count; i++) answer.Add(table.Rows[i][0].ToString());
                    }
                break;
            }

            connection.Close();
            return answer;
        }

        public string unfriend(string userNameSender, string userNameFriend)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"delete from friends where userSender_id = (select user_id from Users where user_name = '{userNameSender}') and userRecipient_id = (select user_id from Users where user_name = '{userNameFriend}') " +
                           $"or userSender_id = (select user_id from Users where user_name = '{userNameFriend}') and userRecipient_id = (select user_id from Users where user_name = '{userNameSender}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 1) answer = "удалён";
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public string acceptInvation(string userNameSender, string userNameFriend)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"update friends set status = 'принято' where userSender_id = (select user_id from Users where user_name = '{userNameSender}') and userRecipient_id = (select user_id from Users where user_name = '{userNameFriend}') " +
                           $"or userSender_id = (select user_id from Users where user_name = '{userNameFriend}') and userRecipient_id = (select user_id from Users where user_name = '{userNameSender}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 1) answer = "приглашение принято";
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public List<string[]> getMessages(string userNameSender, string userNameFriend)
        {
            List<string[]> answer = new List<string[]>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select users_sender.user_name, message, message_date from FriendMessages " +
                           $"join Users as users_sender on FriendMessages.sender_id = users_sender.user_id " +
                           $"join Users as users_recipient on FriendMessages.recipient_id = users_recipient.user_id " +
                           $"where sender_id = (select user_id from Users where user_name = '{userNameSender}') and recipient_id = (select user_id from Users where user_name = '{userNameFriend}') " +
                           $"or sender_id = (select user_id from Users where user_name = '{userNameFriend}') and recipient_id = (select user_id from Users where user_name = '{userNameSender}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string[] row = new string[3];
                    row[0] = table.Rows[i][0].ToString();
                    row[1] = table.Rows[i][1].ToString();
                    row[2] = table.Rows[i][2].ToString();
                    answer.Add(row);
                }
            }

            connection.Close();
            return answer;
        }

        public List<string> getFriendsListWithMessage(string userName)
        {
            List<string> answer = new List<string>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select user_name, max(message_date) as last_message_date from FriendMessages " +
                           $"join Users on (sender_id = user_id or recipient_id = user_id) " +
                           $"where " +
                           $"(sender_id = (select user_id from Users where user_name = '{userName}') or recipient_id = (select user_id from Users where user_name = '{userName}')) " +
                           $"and user_id != (select user_id from Users where user_name = '{userName}') " +
                           $"group by user_id, user_name " +
                           $"order by last_message_date desc;";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++) answer.Add(table.Rows[i][0].ToString());
            }

            connection.Close();
            return answer;
        }

        public List<string> getGames()
        {
            List<string> answer = new List<string>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select game_name from Games;";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++) answer.Add(table.Rows[i][0].ToString());
            }

            connection.Close();
            return answer;
        }

        public byte[] getImageGame(string game_name)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select game_image from Games where game_name = '{game_name}';";
            SqlCommand cmd = new SqlCommand(query, connection);
            var answer = cmd.ExecuteScalar();

            connection.Close();
            return answer as byte[];
        }

        public string createRoom(string user_creator, string game, string room_name, string password, int members_max)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select room_name from Rooms where game_id = (select game_id from Games where game_name = '{game}') and room_name = '{room_name}';";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count < 1)
            {
                adapter = new SqlDataAdapter();
                if (members_max > 0) query = $"insert into Rooms(game_id, room_name, password, members_current, members_max) " +
                                             $"values((select game_id from Games where game_name = '{game}'), '{room_name}', '{password}', {1}, {members_max});";
                else query = $"insert into Rooms(game_id, room_name, password, members_current, members_max) " +
                             $"values((select game_id from Games where game_name = '{game}'), '{room_name}', '{password}', null, null);";
                cmd = new SqlCommand(query, connection);
                adapter.SelectCommand = cmd;
                if (cmd.ExecuteNonQuery() == 1)
                {
                    adapter = new SqlDataAdapter();
                    query = $"insert into RoomMembers(user_id, room_id, status) " +
                            $"values((select user_id from Users where user_name = '{user_creator}'), " +
                            $"(select room_id from Rooms where room_name = '{room_name}' and game_id = (select game_id from Games where game_name = '{game}')), 'создатель')";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();

                    answer = "комната создана";
                }
                else answer = "ошибка";
            }
            else answer = "Имя комнаты уже существует в этой игре";

            connection.Close();
            return answer;
        }

        public List<string[]> getRooms(string game_user, string game_or_user)
        {
            List<string[]> answer = new List<string[]>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "";
            if (game_or_user == "game") query = $"select room_id, room_name, password, members_current, members_max from Rooms where game_id = (select game_id from Games where game_name = '{game_user}')";
            else if (game_or_user == "user") query = $"select Rooms.room_id, room_name, password, members_current, members_max, game_name from Rooms " +
                                                     $"join RoomMembers on Rooms.room_id = RoomMembers.room_id " +
                                                     $"join Games on Rooms.game_id = Games.game_id " +
                                                     $"where user_id = (select user_id from Users where user_name = '{game_user}') and status != 'забанен' " +
                                                     $"order by game_name asc";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string[] row = new string[4];
                    if (game_or_user == "user") row = new string[5];

                    row[0] = table.Rows[i][0].ToString();
                    row[1] = table.Rows[i][1].ToString();
                    row[2] = table.Rows[i][2].ToString();
                    if (table.Rows[i][4].ToString() == "") row[3] = "null";
                    else row[3] = $"{table.Rows[i][3]}/{table.Rows[i][4]}";

                    if (game_or_user == "user") row[4] = table.Rows[i][5].ToString();

                    answer.Add(row);
                }
            }

            connection.Close();
            return answer;
        }

        public string joinRoom(int room_id, string user_name, bool checkOnlyStatus)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select status from RoomMembers where user_id = (select user_id from Users where user_name = '{user_name}') and room_id = {room_id}";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                answer = "не является участником комнаты";

                if (!checkOnlyStatus)
                {
                    query = $"insert into RoomMembers(user_id, room_id, status) values((select user_id from Users where user_name = '{user_name}'), {room_id}, 'участник');\r\n" +
                            $"update Rooms set members_current = members_current + 1 where room_id = {room_id};";
                    cmd = new SqlCommand(query, connection);
                    if (cmd.ExecuteNonQuery() == 2) answer = "стал участником комнаты";
                    else answer = "ошибка";
                }
            }
            else
            {
                answer = table.Rows[0][0].ToString();
            }

            connection.Close();
            return answer;
        }

        public string roomExit(string user_name, int room_id, bool membersMax)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"delete from RoomMembers where user_id = (select user_id from Users where user_name = '{user_name}') and room_id = {room_id}";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            if (cmd.ExecuteNonQuery() == 1)
            {
                answer = "покинул комнату";

                if (membersMax)
                {
                    query = $"update Rooms set members_current = members_current - 1 where room_id = {room_id}";
                    cmd = new SqlCommand(query, connection);
                    adapter.SelectCommand = cmd;
                    cmd.ExecuteNonQuery();
                }
            }
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public string roomSetting(string operation, string operation_object)
        {
            string answer = "";
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query;
            SqlCommand cmd;
            switch (operation)
            {
                case "сменить пароль":
                    query = $"update Rooms set password = '{operation_object.Split(';')[1]}' where room_id = {operation_object.Split(';')[0]}";
                    cmd = new SqlCommand(query, connection);
                    if (cmd.ExecuteNonQuery() == 1) answer = "пароль изменён";
                    else answer = "ошибка";
                break;

                case "удалить комнату":
                    query = $"delete from RoomMembers where room_id = {operation_object};\r\n" +
                            $"delete from Rooms where room_id = {operation_object};";
                    cmd = new SqlCommand(query, connection);
                    if (cmd.ExecuteNonQuery() == 2) answer = "комната удалена";
                    else answer = "ошибка";
                break;

                case "разбанить участника":
                    query = $"delete from RoomMembers where room_id = {operation_object.Split(';')[0]} " +
                            $"and user_id = (select user_id from Users where user_name = '{operation_object.Split(';')[1]}')";
                    cmd = new SqlCommand(query, connection);
                    if (cmd.ExecuteNonQuery() == 1) answer = "пользователь разбанен";
                    else answer = "ошибка";
                break;
            }

            connection.Close();
            return answer;
        }

        public List<string[]> getMembers(int room_id)
        {
            List<string[]> answer = new List<string[]>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select user_name, RoomMembers.status from Users " +
                           $"join RoomMembers on RoomMembers.user_id = Users.user_id where RoomMembers.room_id = {room_id} " +
                           $"order by case RoomMembers.status when 'создатель' then 1 when 'участник' then 2 when 'забанен' then 3 end asc";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string[] row = new string[2];
                    row[0] = table.Rows[i][0].ToString();
                    row[1] = table.Rows[i][1].ToString();

                    answer.Add(row);
                }
            }

            connection.Close();
            return answer;
        }

        public List<string[]> getMessagesInRoom(int room_id)
        {
            List<string[]> answer = new List<string[]>();
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select Users.user_name, message, message_date from RoomMessages " +
                           $"join Users on RoomMessages.sender_id = Users.user_id where room_id = {room_id}";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    string[] row = new string[3];
                    row[0] = table.Rows[i][0].ToString();
                    row[1] = table.Rows[i][1].ToString();
                    row[2] = table.Rows[i][2].ToString();
                    answer.Add(row);
                }
            }

            connection.Close();
            return answer;
        }

        public string messagesRead(string sender, string recipient)
        {
            string answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            string query = $"update FriendMessages set status = 'прочитано' where sender_id = (select user_id from Users where user_name = '{sender}') and " +
                           $"recipient_id = (select user_id from Users where user_name = '{recipient}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            if (cmd.ExecuteNonQuery() == 1) answer = "сообщения прочитаны";
            else answer = "ошибка";

            connection.Close();
            return answer;
        }

        public int getUnreadMessagesCount(string sender, string recipient)
        {
            int answer;
            SqlConnection connection = new SqlConnection(@"Data Source=DENNY\SERVER;Initial Catalog=GameChat;Integrated Security=True");
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = $"select count(status) from FriendMessages where sender_id = (select user_id from Users where user_name = '{sender}') " +
                           $"and recipient_id = (select user_id from Users where user_name = '{recipient}') and status = 'не прочитано'";
            SqlCommand cmd = new SqlCommand(query, connection);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
            answer = int.Parse(table.Rows[0][0].ToString());

            connection.Close();
            return answer;
        }
    }
}
