// See https://aka.ms/new-console-template for more information
using FloodFillProject;
using FloodFillProject.Nodes;
using FloodFillProject.Space;

//Console.WriteLine($"Please, enter to a area size.");
//Console.Write($"Size line: ");
//var line = Convert.ToInt32(Console.ReadLine());
//Console.Write($"Size column: ");
//var column = Convert.ToInt32(Console.ReadLine());
//var areaTest1 = new Matrix(line, column);
//Console.WriteLine($"The are size is:\n{areaTest1.ToString()}\n");

//areaTest1.FillWithAdditionOperatorDrawing(1, 0);
//areaTest1.FillAllEqual(0);
//areaTest1.Print();

var areaTest1 = new Matrix(5, 6);
// [1,2]
//areaTest1.Mtx = new int[5,6]
//{
//    {0, 1, 0, 0, 0, 0},
//    {0, 1, 1, 0, 1, 0},
//    {0, 1, 1, 0, 0, 0},
//    {0, 1, 0, 0, 0, 0},
//    {0, 1, 0, 1, 0, 0}
//};

// [2,2]
areaTest1.Mtx = new int[5, 6]
{
    {0, 1, 0, 0, 0, 0},
    {0, 1, 0, 0, 1, 0},
    {0, 0, 1, 0, 0, 0},
    {0, 1, 0, 0, 0, 0},
    {0, 1, 0, 1, 0, 0}
};
areaTest1.Print();


Console.WriteLine($"Please, enter to a position click.");
Console.Write($"Position line: ");
var clickLine = Convert.ToInt32(Console.ReadLine());
Console.Write($"Position column: ");
var clickColumn = Convert.ToInt32(Console.ReadLine());
var positionClick = new Node(clickLine, clickColumn);
positionClick.SetNeighbors(areaTest1);


Console.Write($"Change to color: ");
var newColor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The position click is:\n{positionClick.ToString()}\n");
var color = new Color(areaTest1.Mtx[positionClick.Line, positionClick.Column], newColor);


var floodFill = new FloodFill(areaTest1, positionClick, color);
floodFill.Run();
areaTest1.Print();