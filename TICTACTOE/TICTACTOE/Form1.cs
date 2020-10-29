using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{

    class TicTacToe
    {

        private string[,] model = new string[3, 3];
        public void Play(string player, int row, int col)
        {
            model[row, col] = player;
        }

        public string GetWinner(string player)
        {
            ///horizomtal
            if ((model[0, 0] != null && model[0, 1] != null && model[0, 2] != null) && (model[0, 0] == model[0, 1] && model[0, 1] == model[0, 2]))
            {
                return player;
            }
            if ((model[1, 0] != null && model[1, 1] != null && model[1, 2] != null) && (model[1, 0] == model[1, 1] && model[1, 1] == model[1, 2]))
            {
                return player;
            }
            if ((model[2, 0] != null && model[2, 1] != null && model[2, 2] != null) && (model[2, 0] == model[2, 1] && model[2, 1] == model[2, 2]))
            {
                return player;
            }
            /////////////////verticales
            if ((model[0, 0] != null && model[1, 0] != null && model[2, 0] != null) && (model[0, 0] == model[1, 0] && model[1, 0] == model[2, 0]))
            {
                return player;
            }
            if ((model[0, 1] != null && model[1, 1] != null && model[2, 1] != null) && (model[0, 1] == model[1, 1] && model[1, 1] == model[2, 1]))
            {
                return player;
            }
            if ((model[0, 2] != null && model[1, 2] != null && model[2, 2] != null) && (model[0, 2] == model[1, 2] && model[1, 2] == model[2, 2]))
            {
                return player;
            }
            ///diagonal
            if ((model[0, 0] != null && model[1, 1] != null && model[2, 2] != null) && (model[0, 0] == model[1, 1] && model[1, 1] == model[2, 2]))
            {
                return player;
            }
            if ((model[0, 2] != null && model[1, 1] != null && model[2, 0] != null) && (model[0, 2] == model[1, 1] && model[1, 1] == model[2, 0]))
            {
                return player;
            }

            return null;


        }


    }


    public partial class Form1 : Form
    {

        TicTacToe game;
        public Form1()
        {
            InitializeComponent();
            game = new TicTacToe();
        }

        string currentplayer = "x";

        private void MapModel(Button buttonx)
        {

            int row = 0;
            int col = 0;

            var rowcol=buttonx.Tag.ToString().Split(',');
            row = Convert.ToInt32(rowcol[0]);
            col = Convert.ToInt32(rowcol[1]);
            game.Play(currentplayer, row, col);

        }


        private void button1_Click(object sender, EventArgs e)
        {



            if(!(sender is Button))
            {
                   return;
            }
            var buttonx = (Button)sender;

            MapModel(buttonx);


            buttonx.Text = this.currentplayer;

            var winner = game.GetWinner(currentplayer);
            if (!string.IsNullOrEmpty(winner))  MessageBox.Show("jugador " + winner + " ha ganado");


            if (currentplayer == "x") { currentplayer = "O"; }
            else { currentplayer = "x"; }

        }

    }
}
 
