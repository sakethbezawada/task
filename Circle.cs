using System;

public class Circle : Shape{
  private int _radius;
  
  public int Radius{
    set{
      _radius = value;
    }
    get{
      return _radius;
    }
  }
  public override void CalculateArea(){
    Area = (22/7) * Radius * Radius;
  }
  public override void CalculatePerimeter(){
    Perimeter = (2 * (22/7) * Radius);
  }
  public Circle(){
    Console.WriteLine("This is circle");
  }

}