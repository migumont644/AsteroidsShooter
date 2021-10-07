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
            scoreTwoLabel.Text = $"Score: {Form1.score}";
        }

        private void GameOverScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                //When returning to the menu, be sure to click your mouse once. 
                case Keys.Space:
                    Form1.score = 0;
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
        }
    }
}
