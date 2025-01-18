using System;
using System.Collections.Generic;
using System.Linq;

public class Adult : Human{
    public Adult(string name) : base(name) { 
        Children = new List<Child>();
    }
    public List<Child> Children { get; set; }
    public void AddChild(Child child){
        Children.Add(child);
    }
    public int CountChildren(){
        return Children.Count();
    }
    public override string EatSnack()
    {
        return "Cake.";
    }
}