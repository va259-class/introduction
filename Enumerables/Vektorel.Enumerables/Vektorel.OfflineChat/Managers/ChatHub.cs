namespace Vektorel.OfflineChat.Managers
{
    public class ChatHub
    {
        private static ChatHub instance;
        private ChatHub() { }

        public static ChatHub Create()
        {
            if (instance != null)
            {
                return instance;
            }
            instance = new ChatHub();
            return instance;
        }
    }
}
