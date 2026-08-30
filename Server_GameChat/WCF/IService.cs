using System.ServiceModel;
using System.Collections.Generic;
using System.Data;

namespace WCF
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "IService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string login(string Email, string password);

        [OperationContract]
        string accountCheckForReg(string userName, string Email);

        [OperationContract]
        string FriendAdd(string userNameSender, string userNameRecepient);

        [OperationContract]
        string Reg(string userName, string Email, string password);

        [OperationContract]
        string getAccount(string Email);

        [OperationContract]
        List<string> getFriendList(string userName, string type);

        [OperationContract]
        string unfriend(string userNameSender, string userNameFriend);

        [OperationContract]
        string acceptInvation(string userNameSender, string userNameFriend);

        [OperationContract]
        List<string[]> getMessages(string userNameSender, string userNameFriend);

        [OperationContract]
        List<string> getFriendsListWithMessage(string userName);

        [OperationContract]
        List<string> getGames();

        [OperationContract]
        byte[] getImageGame(string game_name);

        [OperationContract]
        string createRoom(string user_creator, string game, string room_name, string password, int membersNumber);

        [OperationContract]
        List<string[]> getRooms(string game_user, string game_or_user);

        [OperationContract]
        string joinRoom(int room_id, string user_name, bool checkOnlyStatus);

        [OperationContract]
        string roomExit(string user_name, int room_id, bool membersMax);

        [OperationContract]
        string roomSetting(string operation, string operation_object);

        [OperationContract]
        List<string[]> getMembers(int room_id);

        [OperationContract]
        List<string[]> getMessagesInRoom(int room_id);

        [OperationContract]
        string messagesRead(string sender, string recipient);

        [OperationContract]
        int getUnreadMessagesCount(string sender, string recipient);
    }
}
