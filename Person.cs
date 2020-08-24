using System;

namespace c
{
    [MySpecial("attribute--test")]
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // public override string ToString()
        // {
        //     return "大傻子";
        // }

        public override string ToString() => "大傻叉";
    }
}