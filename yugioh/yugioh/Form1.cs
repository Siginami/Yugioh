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
        Kocki kocki1 = new Kocki("Summon2", "Summon2", "Summon2", "Magic", "Move", "Move");
        Kocki kocki2 = new Kocki("Summon2", "Summon2", "Summon2", "Move", "Deffend", "Attack");
        Kocki kocki3 = new Kocki("Summon2", "Summon2", "Summon2", "Attack", "Attack", "Magic");
        Kocki kocki4 = new Kocki("Summon2", "Summon2", "Summon2", "Deffend", "Attack", "Magic");
        Kocki kocki5 = new Kocki("Summon2", "Summon2", "Summon2", "Magic", "Magic", "Deffend");
        Kocki kocki6 = new Kocki("Summon2", "Move", "Attack", "Magic", "Deffend", "Move2");
        Kocki kocki7 = new Kocki("Summon2", "Move", "Magic", "Magic", "Deffend", "Deffend");
        Kocki kocki8 = new Kocki("Summon2", "Attack", "Attack", "Magic", "Magic", "Deffend");
        Kocki kocki9 = new Kocki("Summon2", "Summon2", "Summon2", "Attack", "Move", "Deffend");
        Kocki kocki10 = new Kocki("Summon3", "Summon3", "Attack2", "Magic", "Move2", "Deffend");
        Kocki kocki11 = new Kocki("Summon3", "Summon3", "Attack", "Magic", "Move2", "Deffend2");
        Kocki kocki12 = new Kocki("Summon3", "Summon3", "Attack", "Magic2", "Move2", "Deffend");
        Kocki kocki13 = new Kocki("Summon3", "Summon3", "Attack", "Magic2", "Move", "Deffend2");
        Kocki kocki14 = new Kocki("Summon4", "Magic2", "Attack2", "Move2", "Deffend2", "Move3");
        Kocki kocki15 = new Kocki("Summon4", "Move2", "Magic2", "Deffend2", "Attack2", "Magic3");
        public Form1()
        {
            InitializeComponent();
            docGrForms = new DrawDoc();
            /*Kocki kocka1 = new Kocki("Summon2", "Summon2", "Summon2", "Magic", "Move", "Move");
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
            Kocki kocka15 = new Kocki("Summon4", "Move2", "Magic2", "Deffend2", "Attack2", "Magic3");*/
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

        private string PresmetajValue(int randomizer, int randomzier2)
        {
            string value = "";
            switch (randomizer)
            {
                case 1:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki1.strana1;
                            break;
                        case 2:
                            value = kocki1.strana2;
                            break;
                        case 3:
                            value = kocki1.strana3;
                            break;
                        case 4:
                            value = kocki1.strana4;
                            break;
                        case 5:
                            value = kocki1.strana5;
                            break;
                        case 6:
                            value = kocki1.strana6;
                            break;
                    }
                    break;
                case 2:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki2.strana1;
                            break;
                        case 2:
                            value = kocki2.strana2;
                            break;
                        case 3:
                            value = kocki2.strana3;
                            break;
                        case 4:
                            value = kocki2.strana4;
                            break;
                        case 5:
                            value = kocki2.strana5;
                            break;
                        case 6:
                            value = kocki2.strana6;
                            break;
                    }
                    break;
                case 3:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki3.strana1;
                            break;
                        case 2:
                            value = kocki3.strana2;
                            break;
                        case 3:
                            value = kocki3.strana3;
                            break;
                        case 4:
                            value = kocki3.strana4;
                            break;
                        case 5:
                            value = kocki3.strana5;
                            break;
                        case 6:
                            value = kocki3.strana6;
                            break;
                    }
                    break;
                case 4:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki4.strana1;
                            break;
                        case 2:
                            value = kocki4.strana2;
                            break;
                        case 3:
                            value = kocki4.strana3;
                            break;
                        case 4:
                            value = kocki4.strana4;
                            break;
                        case 5:
                            value = kocki4.strana5;
                            break;
                        case 6:
                            value = kocki4.strana6;
                            break;
                    }
                    break;
                case 5:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki5.strana1;
                            break;
                        case 2:
                            value = kocki5.strana2;
                            break;
                        case 3:
                            value = kocki5.strana3;
                            break;
                        case 4:
                            value = kocki5.strana4;
                            break;
                        case 5:
                            value = kocki5.strana5;
                            break;
                        case 6:
                            value = kocki5.strana6;
                            break;
                    }
                    break;
                case 6:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki6.strana1;
                            break;
                        case 2:
                            value = kocki6.strana2;
                            break;
                        case 3:
                            value = kocki6.strana3;
                            break;
                        case 4:
                            value = kocki6.strana4;
                            break;
                        case 5:
                            value = kocki6.strana5;
                            break;
                        case 6:
                            value = kocki6.strana6;
                            break;
                    }
                    break;
                case 7:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki7.strana1;
                            break;
                        case 2:
                            value = kocki7.strana2;
                            break;
                        case 3:
                            value = kocki7.strana3;
                            break;
                        case 4:
                            value = kocki7.strana4;
                            break;
                        case 5:
                            value = kocki7.strana5;
                            break;
                        case 6:
                            value = kocki7.strana6;
                            break;
                    }
                    break;
                case 8:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki8.strana1;
                            break;
                        case 2:
                            value = kocki8.strana2;
                            break;
                        case 3:
                            value = kocki8.strana3;
                            break;
                        case 4:
                            value = kocki8.strana4;
                            break;
                        case 5:
                            value = kocki8.strana5;
                            break;
                        case 6:
                            value = kocki8.strana6;
                            break;
                    }
                    break;
                case 9:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki9.strana1;
                            break;
                        case 2:
                            value = kocki9.strana2;
                            break;
                        case 3:
                            value = kocki9.strana3;
                            break;
                        case 4:
                            value = kocki9.strana4;
                            break;
                        case 5:
                            value = kocki9.strana5;
                            break;
                        case 6:
                            value = kocki9.strana6;
                            break;
                    }
                    break;
                case 10:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki10.strana1;
                            break;
                        case 2:
                            value = kocki10.strana2;
                            break;
                        case 3:
                            value = kocki10.strana3;
                            break;
                        case 4:
                            value = kocki10.strana4;
                            break;
                        case 5:
                            value = kocki10.strana5;
                            break;
                        case 6:
                            value = kocki10.strana6;
                            break;
                    }
                    break;
                case 11:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki11.strana1;
                            break;
                        case 2:
                            value = kocki11.strana2;
                            break;
                        case 3:
                            value = kocki11.strana3;
                            break;
                        case 4:
                            value = kocki11.strana4;
                            break;
                        case 5:
                            value = kocki11.strana5;
                            break;
                        case 6:
                            value = kocki11.strana6;
                            break;
                    }
                    break;
                case 12:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki12.strana1;
                            break;
                        case 2:
                            value = kocki12.strana2;
                            break;
                        case 3:
                            value = kocki12.strana3;
                            break;
                        case 4:
                            value = kocki12.strana4;
                            break;
                        case 5:
                            value = kocki12.strana5;
                            break;
                        case 6:
                            value = kocki12.strana6;
                            break;
                    }
                    break;
                case 13:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki13.strana1;
                            break;
                        case 2:
                            value = kocki13.strana2;
                            break;
                        case 3:
                            value = kocki13.strana3;
                            break;
                        case 4:
                            value = kocki13.strana4;
                            break;
                        case 5:
                            value = kocki13.strana5;
                            break;
                        case 6:
                            value = kocki13.strana6;
                            break;
                    }
                    break;
                case 14:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki14.strana1;
                            break;
                        case 2:
                            value = kocki14.strana2;
                            break;
                        case 3:
                            value = kocki14.strana3;
                            break;
                        case 4:
                            value = kocki14.strana4;
                            break;
                        case 5:
                            value = kocki14.strana5;
                            break;
                        case 6:
                            value = kocki14.strana6;
                            break;
                    }
                    break;
                case 15:
                    switch (randomzier2)
                    {
                        case 1:
                            value = kocki15.strana1;
                            break;
                        case 2:
                            value = kocki15.strana2;
                            break;
                        case 3:
                            value = kocki15.strana3;
                            break;
                        case 4:
                            value = kocki15.strana4;
                            break;
                        case 5:
                            value = kocki15.strana5;
                            break;
                        case 6:
                            value = kocki15.strana6;
                            break;
                    }
                    break;
            }
            return value;
        }

        /*private void Najdislika(string kocka, PictureBox slika)
        {
            switch (kocka)
            {
                case "Summon2":
                    slika.Image = Image.FromFile("‪");
                    break;
                case "Summon3":
                    slika.Image = Image.FromFile("");
                    break;
                case "Summon4":
                    slika.Image = Image.FromFile("");
                    break;
                case "Move":
                    slika.Image = Image.FromFile("");
                    break;
                case "Attack":
                    slika.Image = Image.FromFile("");
                    break;
                case "Deffend":
                    slika.Image = Image.FromFile("");
                    break;
                case "Magic":
                    slika.Image = Image.FromFile("");
                    break;
                case "Move2":
                    slika.Image = Image.FromFile("");
                    break;
                case "Attack2":
                    slika.Image = Image.FromFile("");
                    break;
                case "Deffend2":
                    slika.Image = Image.FromFile("");
                    break;
                case "Magic2":
                    slika.Image = Image.FromFile("");
                    break;
            }
        }*/
        //vadi exception ne go rabiram =/

        private void endturn_Click(object sender, EventArgs e)
        {

            int randomizer = brojce.Next(1, 15);
            int randomzier2 = brojce.Next(1, 6);
            int randomizer3 = brojce.Next(1, 15);
            int randomzier4 = brojce.Next(1, 6);
            int randomizer5= brojce.Next(1, 15);
            int randomzier6 = brojce.Next(1, 6);
            string prvakocka = PresmetajValue(randomizer, randomzier2);
            string vtorakocka = PresmetajValue(randomizer3, randomzier4);
            string tretakocka = PresmetajValue(randomizer5,randomzier6);
            /*Najdislika(prvakocka, kocka1);
            Najdislika(vtorakocka, kocka2);
            Najdislika(tretakocka, kocka3);*/
        }
    }
}
