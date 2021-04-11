
namespace Uaine.Objects.Primitives
{
    public class Alignment
    {
        public const int left = 0;
        public const int centre = 1;
        public const int right = 2;

        public int alignment;

        public Alignment(int c)
        {
            alignment = c;
        }

        public static Alignment Left = new Alignment(left);
        public static Alignment Centre = new Alignment(centre);
        public static Alignment Right = new Alignment(right);
    }
}
