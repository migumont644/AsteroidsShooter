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
        Boolean leftArrowDown, rightArrowDown, upArrowDown, downArrowDown, spaceDown;
      
        List<Asteroids> asteroids = new List<Asteroids>();

        int newAsteroidsCounter = 0;
        int asteroidBigger = 0;

        Random randGen = new Random();
      
        Asteroids hero;


        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush brownBrush = new SolidBrush(Color.Brown);
        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {

        asteroidBigger = 0;
        CreateAsteroids();

            hero = new Asteroids(this.Width / 2 - 100, this.Height - 100, 20, 13, redBrush);
        }

        public void CreateAsteroids()
        {
            asteroidBigger = 0;
            int randomLocationX = randGen.Next(0, this.Width);
            int randomLocationY = randGen.Next(0, this.Height);
            Asteroids a = new Asteroids(randomLocationX, randomLocationY, 40, 0, brownBrush);
            asteroids.Add(a);
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
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
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            newAsteroidsCounter++;
            asteroidBigger++;

            //move hero
            if (leftArrowDown)
            {
                hero.Move("left");
            }
            if (rightArrowDown)
            {
                hero.Move("right");
            }
            if (upArrowDown)
            {
                hero.Move("up");
            }
            if (downArrowDown)
            {
                hero.Move("down");
            }
            foreach (Asteroids a in asteroids)
            {
                if (hero.Collision(a) && spaceDown)
                {
                    asteroids.Remove(a);
                    break;                   
                }
            }

             



            if (asteroidBigger == 150)
            {
                foreach (Asteroids a in asteroids)
                {
                    a.size += 40;
                }

            }
            if (asteroidBigger == 250)
            {
                foreach (Asteroids a in asteroids)
                {
                    a.size += 40;
                }
            }
            if (asteroidBigger == 350)
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                GameOverScreen gos = new GameOverScreen();
                f.Controls.Add(gos);
            }

            Refresh();

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Asteroids a in asteroids)
            {
                e.Graphics.FillRectangle(brownBrush, a.x, a.y, a.size, a.size);
            }
            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.size, hero.size);
           
        }
    }
}
