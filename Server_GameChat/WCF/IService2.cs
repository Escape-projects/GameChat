using System;
using System.ServiceModel;

namespace WCF
{
    // ПРИМЕЧАНИЕ. Можно использовать команду "Переименовать" в меню "Рефакторинг", чтобы изменить имя интерфейса "ISendMessage" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IService2CallBack))]
    public interface IService2
    {
        [OperationContract]
        void Connect(string user_name);

        [OperationContract]
        void Disconnect(string user_name);

        [OperationContract]
        string SendMessageFriend(string message, string sender, string recipient, DateTime dateTime);

        [OperationContract]
        string SendMessageInRoom(int room_id, string sender_name, string message, DateTime dateTime);

        [OperationContract]
        string ban(int room_id, string user_name, string game);
    }

    public interface IService2CallBack
    {
        [OperationContract(IsOneWay = true)]
        void SendMessageFriendCallBack(string message, string sender, DateTime dateTime);

        [OperationContract(IsOneWay = true)]
        void SendMessageInRoomCallBack(int room_id, string sender_name, string message, DateTime dateTime);

        [OperationContract(IsOneWay = true)]
        void banCallBack(int room_id, string game);
    }
}
