using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AsteroidsShooter
{
    class Asteroids
    {
        public int x, y, size, speed;
        public SolidBrush brushColour;

        public Asteroids(int _x, int _y, int _size, int _speed, SolidBrush _brushcolor)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            brushColour = _brushcolor;
        }


        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            else if (direction == "right")
            {
                x += speed;
            }
            else if (direction == "up")
            {
                y -= speed;
            }
            else if (direction == "down")
            {
                y += speed;
            }
        }
        public bool Collision(Asteroids a)
        {
            Rectangle thisRec = new Rectangle(x, y, size, size);
            Rectangle asteroidRec = new Rectangle(a.x, a.y, a.size, a.size);

            if (thisRec.IntersectsWith(asteroidRec))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}