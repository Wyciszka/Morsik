using System.CodeDom;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Morsik
{
    public partial class Form1 : Form
    {
        int i = 0;
        int[] tab = { 0, 0, 0 };
        int[] wygrana = { 1, 2, 3 };
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            List<Label> grupa = new List<Label>()
            {
                label1, label2, label3, label4, label5, label6,
                label7, label8, label9, label10, label11, label12,
                label13, label14, label15, label16, label17, label18,
                label19, label20, label21, label22, label23, label24,
                label25, label26, label27, label28, label29, label30,
                label31, label32, label33, label34, label35, label36
            };

            //poruszanie w labiryncie
            int x = pictureBox2.Location.X;
            int y = pictureBox2.Location.Y;

            if (e.KeyCode == Keys.D) x += 8;
            else if (e.KeyCode == Keys.A) x -= 8;
            else if (e.KeyCode == Keys.W) y -= 8;
            else if (e.KeyCode == Keys.S) y += 8;

            pictureBox2.Location = new Point(x, y);

            //dotkniecie sciany
            foreach (Label element in grupa)
            {
                if (pictureBox2.Bounds.IntersectsWith(element.Bounds))
                {
                    pictureBox2.Location = new Point(283, 203);
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Menu nowy = new Menu();
            nowy.Show();
        }
    }
}
