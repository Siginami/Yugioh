using System.Windows.Forms;

namespace yugioh
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.player1zivoti = new System.Windows.Forms.TextBox();
            this.Hearts = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.player1magic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.player1deffend = new System.Windows.Forms.TextBox();
            this.player1attack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.player1move = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.player2zivoti = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.player2magic = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.player2deffend = new System.Windows.Forms.TextBox();
            this.player2attack = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.player2move = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.summon = new System.Windows.Forms.Button();
            this.endturn = new System.Windows.Forms.Button();
            this.kocka1 = new System.Windows.Forms.PictureBox();
            this.kocka2 = new System.Windows.Forms.PictureBox();
            this.kocka3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kocka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocka2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocka3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.player1zivoti);
            this.groupBox2.Controls.Add(this.Hearts);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.player1magic);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.player1deffend);
            this.groupBox2.Controls.Add(this.player1attack);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.player1move);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(537, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 275);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player1";
            // 
            // player1zivoti
            // 
            this.player1zivoti.Location = new System.Drawing.Point(201, 248);
            this.player1zivoti.Name = "player1zivoti";
            this.player1zivoti.Size = new System.Drawing.Size(180, 20);
            this.player1zivoti.TabIndex = 9;
            this.player1zivoti.Text = "3";
            // 
            // Hearts
            // 
            this.Hearts.AutoSize = true;
            this.Hearts.Location = new System.Drawing.Point(147, 251);
            this.Hearts.Name = "Hearts";
            this.Hearts.Size = new System.Drawing.Size(38, 13);
            this.Hearts.TabIndex = 8;
            this.Hearts.Text = "Hearts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Magic";
            // 
            // player1magic
            // 
            this.player1magic.Location = new System.Drawing.Point(201, 190);
            this.player1magic.Name = "player1magic";
            this.player1magic.ReadOnly = true;
            this.player1magic.Size = new System.Drawing.Size(180, 20);
            this.player1magic.TabIndex = 6;
            this.player1magic.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deffend";
            // 
            // player1deffend
            // 
            this.player1deffend.Location = new System.Drawing.Point(201, 132);
            this.player1deffend.Name = "player1deffend";
            this.player1deffend.ReadOnly = true;
            this.player1deffend.Size = new System.Drawing.Size(180, 20);
            this.player1deffend.TabIndex = 4;
            this.player1deffend.Text = "0";
            // 
            // player1attack
            // 
            this.player1attack.Location = new System.Drawing.Point(201, 74);
            this.player1attack.Name = "player1attack";
            this.player1attack.ReadOnly = true;
            this.player1attack.Size = new System.Drawing.Size(180, 20);
            this.player1attack.TabIndex = 3;
            this.player1attack.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attack";
            // 
            // player1move
            // 
            this.player1move.Location = new System.Drawing.Point(201, 16);
            this.player1move.Name = "player1move";
            this.player1move.ReadOnly = true;
            this.player1move.Size = new System.Drawing.Size(180, 20);
            this.player1move.TabIndex = 1;
            this.player1move.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Move";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.player2zivoti);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.player2magic);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.player2deffend);
            this.groupBox3.Controls.Add(this.player2attack);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.player2move);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(537, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 275);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hearts";
            // 
            // player2zivoti
            // 
            this.player2zivoti.Location = new System.Drawing.Point(201, 244);
            this.player2zivoti.Name = "player2zivoti";
            this.player2zivoti.Size = new System.Drawing.Size(180, 20);
            this.player2zivoti.TabIndex = 8;
            this.player2zivoti.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Magic";
            // 
            // player2magic
            // 
            this.player2magic.Location = new System.Drawing.Point(201, 187);
            this.player2magic.Name = "player2magic";
            this.player2magic.ReadOnly = true;
            this.player2magic.Size = new System.Drawing.Size(180, 20);
            this.player2magic.TabIndex = 6;
            this.player2magic.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deffend";
            // 
            // player2deffend
            // 
            this.player2deffend.Location = new System.Drawing.Point(201, 130);
            this.player2deffend.Name = "player2deffend";
            this.player2deffend.ReadOnly = true;
            this.player2deffend.Size = new System.Drawing.Size(180, 20);
            this.player2deffend.TabIndex = 4;
            this.player2deffend.Text = "0";
            // 
            // player2attack
            // 
            this.player2attack.Location = new System.Drawing.Point(201, 73);
            this.player2attack.Name = "player2attack";
            this.player2attack.ReadOnly = true;
            this.player2attack.Size = new System.Drawing.Size(180, 20);
            this.player2attack.TabIndex = 3;
            this.player2attack.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Attack";
            // 
            // player2move
            // 
            this.player2move.Location = new System.Drawing.Point(201, 16);
            this.player2move.Name = "player2move";
            this.player2move.ReadOnly = true;
            this.player2move.Size = new System.Drawing.Size(180, 20);
            this.player2move.TabIndex = 1;
            this.player2move.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(147, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Move";
            // 
            // summon
            // 
            this.summon.Enabled = false;
            this.summon.Location = new System.Drawing.Point(489, 302);
            this.summon.Name = "summon";
            this.summon.Size = new System.Drawing.Size(113, 52);
            this.summon.TabIndex = 15;
            this.summon.Text = "Summon";
            this.summon.UseVisualStyleBackColor = true;
            this.summon.Click += new System.EventHandler(this.summon_Click);
            // 
            // endturn
            // 
            this.endturn.Location = new System.Drawing.Point(489, 361);
            this.endturn.Name = "endturn";
            this.endturn.Size = new System.Drawing.Size(113, 52);
            this.endturn.TabIndex = 16;
            this.endturn.Text = "End Turn";
            this.endturn.UseVisualStyleBackColor = true;
            this.endturn.Click += new System.EventHandler(this.endturn_Click);
            // 
            // kocka1
            // 
            this.kocka1.Location = new System.Drawing.Point(608, 302);
            this.kocka1.Name = "kocka1";
            this.kocka1.Size = new System.Drawing.Size(100, 111);
            this.kocka1.TabIndex = 17;
            this.kocka1.TabStop = false;
            // 
            // kocka2
            // 
            this.kocka2.Location = new System.Drawing.Point(714, 302);
            this.kocka2.Name = "kocka2";
            this.kocka2.Size = new System.Drawing.Size(100, 111);
            this.kocka2.TabIndex = 18;
            this.kocka2.TabStop = false;
            // 
            // kocka3
            // 
            this.kocka3.Location = new System.Drawing.Point(818, 302);
            this.kocka3.Name = "kocka3";
            this.kocka3.Size = new System.Drawing.Size(100, 111);
            this.kocka3.TabIndex = 19;
            this.kocka3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 8);
           
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 698);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 60);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 710);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kocka3);
            this.Controls.Add(this.kocka2);
            this.Controls.Add(this.kocka1);
            this.Controls.Add(this.endturn);
            this.Controls.Add(this.summon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kocka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocka2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kocka3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox player1magic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox player1deffend;
        private System.Windows.Forms.TextBox player1attack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox player1move;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox player2magic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox player2deffend;
        private System.Windows.Forms.TextBox player2attack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox player2move;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button summon;
        private System.Windows.Forms.Button endturn;
        private System.Windows.Forms.PictureBox kocka1;
        private System.Windows.Forms.PictureBox kocka2;
        private System.Windows.Forms.PictureBox kocka3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox player1zivoti;
        private System.Windows.Forms.Label Hearts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox player2zivoti;
        private System.Windows.Forms.Button button1;
    }
}

