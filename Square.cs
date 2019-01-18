using System;

public class Square : Shape{
  private int _side;
  
  public int Side{
    set{
      _side = value;
    }
    get{
      return _side;
    }
  }
  public override void CalculateArea(){
    Area = Side * Side;
  }
  public override void CalculatePerimeter(){
    Perimeter = 4 * Side;
  }
  public Square(){
    Console.WriteLine("This is square");
  }

}