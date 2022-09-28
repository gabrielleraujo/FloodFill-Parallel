namespace FloodFillProject.Space;

public abstract class Position
{
    public int Line { get; private set; }
    public int Column { get; private set; }

    public Position(int line, int column)
    {
        Line = line;
        Column = column;
    }

    public abstract Position Next(Matrix area);
    public override string ToString() => $"[{Line}][{Column}]";

    public bool ApplyColor(Matrix area, Color color)
    {
        if (Line >= area.Line || Column >= area.Column)
        {
            Console.WriteLine($"Error! -> Out of range {ToString()}.\n");
            return false;
        }
        LogApplyColor(area, color);

        if (area.Mtx[Line, Column] == color.ActualColor)
        {
            Console.WriteLine("CHANGED!");
            area.SetValue(Line, Column, color.NewColor);
            return true;
        }
        return false;
    }

    private void LogApplyColor(Matrix area, Color color)
    {
        Console.WriteLine("---ApplyColor\n");
        Console.WriteLine($"---ActualColor: {area.Mtx[Line, Column]}");
        Console.WriteLine($"---NewColor: {color.NewColor}");
        Console.WriteLine($"position: {ToString()}");
    }
}
