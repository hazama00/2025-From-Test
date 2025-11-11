using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foom_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                { 

                TestButton TestButton = new TestButton();

                TestButton.Location = new Point(50 *i , 50);

                TestButton.Size = new Size(150, 100);

                TestButton.Text = "あいうえお";

                TestButton.Click += hogehogeClick;


                Controls.Add(TestButton);
                }
            }
        }

        private void hogehogeClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");
        }
    }
}
