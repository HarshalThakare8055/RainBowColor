using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RainBow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //if(chbRed.Checked==true||chbOrange.Checked==true||chbYellow.Checked==true||chbGreen.Checked==true||chbBlue.Checked==true||chbIndigo.Checked==true||chbViolet.Checked==true)
            //{
            //    if (chbRed.Checked == false)
            //    {
            //        PnlRed.BackColor = System.Drawing.Color.Transparent;
            //    }
            //    else PnlOrange.BackColor = System.Drawing.Color.Orange;
            //}
            //else
            /*if (chbRed.Checked == false)
            {
                Pnl0.BackColor = System.Drawing.Color.Orange;
            }
            else if (chbOrange.Checked == false)
            {
                Pnl1.BackColor = System.Drawing.Color.Yellow;
            }
            else if (chbYellow.Checked == true)

            {
                Pnl2.BackColor = System.Drawing.Color.Yellow;
            }
            else if (chbGreen.Checked == true)
            {
                Pnl3.BackColor = System.Drawing.Color.Green;
            }
            else if (chbBlue.Checked == true)
            {
                Pnl4.BackColor = System.Drawing.Color.Blue;
            }
            else if (chbIndigo.Checked == true)
            {
                Pnl5.BackColor = System.Drawing.Color.Indigo;

            }
            else if (chbViolet.Checked == true)
            {
                Pnl6.BackColor = System.Drawing.Color.Violet;
            }
            else
            {
                chbRed.Checked = false;
                chbOrange.Checked = false;
                chbYellow.Checked = false;
                chbGreen.Checked = false;
                chbBlue.Checked = false;
                chbIndigo.Checked = false;
                chbViolet.Checked = false;
            }*/
        }

        private void FillColors(Color[] colors)//method
        {
            for (int i = 0; i < colors.Length; i++)
            {
                Panel pnlToColor = GetPanelById(i);
                if(pnlToColor != null)
                    pnlToColor.BackColor = colors[i];
            }
        }

        private Panel GetPanelById(int id)
        {
            Panel pnlToReturn = null;
            Control[] ctrl = Controls.Find($"Pnl{id}", true);
            if (ctrl.Length > 0)
                if (ctrl[0] is Panel)
                    pnlToReturn = (Panel)ctrl[0];
            return pnlToReturn;
        }

        private void chbColor_CheckedChanged(object sender, EventArgs e)
        {
            List<Color> rainbowColors = new List<Color>();
            if (chbRed.Checked)
                rainbowColors.Add(Color.Red);
            if(chbOrange.Checked)
                rainbowColors.Add(Color.Orange);
            if (chbYellow.Checked)
                rainbowColors.Add(Color.Yellow);
            if (chbGreen.Checked)
                rainbowColors.Add(Color.Green);
            if (chbBlue.Checked)
                rainbowColors.Add(Color.Blue);
            if (chbIndigo.Checked)
                rainbowColors.Add(Color.Indigo);
            if (chbViolet.Checked)
                rainbowColors.Add(Color.Violet);
            if(rainbowColors.Count < 7)
            {
                do
                {
                    rainbowColors.Add(Color.Transparent);
                } while (rainbowColors.Count != 7);
            }
            FillColors(rainbowColors.ToArray());
        }

        private void chbRed_CheckedChanged(object sender, EventArgs e)
        {
            /*if (chbRed.Checked == true)
            {
                Pnl0.BackColor = System.Drawing.Color.Red;
            }
            else
            
                Pnl0.BackColor = System.Drawing.Color.Transparent;
            
           

            */
        }

        private void chbOrange_CheckedChanged(object sender, EventArgs e)
        {
            if (chbOrange.Checked == true)
            {
                Pnl1.BackColor = System.Drawing.Color.Orange;
            }
            else Pnl1.BackColor = System.Drawing.Color.Transparent;
        }

        private void chbYellow_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbGreen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbBlue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbIndigo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chbViolet_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
