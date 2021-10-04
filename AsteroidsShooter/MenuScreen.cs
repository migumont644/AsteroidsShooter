using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsteroidsShooter
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {              
                case Keys.Space:
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    GameScreen gs = new GameScreen();
                    f.Controls.Add(gs);
                    break;

                case Keys.Escape:                    
                        Application.Exit();
                    break;
            }
        }
    }
  }

