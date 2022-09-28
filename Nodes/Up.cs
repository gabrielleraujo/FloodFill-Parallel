using FloodFillProject.Space;

namespace FloodFillProject.Nodes;

public class Up : Node
{
    public Up(int line, int column) : base(line, column)
    {
    }

    public override Position Next(Matrix area)
    {
        if (Line > 0) return new Up(Line - 1, Column);

        Console.WriteLine($"---Up Next null position: {ToString()}");
        return null;
    }
}
