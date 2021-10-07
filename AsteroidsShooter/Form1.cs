using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//AsteroidsShooter Miguel.M Oct 10, 2021
namespace AsteroidsShooter
{
    public partial class Form1 : Form
    {
       public static int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();

            this.Controls.Add(ms);
        }
    }
}
