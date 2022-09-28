using FloodFillProject.Space;

namespace FloodFillProject.Nodes;

public class Left : Node
{
    public Left(int line, int column) : base(line, column)
    {
    }

    public override Position Next(Matrix area)
    {
        if (Column > 0) return new Left(Line, Column - 1);

        Console.WriteLine($"---Left Next null position: {ToString()}");
        return null;
    }
}
