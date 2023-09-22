namespace ClassFiveDotNet
{
    public partial class Program
    {
        public interface IArmor
        {
            //why do we want to implement properties? So that it can be different items/have different things (names/defense/behaviors)
            string Name { get; set; }
            int Defense { get; set; }
        }

    }    
}