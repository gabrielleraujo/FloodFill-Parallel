namespace FloodFillProject.Space;

public record Color
{
    public readonly int ActualColor;
    public readonly int NewColor;

    public Color(int actualColor, int newColor)
    {
        ActualColor = actualColor;
        NewColor = newColor;
    }    
}
