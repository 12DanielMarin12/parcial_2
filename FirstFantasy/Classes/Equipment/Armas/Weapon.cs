using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        public abstract string ShowInformation();
        public abstract string Atacar();

        private string name;

        public string Name { get => name; set => name = value; }
    }
}
