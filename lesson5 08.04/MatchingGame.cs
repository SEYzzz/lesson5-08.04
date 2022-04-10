using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lesson5_08._04
{
    public partial class MatchingGame : Form
    {
        public Person gamer { get; set; }
        public MatchingGame(Person gamer)
        {
            this.gamer = gamer;
            InitializeComponent();
            AssignIcons();
            IsClicked();
        }

        Random rnd = new Random();
        List<string> icons_1 = new List<string>()
        {
            "!", "N", ",", "k", "b", "v", "w", "z", "m", "l", "K", "p", "?", ".", "a", "O", "r", "t",
            "!", "N", ",", "k", "b", "v", "w", "z", "m", "l", "K", "p", "?", ".", "a", "O", "r", "t"
        };

        private void AssignIcons()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                Label iconLable = control as Label;
                if(iconLable != null)
                {
                    int rndNum = rnd.Next(icons_1.Count);
                    iconLable.Text = icons_1[rndNum];
                    iconLable.ForeColor = iconLable.BackColor;
                    icons_1.RemoveAt(rndNum);
                }
            }
        }

        private void IsClicked()
        {
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                if(control is Label)
                {
                    control.Click += new EventHandler(LabelClick);
                }
            }
        }

        Label secondClicked;
        Label firstClicked;
        private void LabelClick(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                timer1.Start();

                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                AreYouWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    gamer.Scores += 1;
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            gamer.Time += 650;

            if (firstClicked != null && secondClicked != null)
            {
                firstClicked.ForeColor = firstClicked.BackColor;
                secondClicked.ForeColor = secondClicked.BackColor;
            }

            firstClicked = null;
            secondClicked = null;
        }

        private void AreYouWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Вы нашли все картинки!", "Поздравляем");
            Close();
        }


        private void MatchingGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            using(StreamWriter writer = new StreamWriter("Rating.txt", true))
            {
                writer.WriteLine(gamer.ToString());
            }
        }
    }
}
