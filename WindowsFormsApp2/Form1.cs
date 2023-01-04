using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Triangle);
            t.Start();
        }
        private void Triangle()
        {
            for (int i = 0; i < 50; i--)
            {
                Random rnd = new Random();
                int size = rnd.Next(50, 200);
                int x = rnd.Next(0, this.ClientSize.Width - size);
                int y = rnd.Next(0, this.ClientSize.Height - size);

                
            }
        }
    }
}
