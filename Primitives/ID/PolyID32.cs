
using System.Text;

namespace Uaine.Objects.Primitives.ID
{
    public class PolyID32
    {
        public ID32[] IDs;
        public int NumIDs { get => IDs.Length; }
        public int Length { get => IDs.Length; }
        public ID32 TopLevelID { get => IDs[0]; }
        public ID32 BottomLevelID { get => IDs[Length - 1]; }
        public PolyID32(ID32[] IDArray)
        {
            IDs = IDArray;
        }
        public PolyID32(ID16[] IDArray)
        {
            IDs = new ID32[IDArray.Length];
            for (int i = 0; i < IDArray.Length; i++)
            {
                IDs[i] = IDArray[i];
            }
        }

        //overrides
        public override string ToString()
        {
            return ParseIntoString(".");
        }
        public string ParseIntoString(string delimitter)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Length - 1; i++)    //all but last
            {
                sb.Append(IDs[i].ToString() + delimitter);
            }
            sb.Append(IDs[Length - 1].ToString());
            return sb.ToString();
        }
    }
}
