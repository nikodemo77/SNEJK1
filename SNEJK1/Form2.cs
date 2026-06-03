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
        List<PictureBox> snake = new List<PictureBox>();

        int score = 0;

        int level = 1;


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
            snake.Add(head);

            food.BackColor = Color.Red;

            food.Width = 20;
            food.Height = 20;

            food.Left = 200;
            food.Top = 200;

            this.Controls.Add(food);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = snake.Count - 1; i > 0; i--)
            {
                for (int j = snake.Count - 1; i > 0; i--)
                {
                    snake[i].Left = snake[i - 1].Left;
                    snake[i].Top = snake[i - 1].Top;
                }
            }

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

                score++;

                labelScore.Text = "Punkty: " + score;

                if(score % 5 == 0)
                {
                    level++;

                    labelLevel.Text = "Level: " + level;

                    timer1.Interval -= 10;
                }

                food.Left = random.Next(0, 700);
                food.Top = random.Next(0, 400);

                PictureBox body = new PictureBox();

                body.BackColor = Color.Green;

                body.Width = 20;
                body.Height = 20;

                this.Controls.Add(body);

                snake.Add(body);

            }

            if (head.Left < 0 ||
                head.Top < 0 ||
                head.Right > this.ClientSize.Width ||
                head.Bottom > this.ClientSize.Height)
            {
                timer1.Stop();

                MessageBox.Show("Przegrałeś");
                
                
            }

            for (int i = 1; i < snake.Count; i++)
            {
                if (head.Bounds.IntersectsWith(snake[i].Bounds))
                {
                    timer1.Stop();

                    MessageBox.Show(
                        $"Przegrałeś!\n\nPunkty: {score} \nLevel: {level}"
                        );

                    this.Close();
                }
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && direction != "left")
            {
                direction = "right";
            }

            if (e.KeyCode == Keys.A && direction != "right")
            {
                direction = "left";
            }

            if (e.KeyCode == Keys.W && direction != "down")
            {
                direction = "up";
            }

            if (e.KeyCode == Keys.S && direction != "up")
            {
                direction = "down";
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
