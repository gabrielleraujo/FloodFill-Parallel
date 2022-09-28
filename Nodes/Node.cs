using FloodFillProject.Space;

namespace FloodFillProject.Nodes;

public class Node : Position
{
    public Up? Up { get; private set; }
    public Right? Right { get; private set; }
    public Down? Down { get; private set; }
    public Left? Left { get; private set; }

    public Node(int line, int column) : base(line, column)
    {
    }

    public override Position Next(Matrix area) => Right;

    public void SetNeighbors(Matrix area)
    {
        if (Line < area.Line) 
            Down = new Down(Line + 1, Column);

        if (Column < area.Column) 
            Right = new Right(Line, Column + 1);

        if (Line > 0) 
            Up = new Up(Line - 1, Column);

        if (Column > 0) 
            Left = new Left(Line, Column - 1);
    }
}
