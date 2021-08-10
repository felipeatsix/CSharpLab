using AbstractClass.Abstractions;

namespace AbstractClass.Shapes
{
    public class Triangle : Shape
    {
        protected sealed override string[] Lines { get; } = { @"   /\" , @"  /  \" , @" /    \", @"/______\" };
    }
}