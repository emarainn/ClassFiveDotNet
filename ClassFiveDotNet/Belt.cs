namespace ClassFiveDotNet
{
    public partial class Program
    {
        public class Belt : IArmor
        {
            public string Name { get; set; }
            public int Defense { get; set; }

            // default constructor
            public Belt()
            {
                Name = "Magical Belt";
                Defense = 15;
            }
            // constructor
            public Belt(string name, int defense)
            {
                Name = name;
                Defense = defense;
            }

            // method
            public void MyMethod()
            {

            }
        }

    }    
}