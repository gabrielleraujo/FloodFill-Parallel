using FloodFillProject.Space;
using FloodFillProject.Nodes;
using FloodFillProject.Searchers;

namespace FloodFillProject;

public class FloodFill
{
    public readonly Matrix Area;
    public readonly Color Color;
    public readonly Node PositionClick;

    public FloodFill(Matrix area, Node positionClick, Color color)
    {
        Area = area;
        Color = color;
        PositionClick = positionClick;
    }

    private void ChangeColorRecursive(Position position)
    {
        if (position is null) return;
        if (position.ApplyColor(Area, Color) == false) return;

        ChangeColorRecursive(position.Next(Area));
    }

    public void Run()
    {
        TryDrawTheAdditionOperator();

        Console.WriteLine("=== Start Perpendicular Search on Neighbors =======================================\n");
        Parallel.Invoke(
            () => { new LeftToUp(Area, Color).Run(PositionClick.Line - 1, PositionClick.Column - 1); },
            () => { new LeftToDown(Area, Color).Run(PositionClick.Line + 1, PositionClick.Column - 1); },
            () => { new RightToUp(Area, Color).Run(PositionClick.Line - 1, PositionClick.Column + 1); },
            () => { new RightToDown(Area, Color).Run(PositionClick.Line + 1, PositionClick.Column + 1); });
        Console.WriteLine("=== End Perpendicular Search on Neighbors =========================================\n");
    }

    #region Draw (+)
    public void TryDrawTheAdditionOperator()
    {
        if (PositionClick is null) return;
        _ = PositionClick.ApplyColor(Area, Color);

        Console.WriteLine("\n=== Start - (+) Addition Operator Drawing ======================================================\n");
        Parallel.Invoke(
            () => { ChangeColorRecursive(PositionClick.Up); },
            () => { ChangeColorRecursive(PositionClick.Down); },
            () => { ChangeColorRecursive(PositionClick.Right); },
            () => { ChangeColorRecursive(PositionClick.Left); });
        Console.WriteLine("\n=== End - (+) Addition Operator Drawing =========================================================\n");
    }
    #endregion
}
