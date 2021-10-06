using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace AsteroidsShooter
{
    public partial class GameOverScreen : UserControl
    {
        SoundPlayer startOverSound = new SoundPlayer(Properties.Resources.alert_start);
        public GameOverScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Space:
                    startOverSound.Play();
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    MenuScreen ms = new MenuScreen();
                    f.Controls.Add(ms);
                    break;

                case Keys.Escape:
                    Application.Exit();
                    break;
            }
            scoreTwoLabel.Text = $"Score: {Form1.score}";
        }
    }
}
