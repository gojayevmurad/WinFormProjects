namespace changeBack_Time
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
            this.titleCity = new System.Windows.Forms.Label();
            this.bakuBtn = new System.Windows.Forms.Button();
            this.londonBtn = new System.Windows.Forms.Button();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleCity
            // 
            this.titleCity.AutoSize = true;
            this.titleCity.Font = new System.Drawing.Font("Algerian", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleCity.ForeColor = System.Drawing.Color.DarkBlue;
            this.titleCity.Location = new System.Drawing.Point(323, 45);
            this.titleCity.Name = "titleCity";
            this.titleCity.Size = new System.Drawing.Size(167, 59);
            this.titleCity.TabIndex = 0;
            this.titleCity.Text = "Baku";
            // 
            // bakuBtn
            // 
            this.bakuBtn.BackColor = System.Drawing.Color.Transparent;
            this.bakuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bakuBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bakuBtn.Location = new System.Drawing.Point(12, 388);
            this.bakuBtn.MaximumSize = new System.Drawing.Size(100, 50);
            this.bakuBtn.MinimumSize = new System.Drawing.Size(100, 50);
            this.bakuBtn.Name = "bakuBtn";
            this.bakuBtn.Padding = new System.Windows.Forms.Padding(10);
            this.bakuBtn.Size = new System.Drawing.Size(100, 50);
            this.bakuBtn.TabIndex = 1;
            this.bakuBtn.Text = "Baku";
            this.bakuBtn.UseVisualStyleBackColor = false;
            this.bakuBtn.Click += new System.EventHandler(this.bakuBtn_Click);
            // 
            // londonBtn
            // 
            this.londonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.londonBtn.Location = new System.Drawing.Point(118, 389);
            this.londonBtn.MaximumSize = new System.Drawing.Size(100, 50);
            this.londonBtn.MinimumSize = new System.Drawing.Size(100, 50);
            this.londonBtn.Name = "londonBtn";
            this.londonBtn.Size = new System.Drawing.Size(100, 50);
            this.londonBtn.TabIndex = 2;
            this.londonBtn.Text = "London";
            this.londonBtn.UseVisualStyleBackColor = true;
            this.londonBtn.Click += new System.EventHandler(this.londonBtn_Click);
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLabel.Location = new System.Drawing.Point(109, 114);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(148, 52);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::changeBack_Time.Properties.Resources.bak;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.londonBtn);
            this.Controls.Add(this.bakuBtn);
            this.Controls.Add(this.titleCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleCity;
        private System.Windows.Forms.Button bakuBtn;
        private System.Windows.Forms.Button londonBtn;
        private System.Windows.Forms.Label dateTimeLabel;
    }
}

