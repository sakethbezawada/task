using System;

class MainClass {
  public static string option;

  public static void Main (string[] args) {

    Console.WriteLine ("Choose a Shape:\n r.Rectangle\n s.Square\n c.Circle");
    option = Console.ReadLine();
     switch (option)
      {
          case "r":
             Rectangle sp = new Rectangle();
             Console.WriteLine("Enter Width");
             sp.Width = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Height");
             sp.Height = int.Parse(Console.ReadLine());
             sp.CalculateArea();
             sp.CalculatePerimeter();
             Console.WriteLine("Area:{0}",sp.Area);
             Console.WriteLine("Perimeter:{0}",sp.Perimeter);
             break;
             
          case "s":
             Square sp1 = new Square();
             Console.WriteLine("Enter Side");
             sp1.Side = int.Parse(Console.ReadLine());
             sp1.CalculateArea();
             sp1.CalculatePerimeter();
             Console.WriteLine("Area:{0}",sp1.Area);
             Console.WriteLine("Perimeter:{0}",sp1.Perimeter);
             break;

           case "c":
             Circle sp2 = new Circle();
             Console.WriteLine("Enter Radius");
             sp2.Radius = int.Parse(Console.ReadLine());
             sp2.CalculateArea();
             sp2.CalculatePerimeter();
             Console.WriteLine("Area:{0}",sp2.Area);
             Console.WriteLine("Perimeter:{0}",sp2.Perimeter);
              break;


          default:
              Console.WriteLine("Default case");
              break;
      }

      
  }
}