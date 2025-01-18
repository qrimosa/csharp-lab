using System;
using System.Collections.Generic;
using System.Linq;

public class Child : Human, ISinger{
    public Child(string name) : base(name){}
    public string Sing(){
        return "Baby shark doo doo doo doo";
    }
}