using FloodFillProject.Space;

namespace FloodFillProject.Nodes;

public class Down : Node
{
    public Down(int line, int column) : base(line, column)
    {
    }

    public override Position Next(Matrix area)
    {
        if (Line + 1 < area.Line) return new Down(Line + 1, Column);

        Console.WriteLine($"---Down Next null position: {ToString()}");
        return null;
    }
}
