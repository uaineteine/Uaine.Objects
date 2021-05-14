namespace Uaine.Objects.Primitives
{
    public class Message
    {
        public TextObject Title;
        public TextObject Description;
        public Message(TextObject title)
        {
            Title = title;
            Description = new TextObject("");
        }
        public Message(TextObject title, TextObject desc)
        {
            Title = title;
            Description = desc;
        }
    }
}
