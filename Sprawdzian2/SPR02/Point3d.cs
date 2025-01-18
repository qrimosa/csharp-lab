using System;
using System.Collections.Generic;
using System.Linq;

public class PointThreeD{
    public PointThreeD(double x, double y, double z){
        this.X = x; 
        this.Y = y; 
        this.Z = z;
    }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public double GetDistanceFromOrigin(){
        return Math.Sqrt(X*X + Y*Y + Z*Z);
    }
}