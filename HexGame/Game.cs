using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexGame
{
    public partial class Game : Form
    {
        GameParameters game_parameters;

        public Game(GameParameters game_parameters)
        {
            this.game_parameters = game_parameters;
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            generateBoard();
        }

        public void generateBoard()
        {
            int hexSize = 100;
            for(int i = -1; i <= game_parameters.getGridSize(); i++)
            {
                for (int j = -1; j <= game_parameters.getGridSize(); j++)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Width = hexSize;
                    pictureBox.Height = hexSize;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.BackColor = Color.Transparent;
                    pictureBox.Parent = this;
                    if(i == -1 || i == game_parameters.getGridSize())
                    {
                        pictureBox.Image = Properties.Resources.red;
                    } else if (j == -1 || j == game_parameters.getGridSize())
                    {
                        pictureBox.Image = Properties.Resources.blue_hex;
                    }
                    else
                    {
                        pictureBox.Image = Properties.Resources.hex;
                    }
                        
                    pictureBox.Left = hexSize * j + i * hexSize / 2;
                    pictureBox.Top = hexSize * i * 3 / 4;
                    Controls.Add(pictureBox);
                    pictureBox.Visible = true;
                    pictureBox.Show();
                    pictureBox.Refresh();
                }
            }
        }


        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Board
    {
        int size;
        BoardColor[,] board;

        public Board(int size)
        {
            this.size = size;
            board = new BoardColor[size, size];
        }


        enum BoardColor
        {
            RED,BLUE,NONE
        }
    }
}
