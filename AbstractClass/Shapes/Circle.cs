using AbstractClass.Abstractions;

namespace AbstractClass.Shapes
{
    public class Circle : Shape
    {
        protected sealed override string[] Lines { get; } = {@"   -", @" /   \", @"|     |", @" \   /", @"   - "};
    }
}