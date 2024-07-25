namespace WFA24072501
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grb01 = new GroupBox();
            tlp01 = new TableLayoutPanel();
            btnRogzit = new Button();
            rdbTul = new RadioButton();
            rdbVez = new RadioButton();
            rdbAlk = new RadioButton();
            nudFizu = new NumericUpDown();
            chbJogsi = new CheckBox();
            dtpSzulDat = new DateTimePicker();
            tbxNev = new TextBox();
            lbl05 = new Label();
            lbl06 = new Label();
            lbl04 = new Label();
            lbl03 = new Label();
            lbl02 = new Label();
            lbl01 = new Label();
            rtbNyersAdatok = new RichTextBox();
            lbl07 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl08 = new Label();
            lblAtlagFizu = new Label();
            grb01.SuspendLayout();
            tlp01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudFizu).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // grb01
            // 
            grb01.Controls.Add(tlp01);
            grb01.Controls.Add(rdbTul);
            grb01.Controls.Add(rdbVez);
            grb01.Controls.Add(rdbAlk);
            grb01.Controls.Add(nudFizu);
            grb01.Controls.Add(chbJogsi);
            grb01.Controls.Add(dtpSzulDat);
            grb01.Controls.Add(tbxNev);
            grb01.Controls.Add(lbl05);
            grb01.Controls.Add(lbl06);
            grb01.Controls.Add(lbl04);
            grb01.Controls.Add(lbl03);
            grb01.Controls.Add(lbl02);
            grb01.Controls.Add(lbl01);
            grb01.Location = new Point(12, 12);
            grb01.Name = "grb01";
            grb01.Size = new Size(586, 473);
            grb01.TabIndex = 0;
            grb01.TabStop = false;
            grb01.Text = "adatok";
            // 
            // tlp01
            // 
            tlp01.ColumnCount = 3;
            tlp01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp01.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp01.Controls.Add(btnRogzit, 1, 0);
            tlp01.Location = new Point(11, 389);
            tlp01.Name = "tlp01";
            tlp01.RowCount = 1;
            tlp01.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp01.Size = new Size(569, 64);
            tlp01.TabIndex = 7;
            // 
            // btnRogzit
            // 
            btnRogzit.Enabled = false;
            btnRogzit.Font = new Font("Segoe UI", 14F);
            btnRogzit.Location = new Point(116, 3);
            btnRogzit.Name = "btnRogzit";
            btnRogzit.Size = new Size(335, 58);
            btnRogzit.TabIndex = 6;
            btnRogzit.Text = "adatok rögzítése";
            btnRogzit.UseVisualStyleBackColor = true;
            // 
            // rdbTul
            // 
            rdbTul.AutoSize = true;
            rdbTul.Location = new Point(434, 316);
            rdbTul.Name = "rdbTul";
            rdbTul.Size = new Size(126, 32);
            rdbTul.TabIndex = 5;
            rdbTul.Text = "tulajdonos";
            rdbTul.UseVisualStyleBackColor = true;
            // 
            // rdbVez
            // 
            rdbVez.AutoSize = true;
            rdbVez.Location = new Point(337, 316);
            rdbVez.Name = "rdbVez";
            rdbVez.Size = new Size(91, 32);
            rdbVez.TabIndex = 5;
            rdbVez.Text = "vezető";
            rdbVez.UseVisualStyleBackColor = true;
            // 
            // rdbAlk
            // 
            rdbAlk.AutoSize = true;
            rdbAlk.Checked = true;
            rdbAlk.Location = new Point(196, 316);
            rdbAlk.Name = "rdbAlk";
            rdbAlk.Size = new Size(135, 32);
            rdbAlk.TabIndex = 5;
            rdbAlk.TabStop = true;
            rdbAlk.Text = "alkalmazott";
            rdbAlk.UseVisualStyleBackColor = true;
            // 
            // nudFizu
            // 
            nudFizu.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudFizu.Location = new Point(196, 250);
            nudFizu.Maximum = new decimal(new int[] { 3000000, 0, 0, 0 });
            nudFizu.Minimum = new decimal(new int[] { 342000, 0, 0, 0 });
            nudFizu.Name = "nudFizu";
            nudFizu.Size = new Size(119, 34);
            nudFizu.TabIndex = 4;
            nudFizu.TextAlign = HorizontalAlignment.Right;
            nudFizu.Value = new decimal(new int[] { 342000, 0, 0, 0 });
            // 
            // chbJogsi
            // 
            chbJogsi.AutoSize = true;
            chbJogsi.Location = new Point(196, 185);
            chbJogsi.Name = "chbJogsi";
            chbJogsi.Size = new Size(65, 32);
            chbJogsi.TabIndex = 3;
            chbJogsi.Text = "van";
            chbJogsi.UseVisualStyleBackColor = true;
            // 
            // dtpSzulDat
            // 
            dtpSzulDat.Format = DateTimePickerFormat.Short;
            dtpSzulDat.Location = new Point(196, 115);
            dtpSzulDat.MaxDate = new DateTime(2024, 7, 25, 0, 0, 0, 0);
            dtpSzulDat.Name = "dtpSzulDat";
            dtpSzulDat.Size = new Size(166, 34);
            dtpSzulDat.TabIndex = 2;
            dtpSzulDat.Value = new DateTime(2024, 7, 25, 0, 0, 0, 0);
            // 
            // tbxNev
            // 
            tbxNev.Location = new Point(196, 51);
            tbxNev.Name = "tbxNev";
            tbxNev.Size = new Size(266, 34);
            tbxNev.TabIndex = 1;
            // 
            // lbl05
            // 
            lbl05.AutoSize = true;
            lbl05.Location = new Point(81, 318);
            lbl05.Name = "lbl05";
            lbl05.Size = new Size(76, 28);
            lbl05.TabIndex = 0;
            lbl05.Text = "státusz:";
            // 
            // lbl06
            // 
            lbl06.AutoSize = true;
            lbl06.Location = new Point(321, 252);
            lbl06.Name = "lbl06";
            lbl06.Size = new Size(50, 28);
            lbl06.TabIndex = 0;
            lbl06.Text = "HUF";
            // 
            // lbl04
            // 
            lbl04.AutoSize = true;
            lbl04.Location = new Point(86, 252);
            lbl04.Name = "lbl04";
            lbl04.Size = new Size(71, 28);
            lbl04.TabIndex = 0;
            lbl04.Text = "fizetés:";
            // 
            // lbl03
            // 
            lbl03.AutoSize = true;
            lbl03.Location = new Point(39, 186);
            lbl03.Name = "lbl03";
            lbl03.Size = new Size(118, 28);
            lbl03.TabIndex = 0;
            lbl03.Text = "jogosítvány:";
            // 
            // lbl02
            // 
            lbl02.AutoSize = true;
            lbl02.Location = new Point(6, 120);
            lbl02.Name = "lbl02";
            lbl02.Size = new Size(151, 28);
            lbl02.TabIndex = 0;
            lbl02.Text = "születési dátum:";
            // 
            // lbl01
            // 
            lbl01.AutoSize = true;
            lbl01.Location = new Point(110, 54);
            lbl01.Name = "lbl01";
            lbl01.Size = new Size(47, 28);
            lbl01.TabIndex = 0;
            lbl01.Text = "név:";
            // 
            // rtbNyersAdatok
            // 
            rtbNyersAdatok.Enabled = false;
            rtbNyersAdatok.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            rtbNyersAdatok.Location = new Point(604, 43);
            rtbNyersAdatok.Name = "rtbNyersAdatok";
            rtbNyersAdatok.Size = new Size(422, 380);
            rtbNyersAdatok.TabIndex = 1;
            rtbNyersAdatok.Text = "";
            // 
            // lbl07
            // 
            lbl07.AutoSize = true;
            lbl07.Location = new Point(604, 12);
            lbl07.Name = "lbl07";
            lbl07.Size = new Size(158, 28);
            lbl07.TabIndex = 0;
            lbl07.Text = "rögzített adatok:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(lbl08, 0, 0);
            tableLayoutPanel1.Controls.Add(lblAtlagFizu, 1, 0);
            tableLayoutPanel1.Location = new Point(604, 429);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(422, 56);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl08
            // 
            lbl08.Location = new Point(3, 0);
            lbl08.Name = "lbl08";
            lbl08.Size = new Size(205, 56);
            lbl08.TabIndex = 0;
            lbl08.Text = "ÁTLAGFIZETÉS:";
            lbl08.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAtlagFizu
            // 
            lblAtlagFizu.Location = new Point(214, 0);
            lblAtlagFizu.Name = "lblAtlagFizu";
            lblAtlagFizu.Size = new Size(205, 56);
            lblAtlagFizu.TabIndex = 1;
            lblAtlagFizu.Text = "### ### HUF";
            lblAtlagFizu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 497);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(rtbNyersAdatok);
            Controls.Add(grb01);
            Controls.Add(lbl07);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FrmMain";
            Text = "adatrögzítő form";
            grb01.ResumeLayout(false);
            grb01.PerformLayout();
            tlp01.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudFizu).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grb01;
        private DateTimePicker dtpSzulDat;
        private TextBox tbxNev;
        private Label lbl04;
        private Label lbl03;
        private Label lbl02;
        private Label lbl01;
        private CheckBox chbJogsi;
        private Label lbl05;
        private NumericUpDown nudFizu;
        private RadioButton rdbTul;
        private RadioButton rdbVez;
        private RadioButton rdbAlk;
        private Label lbl06;
        private TableLayoutPanel tlp01;
        private Button btnRogzit;
        private RichTextBox rtbNyersAdatok;
        private Label lbl07;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl08;
        private Label lblAtlagFizu;
    }
}
