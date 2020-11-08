using FirstFantasy.Classes.Equipment;
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

            Sword weapon = new Sword();
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
            String arma = CboxWeapon.Text;
            switch (arma)
            {
                case "":
                    MessageBox.Show("You MUST select a aquipment");
                    break;

            }
            string armadura = CboxArmor.Text;

            //INVENTARIO
            if (myCharacter != null && arma != "")
            {
                myCharacter.Name = "Solrac";
                myCharacter.Level = 2;
                myCharacter.Experience = 10000;
                TxtOutput.Text = myCharacter.Taunt() + "\nArmadura:" + armadura +"\nArma:"+arma+ "\nDamage:" +weapon.Atacar()+ "\n\nINVENTARIO:\n";

                List<IDescribable> objectList = new List<IDescribable>();
                objectList.Add(new Potion());
                objectList.Add(new Axe());
                
                foreach (IDescribable d in objectList)
                {
                    TxtOutput.Text +=   d.ShowInformation() + "\n\n";
                }
            }

            

           
             

            

            




        }

         
    }
}
