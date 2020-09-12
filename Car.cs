using System.Collections;
using System.Collections.Generic;
using System;


namespace c
{
    class Car : IComparable<Car>
    {
        public int A;
        public Car(int a)
        {
            A = a;
        }

        public int CompareTo(Car other)
        {
            return A - other.A;
        }
    }
}