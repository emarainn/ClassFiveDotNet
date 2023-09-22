namespace ClassFiveDotNet
{
    public partial class Program
    {
        public class Leather : IArmor
        {
            public string Name { get; set; }
            public int Defense {get; set;}

            //default constructor
            public Leather() //this gets called when an instance gets made IArmor armor = new Leather(); in main
            {
                Name = "Leather Armor";
                Defense = 11;
            }

            //custructor
            public Leather(String name, int defense)
            {
                Name= name; 
                Defense = defense;
            }

            //method
            public void MyMethod()
            {

            }
        }

    }    
}