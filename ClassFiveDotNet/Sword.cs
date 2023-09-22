﻿
using static ClassFiveDotNet.Program;

namespace ClassFiveDotNet
{
    public partial class Program
    {
        public class Sword : IWeapon
        {   
            public string Name { get; set; }  
            public int Power { get; set; } 

            public Sword(string name, int power) {
                Name = name;
                Power = power ;
            }
        }
    }    
}

/*
            //When you write this:
            public int MyVar { get; set; }
      
            This is what it looks like in the background:
                    private int myVar;        
                    public int MyVar 
                    {
                        get { return myVar; }
                        set { myVar = value; }
                    }
                    

public void MyMethod()
{
    MyVar = 3 + 3;
}
        }

        public class MyNewClass
{
    public void MyNewMethod()
    {
        Sword sword = new Sword();
        var value = sword.MyVar;
        sword.MyVar = 3;
    }
*/