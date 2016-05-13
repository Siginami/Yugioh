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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.player2zivoti = new System.Windows.Forms.TextBox();
            this.summon = new System.Windows.Forms.Button();
            this.endturn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbkockaeden = new System.Windows.Forms.TextBox();
            this.tbkockatri = new System.Windows.Forms.TextBox();
            this.tbkockadva = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.player1zivoti);
            this.groupBox2.Location = new System.Drawing.Point(537, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(387, 275);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player1";
            // 
            // player1zivoti
            // 
            this.player1zivoti.Location = new System.Drawing.Point(201, 19);
            this.player1zivoti.Name = "player1zivoti";
            this.player1zivoti.Size = new System.Drawing.Size(180, 20);
            this.player1zivoti.TabIndex = 9;
            this.player1zivoti.Text = "0";
            this.player1zivoti.TextChanged += new System.EventHandler(this.player1zivoti_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.player2zivoti);
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
            this.label9.Location = new System.Drawing.Point(146, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Points";
            // 
            // player2zivoti
            // 
            this.player2zivoti.Location = new System.Drawing.Point(207, 19);
            this.player2zivoti.Name = "player2zivoti";
            this.player2zivoti.Size = new System.Drawing.Size(180, 20);
            this.player2zivoti.TabIndex = 8;
            this.player2zivoti.Text = "0";
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
            this.endturn.Text = "Start game";
            this.endturn.UseVisualStyleBackColor = true;
            this.endturn.Click += new System.EventHandler(this.endturn_Click);
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
            // tbkockaeden
            // 
            this.tbkockaeden.Location = new System.Drawing.Point(738, 294);
            this.tbkockaeden.Name = "tbkockaeden";
            this.tbkockaeden.Size = new System.Drawing.Size(180, 20);
            this.tbkockaeden.TabIndex = 22;
            // 
            // tbkockatri
            // 
            this.tbkockatri.Location = new System.Drawing.Point(738, 404);
            this.tbkockatri.Name = "tbkockatri";
            this.tbkockatri.Size = new System.Drawing.Size(180, 20);
            this.tbkockatri.TabIndex = 23;
            // 
            // tbkockadva
            // 
            this.tbkockadva.Location = new System.Drawing.Point(738, 349);
            this.tbkockadva.Name = "tbkockadva";
            this.tbkockadva.Size = new System.Drawing.Size(180, 20);
            this.tbkockadva.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(687, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Kocka1";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(690, 410);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Kocka3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(687, 355);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Kocka2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 710);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbkockadva);
            this.Controls.Add(this.tbkockatri);
            this.Controls.Add(this.tbkockaeden);
            this.Controls.Add(this.panel1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button summon;
        private System.Windows.Forms.Button endturn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox player1zivoti;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox player2zivoti;
        private TextBox tbkockaeden;
        private TextBox tbkockatri;
        private TextBox tbkockadva;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label1;
    }
}

