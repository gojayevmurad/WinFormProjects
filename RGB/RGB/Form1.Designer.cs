namespace RGB
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.blueValue = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.none = new System.Windows.Forms.Label();
            this.greenValue = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.redValue = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.blueValue);
            this.panel4.Controls.Add(this.trackBarBlue);
            this.panel4.Location = new System.Drawing.Point(574, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 286);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Blue";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blueValue
            // 
            this.blueValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.blueValue.BackColor = System.Drawing.Color.White;
            this.blueValue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueValue.Location = new System.Drawing.Point(3, 9);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(155, 41);
            this.blueValue.TabIndex = 1;
            this.blueValue.Text = "0";
            this.blueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(55, 53);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarBlue.Size = new System.Drawing.Size(45, 186);
            this.trackBarBlue.TabIndex = 0;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.none);
            this.panel3.Controls.Add(this.greenValue);
            this.panel3.Controls.Add(this.trackBarGreen);
            this.panel3.Location = new System.Drawing.Point(340, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 286);
            this.panel3.TabIndex = 2;
            // 
            // none
            // 
            this.none.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.none.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.none.Location = new System.Drawing.Point(0, 260);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(161, 26);
            this.none.TabIndex = 2;
            this.none.Text = "Green";
            this.none.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenValue
            // 
            this.greenValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.greenValue.BackColor = System.Drawing.Color.White;
            this.greenValue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenValue.Location = new System.Drawing.Point(3, 9);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(155, 41);
            this.greenValue.TabIndex = 1;
            this.greenValue.Text = "0";
            this.greenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(55, 53);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarGreen.Size = new System.Drawing.Size(45, 186);
            this.trackBarGreen.TabIndex = 0;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.redValue);
            this.panel2.Controls.Add(this.trackBarRed);
            this.panel2.Location = new System.Drawing.Point(97, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 286);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Red";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redValue
            // 
            this.redValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.redValue.BackColor = System.Drawing.Color.White;
            this.redValue.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redValue.Location = new System.Drawing.Point(3, 9);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(155, 41);
            this.redValue.TabIndex = 1;
            this.redValue.Text = "0";
            this.redValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(55, 53);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRed.Size = new System.Drawing.Size(45, 186);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label redValue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label blueValue;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label none;
        private System.Windows.Forms.Label greenValue;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label label2;
    }
}

