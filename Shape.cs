using System;

public abstract class Shape{
  private float _area;
  private string _color;
  private float _perimeter;

public float Area{
  set{
    _area = value;
  }
  get{
    return _area;
  }
}
public string Color{
  set{
    _color = value;
  }
  get{
    return _color;
  }
}
public float Perimeter{
  set{
    _perimeter = value;
  }
  get{
    return _perimeter;
  }
}
public abstract void CalculateArea();
public abstract void CalculatePerimeter();

}
