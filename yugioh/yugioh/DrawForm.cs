using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yugioh
{
   
    public class Place
    {
        public Point Position { get; set; }
        public Color Col { get; set; }
        public int Size { get; set; }

        [NonSerialized]
        public bool isSelected = false;
        public bool player1 = false;
        public bool player2 = false;
        public bool imapoen = false;

       
        
        public bool isFree()
        {
            if(player1 || player2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int X
        {
            get
            {
                return Position.X;
            }
        }
        public int Y
        {
            get
            {
                return Position.Y;
            }
        }

        public Place()
        {
            Position = Point.Empty;
        }

        public Place(Place f) : this(f.Position, f.Col, f.Size, f.isSelected)
        {
        }
        public Place(Color col)
        {
            Col = col;
        }
        public Place(Point p, Color col, int size)
        {
            Position = p;
            Col = col;
            Size = size;
        }
        public Place(Point p, Color col, int size, bool sel = false)
        {
            Position = p;
            Col = col;
            Size = size;
            isSelected = sel;
        }
        public Place(int x, int y, Color col, int size)
        {
            Position = new Point(x, y);
            Col = col;
            Size = size;
            isSelected = false;
        }

        public void Move(int x, int y)
        {
            
        }


        public void Draw(Graphics g, bool isSelected)
        {
            if (isFree())
            {
                Col = Color.Red;
            }
            if (isSelected)
            {
                Col = Color.Black;
            }
            if (imapoen)
            {
                Col = Color.Yellow;
            }
            if (player1)
            {
                Col = Color.DarkSeaGreen;
            }
            if(player2)
            {
                Col = Color.Blue;
            }
            SolidBrush br = new SolidBrush(Col);
            Rectangle boundRect = new Rectangle(Position, new Size(this.Size, this.Size));
            boundRect.Offset(-Size/2, -Size/2);
            g.FillRectangle(br, boundRect);
            br.Dispose();
            if (isSelected)
            {
                Pen pn = new Pen(Color.Gray, 1);
                boundRect.Inflate(7, 7);
                g.DrawEllipse(pn, boundRect);
                pn.Dispose();
            }


        }
    }

    
    public class Grid
    {
        public List<Place> drwPlaces;
        public int NumObjects
        {
            get { return drwPlaces.Count; }
        }

       

        public Grid()
        {
            drwPlaces = new List<Place>();
        }

        public Place this[int index]
        {
            get
            {
                return drwPlaces[index];
            }
        }

        public void AddObj(Place f)
        {
            drwPlaces.Add(f);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Place frm in drwPlaces)
                frm.Draw(g, frm.isSelected);
        }
        
        public void Dispose()
        {
            drwPlaces.Clear();
        }

        static int Distance(Point a, Point b)
        {
            return (int)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }
        public void Summon()
        {
            
        }
        public void RemoveSelected()
        {
            var selList = drwPlaces.Where(w => w.isSelected).ToList();
            foreach (Place frm in selList)
                drwPlaces.Remove(frm);
        }
        public bool Select(Point pos)
        {
            for (int i = drwPlaces.Count - 1; i >= 0; i--)
            {
                Place frm = drwPlaces[i];
                if(drwPlaces[i].isSelected == true)
                {
                    drwPlaces[i].isSelected = false;
                }
                if (Distance(pos, frm.Position) < frm.Size / 2)
                {
                    drwPlaces[i].isSelected = !drwPlaces[i].isSelected;
                //return true;
                }
            }
            return false;
        }
        public void ChangeColorSelected(Color col)
        {
            foreach (Place frm in drwPlaces)
                if (frm.isSelected)
                    frm.Col = col;
        }
    }
}
