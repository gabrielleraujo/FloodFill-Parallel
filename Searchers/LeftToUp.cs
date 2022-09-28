using FloodFillProject.Space;
using FloodFillProject.Nodes;

namespace FloodFillProject.Searchers;

public class LeftToUp : TryChangeColorTemplateMethod
{
    public LeftToUp(Matrix area, Color color) : base(area, color) 
    {
    }

    public void Run(int lineInitiateFrom, int columnInitiateFrom)
    {
        for (int column = columnInitiateFrom; column >= 0; column--)
        {
            if (TryChangeColor(new Up(lineInitiateFrom, column)) == false) return;
        }
    }

    protected override bool ConditionY(Node position) => Area.Mtx[position.Down.Line, position.Down.Column] == Color.NewColor;
    protected override bool ConditionX(Node position) => Area.Mtx[position.Right.Line, position.Right.Column] == Color.NewColor;
}
