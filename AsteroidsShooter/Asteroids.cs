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
        public void Move()
        {
            y += speed;
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
                y += speed;
            }
            else if (direction == "down")
            {
                y -= speed;
            }
        }
    }
}