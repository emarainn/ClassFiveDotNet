namespace ClassFiveDotNet
{
    public partial class Program
    {
        public class Hammer : IWeapon
        {
            public string Name { get; set; }
            public int Power { get; set; }

            public Hammer(string name, int power)
            {
                Name = name;
                Power = power;
            }
        }
    }    
}