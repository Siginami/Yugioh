using System;
using System.Collections;
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
        public bool grid = false;
        string direction = "up";
        Igrac2 igrac1 = new Igrac2();
        Igrac2 igrac2 = new Igrac2();
        int prvidvakruga = 0;
        string whatsummon = "";//da se znae koj summon kje se pravi
        bool prvigrac = false;//dali e prviot ili vtoriot na red igrata pocnuva koga kje se klikne end turn
        bool flag = true;//dali e kliknato end turn prethodno ili ne
        static int Seed = (int)DateTime.Now.Ticks;
        Random brojce = new Random(Seed);
        public static Grid formaGrid;
        public ArrayList player1Array;
        public ArrayList player2Array;
        protected Grid clipBoard = null;
        protected String FileName = null;
        protected Color currentColor = Color.LightYellow;
        protected int currentSize = 10;
        protected Point moveClickPosition;
        Kocki kocki1 = new Kocki("Summon2", "Summon2", "Summon2", "Summon2", "Summon2", "Summon2");
        Kocki kocki2 = new Kocki("Summon3", "Summon3", "Summon3", "Summon3", "Summon3", "Summon3");
        Kocki kocki3 = new Kocki("Summon4", "Summon4", "Summon4", "Summon4", "Summon4", "Summon4");
        Kocki kocki4 = new Kocki("Summon2", "Summon4", "Summon3", "Summon2", "Summon4", "Summon2");
        Kocki kocki5 = new Kocki("Summon3", "Summon2", "Summon3", "Summon4", "Summon2", "Summon2");
        Kocki kocki6 = new Kocki("Summon2", "Summon4", "Summon3", "Summon3", "Summon2", "Summon3");
        Kocki kocki7 = new Kocki("Summon3", "Summon2", "Summon3", "Summon3", "Summon4", "Summon4");
        Kocki kocki8 = new Kocki("Summon2", "Summon3", "Summon4", "Summon2", "Summon4", "Summon4");
        Kocki kocki9 = new Kocki("Summon4", "Summon4", "Summon4", "Summon3", "Summon2", "Summon3");

        public Form1()
        {
            DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            formaGrid = new Grid();
            player1Array = new ArrayList();
            player2Array = new ArrayList();
        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            formaGrid.DrawAll(g);
            g.Dispose();
            int numOfCells = 13;
            int numOfCol = 19;
            int cellSize = 25;
            Point l = new Point();
            for (int x = 1; x <= numOfCells; ++x)
            {
                for (int y = 1; y <= numOfCol; ++y)
                {
                    l = new Point(x * (cellSize + 10), y * (cellSize + 10));
                }
            }
        }

        public void generateGrid()
        {
            Graphics g = panel1.CreateGraphics();
            formaGrid.DrawAll(g);
            g.Dispose();
            int numOfCells = 13;
            int numOfCol = 19;
            int cellSize = 25;
            Point l = new Point();
            for (int x = 1; x <= numOfCells; ++x)
            {
                for (int y = 1; y <= numOfCol; ++y)
                {

                    l = new Point(x * (cellSize + 10), y * (cellSize + 10));
                    formaGrid.AddObj(new Place(l, currentColor, cellSize));
                }
            }
            formaGrid[132].player1 = true;
            formaGrid[114].player2 = true;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                formaGrid.Select(e.Location);
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                formaGrid.Select(e.Location);
            }
            Invalidate(true);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
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
            }
            return value;
        }

        private void Canyousummon(string prvakocka, string vtorakocka, string tretakocka)
        {
            if (prvakocka == vtorakocka && prvakocka == tretakocka && prvakocka == "Summon2")
            {
                summon.Enabled = true;
                whatsummon = "Summon2";
            }
            else if (prvakocka == "Summon3" && prvakocka == vtorakocka && prvakocka == tretakocka)
            {
                summon.Enabled = true;
                whatsummon = "Summon3";
            }
            else if (prvakocka == "Summon4" && prvakocka == vtorakocka && prvakocka == tretakocka)
            {
                summon.Enabled = true;
                whatsummon = "Summon4";
            }
            if (prvidvakruga <= 2)
            {
                summon.Enabled = false;
            }
        }

        private void endturn_Click(object sender, EventArgs e)
        {
            prvidvakruga++;
            button1.Enabled = true;
            if (summon.Enabled)
            {
                summon.Enabled = false;
            }
            if (!flag)
            {
                int bonuspoen = brojce.Next(1, 247);
                SpawnPoint(bonuspoen);
                int randomizer = brojce.Next(1, 9);
                int randomzier2 = brojce.Next(1, 6);
                int randomizer3 = brojce.Next(1, 9);
                int randomzier4 = brojce.Next(1, 6);
                int randomizer5 = brojce.Next(1, 9);
                int randomzier6 = brojce.Next(1, 6);
                string prvakocka = PresmetajValue(randomizer, randomzier2);
                string vtorakocka = PresmetajValue(randomizer3, randomzier4);
                string tretakocka = PresmetajValue(randomizer5, randomzier6);
                tbkockaeden.Text = prvakocka;
                tbkockadva.Text = vtorakocka;
                tbkockatri.Text = tretakocka;
                if (prvigrac)
                {
                    DialogResult result = MessageBox.Show("Player 1 move", "Whose turn is it", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Canyousummon(prvakocka, vtorakocka, tretakocka);
                    player1left.Enabled = true;
                    player1down.Enabled = true;
                    player1right.Enabled = true;
                    player1up.Enabled = true;
                    player2down.Enabled = false;
                    player2up.Enabled = false;
                    player2left.Enabled = false;
                    player2right.Enabled = false;
                    direction = "up";
                    prvigrac = false;

                }
                else
                {
                    DialogResult result = MessageBox.Show("Player 2 move", "Whose turn is it", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Canyousummon(prvakocka, vtorakocka, tretakocka);
                    player2left.Enabled = true;
                    player2down.Enabled = true;
                    player2right.Enabled = true;
                    player2up.Enabled = true;
                    player1down.Enabled = false;
                    player1up.Enabled = false;
                    player1left.Enabled = false;
                    player1right.Enabled = false;
                    direction = "down";
                    prvigrac = true;

                }
            }
            else
            {
                generateGrid();
                endturn.Text = "End Turn";
                int bonuspoen = brojce.Next(1, 247);
                SpawnPoint(bonuspoen);
                int randomizer = brojce.Next(1, 9);
                int randomzier2 = brojce.Next(1, 6);
                int randomizer3 = brojce.Next(1, 9);
                int randomzier4 = brojce.Next(1, 6);
                int randomizer5 = brojce.Next(1, 9);
                int randomzier6 = brojce.Next(1, 6);
                string prvakocka = PresmetajValue(randomizer, randomzier2);
                string vtorakocka = PresmetajValue(randomizer3, randomzier4);
                string tretakocka = PresmetajValue(randomizer5, randomzier6);
                tbkockaeden.Text = prvakocka;
                tbkockadva.Text = vtorakocka;
                tbkockatri.Text = tretakocka;
                DialogResult result = MessageBox.Show("Player 1 move", "Whose turn is it", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Canyousummon(prvakocka, vtorakocka, tretakocka);
                player2down.Enabled = false;
                player2up.Enabled = false;
                player2left.Enabled = false;
                player2right.Enabled = false;
                prvigrac = false;
                flag = false;
                panel1.Refresh();
            }
        }

        public bool validateSummon(ArrayList squares)
        {

            bool valid = true;
            if (squares == null)//ova if else
            {
                valid = false;
            }
            else {
                foreach (Place p in squares)
                {
                    if (player1Array.Contains(p) || player2Array.Contains(p))
                    {
                        DialogResult asd = MessageBox.Show("Локацијата " + (p.X) / 35 + " " + (p.Y) / 35 + " е зафатена", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        valid = false;
                    }
                }
            }
            return valid;
        }

        private void summon_Click(object sender, EventArgs e)
        {
            try
            {
                Place selected = getSelectedPlace(direction);
                ArrayList squares = getStshape(selected, direction);
                if (prvigrac == false && getSelectedPlace(direction).player1 == true)
                {
                    if (validateSummon(squares))
                    {
                        summon.Enabled = false;
                        stShapedSquares(direction);
                    }
                    else {
                        DialogResult result = MessageBox.Show("Изберете друга почетна коцка, тие позиции се зафатени.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (prvigrac == true && getSelectedPlace(direction).player2)
                {
                    if (validateSummon(squares))
                    {
                        summon.Enabled = false;
                        stShapedSquares(direction);
                    }
                    else {
                        DialogResult result = MessageBox.Show("Изберете друга почетна коцка, тие позиции се зафатени.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Почетната коцка мора да биде ваша", "Селектирајте ваша коцка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                player1poeni.Text = player1Points(squares).ToString();
                player2poeni.Text = player2Points(squares).ToString();
                panel1.Refresh();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Треба да селектирате коцка во гридот.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void SpawnPoint(int kade)
        {
            int promx = 0;
            int promy = 0;
            foreach (Place p in formaGrid.drwPlaces)
            {
                promx = p.X - 35;
                promy = p.Y - 35;
                if ((promx / 35) * 19 + (promy / 35) == kade)
                {
                    if (p.isFree())
                    {
                        formaGrid[(promx / 35) * 19 + (promy / 35)].imapoen = true;
                        panel1.Refresh();
                        break;
                    }
                    else
                    {
                        SpawnPoint(brojce.Next(0, 247));
                    }
                }
            }
        }

        public Place getIndexOfCube(int x, int y, int mX, int mY, int cX, int cY)
        {
            return formaGrid[((x + (mX * cX)) / 35) * 19 + (y + (mY * cY)) / 35];
        }

        public Place getSelectedPlace(string direction)
        {
            for (int i = 0; i < formaGrid.NumObjects; i++)
            {
                if (formaGrid[i].isSelected)
                {
                    return formaGrid[i];
                }
            }
            return null;
        }

        public ArrayList getTshape(Place start, string direction)
        {
            int colorX = 1;
            int colorY = 0;
            switch (direction)
            {
                case "up":
                    colorX = 35;
                    colorY = -35;
                    break;
                case "down":
                    colorX = 35;
                    colorY = 35;
                    break;
                case "right":
                    colorX = 35;
                    colorY = 35;
                    break;
                case "left":
                    colorX = -35;
                    colorY = 35;
                    break;
            }
            ArrayList squares = new ArrayList();
            int startX = start.X;
            int startY = start.Y;
            startX -= 35;
            startY -= 35;
            //squares.Add(formaGrid[(startX / 35) * 19 + startY / 35]);
            try
            {

                if (direction == "right" || direction == "left")
                {
                    squares.Add(getIndexOfCube(startX, startY, 1, 0, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 2, 0, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 3, 0, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 3, 1, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 3, -1, colorX, colorY));
                }
                else
                {
                    //squares.Add(formaGrid[(startX / 35) * 19 + startY / 35]);
                    squares.Add(formaGrid[(startX / 35) * 19 + (startY + (1 * colorY)) / 35]);
                    squares.Add(formaGrid[(startX / 35) * 19 + (startY + (2 * colorY)) / 35]);
                    squares.Add(formaGrid[(startX / 35) * 19 + (startY + (3 * colorY)) / 35]);
                    squares.Add(formaGrid[(startX - (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35]);
                    squares.Add(formaGrid[(startX + (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35]);
                }
                return squares;//ovoj return
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Неможеш да ја расклопиш коцката надвор од гридот", "Пази каде расклопуваш", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;//ovoj return
            }
            //return squares;
        } //proverka na standard T forma

        //public bool canTshape(string direction)
        //{
        //    int startX = 0;
        //    int startY = 0;
        //    int colorX = 1;
        //    int colorY = 0;
        //    switch (direction)
        //    {
        //        case "up":
        //            colorX = 35;
        //            colorY = -35;
        //            break;
        //        case "down":
        //            colorX = 35;
        //            colorY = 35;
        //            break;
        //        case "right":
        //            colorX = 35;
        //            colorY = 35;
        //            break;
        //        case "left":
        //            colorX = -35;
        //            colorY = 35;
        //            break;
        //    }
        //    for (int i = 0; i < formaGrid.NumObjects; i++)
        //    {
        //        if (formaGrid[i].isSelected)
        //        {
        //            startX = formaGrid[i].X;
        //            startY = formaGrid[i].Y;
        //            startX -= 35;
        //            startY -= 35;
        //        }

        //    }
        //    if (direction == "up" || direction == "down")
        //    {
        //        if (formaGrid[(startX / 35) * 19 + startY / 35].player1 == true ||
        //        formaGrid[(startX / 35) * 19 + (startY + (1 * colorY)) / 35].player1 == true ||
        //        formaGrid[(startX / 35) * 19 + (startY + (2 * colorY)) / 35].player1 == true ||
        //        formaGrid[(startX / 35) * 19 + (startY + (3 * colorY)) / 35].player1 == true ||
        //        formaGrid[(startX - (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player1 == true ||
        //        formaGrid[(startX + (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player1 == true ||
        //        formaGrid[(startX / 35) * 19 + startY / 35].player2 == true ||
        //        formaGrid[(startX / 35) * 19 + (startY + (1 * colorY)) / 35].player2 == true ||
        //        formaGrid[(startX / 35) * 19 + (startY + (2 * colorY)) / 35].player2 == true ||
        //        formaGrid[(startX / 35) * 19 + (startY + (3 * colorY)) / 35].player2 == true ||
        //        formaGrid[(startX - (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player2 == true ||
        //        formaGrid[(startX + (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player2 == true)
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        if (formaGrid[(startX / 35) * 19 + startY / 35].player1 == true ||
        //        formaGrid[((startX + (1 * colorX)) / 35) * 19 + startY / 35].player1 == true ||
        //        formaGrid[((startX + (2 * colorX)) / 35) * 19 + startY / 35].player1 == true ||
        //        formaGrid[((startX + (3 * colorX)) / 35) * 19 + startY / 35].player1 == true ||
        //        formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY + (1 * colorY)) / 35].player1 == true ||
        //        formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY - (1 * colorY)) / 35].player1 == true ||
        //        formaGrid[(startX / 35) * 19 + startY / 35].player2 == true ||
        //        formaGrid[((startX + (1 * colorX)) / 35) * 19 + startY / 35].player2 == true ||
        //        formaGrid[((startX + (2 * colorX)) / 35) * 19 + startY / 35].player2 == true ||
        //        formaGrid[((startX + (3 * colorX)) / 35) * 19 + startY / 35].player2 == true ||
        //        formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY + (1 * colorY)) / 35].player2 == true ||
        //        formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY - (1 * colorY)) / 35].player2 == true)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;


        //}

        public void tShapedSquares(string direction)//crtanje na standard T forma 
        {
            int startX = 0;
            int startY = 0;
            int colorX = 1;
            int colorY = 0;
            switch (direction)
            {
                case "up":
                    colorX = 35;
                    colorY = -35;
                    break;
                case "down":
                    colorX = 35;
                    colorY = 35;
                    break;
                case "right":
                    colorX = 35;
                    colorY = 35;
                    break;
                case "left":
                    colorX = -35;
                    colorY = 35;
                    break;
            }
            for (int i = 0; i < formaGrid.NumObjects; i++)
            {
                if (formaGrid[i].isSelected)
                {
                    startX = formaGrid[i].X;
                    startY = formaGrid[i].Y;
                    startX -= 35;
                    startY -= 35;
                }

            }
            if (!prvigrac)
            {
                if (direction == "up" || direction == "down")
                {
                    formaGrid[(startX / 35) * 19 + startY / 35].player1 = true;
                    formaGrid[(startX / 35) * 19 + (startY + (1 * colorY)) / 35].player1 = true;
                    formaGrid[(startX / 35) * 19 + (startY + (2 * colorY)) / 35].player1 = true;
                    formaGrid[(startX / 35) * 19 + (startY + (3 * colorY)) / 35].player1 = true;
                    formaGrid[(startX - (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player1 = true;
                    formaGrid[(startX + (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player1 = true;
                }
                else
                {
                    formaGrid[(startX / 35) * 19 + startY / 35].player1 = true;
                    formaGrid[((startX + (1 * colorX)) / 35) * 19 + startY / 35].player1 = true;
                    formaGrid[((startX + (2 * colorX)) / 35) * 19 + startY / 35].player1 = true;
                    formaGrid[((startX + (3 * colorX)) / 35) * 19 + startY / 35].player1 = true;
                    formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY + (1 * colorY)) / 35].player1 = true;
                    formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY - (1 * colorY)) / 35].player1 = true;
                }
            }
            else if (prvigrac)
            {
                if (direction == "up" || direction == "down")
                {
                    formaGrid[(startX / 35) * 19 + startY / 35].player2 = true;
                    formaGrid[(startX / 35) * 19 + (startY + (1 * colorY)) / 35].player2 = true;
                    formaGrid[(startX / 35) * 19 + (startY + (2 * colorY)) / 35].player2 = true;
                    formaGrid[(startX / 35) * 19 + (startY + (3 * colorY)) / 35].player2 = true;
                    formaGrid[(startX - (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player2 = true;
                    formaGrid[(startX + (1 * colorX)) / 35 * 19 + (startY + (3 * colorY)) / 35].player2 = true;
                }
                else
                {
                    formaGrid[(startX / 35) * 19 + startY / 35].player2 = true;
                    formaGrid[((startX + (1 * colorX)) / 35) * 19 + startY / 35].player2 = true;
                    formaGrid[((startX + (2 * colorX)) / 35) * 19 + startY / 35].player2 = true;
                    formaGrid[((startX + (3 * colorX)) / 35) * 19 + startY / 35].player2 = true;
                    formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY + (1 * colorY)) / 35].player2 = true;
                    formaGrid[((startX + (3 * colorX)) / 35) * 19 + (startY - (1 * colorY)) / 35].player2 = true;
                }
            }
            player1Array = new ArrayList();
            player2Array = new ArrayList();
            foreach (Place p in formaGrid.drwPlaces)
            {
                if (p.player1)
                {
                    player1Array.Add(p);
                }
                else if (p.player2)
                {
                    player2Array.Add(p);
                }
            }
        }

        public ArrayList getStshape(Place start, string direction)
        {
            int colorX = 1;
            int colorY = 0;
            switch (direction)
            {
                case "up":
                    colorX = 35;
                    colorY = -35;
                    break;
                case "down":
                    colorX = 35;
                    colorY = 35;
                    break;
                case "right":
                    colorX = -35;
                    colorY = 35;
                    break;
                case "left":
                    colorX = 35;
                    colorY = -35;
                    break;
            }
            ArrayList squares = new ArrayList();
            int startX = start.X;
            int startY = start.Y;
            startX -= 35;
            startY -= 35;
            //squares.Add(formaGrid[(startX / 35) * 19 + startY / 35]);
            try
            {

                if (direction == "right" || direction == "left")
                {
                    squares.Add(getIndexOfCube(startX, startY, 0, 1, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, -1, 1, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, -1, 2, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, -2, 2, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, -2, 3, colorX, colorY));
                }
                else
                {
                    //squares.Add(formaGrid[(startX / 35) * 19 + startY / 35]);
                    squares.Add(getIndexOfCube(startX, startY, 0, 1, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 1, 1, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 1, 2, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 2, 2, colorX, colorY));
                    squares.Add(getIndexOfCube(startX, startY, 2, 3, colorX, colorY));
                }
                return squares;//ovoj return
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Не можеш да ја расклопиш коцката надвор од гридот", "Пази каде расклопуваш", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;//ovoj return
            }
            //return squares;
        }//proverka na skali forma

        public void stShapedSquares(string direction)//crtanje na skali forma
        {
            int startX = 0;
            int startY = 0;
            int colorX = 1;
            int colorY = 0;
            switch (direction)
            {
                case "up":
                    colorX = 35;
                    colorY = -35;
                    break;
                case "down":
                    colorX = 35;
                    colorY = 35;
                    break;
                case "right":
                    colorX = -35;
                    colorY = 35;
                    break;
                case "left":
                    colorX = 35;
                    colorY = -35;
                    break;
            }
            for (int i = 0; i < formaGrid.NumObjects; i++)
            {
                if (formaGrid[i].isSelected)
                {
                    startX = formaGrid[i].X;
                    startY = formaGrid[i].Y;
                    startX -= 35;
                    startY -= 35;
                }

            }
            if (!prvigrac)
            {
                if (direction == "up" || direction == "down")
                {
                    getIndexOfCube(startX, startY, 0, 0, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, 0, 1, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, 1, 1, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, 1, 2, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, 2, 2, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, 2, 3, colorX, colorY).player1 = true;
                }
                else
                {
                    getIndexOfCube(startX, startY, 0, 0, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, 0, 1, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, -1, 1, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, -1, 2, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, -2, 2, colorX, colorY).player1 = true;
                    getIndexOfCube(startX, startY, -2, 3, colorX, colorY).player1 = true;
                }
            }
            else if (prvigrac)
            {
                if (direction == "up" || direction == "down")
                {
                    getIndexOfCube(startX, startY, 0, 0, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, 0, 1, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, 1, 1, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, 1, 2, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, 2, 2, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, 2, 3, colorX, colorY).player2 = true;
                }
                else
                {
                    getIndexOfCube(startX, startY, 0, 0, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, 0, 1, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, -1, 1, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, -1, 2, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, -2, 2, colorX, colorY).player2 = true;
                    getIndexOfCube(startX, startY, -2, 3, colorX, colorY).player2 = true;
                }
            }
            player1Array = new ArrayList();
            player2Array = new ArrayList();
            foreach (Place p in formaGrid.drwPlaces)
            {
                if (p.player1)
                {
                    player1Array.Add(p);
                }
                else if (p.player2)
                {
                    player2Array.Add(p);
                }
            }
        }

        void Form1_Load(object sender, EventArgs e)
        {

        }

        public int player1Points(ArrayList squares)
        {
            if (squares == null)//ova if else
            {
            }
            else {
                foreach (Place p in squares)
                {
                    if (p.imapoen == true && p.player1 == true)
                    {
                        igrac1.Points++;
                    }
                }
            }
            return igrac1.Points;
        }

        public int player2Points(ArrayList squares)
        {
            if (squares == null)//ova if else
            {

            }
            else {
                foreach (Place p in squares)
                {
                    if (p.imapoen == true && p.player2 == true)
                    {
                        igrac2.Points++;
                    }
                }
            }
            return igrac2.Points;
        }

        private void player1left_Click(object sender, EventArgs e)
        {
            direction = "left";
        }

        private void player1right_Click(object sender, EventArgs e)
        {
            direction = "right";
        }

        private void player1up_Click(object sender, EventArgs e)
        {
            direction = "up";
        }

        private void player1down_Click(object sender, EventArgs e)
        {
            direction = "down";
        }

        private void player2left_Click_1(object sender, EventArgs e)
        {
            direction = "left";
        }

        private void player2right_Click_1(object sender, EventArgs e)
        {
            direction = "right";
        }

        private void player2up_Click_1(object sender, EventArgs e)
        {
            direction = "up";
        }

        private void player2down_Click_1(object sender, EventArgs e)
        {
            direction = "down";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try // try catch za da vidi dali ima selektirano kocka vo slucaj da nema
            {
                Place selected = getSelectedPlace(direction);
                ArrayList squares = getTshape(selected, direction);
                if (prvigrac == false && getSelectedPlace(direction).player1 == true)
                {
                    if (validateSummon(squares))
                    {
                        button1.Enabled = false;
                        tShapedSquares(direction);
                    }
                    else {
                        DialogResult result = MessageBox.Show("Изберете друга почетна коцка, тие позиции се зафатени.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (prvigrac == true && getSelectedPlace(direction).player2)
                {
                    if (validateSummon(squares))
                    {
                        button1.Enabled = false;
                        tShapedSquares(direction);
                    }
                    else {
                        DialogResult result = MessageBox.Show("Изберете друга почетна коцка, тие позиции се зафатени.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Почетната коцка мора да биде ваша", "Селектирајте ваша коцка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                player1poeni.Text = player1Points(squares).ToString();
                player2poeni.Text = player2Points(squares).ToString();
                panel1.Refresh();
            }
            catch
            {
                DialogResult result = MessageBox.Show("Треба да селектирате коцка во гридот.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
