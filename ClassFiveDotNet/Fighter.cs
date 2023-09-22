

using static ClassFiveDotNet.Program;

namespace ClassFiveDotNet
{
    public class Fighter : ICombatant
    {
        public string Name { get; set; }
        public IArmor Armor { get; set; }
        public IWeapon Weapon { get; set; }

        public Fighter(string name, IArmor armor, IWeapon weapon)
        {
            Name = name;
            Armor = armor;
            Weapon = weapon;
        }

        public void Attack(ICombatant enemy)
        {
            Console.WriteLine($"{this.Name} attacks {enemy.Name} with {this.Weapon.Name}");
        }
    }
}