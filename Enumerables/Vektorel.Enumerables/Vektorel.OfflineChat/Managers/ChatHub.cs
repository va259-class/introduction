namespace Vektorel.OfflineChat.Managers;

public class ChatHub
{
    private static ChatHub instance;
    private static object _lock = new object();
    private ChatHub() { }

    public event UserRegistered OnUserRegistered;
    public event MessageSent OnMessageSent;

    public static ChatHub Create()
    {
        // Singleton Pattern
        if (instance != null)
        {
            return instance;
        }
        lock (_lock)
        {
            //double check
            if (instance != null)
            {
                return instance;
            }
            instance = new ChatHub();
            return instance;
        }
    }

    public void Register(string userName)
    {
        OnUserRegistered?.Invoke(userName);
    }

    public void SendMessage(string userName, string message)
    {
        OnMessageSent?.Invoke(userName, message);
    }
}

public delegate void UserRegistered(string userName);
public delegate void MessageSent(string userName, string message);