
using Task_2;



Circle circle_1= new Circle(5.6);
Console.WriteLine($"Circle radius : {circle_1.GetRadius()}\nCircle area : {circle_1.GetArea()}\nCircle diametr : {circle_1.GetDiameter()}\nCircle ference : {circle_1.GetCircumference()}");
Console.WriteLine("***************************************");
Circle circle_2 = new Circle();
circle_2.SetRadius(2.3);
Console.WriteLine($"Circle radius : {circle_2.GetRadius()}\nCircle area : {circle_2.GetArea()}\nCircle diametr : {circle_2.GetDiameter()}\nCircle ference : {circle_2.GetCircumference()}");
