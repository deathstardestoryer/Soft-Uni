using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Rectangle
    {
    public string id;
    public double width;
    public double height;
    public double coordinates1;
    public double coordinates2;

    public Rectangle(string Id, double Width, double Height, double Coordinates1, double Coordiantes2)
    {
        this.id = Id;
        this.width = Width;
        this.height = Height;
        this.coordinates1 = Coordinates1;
        this.coordinates2 = Coordiantes2;
    }
    public bool IntersectionChecker(Rectangle rectangle)
    {
        return rectangle.coordinates1 + rectangle.width >= this.coordinates1 &&
            rectangle.coordinates1+rectangle.height>= this.coordinates1 &&
            rectangle.coordinates2 + rectangle.width
    }
    }

