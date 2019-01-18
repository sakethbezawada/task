using System;

public class Rectangle : Shape{
  private int _height;
  private int _width;
  
  public int Height{
    set{
      _height = value;
    }
    get{
      return _height;
    }
  }
  public int Width{
    set{
      _width = value;
    }
    get{
      return _width;
    }
  }
  public override void CalculateArea(){
    Area = 22/7 * Height *Width;
  }
  public override void CalculatePerimeter(){
    Perimeter = (2 * (Height + Width));
  }
  public Rectangle(){
    Console.WriteLine("This is Rectangle");
  }

}