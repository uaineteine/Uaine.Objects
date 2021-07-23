
namespace Uaine.Objects.Primitives.ID
{
    public class PolyID32
    {
        public ID32[] IDs;
        public int NumIDs { get => IDs.Length; }
        public ID32 TopLevelID { get => IDs[0]; }
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
    }
}
