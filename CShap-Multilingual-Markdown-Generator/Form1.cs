using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MultiLanguageMarkDownGenerator
{
    public partial class Form1 : Form
    {
        private MarkDownParser _markDownParser = new MarkDownParser();
        private StringBuilder _logBuilder = new StringBuilder();

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
            OFD.Filter = "MD(*.md)|*.base.md";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                var keys = Path.GetFileName(OFD.FileName).Split('.');

                if(keys.Length > 2 && keys[1] == "base")
                {
                    string baseFileName = keys[0];
                    _markDownParser.GenerateDocument(OFD.FileName, baseFileName, MainLanguage, _logBuilder);
                    tbResult.Text = _logBuilder.ToString();
                }
                else
                {
                    tbResult.Text = "파일 규칙이 잘못되었습니다 - 파일명.base 로 되어 있는지 확인해 주세요" + System.Environment.NewLine + "ex : Readme.base";
                }
                _logBuilder.Clear();
        
            }
        }
    }
}
