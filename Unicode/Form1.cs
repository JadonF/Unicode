/*
 * Created by: Jadon Fournier
 * Created on: 06-Apr-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Unicode
 * This program changes unicode to a letter
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicode
{
    public partial class frmUnicode : Form
    {

        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            //Define Variables
            int counter;
            string container;

            //clear list
            this.lstUnicode.Items.Clear();

            for (counter = 65; counter <= 90; counter++)
            {
                container = Char.ConvertFromUtf32(counter);
                lstUnicode.Items.Add(container + "-->" + counter);
            }
        }
    }
}

