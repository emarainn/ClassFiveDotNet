using static ClassFiveDotNet.Program;

namespace ClassFiveDotNet
{
    public interface ICombatant
    {
        public string Name { get; set; }
        public IArmor Armor { get; set; }
        public IWeapon Weapon { get; set; }

        void Attack(ICombatant enemy); //makes it so that all fighters have access to an attack method
    }
}