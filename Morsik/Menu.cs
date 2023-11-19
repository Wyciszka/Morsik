using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morsik
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruszasz się wciskając odpowiedni przycisk myszki. Odpowiednio: \nW - góra, \nS - doł, \nA - lewo, \nD - prawo" +
                "\nCelem gry jest ułożenie słowa wskazanego na górze ekranu w alfabecie Morse'a i wyjście z labiryntu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pomoc nowy = new Pomoc();
            nowy.Show();
        }
    }
}
