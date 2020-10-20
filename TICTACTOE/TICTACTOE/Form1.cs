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

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string currentplayer = "x";
        string[,] model = new string[3, 3];


        private void MapModel(Button buttonx)
        {

            int row = 0;
            int col = 0;

            var rowcol=buttonx.Tag.ToString().Split(',');
            row = Convert.ToInt32(rowcol[0]);
            row = Convert.ToInt32(rowcol[1]);
            model[row, col] = currentplayer;

        }

        public string GetWinner(string player)
        {

            if (model[0, 0] != null && model[0, 1] != null && model[0, 2] != null && model[0,0] == model[0,1] && model[0,1]==model[0,2])
            {
                return player;
            }
            return null;


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


            if (currentplayer == "x") { currentplayer = "O"; }
            else { currentplayer = "x"; }
            var winner = GetWinner(currentplayer);
            if (!string.IsNullOrEmpty(winner))
                MessageBox.Show(winner + "ha ganado");
        }
    }
}
