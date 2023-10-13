namespace UnclickableButton
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
            this.hoverBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hoverBtn
            // 
            this.hoverBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hoverBtn.Location = new System.Drawing.Point(45, 51);
            this.hoverBtn.Name = "hoverBtn";
            this.hoverBtn.Size = new System.Drawing.Size(103, 37);
            this.hoverBtn.TabIndex = 1;
            this.hoverBtn.Text = "Hover me";
            this.hoverBtn.UseVisualStyleBackColor = false;
            this.hoverBtn.MouseEnter += new System.EventHandler(this.hoverBtn_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.hoverBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hoverBtn;
    }
}

