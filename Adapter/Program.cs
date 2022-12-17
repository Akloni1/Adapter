using Adapter;
using Adapter.Ellipse;

IShape circle = new Circle(6);

Console.WriteLine($"Площадь круга: {circle.Square()}");
Console.WriteLine($"Периметр круга: {circle.Perimeter()}");
circle.Draw();



Ellipse ellipse = new Ellipse(9,4);
IShape ellipseAdapter = new AdapterEllipse(ellipse);
Console.WriteLine($"Площадь элипса: {ellipseAdapter.Square()}");
Console.WriteLine($"Периметр элипса: {ellipseAdapter.Perimeter()}");
ellipseAdapter.Draw();