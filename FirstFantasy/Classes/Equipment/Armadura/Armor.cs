using System;
using FirstFantasy.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment.Armadura
{
     public abstract class Armor : IDescribable
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public abstract string ShowInformation();
        
    }
}
