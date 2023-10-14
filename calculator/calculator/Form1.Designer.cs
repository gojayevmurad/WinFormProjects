namespace calculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.previewLbl = new System.Windows.Forms.Label();
            this.mainDisplayLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.operatorResult = new System.Windows.Forms.Label();
            this.operatorDot = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Label();
            this.togglePositive = new System.Windows.Forms.Label();
            this.operatorPlus = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Label();
            this.operatorDivide = new System.Windows.Forms.Label();
            this.btn6 = new System.Windows.Forms.Label();
            this.btn5 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Label();
            this.operatorX = new System.Windows.Forms.Label();
            this.btn9 = new System.Windows.Forms.Label();
            this.btn8 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Label();
            this.operatorMinus = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Label();
            this.btnCE = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.previewLbl);
            this.panel1.Controls.Add(this.mainDisplayLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 73);
            this.panel1.TabIndex = 1;
            // 
            // previewLbl
            // 
            this.previewLbl.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewLbl.Location = new System.Drawing.Point(47, 9);
            this.previewLbl.Name = "previewLbl";
            this.previewLbl.Size = new System.Drawing.Size(364, 23);
            this.previewLbl.TabIndex = 3;
            this.previewLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mainDisplayLabel
            // 
            this.mainDisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDisplayLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainDisplayLabel.Location = new System.Drawing.Point(23, 36);
            this.mainDisplayLabel.Name = "mainDisplayLabel";
            this.mainDisplayLabel.Size = new System.Drawing.Size(388, 37);
            this.mainDisplayLabel.TabIndex = 2;
            this.mainDisplayLabel.Text = "0";
            this.mainDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.operatorResult, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.operatorDot, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.togglePositive, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.operatorPlus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.operatorDivide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.operatorX, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.operatorMinus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnC, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCE, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMod, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 333);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // operatorResult
            // 
            this.operatorResult.AutoSize = true;
            this.operatorResult.BackColor = System.Drawing.Color.Black;
            this.operatorResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorResult.ForeColor = System.Drawing.Color.White;
            this.operatorResult.Location = new System.Drawing.Point(309, 264);
            this.operatorResult.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.operatorResult.Name = "operatorResult";
            this.operatorResult.Size = new System.Drawing.Size(104, 68);
            this.operatorResult.TabIndex = 26;
            this.operatorResult.Text = "=";
            this.operatorResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operatorResult.Click += new System.EventHandler(this.operatorResult_Click);
            // 
            // operatorDot
            // 
            this.operatorDot.AutoSize = true;
            this.operatorDot.BackColor = System.Drawing.Color.Gray;
            this.operatorDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorDot.ForeColor = System.Drawing.Color.White;
            this.operatorDot.Location = new System.Drawing.Point(206, 264);
            this.operatorDot.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.operatorDot.Name = "operatorDot";
            this.operatorDot.Size = new System.Drawing.Size(102, 68);
            this.operatorDot.TabIndex = 25;
            this.operatorDot.Text = ".";
            this.operatorDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(103, 264);
            this.btn0.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(102, 68);
            this.btn0.TabIndex = 24;
            this.btn0.Text = "0";
            this.btn0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn0.Click += new System.EventHandler(this.NumClicked);
            // 
            // togglePositive
            // 
            this.togglePositive.AutoSize = true;
            this.togglePositive.BackColor = System.Drawing.Color.Gray;
            this.togglePositive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.togglePositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.togglePositive.ForeColor = System.Drawing.Color.White;
            this.togglePositive.Location = new System.Drawing.Point(0, 264);
            this.togglePositive.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.togglePositive.Name = "togglePositive";
            this.togglePositive.Size = new System.Drawing.Size(102, 68);
            this.togglePositive.TabIndex = 23;
            this.togglePositive.Text = "+/-";
            this.togglePositive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.togglePositive.Click += new System.EventHandler(this.togglePositive_Click);
            // 
            // operatorPlus
            // 
            this.operatorPlus.AutoSize = true;
            this.operatorPlus.BackColor = System.Drawing.Color.Black;
            this.operatorPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorPlus.ForeColor = System.Drawing.Color.White;
            this.operatorPlus.Location = new System.Drawing.Point(309, 198);
            this.operatorPlus.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.operatorPlus.Name = "operatorPlus";
            this.operatorPlus.Size = new System.Drawing.Size(104, 65);
            this.operatorPlus.TabIndex = 21;
            this.operatorPlus.Text = "+";
            this.operatorPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operatorPlus.Click += new System.EventHandler(this.OperatorsClicked);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(206, 198);
            this.btn3.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(102, 65);
            this.btn3.TabIndex = 20;
            this.btn3.Text = "3";
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn3.Click += new System.EventHandler(this.NumClicked);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(103, 198);
            this.btn2.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(102, 65);
            this.btn2.TabIndex = 19;
            this.btn2.Text = "2";
            this.btn2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn2.Click += new System.EventHandler(this.NumClicked);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(0, 198);
            this.btn1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(102, 65);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "1";
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.Click += new System.EventHandler(this.NumClicked);
            // 
            // operatorDivide
            // 
            this.operatorDivide.AutoSize = true;
            this.operatorDivide.BackColor = System.Drawing.Color.Black;
            this.operatorDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorDivide.ForeColor = System.Drawing.Color.White;
            this.operatorDivide.Location = new System.Drawing.Point(309, 132);
            this.operatorDivide.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.operatorDivide.Name = "operatorDivide";
            this.operatorDivide.Size = new System.Drawing.Size(104, 65);
            this.operatorDivide.TabIndex = 16;
            this.operatorDivide.Text = "/";
            this.operatorDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operatorDivide.Click += new System.EventHandler(this.OperatorsClicked);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(206, 132);
            this.btn6.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(102, 65);
            this.btn6.TabIndex = 15;
            this.btn6.Text = "6";
            this.btn6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn6.Click += new System.EventHandler(this.NumClicked);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(103, 132);
            this.btn5.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(102, 65);
            this.btn5.TabIndex = 14;
            this.btn5.Text = "5";
            this.btn5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn5.Click += new System.EventHandler(this.NumClicked);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(0, 132);
            this.btn4.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(102, 65);
            this.btn4.TabIndex = 13;
            this.btn4.Text = "4";
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn4.Click += new System.EventHandler(this.NumClicked);
            // 
            // operatorX
            // 
            this.operatorX.AutoSize = true;
            this.operatorX.BackColor = System.Drawing.Color.Black;
            this.operatorX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorX.ForeColor = System.Drawing.Color.White;
            this.operatorX.Location = new System.Drawing.Point(309, 66);
            this.operatorX.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.operatorX.Name = "operatorX";
            this.operatorX.Size = new System.Drawing.Size(104, 65);
            this.operatorX.TabIndex = 11;
            this.operatorX.Text = "*";
            this.operatorX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operatorX.Click += new System.EventHandler(this.OperatorsClicked);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(206, 66);
            this.btn9.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(102, 65);
            this.btn9.TabIndex = 10;
            this.btn9.Text = "9";
            this.btn9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn9.Click += new System.EventHandler(this.NumClicked);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(103, 66);
            this.btn8.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(102, 65);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn8.Click += new System.EventHandler(this.NumClicked);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(0, 66);
            this.btn7.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(102, 65);
            this.btn7.TabIndex = 8;
            this.btn7.Text = "7";
            this.btn7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn7.Click += new System.EventHandler(this.NumClicked);
            // 
            // operatorMinus
            // 
            this.operatorMinus.AutoSize = true;
            this.operatorMinus.BackColor = System.Drawing.Color.Black;
            this.operatorMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorMinus.ForeColor = System.Drawing.Color.White;
            this.operatorMinus.Location = new System.Drawing.Point(309, 0);
            this.operatorMinus.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.operatorMinus.Name = "operatorMinus";
            this.operatorMinus.Size = new System.Drawing.Size(104, 65);
            this.operatorMinus.TabIndex = 6;
            this.operatorMinus.Text = "-";
            this.operatorMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.operatorMinus.Click += new System.EventHandler(this.OperatorsClicked);
            // 
            // btnC
            // 
            this.btnC.AutoSize = true;
            this.btnC.BackColor = System.Drawing.Color.Black;
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.IndianRed;
            this.btnC.Location = new System.Drawing.Point(206, 0);
            this.btnC.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(102, 65);
            this.btnC.TabIndex = 5;
            this.btnC.Text = " C";
            this.btnC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.AutoSize = true;
            this.btnCE.BackColor = System.Drawing.Color.Black;
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCE.Location = new System.Drawing.Point(103, 0);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(102, 65);
            this.btnCE.TabIndex = 4;
            this.btnCE.Text = "CE";
            this.btnCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnMod
            // 
            this.btnMod.AutoSize = true;
            this.btnMod.BackColor = System.Drawing.Color.Gray;
            this.btnMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Location = new System.Drawing.Point(0, 0);
            this.btnMod.Margin = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(102, 65);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "%";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMod.Click += new System.EventHandler(this.OperatorsClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label mainDisplayLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label btnMod;
        private System.Windows.Forms.Label operatorResult;
        private System.Windows.Forms.Label operatorDot;
        private System.Windows.Forms.Label btn0;
        private System.Windows.Forms.Label togglePositive;
        private System.Windows.Forms.Label operatorPlus;
        private System.Windows.Forms.Label btn3;
        private System.Windows.Forms.Label btn2;
        private System.Windows.Forms.Label btn1;
        private System.Windows.Forms.Label operatorDivide;
        private System.Windows.Forms.Label btn6;
        private System.Windows.Forms.Label btn5;
        private System.Windows.Forms.Label btn4;
        private System.Windows.Forms.Label operatorX;
        private System.Windows.Forms.Label btn9;
        private System.Windows.Forms.Label btn8;
        private System.Windows.Forms.Label btn7;
        private System.Windows.Forms.Label operatorMinus;
        private System.Windows.Forms.Label btnC;
        private System.Windows.Forms.Label btnCE;
        private System.Windows.Forms.Label previewLbl;
    }
}

