using Uaine.MonoInput;

namespace Uaine.Objects.Primitives
{
    public class TextObject
    {
        public Alignment alignment { get; set; }
        public string Text { get; set; }
        public bool blankText()
        {
            return Text == "";
        }
        
        public TextObject(string text, Alignment align)
        {
            Text = text;
            alignment = align;
        }
        public TextObject(string text)
        {
            Text = text;
            alignment = Alignment.Left;
        }

        public static TextObject Blank = new TextObject("");
    }
}
