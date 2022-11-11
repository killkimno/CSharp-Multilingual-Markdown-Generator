using System;
using System.IO;
using System.Windows.Forms;

namespace MultiLanguageMarkDownGenerator
{
    public partial class Form1 : Form
    {
        private MarkDownParser _markDownParser = new MarkDownParser();

        public Form1()
        {
            InitializeComponent();
        }

        private MarkDownParser.LanguageType MainLanguage
        {
            get
            {
                if(rbKR.Checked)
                {
                    return MarkDownParser.LanguageType.Kr;
                }
                
                if(rbEn.Checked)
                {
                    return MarkDownParser.LanguageType.En;
                }

                if (rbJp.Checked)
                {
                    return MarkDownParser.LanguageType.Jp;
                }

                if (rbFr.Checked)
                {
                    return MarkDownParser.LanguageType.Fr;
                }

                return MarkDownParser.LanguageType.En;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                string baseFileName = Path.GetFileName(OFD.FileName).Split('.')[0];
                _markDownParser.GenerateDocument(OFD.FileName, baseFileName, MainLanguage);
            }
        }
    }
}
