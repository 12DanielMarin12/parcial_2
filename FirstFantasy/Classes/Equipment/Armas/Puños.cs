using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Fists : Weapon
    {
        public override string ShowInformation()
        {
            return "these hands are lethal";

        }
        public override string Atacar()
        {

            int a = new Random().Next(0, 9);
            string b = " ";
            return b + a;

        }
    }
}
