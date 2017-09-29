using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parquet_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Length_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            var length = this.Length.Value;
            var width = this.Width.Value;
            var worm = this.Worm.Value;
            var kvadratura = length * width;
            var realWorm = (worm / 100) * kvadratura;
            var neededKvadratura = kvadratura + realWorm;

            this.labelKvadratura.Text = kvadratura + " м2";
            this.labelLameli.Text = neededKvadratura + " м2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
