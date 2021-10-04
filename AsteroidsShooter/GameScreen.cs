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
    public partial class GameScreen : UserControl
    {
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;
      
        List<Asteroids> asteroids = new List<Asteroids>();

        Random randGen = new Random();

        Asteroids hero;

        SolidBrush redBrush = new SolidBrush(Color.Red);
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            hero = new Asteroids(this.Width / 2 - 100, this.Height - 100, 20, 4, redBrush);
        }

        private void GameScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.W:
                    leftArrowDown = true;
                    break;
                case Keys.S:
                    rightArrowDown = true;
                    break;            
            }
        }
  
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
                    switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.W:
                    leftArrowDown = false;
                    break;
                case Keys.S:
                    rightArrowDown = false;
                    break;            
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move hero
            if (leftArrowDown)
            {
                hero.Move("left");
            }
            else if (rightArrowDown)
            {
                hero.Move("right");
            }
            else if (upArrowDown)
            {
                hero.Move("up");
            }
            else if (downArrowDown)
            {
                hero.Move("down");
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.size, hero.size);
        }
    }
}
