using System;
/// <summary>
/// class Shape
/// </summary>
class Shape
{
    /// <summary>
    /// Throw Error
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
/// <summary>
/// Class Rectangel inherit from Shape
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
                width = value;
        }
    }
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");

            }
            else
            {
                height = value;
            }
        }
    }
    /// <summary>
    /// overide Area of shape
    /// </summary>
    /// <returns></returns>
    public override int Area()
    {
        return this.height * this.width;

    }
    /// <summary>
    /// overide to string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"[Rectangle] {this.width} / {this.height}";
    }
}
/// <summary>
/// Class Square inherit from rectangle
/// </summary>
class Square : Rectangle
{
    private int size;
    /// <summary>
    /// Getter and setter for size value
    /// </summary>
    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
                base.Height = value;
            base.Width = value;
            this.size = value;
        }

}
    /// <summary>
    /// overide to string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return String.Format("[Square] {0} / {0}", this.size);
    }
}