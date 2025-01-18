using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Human{
    public Human Mother { get; set; }
    public Human Father { get; set; }
    protected Human(string name){
        Name = name;
    }
    public string Name { get; set; }
    public virtual string EatSnack() { return "Ice cream!"; }
    
}