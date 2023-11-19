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
    public partial class Poziom2 : Form
    {
        int i = 0;
        int[] tab2 = { 0, 0, 0, 0, 0 };
        int[] wygrana2 = { 1, 2, 3, 4, 5 };
        public Poziom2()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        private void Poziom2_KeyDown(object sender, KeyEventArgs e)
        {
            List<Label> grupa2 = new List<Label>()
            {
                label1, label2, label3, label4, label5, label6,
                label7, label8, label9, label10, label11, label12,
                label13, label14, label15, label16, label17, label18,
                label19, label20, label21, label22, label23, label24,
                label25, label26, label27, label28, label29, label30,
                label31, label32, label33, label34, label35, label36,
                label37, label38, label39, label40, label41, label42,
                label43, label44, label45, label46, label47, label48,
                label49, label50, label51, label52, label53, label54,
                label55, label56, label57, label58, label59, label60,
                label61, label62, label63
            };
            //poruszanie w labiryncie
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;

            if (e.KeyCode == Keys.D) x += 6;
            else if (e.KeyCode == Keys.A) x -= 6;
            else if (e.KeyCode == Keys.W) y -= 6;
            else if (e.KeyCode == Keys.S) y += 6;

            pictureBox2.Location = new Point(x, y);

            //dotkniecie sciany
            foreach (Label element in grupa2)
            {
                if (pictureBox2.Bounds.IntersectsWith(element.Bounds))
                {
                    pictureBox2.Location = new Point(316, 747);
                }
            }
            //sprawdzanie kolejnosci ulozenia slowa
            if (pictureBox3.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds) && i == 0)
            {
                pictureBox3.Visible = false;
                tab2[0] = 1;
                i++;

            }
            else if (pictureBox3.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox3.Visible = false;
                i = 6;
            }

            if (pictureBox4.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds) && i == 1)
            {
                pictureBox4.Visible = false;
                tab2[1] = 2;
                i++;

            }
            else if (pictureBox4.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds))
            {
                pictureBox4.Visible = false;
                i = 6;
            }

            if (pictureBox7.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds) && i == 2)
            {
                pictureBox7.Visible = false;
                tab2[2] = 3;
                i++;
            }
            else if (pictureBox7.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds))
            {
                pictureBox7.Visible = false;
                i = 6;
            }
            if (pictureBox5.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds) && i == 3)
            {
                pictureBox5.Visible = false;
                tab2[3] = 4;
                i++;
            }
            else if (pictureBox5.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds))
            {
                pictureBox5.Visible = false;
                i = 6;
            }
            if (pictureBox6.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds) && i == 4)
            {
                pictureBox6.Visible = false;
                tab2[4] = 5;
            }
            else if (pictureBox6.Visible == true && pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds))
            {
                pictureBox6.Visible = false;
                i = 6;
            }
            //koniec poziomu
            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds) && tab2.SequenceEqual(wygrana2))
            {
                MessageBox.Show("Gratulacje! Wygrales!");
                this.Hide();
            }
            else if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds))
            {
                MessageBox.Show("Niestety, sprobuj jescze raz!");
                i = 0;
                for (int i = 0; i < 5; i++)
                {
                    tab2[i] = 0;
                }
                pictureBox2.Location = new Point(316, 747);
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
            }
        }

        private void Poziom2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu nowy = new Menu();
            nowy.Show();
        }
    }
}
