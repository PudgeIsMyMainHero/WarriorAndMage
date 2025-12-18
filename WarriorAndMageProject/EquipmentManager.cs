using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    public static class EquipmentManager
    {
        private static Armor _helmet;
        private static Armor _legs;
        private static Armor _shoes;
        private static Armor _body;
        private static Armor _hands;
        private static Jewelry _ringRightHand;
        private static Jewelry _ringLeftHand;
        private static Jewelry _necklace;

        public static void EquipArmor(Player player, Armor armorPart)
        {
            switch (armorPart.ArmorType)
            {
                case ArmorType.Body:
                    if (_body == null && player.PlayerClass == armorPart.PlayerClass) _body = armorPart;
                    break;
                case ArmorType.Hands:
                    if (_hands == null && player.PlayerClass == armorPart.PlayerClass) _hands = armorPart;
                    break;
                case ArmorType.Helmet:
                    if (_helmet == null && player.PlayerClass == armorPart.PlayerClass) _helmet = armorPart;
                    break;
                case ArmorType.Shoes:
                    if (_shoes == null && player.PlayerClass == armorPart.PlayerClass) _shoes = armorPart;
                    break;
                case ArmorType.Legs:
                    if (_legs == null && player.PlayerClass == armorPart.PlayerClass) _legs = armorPart;
                    break;
            }
        }
        public static int GetArmorPoints()
        {
            return 5;
        }
    }
}
