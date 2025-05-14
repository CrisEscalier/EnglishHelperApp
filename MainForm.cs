using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishHelperApp.classes;

namespace EnglishHelperApp
{
    public partial class MainForm : Form
    {
        private Timer slideTimer = new Timer();
        private bool expandiendo = false;
        private int panelMinWidth = 76;
        private int panelMaxWidth = 280;
        private int separacion = 12;
        public MainForm()
        {
            InitializeComponent();
            phonemeChart = new classes.PhonemeChart();
            RenderVowelButtons();

            slideTimer.Interval = 10;
            slideTimer.Tick += SlideTimer_Tick;
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            btn_hide.Visible = false;
            expandiendo = false;
            slideTimer.Start();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            btn_show.Visible = false;
            expandiendo = true;
            slideTimer.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            int paso = 10;
            if(expandiendo)
            {
                if (slidePanel.Width < panelMaxWidth)
                {
                    slidePanel.Width += paso;
                    if (slidePanel.Width > panelMaxWidth) slidePanel.Width = panelMaxWidth;
                } 
                else
                {
                    slideTimer.Stop();
                    btn_hide.Visible = true;
                }
            }
            else
            {
                if(slidePanel.Width > panelMinWidth)
                {
                    slidePanel.Width -= paso;
                    if(slidePanel.Width < panelMinWidth) slidePanel.Width = panelMinWidth;
                }
                else
                {
                    slideTimer.Stop();
                    btn_show.Visible = true;
                }
            }
            simplePanelShowButton.Left = slidePanel.Left + slidePanel.Width + separacion;
            PureVowelPanel.Left = slidePanel.Left + slidePanel.Width + separacion;
            DiphthongPanel.Left = slidePanel.Left + slidePanel.Width + separacion;
            ConsonantPanel.Left = slidePanel.Left + slidePanel.Width + separacion;
            PhonemeDetails.Left = PureVowelPanel.Right + separacion;
        }

        private void Dictionary_button_Click(object sender, EventArgs e)
        {
            this.slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            simplePanelShowButton.Visible = false;
            DictionaryPanel.Visible = true;
            PhoneticPanel.Visible = false;
            PhonemePanel.Visible = false;
        }

        private void Phonemes_Button_Click(object sender, EventArgs e)
        {
            simplePanelShowButton.Visible = true;
            slidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            DictionaryPanel.Visible = false;
            PhoneticPanel.Visible = false;
            PhonemePanel.Visible = true;
        }

        private void Phonetics_button_Click(object sender, EventArgs e)
        {
            simplePanelShowButton.Visible = false;
            PhoneticPanel.Visible = true;
            DictionaryPanel.Visible = false;
            this.slidePanel.BackColor = System.Drawing.Color.Firebrick;
            PhonemePanel.Visible = false;
        }
        
        private void RenderVowelButtons()
        {
            ConsonantPanel.Visible = false;
            DiphthongPanel.Visible = false;
            phonemeChart.InitializeVowelList();
            BtnVowelNumber1.Text = phonemeChart.GetVowelByNumber(1).GetPhoneticSymbol();
            BtnVowelNumber2.Text = phonemeChart.GetVowelByNumber(2).GetPhoneticSymbol();
            BtnVowelNumber3.Text = phonemeChart.GetVowelByNumber(3).GetPhoneticSymbol();
            BtnVowelNumber4.Text = phonemeChart.GetVowelByNumber(4).GetPhoneticSymbol();
            BtnVowelNumber5.Text = phonemeChart.GetVowelByNumber(5).GetPhoneticSymbol();
            BtnVowelNumber6.Text = phonemeChart.GetVowelByNumber(6).GetPhoneticSymbol();
            BtnVowelNumber7.Text = phonemeChart.GetVowelByNumber(7).GetPhoneticSymbol();
            BtnVowelNumber8.Text = phonemeChart.GetVowelByNumber(8).GetPhoneticSymbol();
            BtnVowelNumber9.Text = phonemeChart.GetVowelByNumber(9).GetPhoneticSymbol();
            BtnVowelNumber10.Text = phonemeChart.GetVowelByNumber(10).GetPhoneticSymbol();
            BtnVowelNumber11.Text = phonemeChart.GetVowelByNumber(11).GetPhoneticSymbol();
            BtnVowelNumber12.Text = phonemeChart.GetVowelByNumber(12).GetPhoneticSymbol();
            BtnVowelNumber1.Click += (s, e) => ShowPhonemeDetails(1);
            BtnVowelNumber2.Click += (s, e) => ShowPhonemeDetails(2);
            BtnVowelNumber3.Click += (s, e) => ShowPhonemeDetails(3);
            BtnVowelNumber4.Click += (s, e) => ShowPhonemeDetails(4);
            BtnVowelNumber5.Click += (s, e) => ShowPhonemeDetails(5);
            BtnVowelNumber6.Click += (s, e) => ShowPhonemeDetails(6);
            BtnVowelNumber7.Click += (s, e) => ShowPhonemeDetails(7);
            BtnVowelNumber8.Click += (s, e) => ShowPhonemeDetails(8);
            BtnVowelNumber9.Click += (s, e) => ShowPhonemeDetails(9);
            BtnVowelNumber10.Click += (s, e) => ShowPhonemeDetails(10);
            BtnVowelNumber11.Click += (s, e) => ShowPhonemeDetails(11);
            BtnVowelNumber12.Click += (s, e) => ShowPhonemeDetails(12);
        }

        public void ShowPhonemeDetails(int number)
        {
            var phoneme = phonemeChart.GetVowelByNumber(number);
            PhonemeDetails.Text = phonemeChart.GetPhonemeDetails(phoneme);
        }

        private void btn_show_vowel_Click(object sender, EventArgs e)
        {
            PhonemeDetails.Text = "";
            DiphthongPanel.Visible = false;
            ConsonantPanel.Visible = false;
            PureVowelPanel.Visible = true;
            PhonemeDetails.Visible = true;
        }

        private void btn_show_diphthong_Click(object sender, EventArgs e)
        {
            PhonemeDetails.Text = "";
            DiphthongPanel.Visible = true;
            ConsonantPanel.Visible = false;
            PureVowelPanel.Visible = false;
            PhonemeDetails.Visible = true;
        }

        private void btn_show_consonant_Click(object sender, EventArgs e)
        {
            PhonemeDetails.Text = "";
            DiphthongPanel.Visible = false;
            PureVowelPanel.Visible = false;
            ConsonantPanel.Visible = true;
        }

        
        
        
    }
}
