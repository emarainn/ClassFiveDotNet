namespace ClassFiveDotNet
{
    public partial class Program
    {
        static void Main()
        {

            Console.Write(".Net Day 5 Choose Your Main: " +
                "\n1. Notes for Class/Day 5" +
                "\n2. IArmor : Interface Work" +
                "\nEnter Main Number: ");
            var answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    NotesForClass();
                    break;
                case "2":
                    InterfaceWork();
                    break;
            }
        }

        static void NotesForClass()
        {
            Console.WriteLine("\n-----------------------------------" +
                "\nNotes:" +
                "\nWhat are INTERFACES" +
                "\n\t- When creating an interface instead of public class you use keword interface" +
                "\n\t- It is intended to be like a blueprint (what do you want it to look like?)" +
                "\n\t- You can trust that a property exists because the interface forces it to exist" +
                "\n\nRandom:" +
                "\n\t- NEXT CLASS we are going over abstract interfaces");

        }

        static void InterfaceWork()
        {
            Console.WriteLine("\n-------------------------------------" +
                "\nInterface Work : Armor");

            Console.WriteLine("\nSpecialized Armor:");
            IWeapon sword = new Sword("Short Sword", 10);
            IArmor armor = new Leather("Elven Leather Armor", 12);
            Console.WriteLine($"You are wearing {armor.Name}");

            IWeapon newWeapon = new Hammer("Big Boy Hammer", 13);
            IArmor newArmor = new Belt("Magical FlewFlew Belt", 14);

            Console.WriteLine($"\nYour new weapon is: {newWeapon.Name}\nYour new armor is: {newArmor.Name}");

            ICombatant fighter = new Fighter("Fighter Fred", armor, sword);
            ICombatant badGuy = new Fighter("Scarry Monster", armor, sword);

            fighter.Attack(badGuy);
            
        }
    }    
}