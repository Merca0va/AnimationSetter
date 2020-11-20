using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaming_fundamental_behaviors
{
    public partial class Form1 : Form
    {

        enum Direction
        {
            Left, Right, Up, Down
        }

        int x_Position, y_Position;
        int my_Height, my_Width;
        int max_Height = 500, max_Width = 700;
        int min_Height = 50, min_Width = 50;
        Boolean size_is_expanding = true;
        Boolean arrow_keys_active = true;
        string animation_mode = "none of these"; // move or size or spin and none of these to stop the animations.
        Direction my_direction;
        Image img;

        private void arrowKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrow_keys_active = true;
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
            pictureBox1.Top = 100;
            pictureBox1.Left = 100;
            animation_mode = "move";
        }

        private void mouseClickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrow_keys_active = false;
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
            pictureBox1.Top = 100;
            pictureBox1.Left = 100;
            animation_mode = "move";
        }

        private void rotateImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
            pictureBox1.Top = 100;
            pictureBox1.Left = 100;
            animation_mode = "spin";
        }

        private void resizeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
            pictureBox1.Top = 100;
            pictureBox1.Left = 100;
            animation_mode = "size";
        }

        private void changeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleBuffered = false;
        }

        private void doubleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            animation_mode = "none of these";
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (arrow_keys_active)
            {
                if (e.KeyCode == Keys.Up)
                {
                    my_direction = Direction.Up;
                }

                else if (e.KeyCode == Keys.Down)
                {
                    my_direction = Direction.Down;
                }

                else if (e.KeyCode == Keys.Left)
                {
                    my_direction = Direction.Left;
                }

                else if (e.KeyCode == Keys.Right)
                {
                    my_direction = Direction.Right;
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Picture jumps to mouse location when left click is pressed.
            if (e.Button == MouseButtons.Left && arrow_keys_active == false)
            {
                pictureBox1.Left = e.X;
                pictureBox1.Top = e.Y;
            }
        }
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Height = 300;
            pictureBox1.Width = 300;
            pictureBox1.Top = 100;
            pictureBox1.Left = 100;
            my_direction = Direction.Right;
            img = pictureBox1.Image;
        }

      
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (animation_mode == "size")
            {

                if (my_Height < max_Height && my_Width < max_Width && size_is_expanding)
                {
                    my_Height = my_Height + 10;
                    my_Width = my_Width + 10;
                }

                else if (my_Height == max_Height && my_Width < max_Width && size_is_expanding)
                {
                    my_Width = my_Width + 10;
                }

                else if (my_Height == max_Height && my_Width == max_Width)
                {
                    my_Height = my_Height - 10;
                    my_Width = my_Width - 10;
                    size_is_expanding = false;
                }

                else if (my_Height > min_Height && my_Width > min_Width)
                {
                    my_Width = my_Width - 10;
                    my_Height = my_Height - 10;
                }

                else if (my_Height == min_Height && my_Width > min_Width)
                {
                    my_Width = my_Width - 10;
                }

                else if (my_Height == min_Height && my_Width == min_Width)
                {
                    my_Height = my_Height + 10;
                    my_Width = my_Width + 10;
                    size_is_expanding = true;
                }

                pictureBox1.Height = my_Height;
                pictureBox1.Width = my_Width;
            }

            else if (animation_mode == "move" && arrow_keys_active == true) // if (size_or_movement == "move")
            {
                if (my_direction == Direction.Up)
                {
                    y_Position = y_Position - 10;
                }
                else if (my_direction == Direction.Down)
                {
                    y_Position = y_Position + 10;
                }
                else if (my_direction == Direction.Right)
                {
                    x_Position = x_Position + 10;
                }
                else if (my_direction == Direction.Left)
                {
                    x_Position = x_Position - 10;
                }

                pictureBox1.Left = x_Position;
                pictureBox1.Top = y_Position;
            }

            else if (animation_mode == "spin")
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = img;
            }

            Invalidate();
        }
    }
}
