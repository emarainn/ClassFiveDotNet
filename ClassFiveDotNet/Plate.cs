namespace ClassFiveDotNet
{
    public partial class Program
    {
        public class Plate : IArmor
        {
            string IArmor.Name
            {
                get => throw new NotImplementedException();
                set => throw new NotImplementedException();
            }
            int IArmor.Defense
            {
                get => throw new NotImplementedException();
                set => throw new NotImplementedException();
            }
        }

    }    
}