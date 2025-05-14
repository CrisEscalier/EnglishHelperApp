using System.Windows.Forms;
using EnglishHelperApp.classes;

namespace EnglishHelperApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.slidePanel = new System.Windows.Forms.Panel();
            this.Phonetic_Label = new System.Windows.Forms.LinkLabel();
            this.Phonetic_button = new System.Windows.Forms.Button();
            this.App_Tittle_Label = new System.Windows.Forms.Label();
            this.Phonemes_button = new System.Windows.Forms.Button();
            this.Phonemes_Label = new System.Windows.Forms.LinkLabel();
            this.Dictionary_Label = new System.Windows.Forms.LinkLabel();
            this.Dictionary_button = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.DictionaryPanel = new System.Windows.Forms.Panel();
            this.PhoneticPanel = new System.Windows.Forms.Panel();
            this.PhonemePanel = new System.Windows.Forms.Panel();
            this.DiphthongPanel = new System.Windows.Forms.Panel();
            this.Diphthong8 = new System.Windows.Forms.Button();
            this.Diphthong7 = new System.Windows.Forms.Button();
            this.Diphthong6 = new System.Windows.Forms.Button();
            this.Diphthong5 = new System.Windows.Forms.Button();
            this.Diphtong4 = new System.Windows.Forms.Button();
            this.Diphthong3 = new System.Windows.Forms.Button();
            this.Diphthong2 = new System.Windows.Forms.Button();
            this.Diphthong1 = new System.Windows.Forms.Button();
            this.PhonemeDetails = new System.Windows.Forms.RichTextBox();
            this.PureVowelPanel = new System.Windows.Forms.Panel();
            this.BtnVowelNumber12 = new System.Windows.Forms.Button();
            this.BtnVowelNumber11 = new System.Windows.Forms.Button();
            this.BtnVowelNumber10 = new System.Windows.Forms.Button();
            this.BtnVowelNumber9 = new System.Windows.Forms.Button();
            this.BtnVowelNumber8 = new System.Windows.Forms.Button();
            this.BtnVowelNumber7 = new System.Windows.Forms.Button();
            this.BtnVowelNumber6 = new System.Windows.Forms.Button();
            this.BtnVowelNumber5 = new System.Windows.Forms.Button();
            this.BtnVowelNumber4 = new System.Windows.Forms.Button();
            this.BtnVowelNumber3 = new System.Windows.Forms.Button();
            this.BtnVowelNumber2 = new System.Windows.Forms.Button();
            this.BtnVowelNumber1 = new System.Windows.Forms.Button();
            this.simplePanelShowButton = new System.Windows.Forms.Panel();
            this.btn_show_consonant = new System.Windows.Forms.Button();
            this.btn_show_diphthong = new System.Windows.Forms.Button();
            this.btn_show_vowel = new System.Windows.Forms.Button();
            this.ConsonantPanel = new System.Windows.Forms.Panel();
            this.Consonant12 = new System.Windows.Forms.Button();
            this.Consonant11 = new System.Windows.Forms.Button();
            this.Consonant10 = new System.Windows.Forms.Button();
            this.Consonant9 = new System.Windows.Forms.Button();
            this.Consonant8 = new System.Windows.Forms.Button();
            this.Consonant7 = new System.Windows.Forms.Button();
            this.Consonant6 = new System.Windows.Forms.Button();
            this.Consonant5 = new System.Windows.Forms.Button();
            this.Consonant4 = new System.Windows.Forms.Button();
            this.Consonant3 = new System.Windows.Forms.Button();
            this.Consonant2 = new System.Windows.Forms.Button();
            this.Consonant1 = new System.Windows.Forms.Button();
            this.Consonant24 = new System.Windows.Forms.Button();
            this.Consonant23 = new System.Windows.Forms.Button();
            this.Consonant22 = new System.Windows.Forms.Button();
            this.Consonant21 = new System.Windows.Forms.Button();
            this.Consonant20 = new System.Windows.Forms.Button();
            this.Consonant19 = new System.Windows.Forms.Button();
            this.Consonant18 = new System.Windows.Forms.Button();
            this.Consonant17 = new System.Windows.Forms.Button();
            this.Consonant16 = new System.Windows.Forms.Button();
            this.Consonant15 = new System.Windows.Forms.Button();
            this.Consonant14 = new System.Windows.Forms.Button();
            this.Consonant13 = new System.Windows.Forms.Button();
            this.slidePanel.SuspendLayout();
            this.PhonemePanel.SuspendLayout();
            this.DiphthongPanel.SuspendLayout();
            this.PureVowelPanel.SuspendLayout();
            this.simplePanelShowButton.SuspendLayout();
            this.ConsonantPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.slidePanel.Controls.Add(this.Phonetic_Label);
            this.slidePanel.Controls.Add(this.Phonetic_button);
            this.slidePanel.Controls.Add(this.App_Tittle_Label);
            this.slidePanel.Controls.Add(this.Phonemes_button);
            this.slidePanel.Controls.Add(this.Phonemes_Label);
            this.slidePanel.Controls.Add(this.Dictionary_Label);
            this.slidePanel.Controls.Add(this.Dictionary_button);
            this.slidePanel.Controls.Add(this.btn_show);
            this.slidePanel.Controls.Add(this.btn_hide);
            this.slidePanel.Location = new System.Drawing.Point(-1, 0);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(280, 679);
            this.slidePanel.TabIndex = 1;
            // 
            // Phonetic_Label
            // 
            this.Phonetic_Label.AutoSize = true;
            this.Phonetic_Label.BackColor = System.Drawing.Color.Transparent;
            this.Phonetic_Label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetic_Label.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Phonetic_Label.LinkColor = System.Drawing.Color.White;
            this.Phonetic_Label.Location = new System.Drawing.Point(82, 266);
            this.Phonetic_Label.Name = "Phonetic_Label";
            this.Phonetic_Label.Size = new System.Drawing.Size(182, 21);
            this.Phonetic_Label.TabIndex = 11;
            this.Phonetic_Label.TabStop = true;
            this.Phonetic_Label.Text = "Phonetic Transcription";
            this.Phonetic_Label.VisitedLinkColor = System.Drawing.Color.White;
            this.Phonetic_Label.Click += new System.EventHandler(this.Phonetics_button_Click);
            // 
            // Phonetic_button
            // 
            this.Phonetic_button.BackColor = System.Drawing.Color.Transparent;
            this.Phonetic_button.BackgroundImage = global::EnglishHelperApp.Properties.Resources.phonetics_icon;
            this.Phonetic_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Phonetic_button.FlatAppearance.BorderSize = 0;
            this.Phonetic_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Phonetic_button.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonetic_button.ForeColor = System.Drawing.Color.Lavender;
            this.Phonetic_button.Location = new System.Drawing.Point(13, 253);
            this.Phonetic_button.Name = "Phonetic_button";
            this.Phonetic_button.Size = new System.Drawing.Size(50, 50);
            this.Phonetic_button.TabIndex = 10;
            this.Phonetic_button.UseVisualStyleBackColor = false;
            this.Phonetic_button.Click += new System.EventHandler(this.Phonetics_button_Click);
            // 
            // App_Tittle_Label
            // 
            this.App_Tittle_Label.AutoSize = true;
            this.App_Tittle_Label.BackColor = System.Drawing.Color.Transparent;
            this.App_Tittle_Label.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Tittle_Label.Location = new System.Drawing.Point(76, 48);
            this.App_Tittle_Label.Name = "App_Tittle_Label";
            this.App_Tittle_Label.Size = new System.Drawing.Size(179, 21);
            this.App_Tittle_Label.TabIndex = 8;
            this.App_Tittle_Label.Text = "Enlgish Helper App";
            // 
            // Phonemes_button
            // 
            this.Phonemes_button.BackColor = System.Drawing.Color.Transparent;
            this.Phonemes_button.BackgroundImage = global::EnglishHelperApp.Properties.Resources.phonemes_icon;
            this.Phonemes_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Phonemes_button.FlatAppearance.BorderSize = 0;
            this.Phonemes_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Phonemes_button.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonemes_button.ForeColor = System.Drawing.Color.Lavender;
            this.Phonemes_button.Location = new System.Drawing.Point(13, 175);
            this.Phonemes_button.Name = "Phonemes_button";
            this.Phonemes_button.Size = new System.Drawing.Size(50, 50);
            this.Phonemes_button.TabIndex = 7;
            this.Phonemes_button.UseVisualStyleBackColor = false;
            this.Phonemes_button.Click += new System.EventHandler(this.Phonemes_Button_Click);
            // 
            // Phonemes_Label
            // 
            this.Phonemes_Label.AutoSize = true;
            this.Phonemes_Label.BackColor = System.Drawing.Color.Transparent;
            this.Phonemes_Label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonemes_Label.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Phonemes_Label.LinkColor = System.Drawing.Color.White;
            this.Phonemes_Label.Location = new System.Drawing.Point(82, 188);
            this.Phonemes_Label.Name = "Phonemes_Label";
            this.Phonemes_Label.Size = new System.Drawing.Size(135, 21);
            this.Phonemes_Label.TabIndex = 6;
            this.Phonemes_Label.TabStop = true;
            this.Phonemes_Label.Text = "Phonemes Chart";
            this.Phonemes_Label.VisitedLinkColor = System.Drawing.Color.White;
            this.Phonemes_Label.Click += new System.EventHandler(this.Phonemes_Button_Click);
            // 
            // Dictionary_Label
            // 
            this.Dictionary_Label.AutoSize = true;
            this.Dictionary_Label.BackColor = System.Drawing.Color.Transparent;
            this.Dictionary_Label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dictionary_Label.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Dictionary_Label.LinkColor = System.Drawing.Color.White;
            this.Dictionary_Label.Location = new System.Drawing.Point(82, 109);
            this.Dictionary_Label.Name = "Dictionary_Label";
            this.Dictionary_Label.Size = new System.Drawing.Size(151, 21);
            this.Dictionary_Label.TabIndex = 5;
            this.Dictionary_Label.TabStop = true;
            this.Dictionary_Label.Text = "English Dictionary";
            this.Dictionary_Label.VisitedLinkColor = System.Drawing.Color.White;
            this.Dictionary_Label.Click += new System.EventHandler(this.Dictionary_button_Click);
            // 
            // Dictionary_button
            // 
            this.Dictionary_button.BackColor = System.Drawing.Color.Transparent;
            this.Dictionary_button.BackgroundImage = global::EnglishHelperApp.Properties.Resources.dic_icon;
            this.Dictionary_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dictionary_button.FlatAppearance.BorderSize = 0;
            this.Dictionary_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dictionary_button.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dictionary_button.ForeColor = System.Drawing.Color.Lavender;
            this.Dictionary_button.Location = new System.Drawing.Point(13, 96);
            this.Dictionary_button.Name = "Dictionary_button";
            this.Dictionary_button.Size = new System.Drawing.Size(50, 50);
            this.Dictionary_button.TabIndex = 4;
            this.Dictionary_button.UseVisualStyleBackColor = false;
            this.Dictionary_button.Click += new System.EventHandler(this.Dictionary_button_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.Blue;
            this.btn_show.Location = new System.Drawing.Point(13, 588);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(50, 50);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = ">>";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Visible = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(240)))), ((int)(((byte)(192)))));
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.Color.Red;
            this.btn_hide.Location = new System.Drawing.Point(217, 588);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(50, 50);
            this.btn_hide.TabIndex = 2;
            this.btn_hide.Text = "<<";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // DictionaryPanel
            // 
            this.DictionaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.DictionaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DictionaryPanel.Location = new System.Drawing.Point(0, 0);
            this.DictionaryPanel.Name = "DictionaryPanel";
            this.DictionaryPanel.Size = new System.Drawing.Size(1000, 650);
            this.DictionaryPanel.TabIndex = 2;
            // 
            // PhoneticPanel
            // 
            this.PhoneticPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PhoneticPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhoneticPanel.Location = new System.Drawing.Point(0, 0);
            this.PhoneticPanel.Name = "PhoneticPanel";
            this.PhoneticPanel.Size = new System.Drawing.Size(1000, 650);
            this.PhoneticPanel.TabIndex = 3;
            // 
            // PhonemePanel
            // 
            this.PhonemePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PhonemePanel.Controls.Add(this.DiphthongPanel);
            this.PhonemePanel.Controls.Add(this.ConsonantPanel);
            this.PhonemePanel.Controls.Add(this.PhonemeDetails);
            this.PhonemePanel.Controls.Add(this.PureVowelPanel);
            this.PhonemePanel.Controls.Add(this.simplePanelShowButton);
            this.PhonemePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhonemePanel.Location = new System.Drawing.Point(0, 0);
            this.PhonemePanel.Name = "PhonemePanel";
            this.PhonemePanel.Size = new System.Drawing.Size(1000, 650);
            this.PhonemePanel.TabIndex = 4;
            // 
            // DiphthongPanel
            // 
            this.DiphthongPanel.BackColor = System.Drawing.Color.Green;
            this.DiphthongPanel.Controls.Add(this.Diphthong8);
            this.DiphthongPanel.Controls.Add(this.Diphthong7);
            this.DiphthongPanel.Controls.Add(this.Diphthong6);
            this.DiphthongPanel.Controls.Add(this.Diphthong5);
            this.DiphthongPanel.Controls.Add(this.Diphtong4);
            this.DiphthongPanel.Controls.Add(this.Diphthong3);
            this.DiphthongPanel.Controls.Add(this.Diphthong2);
            this.DiphthongPanel.Controls.Add(this.Diphthong1);
            this.DiphthongPanel.Location = new System.Drawing.Point(297, 96);
            this.DiphthongPanel.Name = "DiphthongPanel";
            this.DiphthongPanel.Size = new System.Drawing.Size(317, 161);
            this.DiphthongPanel.TabIndex = 12;
            this.DiphthongPanel.Visible = false;
            // 
            // Diphthong8
            // 
            this.Diphthong8.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong8.FlatAppearance.BorderSize = 3;
            this.Diphthong8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong8.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong8.ForeColor = System.Drawing.Color.White;
            this.Diphthong8.Location = new System.Drawing.Point(239, 81);
            this.Diphthong8.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong8.Name = "Diphthong8";
            this.Diphthong8.Size = new System.Drawing.Size(75, 75);
            this.Diphthong8.TabIndex = 7;
            this.Diphthong8.UseVisualStyleBackColor = true;
            // 
            // Diphthong7
            // 
            this.Diphthong7.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong7.FlatAppearance.BorderSize = 3;
            this.Diphthong7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong7.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong7.ForeColor = System.Drawing.Color.White;
            this.Diphthong7.Location = new System.Drawing.Point(160, 81);
            this.Diphthong7.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong7.Name = "Diphthong7";
            this.Diphthong7.Size = new System.Drawing.Size(75, 75);
            this.Diphthong7.TabIndex = 6;
            this.Diphthong7.UseVisualStyleBackColor = true;
            // 
            // Diphthong6
            // 
            this.Diphthong6.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong6.FlatAppearance.BorderSize = 3;
            this.Diphthong6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong6.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong6.ForeColor = System.Drawing.Color.White;
            this.Diphthong6.Location = new System.Drawing.Point(81, 81);
            this.Diphthong6.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong6.Name = "Diphthong6";
            this.Diphthong6.Size = new System.Drawing.Size(75, 75);
            this.Diphthong6.TabIndex = 5;
            this.Diphthong6.UseVisualStyleBackColor = true;
            // 
            // Diphthong5
            // 
            this.Diphthong5.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong5.FlatAppearance.BorderSize = 3;
            this.Diphthong5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong5.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong5.ForeColor = System.Drawing.Color.White;
            this.Diphthong5.Location = new System.Drawing.Point(2, 81);
            this.Diphthong5.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong5.Name = "Diphthong5";
            this.Diphthong5.Size = new System.Drawing.Size(75, 75);
            this.Diphthong5.TabIndex = 4;
            this.Diphthong5.UseVisualStyleBackColor = true;
            // 
            // Diphtong4
            // 
            this.Diphtong4.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphtong4.FlatAppearance.BorderSize = 3;
            this.Diphtong4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphtong4.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphtong4.ForeColor = System.Drawing.Color.White;
            this.Diphtong4.Location = new System.Drawing.Point(239, 2);
            this.Diphtong4.Margin = new System.Windows.Forms.Padding(2);
            this.Diphtong4.Name = "Diphtong4";
            this.Diphtong4.Size = new System.Drawing.Size(75, 75);
            this.Diphtong4.TabIndex = 3;
            this.Diphtong4.UseVisualStyleBackColor = true;
            // 
            // Diphthong3
            // 
            this.Diphthong3.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong3.FlatAppearance.BorderSize = 3;
            this.Diphthong3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong3.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong3.ForeColor = System.Drawing.Color.White;
            this.Diphthong3.Location = new System.Drawing.Point(160, 2);
            this.Diphthong3.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong3.Name = "Diphthong3";
            this.Diphthong3.Size = new System.Drawing.Size(75, 75);
            this.Diphthong3.TabIndex = 2;
            this.Diphthong3.UseVisualStyleBackColor = true;
            // 
            // Diphthong2
            // 
            this.Diphthong2.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong2.FlatAppearance.BorderSize = 3;
            this.Diphthong2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong2.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong2.ForeColor = System.Drawing.Color.White;
            this.Diphthong2.Location = new System.Drawing.Point(81, 2);
            this.Diphthong2.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong2.Name = "Diphthong2";
            this.Diphthong2.Size = new System.Drawing.Size(75, 75);
            this.Diphthong2.TabIndex = 1;
            this.Diphthong2.UseVisualStyleBackColor = true;
            // 
            // Diphthong1
            // 
            this.Diphthong1.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Diphthong1.FlatAppearance.BorderSize = 3;
            this.Diphthong1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Diphthong1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diphthong1.ForeColor = System.Drawing.Color.White;
            this.Diphthong1.Location = new System.Drawing.Point(2, 2);
            this.Diphthong1.Margin = new System.Windows.Forms.Padding(2);
            this.Diphthong1.Name = "Diphthong1";
            this.Diphthong1.Size = new System.Drawing.Size(75, 75);
            this.Diphthong1.TabIndex = 0;
            this.Diphthong1.UseVisualStyleBackColor = true;
            // 
            // PhonemeDetails
            // 
            this.PhonemeDetails.BackColor = System.Drawing.Color.Green;
            this.PhonemeDetails.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.PhonemeDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhonemeDetails.ForeColor = System.Drawing.SystemColors.Window;
            this.PhonemeDetails.Location = new System.Drawing.Point(617, 96);
            this.PhonemeDetails.Name = "PhonemeDetails";
            this.PhonemeDetails.ReadOnly = true;
            this.PhonemeDetails.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PhonemeDetails.Size = new System.Drawing.Size(371, 475);
            this.PhonemeDetails.TabIndex = 4;
            this.PhonemeDetails.Text = "";
            this.PhonemeDetails.UseWaitCursor = true;
            this.PhonemeDetails.Visible = false;
            // 
            // PureVowelPanel
            // 
            this.PureVowelPanel.BackColor = System.Drawing.Color.Green;
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber12);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber11);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber10);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber9);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber8);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber7);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber6);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber5);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber4);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber3);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber2);
            this.PureVowelPanel.Controls.Add(this.BtnVowelNumber1);
            this.PureVowelPanel.Location = new System.Drawing.Point(297, 96);
            this.PureVowelPanel.Name = "PureVowelPanel";
            this.PureVowelPanel.Size = new System.Drawing.Size(317, 238);
            this.PureVowelPanel.TabIndex = 3;
            this.PureVowelPanel.Visible = false;
            // 
            // BtnVowelNumber12
            // 
            this.BtnVowelNumber12.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber12.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber12.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber12.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber12.Location = new System.Drawing.Point(239, 160);
            this.BtnVowelNumber12.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber12.Name = "BtnVowelNumber12";
            this.BtnVowelNumber12.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber12.TabIndex = 11;
            this.BtnVowelNumber12.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber11
            // 
            this.BtnVowelNumber11.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber11.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber11.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber11.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber11.Location = new System.Drawing.Point(160, 160);
            this.BtnVowelNumber11.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber11.Name = "BtnVowelNumber11";
            this.BtnVowelNumber11.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber11.TabIndex = 10;
            this.BtnVowelNumber11.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber10
            // 
            this.BtnVowelNumber10.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber10.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber10.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber10.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber10.Location = new System.Drawing.Point(81, 160);
            this.BtnVowelNumber10.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber10.Name = "BtnVowelNumber10";
            this.BtnVowelNumber10.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber10.TabIndex = 9;
            this.BtnVowelNumber10.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber9
            // 
            this.BtnVowelNumber9.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber9.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber9.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber9.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber9.Location = new System.Drawing.Point(2, 160);
            this.BtnVowelNumber9.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber9.Name = "BtnVowelNumber9";
            this.BtnVowelNumber9.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber9.TabIndex = 8;
            this.BtnVowelNumber9.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber8
            // 
            this.BtnVowelNumber8.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber8.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber8.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber8.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber8.Location = new System.Drawing.Point(239, 81);
            this.BtnVowelNumber8.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber8.Name = "BtnVowelNumber8";
            this.BtnVowelNumber8.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber8.TabIndex = 7;
            this.BtnVowelNumber8.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber7
            // 
            this.BtnVowelNumber7.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber7.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber7.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber7.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber7.Location = new System.Drawing.Point(160, 81);
            this.BtnVowelNumber7.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber7.Name = "BtnVowelNumber7";
            this.BtnVowelNumber7.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber7.TabIndex = 6;
            this.BtnVowelNumber7.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber6
            // 
            this.BtnVowelNumber6.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber6.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber6.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber6.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber6.Location = new System.Drawing.Point(81, 81);
            this.BtnVowelNumber6.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber6.Name = "BtnVowelNumber6";
            this.BtnVowelNumber6.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber6.TabIndex = 5;
            this.BtnVowelNumber6.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber5
            // 
            this.BtnVowelNumber5.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber5.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber5.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber5.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber5.Location = new System.Drawing.Point(2, 81);
            this.BtnVowelNumber5.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber5.Name = "BtnVowelNumber5";
            this.BtnVowelNumber5.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber5.TabIndex = 4;
            this.BtnVowelNumber5.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber4
            // 
            this.BtnVowelNumber4.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber4.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber4.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber4.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber4.Location = new System.Drawing.Point(239, 2);
            this.BtnVowelNumber4.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber4.Name = "BtnVowelNumber4";
            this.BtnVowelNumber4.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber4.TabIndex = 3;
            this.BtnVowelNumber4.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber3
            // 
            this.BtnVowelNumber3.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber3.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber3.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber3.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber3.Location = new System.Drawing.Point(160, 2);
            this.BtnVowelNumber3.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber3.Name = "BtnVowelNumber3";
            this.BtnVowelNumber3.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber3.TabIndex = 2;
            this.BtnVowelNumber3.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber2
            // 
            this.BtnVowelNumber2.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber2.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber2.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber2.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber2.Location = new System.Drawing.Point(81, 2);
            this.BtnVowelNumber2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber2.Name = "BtnVowelNumber2";
            this.BtnVowelNumber2.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber2.TabIndex = 1;
            this.BtnVowelNumber2.UseVisualStyleBackColor = true;
            // 
            // BtnVowelNumber1
            // 
            this.BtnVowelNumber1.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.BtnVowelNumber1.FlatAppearance.BorderSize = 3;
            this.BtnVowelNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVowelNumber1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVowelNumber1.ForeColor = System.Drawing.Color.White;
            this.BtnVowelNumber1.Location = new System.Drawing.Point(2, 2);
            this.BtnVowelNumber1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVowelNumber1.Name = "BtnVowelNumber1";
            this.BtnVowelNumber1.Size = new System.Drawing.Size(75, 75);
            this.BtnVowelNumber1.TabIndex = 0;
            this.BtnVowelNumber1.UseVisualStyleBackColor = true;
            // 
            // simplePanelShowButton
            // 
            this.simplePanelShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.simplePanelShowButton.Controls.Add(this.btn_show_consonant);
            this.simplePanelShowButton.Controls.Add(this.btn_show_diphthong);
            this.simplePanelShowButton.Controls.Add(this.btn_show_vowel);
            this.simplePanelShowButton.Location = new System.Drawing.Point(294, 12);
            this.simplePanelShowButton.Name = "simplePanelShowButton";
            this.simplePanelShowButton.Size = new System.Drawing.Size(353, 57);
            this.simplePanelShowButton.TabIndex = 0;
            // 
            // btn_show_consonant
            // 
            this.btn_show_consonant.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_show_consonant.FlatAppearance.BorderSize = 3;
            this.btn_show_consonant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_consonant.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_consonant.ForeColor = System.Drawing.Color.White;
            this.btn_show_consonant.Location = new System.Drawing.Point(237, 0);
            this.btn_show_consonant.Name = "btn_show_consonant";
            this.btn_show_consonant.Size = new System.Drawing.Size(111, 54);
            this.btn_show_consonant.TabIndex = 2;
            this.btn_show_consonant.Text = "Consonants";
            this.btn_show_consonant.UseVisualStyleBackColor = true;
            this.btn_show_consonant.Click += new System.EventHandler(this.btn_show_consonant_Click);
            // 
            // btn_show_diphthong
            // 
            this.btn_show_diphthong.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_show_diphthong.FlatAppearance.BorderSize = 3;
            this.btn_show_diphthong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_diphthong.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_diphthong.ForeColor = System.Drawing.Color.White;
            this.btn_show_diphthong.Location = new System.Drawing.Point(120, 0);
            this.btn_show_diphthong.Name = "btn_show_diphthong";
            this.btn_show_diphthong.Size = new System.Drawing.Size(111, 54);
            this.btn_show_diphthong.TabIndex = 1;
            this.btn_show_diphthong.Text = "Diphthongs";
            this.btn_show_diphthong.UseVisualStyleBackColor = true;
            this.btn_show_diphthong.Click += new System.EventHandler(this.btn_show_diphthong_Click);
            // 
            // btn_show_vowel
            // 
            this.btn_show_vowel.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btn_show_vowel.FlatAppearance.BorderSize = 3;
            this.btn_show_vowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show_vowel.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_vowel.ForeColor = System.Drawing.Color.White;
            this.btn_show_vowel.Location = new System.Drawing.Point(3, 0);
            this.btn_show_vowel.Name = "btn_show_vowel";
            this.btn_show_vowel.Size = new System.Drawing.Size(111, 54);
            this.btn_show_vowel.TabIndex = 0;
            this.btn_show_vowel.Text = "Pure Vowels";
            this.btn_show_vowel.UseVisualStyleBackColor = true;
            this.btn_show_vowel.Click += new System.EventHandler(this.btn_show_vowel_Click);
            // 
            // ConsonantPanel
            // 
            this.ConsonantPanel.BackColor = System.Drawing.Color.Green;
            this.ConsonantPanel.Controls.Add(this.Consonant24);
            this.ConsonantPanel.Controls.Add(this.Consonant23);
            this.ConsonantPanel.Controls.Add(this.Consonant22);
            this.ConsonantPanel.Controls.Add(this.Consonant21);
            this.ConsonantPanel.Controls.Add(this.Consonant20);
            this.ConsonantPanel.Controls.Add(this.Consonant19);
            this.ConsonantPanel.Controls.Add(this.Consonant18);
            this.ConsonantPanel.Controls.Add(this.Consonant17);
            this.ConsonantPanel.Controls.Add(this.Consonant16);
            this.ConsonantPanel.Controls.Add(this.Consonant15);
            this.ConsonantPanel.Controls.Add(this.Consonant14);
            this.ConsonantPanel.Controls.Add(this.Consonant13);
            this.ConsonantPanel.Controls.Add(this.Consonant12);
            this.ConsonantPanel.Controls.Add(this.Consonant11);
            this.ConsonantPanel.Controls.Add(this.Consonant10);
            this.ConsonantPanel.Controls.Add(this.Consonant9);
            this.ConsonantPanel.Controls.Add(this.Consonant8);
            this.ConsonantPanel.Controls.Add(this.Consonant7);
            this.ConsonantPanel.Controls.Add(this.Consonant6);
            this.ConsonantPanel.Controls.Add(this.Consonant5);
            this.ConsonantPanel.Controls.Add(this.Consonant4);
            this.ConsonantPanel.Controls.Add(this.Consonant3);
            this.ConsonantPanel.Controls.Add(this.Consonant2);
            this.ConsonantPanel.Controls.Add(this.Consonant1);
            this.ConsonantPanel.Location = new System.Drawing.Point(297, 96);
            this.ConsonantPanel.Name = "ConsonantPanel";
            this.ConsonantPanel.Size = new System.Drawing.Size(317, 475);
            this.ConsonantPanel.TabIndex = 13;
            this.ConsonantPanel.Visible = false;
            // 
            // Consonant12
            // 
            this.Consonant12.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant12.FlatAppearance.BorderSize = 3;
            this.Consonant12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant12.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant12.ForeColor = System.Drawing.Color.White;
            this.Consonant12.Location = new System.Drawing.Point(239, 160);
            this.Consonant12.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant12.Name = "Consonant12";
            this.Consonant12.Size = new System.Drawing.Size(75, 75);
            this.Consonant12.TabIndex = 11;
            this.Consonant12.UseVisualStyleBackColor = true;
            // 
            // Consonant11
            // 
            this.Consonant11.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant11.FlatAppearance.BorderSize = 3;
            this.Consonant11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant11.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant11.ForeColor = System.Drawing.Color.White;
            this.Consonant11.Location = new System.Drawing.Point(160, 160);
            this.Consonant11.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant11.Name = "Consonant11";
            this.Consonant11.Size = new System.Drawing.Size(75, 75);
            this.Consonant11.TabIndex = 10;
            this.Consonant11.UseVisualStyleBackColor = true;
            // 
            // Consonant10
            // 
            this.Consonant10.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant10.FlatAppearance.BorderSize = 3;
            this.Consonant10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant10.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant10.ForeColor = System.Drawing.Color.White;
            this.Consonant10.Location = new System.Drawing.Point(81, 160);
            this.Consonant10.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant10.Name = "Consonant10";
            this.Consonant10.Size = new System.Drawing.Size(75, 75);
            this.Consonant10.TabIndex = 9;
            this.Consonant10.UseVisualStyleBackColor = true;
            // 
            // Consonant9
            // 
            this.Consonant9.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant9.FlatAppearance.BorderSize = 3;
            this.Consonant9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant9.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant9.ForeColor = System.Drawing.Color.White;
            this.Consonant9.Location = new System.Drawing.Point(2, 160);
            this.Consonant9.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant9.Name = "Consonant9";
            this.Consonant9.Size = new System.Drawing.Size(75, 75);
            this.Consonant9.TabIndex = 8;
            this.Consonant9.UseVisualStyleBackColor = true;
            // 
            // Consonant8
            // 
            this.Consonant8.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant8.FlatAppearance.BorderSize = 3;
            this.Consonant8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant8.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant8.ForeColor = System.Drawing.Color.White;
            this.Consonant8.Location = new System.Drawing.Point(239, 81);
            this.Consonant8.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant8.Name = "Consonant8";
            this.Consonant8.Size = new System.Drawing.Size(75, 75);
            this.Consonant8.TabIndex = 7;
            this.Consonant8.UseVisualStyleBackColor = true;
            // 
            // Consonant7
            // 
            this.Consonant7.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant7.FlatAppearance.BorderSize = 3;
            this.Consonant7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant7.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant7.ForeColor = System.Drawing.Color.White;
            this.Consonant7.Location = new System.Drawing.Point(160, 81);
            this.Consonant7.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant7.Name = "Consonant7";
            this.Consonant7.Size = new System.Drawing.Size(75, 75);
            this.Consonant7.TabIndex = 6;
            this.Consonant7.UseVisualStyleBackColor = true;
            // 
            // Consonant6
            // 
            this.Consonant6.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant6.FlatAppearance.BorderSize = 3;
            this.Consonant6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant6.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant6.ForeColor = System.Drawing.Color.White;
            this.Consonant6.Location = new System.Drawing.Point(81, 81);
            this.Consonant6.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant6.Name = "Consonant6";
            this.Consonant6.Size = new System.Drawing.Size(75, 75);
            this.Consonant6.TabIndex = 5;
            this.Consonant6.UseVisualStyleBackColor = true;
            // 
            // Consonant5
            // 
            this.Consonant5.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant5.FlatAppearance.BorderSize = 3;
            this.Consonant5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant5.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant5.ForeColor = System.Drawing.Color.White;
            this.Consonant5.Location = new System.Drawing.Point(2, 81);
            this.Consonant5.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant5.Name = "Consonant5";
            this.Consonant5.Size = new System.Drawing.Size(75, 75);
            this.Consonant5.TabIndex = 4;
            this.Consonant5.UseVisualStyleBackColor = true;
            // 
            // Consonant4
            // 
            this.Consonant4.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant4.FlatAppearance.BorderSize = 3;
            this.Consonant4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant4.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant4.ForeColor = System.Drawing.Color.White;
            this.Consonant4.Location = new System.Drawing.Point(239, 2);
            this.Consonant4.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant4.Name = "Consonant4";
            this.Consonant4.Size = new System.Drawing.Size(75, 75);
            this.Consonant4.TabIndex = 3;
            this.Consonant4.UseVisualStyleBackColor = true;
            // 
            // Consonant3
            // 
            this.Consonant3.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant3.FlatAppearance.BorderSize = 3;
            this.Consonant3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant3.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant3.ForeColor = System.Drawing.Color.White;
            this.Consonant3.Location = new System.Drawing.Point(160, 2);
            this.Consonant3.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant3.Name = "Consonant3";
            this.Consonant3.Size = new System.Drawing.Size(75, 75);
            this.Consonant3.TabIndex = 2;
            this.Consonant3.UseVisualStyleBackColor = true;
            // 
            // Consonant2
            // 
            this.Consonant2.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant2.FlatAppearance.BorderSize = 3;
            this.Consonant2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant2.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant2.ForeColor = System.Drawing.Color.White;
            this.Consonant2.Location = new System.Drawing.Point(81, 2);
            this.Consonant2.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant2.Name = "Consonant2";
            this.Consonant2.Size = new System.Drawing.Size(75, 75);
            this.Consonant2.TabIndex = 1;
            this.Consonant2.UseVisualStyleBackColor = true;
            // 
            // Consonant1
            // 
            this.Consonant1.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant1.FlatAppearance.BorderSize = 3;
            this.Consonant1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant1.ForeColor = System.Drawing.Color.White;
            this.Consonant1.Location = new System.Drawing.Point(2, 2);
            this.Consonant1.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant1.Name = "Consonant1";
            this.Consonant1.Size = new System.Drawing.Size(75, 75);
            this.Consonant1.TabIndex = 0;
            this.Consonant1.UseVisualStyleBackColor = true;
            // 
            // Consonant24
            // 
            this.Consonant24.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant24.FlatAppearance.BorderSize = 3;
            this.Consonant24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant24.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant24.ForeColor = System.Drawing.Color.White;
            this.Consonant24.Location = new System.Drawing.Point(239, 397);
            this.Consonant24.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant24.Name = "Consonant24";
            this.Consonant24.Size = new System.Drawing.Size(75, 75);
            this.Consonant24.TabIndex = 23;
            this.Consonant24.UseVisualStyleBackColor = true;
            // 
            // Consonant23
            // 
            this.Consonant23.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant23.FlatAppearance.BorderSize = 3;
            this.Consonant23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant23.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant23.ForeColor = System.Drawing.Color.White;
            this.Consonant23.Location = new System.Drawing.Point(160, 397);
            this.Consonant23.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant23.Name = "Consonant23";
            this.Consonant23.Size = new System.Drawing.Size(75, 75);
            this.Consonant23.TabIndex = 22;
            this.Consonant23.UseVisualStyleBackColor = true;
            // 
            // Consonant22
            // 
            this.Consonant22.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant22.FlatAppearance.BorderSize = 3;
            this.Consonant22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant22.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant22.ForeColor = System.Drawing.Color.White;
            this.Consonant22.Location = new System.Drawing.Point(81, 397);
            this.Consonant22.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant22.Name = "Consonant22";
            this.Consonant22.Size = new System.Drawing.Size(75, 75);
            this.Consonant22.TabIndex = 21;
            this.Consonant22.UseVisualStyleBackColor = true;
            // 
            // Consonant21
            // 
            this.Consonant21.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant21.FlatAppearance.BorderSize = 3;
            this.Consonant21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant21.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant21.ForeColor = System.Drawing.Color.White;
            this.Consonant21.Location = new System.Drawing.Point(2, 397);
            this.Consonant21.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant21.Name = "Consonant21";
            this.Consonant21.Size = new System.Drawing.Size(75, 75);
            this.Consonant21.TabIndex = 20;
            this.Consonant21.UseVisualStyleBackColor = true;
            // 
            // Consonant20
            // 
            this.Consonant20.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant20.FlatAppearance.BorderSize = 3;
            this.Consonant20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant20.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant20.ForeColor = System.Drawing.Color.White;
            this.Consonant20.Location = new System.Drawing.Point(239, 318);
            this.Consonant20.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant20.Name = "Consonant20";
            this.Consonant20.Size = new System.Drawing.Size(75, 75);
            this.Consonant20.TabIndex = 19;
            this.Consonant20.UseVisualStyleBackColor = true;
            // 
            // Consonant19
            // 
            this.Consonant19.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant19.FlatAppearance.BorderSize = 3;
            this.Consonant19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant19.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant19.ForeColor = System.Drawing.Color.White;
            this.Consonant19.Location = new System.Drawing.Point(160, 318);
            this.Consonant19.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant19.Name = "Consonant19";
            this.Consonant19.Size = new System.Drawing.Size(75, 75);
            this.Consonant19.TabIndex = 18;
            this.Consonant19.UseVisualStyleBackColor = true;
            // 
            // Consonant18
            // 
            this.Consonant18.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant18.FlatAppearance.BorderSize = 3;
            this.Consonant18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant18.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant18.ForeColor = System.Drawing.Color.White;
            this.Consonant18.Location = new System.Drawing.Point(81, 318);
            this.Consonant18.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant18.Name = "Consonant18";
            this.Consonant18.Size = new System.Drawing.Size(75, 75);
            this.Consonant18.TabIndex = 17;
            this.Consonant18.UseVisualStyleBackColor = true;
            // 
            // Consonant17
            // 
            this.Consonant17.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant17.FlatAppearance.BorderSize = 3;
            this.Consonant17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant17.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant17.ForeColor = System.Drawing.Color.White;
            this.Consonant17.Location = new System.Drawing.Point(2, 318);
            this.Consonant17.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant17.Name = "Consonant17";
            this.Consonant17.Size = new System.Drawing.Size(75, 75);
            this.Consonant17.TabIndex = 16;
            this.Consonant17.UseVisualStyleBackColor = true;
            // 
            // Consonant16
            // 
            this.Consonant16.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant16.FlatAppearance.BorderSize = 3;
            this.Consonant16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant16.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant16.ForeColor = System.Drawing.Color.White;
            this.Consonant16.Location = new System.Drawing.Point(239, 239);
            this.Consonant16.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant16.Name = "Consonant16";
            this.Consonant16.Size = new System.Drawing.Size(75, 75);
            this.Consonant16.TabIndex = 15;
            this.Consonant16.UseVisualStyleBackColor = true;
            // 
            // Consonant15
            // 
            this.Consonant15.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant15.FlatAppearance.BorderSize = 3;
            this.Consonant15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant15.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant15.ForeColor = System.Drawing.Color.White;
            this.Consonant15.Location = new System.Drawing.Point(160, 239);
            this.Consonant15.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant15.Name = "Consonant15";
            this.Consonant15.Size = new System.Drawing.Size(75, 75);
            this.Consonant15.TabIndex = 14;
            this.Consonant15.UseVisualStyleBackColor = true;
            // 
            // Consonant14
            // 
            this.Consonant14.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant14.FlatAppearance.BorderSize = 3;
            this.Consonant14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant14.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant14.ForeColor = System.Drawing.Color.White;
            this.Consonant14.Location = new System.Drawing.Point(81, 239);
            this.Consonant14.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant14.Name = "Consonant14";
            this.Consonant14.Size = new System.Drawing.Size(75, 75);
            this.Consonant14.TabIndex = 13;
            this.Consonant14.UseVisualStyleBackColor = true;
            // 
            // Consonant13
            // 
            this.Consonant13.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.Consonant13.FlatAppearance.BorderSize = 3;
            this.Consonant13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consonant13.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consonant13.ForeColor = System.Drawing.Color.White;
            this.Consonant13.Location = new System.Drawing.Point(2, 239);
            this.Consonant13.Margin = new System.Windows.Forms.Padding(2);
            this.Consonant13.Name = "Consonant13";
            this.Consonant13.Size = new System.Drawing.Size(75, 75);
            this.Consonant13.TabIndex = 12;
            this.Consonant13.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.slidePanel);
            this.Controls.Add(this.PhonemePanel);
            this.Controls.Add(this.DictionaryPanel);
            this.Controls.Add(this.PhoneticPanel);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "English Helper App";
            this.slidePanel.ResumeLayout(false);
            this.slidePanel.PerformLayout();
            this.PhonemePanel.ResumeLayout(false);
            this.DiphthongPanel.ResumeLayout(false);
            this.PureVowelPanel.ResumeLayout(false);
            this.simplePanelShowButton.ResumeLayout(false);
            this.ConsonantPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private PhonemeChart phonemeChart;
        private Dictionary dictionary = new Dictionary();

        #endregion
        private Panel slidePanel;
        private Button btn_hide;
        private Button btn_show;
        private Button Dictionary_button;
        private LinkLabel Dictionary_Label;
        private Button Phonemes_button;
        private LinkLabel Phonemes_Label;
        private Label App_Tittle_Label;
        private Button Phonetic_button;
        private LinkLabel Phonetic_Label;
        private Panel DictionaryPanel;
        private Panel PhoneticPanel;
        private Panel PhonemePanel;
        private Panel simplePanelShowButton;
        private Button btn_show_vowel;
        private Button btn_show_consonant;
        private Button btn_show_diphthong;
        private Panel PureVowelPanel;
        private Button BtnVowelNumber1;
        private Button BtnVowelNumber12;
        private Button BtnVowelNumber11;
        private Button BtnVowelNumber10;
        private Button BtnVowelNumber9;
        private Button BtnVowelNumber8;
        private Button BtnVowelNumber7;
        private Button BtnVowelNumber6;
        private Button BtnVowelNumber5;
        private Button BtnVowelNumber4;
        private Button BtnVowelNumber3;
        private Button BtnVowelNumber2;
        private RichTextBox PhonemeDetails;
        private Panel DiphthongPanel;
        private Button Diphthong8;
        private Button Diphthong7;
        private Button Diphthong6;
        private Button Diphthong5;
        private Button Diphtong4;
        private Button Diphthong3;
        private Button Diphthong2;
        private Button Diphthong1;
        private Panel ConsonantPanel;
        private Button Consonant12;
        private Button Consonant11;
        private Button Consonant10;
        private Button Consonant9;
        private Button Consonant8;
        private Button Consonant7;
        private Button Consonant6;
        private Button Consonant5;
        private Button Consonant4;
        private Button Consonant3;
        private Button Consonant2;
        private Button Consonant1;
        private Button Consonant24;
        private Button Consonant23;
        private Button Consonant22;
        private Button Consonant21;
        private Button Consonant20;
        private Button Consonant19;
        private Button Consonant18;
        private Button Consonant17;
        private Button Consonant16;
        private Button Consonant15;
        private Button Consonant14;
        private Button Consonant13;
    }
}

