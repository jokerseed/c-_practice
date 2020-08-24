using System;

namespace c
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
    public class MySpecialAttribute : Attribute
    {
        public MySpecialAttribute(string desc)
        {
            Console.WriteLine(desc);
        }
    }
}