using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Sword : Weapon
    {
        public override string ShowInformation()
        {
            return "this sword is lethal";
            
        }
        public override string Atacar()
        {

            int a = new Random().Next(0, 9);
            string b = " ";
            return b + a;

        }
    }
        
    
}
