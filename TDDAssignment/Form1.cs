using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDDAssignment
{
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        private void button1_Load(object sender, EventArgs e)
        {
            try
            {
                var len = double.Parse(tbLength.Text);
                var wid = double.Parse(tbWidth.Text);
                var dep = double.Parse(tbDepth.Text);
                var volume = Capacity(len, wid, dep);
                tbVolume.Text = volume.ToString();
            }
            catch (Exception exception)
            {
                tbVolume.Text = "Error noticed";
            }

        }

        public double Capacity(double length, double width, double depth)
        {
            var volume = length * width* depth;
            return volume;
        }

        private void tbVolume_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var len = double.Parse(tbLength.Text);
                var wid = double.Parse(tbWidth.Text);
                var dep = double.Parse(tbDepth.Text);
                var volume = Capacity(len, wid, dep);
                tbVolume.Text = volume.ToString();
            }
            catch (Exception exception)
            {
                tbVolume.Text = "Error noticed";
            }

        }
    }
}
