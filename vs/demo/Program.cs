using System;
using System.Collections.Generic;

namespace demo
{
    class Program
    {
        int? optionalInt = default;
        string? optionalString = default;
        (double Sum, int Count) t = (4.5,1);
        static void Main(string[] args)
        {
            
        }
    }
    public struct MyStruct { 
        public double X { get; }
        public double Y { get; }
        public MyStruct(double x, double y) => (X, Y) = (x,y);
    }
    interface IControl {
        void Paint();
    }
    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }
    interface IComboBox : ITextBox, IListBox { }
    public enum SomeRootVegetable {
        HorseRadish,
        Radish,
        Turnip
    }
    public enum Seasons
    {
        None = 0,
        Summer = 1,
        Autumn = 2,
        Winter = 4,
        Spring = 8,
        All = Summer | Autumn | Winter | Spring
    }
    public abstract class Expression {
        public abstract double Evaluate(Dictionary<string, object> vars);
    }
    public class Constant : Expression
    {
        double _value;
        public Constant(double value)
        {
            _value = value;
        }
        public override double Evaluate(Dictionary<string, object> vars)
        {
            return _value;
        }
    }
    public class VariableReference : Expression
    {
        string _name;
        public VariableReference(string name)
        {
            _name = name;
        }
        public override double Evaluate(Dictionary<string, object> vars)
        {
            object value = vars[_name] ?? throw new Exception($"Unknown variable: {_name}");
            return Convert.ToDouble(value);
        }
    }
    public class Operation : Expression
    {
        Expression _left;
        char _op;
        Expression _right;
        public Operation(Expression left, char op, Expression right)
        {
            _left = left;
            _op = op;
            _right = right;
        }
        public override double Evaluate(Dictionary<string, object> vars)
        {
            double x = _left.Evaluate(vars);
            double y = _right.Evaluate(vars);
            switch (_op)
            {
                case '+': return x + y;
                case '-': return x - y;
                case '*': return x * y;
                case '/': return x / y;

                default: throw new Exception("Unknown operator");
            }
        }
    }
}
