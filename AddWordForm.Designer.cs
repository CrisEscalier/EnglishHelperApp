namespace EnglishHelperApp
{
    partial class AddWordForm
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
            this.AddWordLabel = new System.Windows.Forms.Label();
            this.PronunciationTextBox = new System.Windows.Forms.TextBox();
            this.DefinitionTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.TrueWeakRadioButton = new System.Windows.Forms.RadioButton();
            this.FalseWeakRadioButton = new System.Windows.Forms.RadioButton();
            this.PronunciationLabel = new System.Windows.Forms.Label();
            this.DefinitionLabel = new System.Windows.Forms.Label();
            this.WordTypeLabel = new System.Windows.Forms.Label();
            this.WeakFormLabel = new System.Windows.Forms.Label();
            this.TagWordLabel = new System.Windows.Forms.Label();
            this.CountableLabel = new System.Windows.Forms.Label();
            this.TrueCountableRadioButton = new System.Windows.Forms.RadioButton();
            this.FalseCountableRadioButton = new System.Windows.Forms.RadioButton();
            this.TagNameTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWordLabel
            // 
            this.AddWordLabel.AutoSize = true;
            this.AddWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWordLabel.Location = new System.Drawing.Point(164, 9);
            this.AddWordLabel.Name = "AddWordLabel";
            this.AddWordLabel.Size = new System.Drawing.Size(176, 24);
            this.AddWordLabel.TabIndex = 0;
            this.AddWordLabel.Text = "New Word Interface";
            // 
            // PronunciationTextBox
            // 
            this.PronunciationTextBox.Location = new System.Drawing.Point(189, 87);
            this.PronunciationTextBox.Name = "PronunciationTextBox";
            this.PronunciationTextBox.Size = new System.Drawing.Size(220, 20);
            this.PronunciationTextBox.TabIndex = 1;
            // 
            // DefinitionTextBox
            // 
            this.DefinitionTextBox.Location = new System.Drawing.Point(189, 113);
            this.DefinitionTextBox.Name = "DefinitionTextBox";
            this.DefinitionTextBox.Size = new System.Drawing.Size(220, 20);
            this.DefinitionTextBox.TabIndex = 2;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(189, 139);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(220, 20);
            this.TypeTextBox.TabIndex = 3;
            // 
            // TrueWeakRadioButton
            // 
            this.TrueWeakRadioButton.AutoSize = true;
            this.TrueWeakRadioButton.Location = new System.Drawing.Point(189, 167);
            this.TrueWeakRadioButton.Name = "TrueWeakRadioButton";
            this.TrueWeakRadioButton.Size = new System.Drawing.Size(43, 17);
            this.TrueWeakRadioButton.TabIndex = 4;
            this.TrueWeakRadioButton.Text = "Yes";
            this.TrueWeakRadioButton.UseVisualStyleBackColor = true;
            this.TrueWeakRadioButton.CheckedChanged += new System.EventHandler(this.TrueWeakRadioButton_CheckedChanged);
            // 
            // FalseWeakRadioButton
            // 
            this.FalseWeakRadioButton.AutoSize = true;
            this.FalseWeakRadioButton.Location = new System.Drawing.Point(238, 167);
            this.FalseWeakRadioButton.Name = "FalseWeakRadioButton";
            this.FalseWeakRadioButton.Size = new System.Drawing.Size(39, 17);
            this.FalseWeakRadioButton.TabIndex = 5;
            this.FalseWeakRadioButton.Text = "No";
            this.FalseWeakRadioButton.UseVisualStyleBackColor = true;
            this.FalseWeakRadioButton.CheckedChanged += new System.EventHandler(this.FalseWeakRadioButton_CheckedChanged);
            // 
            // PronunciationLabel
            // 
            this.PronunciationLabel.AutoSize = true;
            this.PronunciationLabel.Location = new System.Drawing.Point(111, 94);
            this.PronunciationLabel.Name = "PronunciationLabel";
            this.PronunciationLabel.Size = new System.Drawing.Size(75, 13);
            this.PronunciationLabel.TabIndex = 6;
            this.PronunciationLabel.Text = "Pronunciation:";
            // 
            // DefinitionLabel
            // 
            this.DefinitionLabel.AutoSize = true;
            this.DefinitionLabel.Location = new System.Drawing.Point(111, 120);
            this.DefinitionLabel.Name = "DefinitionLabel";
            this.DefinitionLabel.Size = new System.Drawing.Size(54, 13);
            this.DefinitionLabel.TabIndex = 7;
            this.DefinitionLabel.Text = "Definition:";
            // 
            // WordTypeLabel
            // 
            this.WordTypeLabel.AutoSize = true;
            this.WordTypeLabel.Location = new System.Drawing.Point(111, 142);
            this.WordTypeLabel.Name = "WordTypeLabel";
            this.WordTypeLabel.Size = new System.Drawing.Size(63, 13);
            this.WordTypeLabel.TabIndex = 8;
            this.WordTypeLabel.Text = "Word Type:";
            // 
            // WeakFormLabel
            // 
            this.WeakFormLabel.AutoSize = true;
            this.WeakFormLabel.Location = new System.Drawing.Point(111, 169);
            this.WeakFormLabel.Name = "WeakFormLabel";
            this.WeakFormLabel.Size = new System.Drawing.Size(62, 13);
            this.WeakFormLabel.TabIndex = 9;
            this.WeakFormLabel.Text = "Weak form:";
            // 
            // TagWordLabel
            // 
            this.TagWordLabel.AutoSize = true;
            this.TagWordLabel.Location = new System.Drawing.Point(111, 64);
            this.TagWordLabel.Name = "TagWordLabel";
            this.TagWordLabel.Size = new System.Drawing.Size(65, 13);
            this.TagWordLabel.TabIndex = 10;
            this.TagWordLabel.Text = "Word name:";
            // 
            // CountableLabel
            // 
            this.CountableLabel.AutoSize = true;
            this.CountableLabel.Location = new System.Drawing.Point(111, 194);
            this.CountableLabel.Name = "CountableLabel";
            this.CountableLabel.Size = new System.Drawing.Size(58, 13);
            this.CountableLabel.TabIndex = 11;
            this.CountableLabel.Text = "Countable:";
            // 
            // TrueCountableRadioButton
            // 
            this.TrueCountableRadioButton.AutoSize = true;
            this.TrueCountableRadioButton.Location = new System.Drawing.Point(189, 194);
            this.TrueCountableRadioButton.Name = "TrueCountableRadioButton";
            this.TrueCountableRadioButton.Size = new System.Drawing.Size(43, 17);
            this.TrueCountableRadioButton.TabIndex = 12;
            this.TrueCountableRadioButton.Text = "Yes";
            this.TrueCountableRadioButton.UseVisualStyleBackColor = true;
            this.TrueCountableRadioButton.CheckedChanged += new System.EventHandler(this.TrueCountableRadioButton_CheckedChanged);
            // 
            // FalseCountableRadioButton
            // 
            this.FalseCountableRadioButton.AutoSize = true;
            this.FalseCountableRadioButton.Location = new System.Drawing.Point(238, 194);
            this.FalseCountableRadioButton.Name = "FalseCountableRadioButton";
            this.FalseCountableRadioButton.Size = new System.Drawing.Size(39, 17);
            this.FalseCountableRadioButton.TabIndex = 13;
            this.FalseCountableRadioButton.Text = "No";
            this.FalseCountableRadioButton.UseVisualStyleBackColor = true;
            this.FalseCountableRadioButton.CheckedChanged += new System.EventHandler(this.FalseCountableRadioButton_CheckedChanged);
            // 
            // TagNameTextBox
            // 
            this.TagNameTextBox.Location = new System.Drawing.Point(189, 61);
            this.TagNameTextBox.Name = "TagNameTextBox";
            this.TagNameTextBox.Size = new System.Drawing.Size(220, 20);
            this.TagNameTextBox.TabIndex = 14;
            // 
            // AddButton
            // 
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Location = new System.Drawing.Point(189, 304);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(151, 55);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add Word";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(507, 440);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TagNameTextBox);
            this.Controls.Add(this.FalseCountableRadioButton);
            this.Controls.Add(this.TrueCountableRadioButton);
            this.Controls.Add(this.CountableLabel);
            this.Controls.Add(this.TagWordLabel);
            this.Controls.Add(this.WeakFormLabel);
            this.Controls.Add(this.WordTypeLabel);
            this.Controls.Add(this.DefinitionLabel);
            this.Controls.Add(this.PronunciationLabel);
            this.Controls.Add(this.FalseWeakRadioButton);
            this.Controls.Add(this.TrueWeakRadioButton);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.DefinitionTextBox);
            this.Controls.Add(this.PronunciationTextBox);
            this.Controls.Add(this.AddWordLabel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "AddWordForm";
            this.Text = "AddWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddWordLabel;
        private System.Windows.Forms.TextBox PronunciationTextBox;
        private System.Windows.Forms.TextBox DefinitionTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.RadioButton TrueWeakRadioButton;
        private System.Windows.Forms.RadioButton FalseWeakRadioButton;
        private System.Windows.Forms.Label PronunciationLabel;
        private System.Windows.Forms.Label DefinitionLabel;
        private System.Windows.Forms.Label WordTypeLabel;
        private System.Windows.Forms.Label WeakFormLabel;
        private System.Windows.Forms.Label TagWordLabel;
        private System.Windows.Forms.Label CountableLabel;
        private System.Windows.Forms.RadioButton TrueCountableRadioButton;
        private System.Windows.Forms.RadioButton FalseCountableRadioButton;
        private System.Windows.Forms.TextBox TagNameTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}