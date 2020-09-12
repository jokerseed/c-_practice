using System.Runtime.Serialization;

namespace c
{
    public class Walk : ISerializable
    {
        public virtual void WalkHandle()
        {
            System.Console.WriteLine("走路");
        }

        public void GetObjectData(SerializationInfo s, StreamingContext sc)
        {

        }
    }
}