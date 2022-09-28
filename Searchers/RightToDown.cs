using FloodFillProject.Space;
using FloodFillProject.Nodes;

namespace FloodFillProject.Searchers;

public class RightToDown : TryChangeColorTemplateMethod
{
    public RightToDown(Matrix area, Color color) : base(area, color)
    {
    }

    public void Run(int lineInitiateFrom, int columnInitiateFrom)
    {
        for (int column = columnInitiateFrom; column < Area.Column; column++)
        {
            if (TryChangeColor(new Down(lineInitiateFrom, column)) == false) return;
        }
    }

    protected override bool ConditionY(Node position) => Area.Mtx[position.Up.Line, position.Up.Column] == Color.NewColor;
    protected override bool ConditionX(Node position) => Area.Mtx[position.Left.Line, position.Left.Column] == Color.NewColor;
}
