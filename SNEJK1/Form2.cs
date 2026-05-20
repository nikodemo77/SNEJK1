using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNEJK1
{
    public partial class Form2 : Form
    {
        PictureBox head = new PictureBox();

        PictureBox food = new PictureBox();

        string direction = "right";

        int speed = 20;

        Random random = new Random();
    

        public Form2()
        {
            InitializeComponent();

            this.KeyPreview = true;

            head.BackColor = Color.Lime;

            head.Width = 20;
            head.Height = 20;

            head.Left = 100;
            head.Top = 100;

            this.Controls.Add(head);

            food.BackColor = Color.Red;

            food.Width = 20;
            food.Height = 20;

            food.Left = 200;
            food.Top = 200;

            this.Controls.Add(food);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (direction == "right")
            {
                head.Left += speed;
            }

            if (direction == "left")
            {
                head.Left -= speed;
            }

            if (direction == "up")
            {
                head.Top -= speed;
            }

            if (direction == "down")
            {
                head.Top += speed;
            }

            if (head.Bounds.IntersectsWith(food.Bounds))
            {
                food.Left = random.Next(0, 700);
                food.Top = random.Next(0, 400);
            }

            if (head.Left < 0 ||
                head.Top < 0 ||
                head.Right > this.ClientSize.Width ||
                head.Bottom > this.ClientSize.Height)
            {
                timer1.Stop();

                MessageBox.Show("Przegrałeś");
                MessageBox.Show("Przegrałeś");
                MessageBox.Show("Przegrałeś");
                MessageBox.Show("Wygrałeś!");
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                direction = "right";
            }

            if (e.KeyCode == Keys.A)
            {
                direction = "left";
            }

            if (e.KeyCode == Keys.W)
            {
                direction = "up";
            }

            if (e.KeyCode == Keys.S)
            {
                direction = "down";
            }
        }
    }
}
