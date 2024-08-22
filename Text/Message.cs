namespace Uaine.Objects.Text
{
    public class TextMessage
    {
        public TextObject Title;
        public TextObject Description;
        public TextMessage(TextObject title)
        {
            Title = title;
            Description = new TextObject("");
        }
        public TextMessage(TextObject title, TextObject desc)
        {
            Title = title;
            Description = desc;
        }
    }
}
