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
    public partial class AddWordForm : Form
    {
        
        public AddWordForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Word word = new Word();
            word.SetTagName(TagNameTextBox.Text);
            word.SetCountability(TrueCountableRadioButton.Checked==true && FalseCountableRadioButton.Checked==false);
            Definition definition = new Definition();
            definition.SetPronunciation(PronunciationTextBox.Text);
            definition.SetDefinition(DefinitionTextBox.Text);
            definition.SetWordType(TypeTextBox.Text);
            definition.SetForm(TrueWeakRadioButton.Checked==true && FalseWeakRadioButton.Checked==false);
            word.AddDefinition(definition);
        }

        private void TrueWeakRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FalseWeakRadioButton.Checked = false;
        }

        private void FalseWeakRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TrueWeakRadioButton.Checked = false;
        }

        private void TrueCountableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            FalseCountableRadioButton.Checked = false;
        }

        private void FalseCountableRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TrueCountableRadioButton.Checked = false;
        }
    }
}
