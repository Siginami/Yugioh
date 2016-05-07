using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yugioh
{
    public partial class Form1 : Form
    {
        static int Seed = (int)DateTime.Now.Ticks;
        Random brojce = new Random(Seed);
        protected DrawDoc docGrForms;
        protected DrawDoc clipBoard = null;
        protected String FileName = null;
        protected Color currentColor = Color.Red;
        protected int currentSize = 10;
        protected bool drawingMode = true;
        protected Point moveClickPosition;
        public Form1()
        {
            InitializeComponent();
            docGrForms = new DrawDoc();
            Kocki kocka1 = new Kocki("Summon2", "Summon2", "Summon2", "Magic", "Move", "Move");
            Kocki kocka2 = new Kocki("Summon2", "Summon2", "Summon2", "Move", "Deffend", "Attack");
            Kocki kocka3 = new Kocki("Summon2", "Summon2", "Summon2", "Attack", "Attack", "Magic");
            Kocki kocka4 = new Kocki("Summon2", "Summon2", "Summon2", "Deffend", "Attack", "Magic");
            Kocki kocka5 = new Kocki("Summon2", "Summon2", "Summon2", "Magic", "Magic", "Deffend");
            Kocki kocka6 = new Kocki("Summon2", "Move", "Attack", "Magic", "Deffend", "Move2");
            Kocki kocka7 = new Kocki("Summon2", "Move", "Magic", "Magic", "Deffend", "Deffend");
            Kocki kocka8 = new Kocki("Summon2", "Attack", "Attack", "Magic", "Magic", "Deffend");
            Kocki kocka9 = new Kocki("Summon2", "Summon2", "Summon2", "Attack", "Move", "Deffend");
            Kocki kocka10 = new Kocki("Summon3", "Summon3", "Attack2", "Magic", "Move2", "Deffend");
            Kocki kocka11 = new Kocki("Summon3", "Summon3", "Attack", "Magic", "Move2", "Deffend2");
            Kocki kocka12 = new Kocki("Summon3", "Summon3", "Attack", "Magic2", "Move2", "Deffend");
            Kocki kocka13 = new Kocki("Summon3", "Summon3", "Attack", "Magic2", "Move", "Deffend2");
            Kocki kocka14 = new Kocki("Summon4", "Magic2", "Attack2", "Move2", "Deffend2", "Move3");
            Kocki kocka15 = new Kocki("Summon4", "Move2", "Magic2", "Deffend2", "Attack2", "Magic3");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            docGrForms.DrawAll(g);
            g.Dispose();
            int numOfCells = 13;
            int numOfCol = 19;
            int cellSize = 25;
            Pen p = new Pen(Color.Black);
            Point l = new Point();
            for (int x = 1; x <= numOfCells; ++x)
            for (int y = 1; y <= numOfCol; ++y)
            {
                l = new Point(x * (cellSize + 10), y * (cellSize + 10));
                //g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
                docGrForms.AddObj(new DrawForm(l, currentColor, cellSize));
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (drawingMode)
                    docGrForms.AddObj(new DrawForm(e.Location, currentColor, currentSize));
                else if (docGrForms.OverSelectedObject(e.Location))
                {
                    moveClickPosition = e.Location;
                    this.Cursor = Cursors.Hand;
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                docGrForms.Select(e.Location);
            }
            Invalidate(true);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !drawingMode)
            {
                docGrForms.MoveSelected(e.Location - (Size)moveClickPosition);
                moveClickPosition = e.Location;
                Invalidate(true);
            }
        }

        private void endturn_Click(object sender, EventArgs e)
        {
            int randomizer = brojce.Next(1, 15);
            int randomizer2 = brojce.Next(1, 6);
            //Kako da pristapam do kockata so broj randomizer i stranata so broj randomizer2???
        }
    }
}
