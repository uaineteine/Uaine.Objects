
using System.Text;

namespace Uaine.Objects.Primitives.ID
{
    public class PolyID64
    {
        public ID64[] IDs;
        public int NumIDs { get => IDs.Length; }
        public int Length { get => IDs.Length; }
        public ID64 TopLevelID { get => IDs[0]; }
        public ID64 BottomLevelID { get => IDs[Length - 1]; }
        public PolyID64(ID64[] IDArray)
        {
            IDs = IDArray;
        }
        public PolyID64(ID16[] IDArray)
        {
            IDs = new ID64[IDArray.Length];
            for (int i = 0; i < IDArray.Length; i++)
            {
                IDs[i] = new ID64(IDArray[i]);
            }
        }

        public PolyID64(ID32[] IDArray)
        {
            IDs = new ID64[IDArray.Length];
            for (int i = 0; i < IDArray.Length; i++)
            {
                IDs[i] = new ID64(IDArray[i]);
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
