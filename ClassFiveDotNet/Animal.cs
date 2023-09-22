namespace ClassFiveDotNet
{
    public partial class Program
    {
        public class Animal { 
        public int Id { get; set; }
        public string Name { get; set; }
        public Owner? Owner { get; set; }//this makes it so owner cant be null, this creates a one to one relationship,
                                        //an owner can exist but it doesn't have to belong to an animal
        public string Type { get; set; }    
        }

        public class Owner//this makes it so that an Animal has to have an owner 
        {
            public string Name { get; set; }
            public string Address  { get; set; }


        }
    }    
}