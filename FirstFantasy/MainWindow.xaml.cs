using FirstFantasy.Classes.Equipment;
using FirstFantasy.Classes.Equipment.Armadura;
using FirstFantasy.Classes.Player;
using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {

            
                Character myCharacter;
                
                String character = CboxCharacter.Text;
                switch (character)
                {
                    case "Cleric":
                        myCharacter = new Cleric();
                        
                        break;

                    case "Fighter":
                        myCharacter = new Fighter();
                        
                        break;

                    case "Rouge":
                        myCharacter = new Rouge();
                        
                        break;

                    case "Wizard":
                        myCharacter = new Wizard();
                        
                        break;

                    default:
                        myCharacter = null;
                        MessageBox.Show("You MUST select a typ" +"e");
                        break;

                }
            
            Weapon weapons = null;
            String arma = CboxWeapon.Text;
            switch (arma)
            {
                case "Axe":
                    weapons = new Axe();
                    break;
                case "Sword":
                    weapons = new Sword();
                    break;
                case "Fists":
                    weapons = new Fists();
                    break;
                
                case "":
                    MessageBox.Show("You MUST select a aquipment");
                    break;

            }
            Armor meArmor=null;
            String armadura = CboxArmor.Text;
            switch (armadura)
            {
                case "Diamond":
                    meArmor = new Diamond();
                    break;
                case "Adamantite":
                    meArmor = new Adamantite();
                    break;
                case "Iron":
                    meArmor = new Iron();
                    break;
                case "Leather":
                    meArmor = new Leather();
                    break;
                case "":
                    MessageBox.Show("You MUST select a Armor");
                    break;
            }








            if (myCharacter != null && arma != "")
            {
                if (armadura != null)
                {
                    //NOMBRAMIENTOS
                    myCharacter.Name = "sola";
                    myCharacter.Level = 2;
                    myCharacter.Experience = 10000;
                    //EQUIPAMENTO
                    TxtOutput.Text = myCharacter.Taunt() + "\nArma:" + arma + "\n armadura: " + armadura + "\nDamage:" + weapons.Atacar()  + "\n\nINVENTARIO:\n";

                    //DESCRIPCION DE INVENTARIO
                    List<IDescribable> objectList = new List<IDescribable>();
                    objectList.Add(new Potion());

                    foreach (IDescribable d in objectList)
                    {
                        TxtOutput.Text += d.ShowInformation() + "\n\n";
                    }
                }
            }

            //{
            //    case "Sword":
            //        weapons = new Sword();
            //        break;
            //    case "":
            //        MessageBox.Show("You MUST select a aquipment");
            //        break;

            //}
            //string armadura = CboxArmor.Text;

            ////NOMBRES
            //string NameArmor =TbArm.Text;
            //string NameWeapon =TbWea.Text;
            //string NameCharacter =TbCha.Text;



            //    //INVENTARIO
            //    List<IDescribable> objectList = new List<IDescribable>();
            //    objectList.Add(new Potion());
            //    objectList.Add(new Axe());

            //    foreach (IDescribable d in objectList)
            //    {
            //        TxtOutput.Text +=   d.ShowInformation() + "\n\n";
            //    }
            //}













        }


    }
}
