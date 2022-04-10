using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson5_08._04
{
    public partial class Form1 : Form
    {
        public static Rating rating { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MatchingGame game = new MatchingGame(new Person($"{txtBoxName.Text}"));
            game.Show();
        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            Rating rating = new Rating();
            rating.Show();
        }
    }
}
