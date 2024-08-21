namespace Uaine.Objects.Text
{
    public class Notification
    {
        public TextMessage message;
        public float NotificationTime { get; set; }
        public Notification(TextMessage msg, float time)
        {
            message = msg;
            NotificationTime = time;
        }
    }
}
