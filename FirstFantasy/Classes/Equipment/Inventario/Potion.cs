
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Potion : Inventario.Items
    {
        public override string ShowInformation()
        {
            return "This is a strange potion,Who knows what he will do, drink it to find out";
        }
    }
}
