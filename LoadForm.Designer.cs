namespace EnglishHelperApp
{
    partial class LoadForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.Initial_Label = new System.Windows.Forms.Label();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.loadTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Initial_Label
            // 
            this.Initial_Label.AutoSize = true;
            this.Initial_Label.BackColor = System.Drawing.Color.Transparent;
            this.Initial_Label.Font = new System.Drawing.Font("Lucida Handwriting", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Initial_Label.Location = new System.Drawing.Point(138, 325);
            this.Initial_Label.Name = "Initial_Label";
            this.Initial_Label.Size = new System.Drawing.Size(720, 83);
            this.Initial_Label.TabIndex = 9;
            this.Initial_Label.Text = "Enlgish Helper App";
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 10;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // loadTimer
            // 
            this.loadTimer.Interval = 4500;
            this.loadTimer.Tick += new System.EventHandler(this.loadTimer_Tick);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Initial_Label);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Helper App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Initial_Label;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer loadTimer;
    }
}