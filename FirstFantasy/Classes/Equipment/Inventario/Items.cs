using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasy.Interfaces;

namespace FirstFantasy.Classes.Equipment.Inventario
{
    public abstract class Items : IDescribable
    {
        private string name;

        public string Name { get => name; set => name = value; }
        public abstract string ShowInformation();
    }
}
