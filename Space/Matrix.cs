namespace FloodFillProject.Space;

public class Matrix
{
    public readonly int Line;
    public readonly int Column;
    public int[,] Mtx { get; set; }

    public Matrix(int line, int column)
    {
        Line = line;
        Column = column;
        Mtx = new int[Line, Column];
    }

    public void SetValue(int line, int column, int value)
    {
        Mtx[line, column] = value;
    }

    public void FillAllEqual(int value)
    {
        for (int i = 0; i < Line; i++)
        {
            for (int j = 0; j < Column; j++)
            {
                Mtx[i, j] = value;
            }
        }
    }

    public void FillWithAdditionOperatorDrawing(int center, int other)
    {
        var centerLine = (int)Math.Floor((decimal)Line / 2);
        var centerColumn = (int)Math.Floor((decimal)Column / 2);

        for (int i = 0; i < Line; i++)
        {
            for (int j = 0; j < Column; j++)
            {
                if(i == centerLine || j == centerColumn) Mtx[i, j] = center;
                else Mtx[i, j] = other;
            }
        }
    }

    public void FillRandom()
    {
        var random = new Random();

        for (int i = 0; i < Line; i++)
        {
            for (int j = 0; j < Column; j++)
            {
                var value = random.Next(0, 9);
                Mtx[i, j] = value;
            }
        }
    }

    public void Print()
    {
        for (int i = 0; i < Line; i++)
        {
            for (int j = 0; j < Column; j++)
                Console.Write($"{Mtx[i,j]} ");
            Console.WriteLine();
        }
    }

    public override string ToString() => $"[{Line}][{Column}]";
}
