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
            // String option = CboxCharacter.Text;

            List<IDescribable> objectList = new List<IDescribable>();
            objectList.Add(new Axe());
            objectList.Add(new Potion());
            objectList.Add(new Wizard { Level = 10 });

            IDescribable i = new Fighter();


            TxtOutput.Text = "";

            foreach (IDescribable d in objectList)
            {
                TxtOutput.Text += d.ShowInformation()+"\n";
            }


            /*

            switch (option)
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
                    MessageBox.Show("You MUST select a type");
                    break;

            }


            myCharacter.Name = "Solrac";
            myCharacter.Level= 2;
            myCharacter.Experience = 10000;

            if (myCharacter != null)
            {

                TxtOutput.Text = myCharacter.Taunt();

                ((Wizard)myCharacter).CastSpell();

            }


            */


        }
    }
}
