namespace WarriorAndMageProject
{
    public class Armor : Item
    {
        private int _armorPoints;
        private ArmorType _armorType;
        private PlayerClass _playerClass;
        
        public ArmorType ArmorType
        {
            get {return  _armorType;}
        }

        public PlayerClass PlayerClass
        {
            get {return  _playerClass;}
        }

        public Armor(int maxStack, string name, string description, ArmorType armorType, PlayerClass playerClass, int armorPoints) : base(maxStack, name, description)
        {
            _armorType = armorType;
            _playerClass = playerClass;
            _armorPoints = armorPoints;
        }
    }
}