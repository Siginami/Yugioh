using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yugioh
{
    [Serializable]
    public class DrawForm
    {
        public Point Position { get; set; }
        public Color Col { get; set; }
        public int Size { get; set; }

        [NonSerialized]
        public bool isSelected;

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

        public DrawForm()
        {
            Position = Point.Empty;
        }

        public DrawForm(DrawForm f) : this(f.Position, f.Col, f.Size, f.isSelected)
        {
        }

        public DrawForm(Point p, Color col, int size, bool sel = false)
        {
            Position = p;
            Col = col;
            Size = size;
            isSelected = sel;
        }
        public DrawForm(int x, int y, Color col, int size)
        {
            Position = new Point(x, y);
            Col = col;
            Size = size;
        }

        public void Move(int x, int y)
        {
            Position.Offset(x, y);
            Position = new Point(X + x, Y + y);
        }

        public void Move(Point m)
        {
            Position.Offset(m);
        }

        public void Draw(Graphics g)
        {
            SolidBrush br = new SolidBrush(Col);
            Rectangle boundRect = new Rectangle(Position, new Size(this.Size, this.Size));
            boundRect.Offset(-Size/2, -Size/2);
            g.FillRectangle(br, boundRect);
            br.Dispose();
            if (isSelected)
            {
                Pen pn = new Pen(Color.Gray, 1);
                boundRect.Inflate(10, 10);
                g.DrawEllipse(pn, boundRect);
                pn.Dispose();
            }
        }
    }

    [Serializable]
    public class DrawDoc
    {
        public List<DrawForm> drwObj;
        public int NumObjects
        {
            get { return drwObj.Count; }
        }

        public int NumSelectedObjects
        {
            get
            {
                int n = 0;
                foreach (DrawForm frm in drwObj)
                    if (frm.isSelected)
                        n++;
                return n;
            }
        }

        public DrawDoc()
        {
            drwObj = new List<DrawForm>();
        }

        public DrawForm this[int index]
        {
            get
            {
                return drwObj[index];
            }
        }

        public void AddObj(DrawForm f)
        {
            drwObj.Add(f);
        }

        public void DrawAll(Graphics g)
        {
            foreach (DrawForm frm in drwObj)
                frm.Draw(g);
        }

        public void RemoveLast()
        {
            drwObj.RemoveAt(drwObj.Count - 1);
        }

        public void RemoveSelected()
        {
            var selList = drwObj.Where(w => w.isSelected).ToList();
            foreach (DrawForm frm in selList)
                drwObj.Remove(frm);
        }

        public void Dispose()
        {
            drwObj.Clear();
        }

        static int Distance(Point a, Point b)
        {
            return (int)Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public bool Select(Point pos)
        {
            for (int i = drwObj.Count - 1; i >= 0; i--)
            {
                DrawForm frm = drwObj[i];
                if (Distance(pos, frm.Position) < frm.Size / 2)
                {
                    frm.isSelected = !frm.isSelected;
                    return true;
                }
            }
            return false;
        }

        public void SelectAll(bool selection = true)
        {
            foreach (DrawForm frm in drwObj)
                frm.isSelected = selection;
        }

        public bool OverSelectedObject(Point pos)
        {
            foreach (DrawForm frm in drwObj)
                if (frm.isSelected && Distance(pos, frm.Position) < frm.Size / 2)
                    return true;
            return false;
        }

        public void MoveSelected(Point move)
        {
            foreach (DrawForm frm in drwObj)
                if (frm.isSelected)
                    frm.Move(move.X, move.Y);
        }

        public void ChangeSizeSelected(int size)
        {
            foreach (DrawForm frm in drwObj)
                if (frm.isSelected)
                    frm.Size = size;
        }

        public void ChangeColorSelected(Color col)
        {
            foreach (DrawForm frm in drwObj)
                if (frm.isSelected)
                    frm.Col = col;
        }

        public DrawDoc CopySelected()
        {
            DrawDoc ret = new DrawDoc();
            foreach (DrawForm frm in drwObj)
                if (frm.isSelected)
                    ret.AddObj(new DrawForm(frm));
            SelectAll(false);
            return ret;
        }

        public DrawDoc CutSelected()
        {
            DrawDoc ret = new DrawDoc();
            foreach (DrawForm frm in drwObj)
                if (frm.isSelected)
                    ret.AddObj(frm);
            RemoveSelected();
            return ret;
        }

        public void Paste(DrawDoc clip)
        {
            SelectAll(false);
            for (int i = 0; i < clip.NumObjects; i++)
                drwObj.Add(new DrawForm(clip[i]));
        }
    }
}
