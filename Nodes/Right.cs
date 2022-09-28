using FloodFillProject.Space;

namespace FloodFillProject.Nodes;

public class Right : Node
{
    public Right(int line, int column) : base(line, column)
    {
    }

    public override Position Next(Matrix area)
    {
        if (Column + 1 < area.Column) return new Right(Line, Column + 1);

        Console.WriteLine($"---Right Next null position: {ToString()}");
        return null;
    }
}

