using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Drawing; 
namespace Snails
{
    class Snails
    {
        Image image; 
        public int X { get; set; }
        public int Y { get; set; }
        static Random r = new Random(); 

        public Snails()
        {
            X = 0; Y = 0;
            image = Properties.Resources.snail4; 
        }

        public Snails(int x, int y, Image image)
        {
            X = x;
            Y = y;
            this.image = image; 
        }

       public void Move()
        {
            X += r.Next(10, 20); 
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(image, X - image.Width/2, Y - image.Height/2);
        }


    }

    class TurboSnail : Snails
    {

    }
}
