using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorAndMageProject
{
    public class Item
    {
        protected readonly int maxStack;

        protected readonly string name;
        protected readonly string description;

        public int MaxStack
        {
            get
            {
                return maxStack;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public Item(int maxStack, string name, string description)
        {
            this.maxStack = maxStack;
            this.name = name;
            this.description = description;
        }
    }
}
