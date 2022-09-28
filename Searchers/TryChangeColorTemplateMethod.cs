using FloodFillProject.Space;
using FloodFillProject.Nodes;

namespace FloodFillProject.Searchers;

public abstract class TryChangeColorTemplateMethod
{
    protected readonly Matrix Area;
    protected readonly Color Color;

    public TryChangeColorTemplateMethod(Matrix area, Color color)
    {
        Area = area;
        Color = color;
    }

    protected bool TryChangeColor(Node position)
    {
        if (position is null) return false;

        position.SetNeighbors(Area);
        var next = position.Next(Area);

        if (ConditionY(position))
        {
            _ = position.ApplyColor(Area, Color);
            TryChangeColor((Node)next);
        }
        else if (ConditionX(position))
        {
            _ = position.ApplyColor(Area, Color);
            TryChangeColor((Node)next);
        }
        return true;
    }

    protected abstract bool ConditionY(Node position);
    protected abstract bool ConditionX(Node position);
}
