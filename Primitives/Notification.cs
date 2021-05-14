namespace Uaine.Objects.Primitives
{
    public class Notification
    {
        public Message message;
        public float NotificationTime { get; set; }
        public Notification(Message msg, float time)
        {
            message = msg;
            NotificationTime = time;
        }
    }
}
