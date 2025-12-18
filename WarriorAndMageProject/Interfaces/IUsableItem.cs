using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    internal interface IUsableItem
    {
        void Use(Player player, Enemy target = null);
    }
}
