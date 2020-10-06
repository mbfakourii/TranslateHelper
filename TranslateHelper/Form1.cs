using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace TranslateHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Develop By Mohammad Baqer Fakouri");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Remive_Spaces(Point_Enter(Remover_Enter(textBox1.Text)));
        }

        private String Remover_Enter(String str_Value)
        {
            str_Value = Regex.Replace(str_Value, @"\t|\n|\r", " ");
            return str_Value;
        }

        private String Point_Enter(String str_Value)
        {
            str_Value = Regex.Replace(str_Value, @"\t|\.|\r", "."  + System.Environment.NewLine);
            return str_Value.Trim();
        }

        private String Remive_Spaces(String str_Value)
        {

            RegexOptions options = RegexOptions.Multiline;

            str_Value = Regex.Replace(str_Value, @"^\s", System.Environment.NewLine, options);
            return str_Value;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = Remive_Spaces(Point_Enter(Remover_Enter(textBox1.Text)));
            Clipboard.SetText(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void buttonss_Click(object sender, EventArgs e)
        {
            textBox2.Text = Remive_Spaces(Point_Enter(Remover_Enter(textBox1.Text)));


            var lngSrc = ((KeyValuePair<string, string>)cmbSrc.SelectedItem).Key;
            var lngDest = ((KeyValuePair<string, string>)cmbDesc.SelectedItem).Key;

            AutoResxTranslator.GTranslateService.TranslateAsync(
                this.textBox2.Text, lngSrc, lngDest, "",
                (success, result) =>
                {
                    SetResult(result);
                });
            
        }
        void SetResult(string result)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(SetResult), result);
                return;
            }
            else
            {
               textBox3.Text = result;
                Clipboard.SetText(result);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private readonly Dictionary<string, string> _languages =
            new Dictionary<string, string>
            {
                {"auto", "(Detect)"},
                {"af", "Afrikaans"},
                {"sq", "Albanian"},
                {"ar", "Arabic"},
                {"hy", "Armenian"},
                {"az", "Azerbaijani"},
                {"eu", "Basque"},
                {"be", "Belarusian"},
                {"bn", "Bengali"},
                {"bg", "Bulgarian"},
                {"ca", "Catalan"},
                {"zh-CN", "Chinese (Simplified)"},
                {"zh-TW", "Chinese (Traditional)"},
                {"hr", "Croatian"},
                {"cs", "Czech"},
                {"da", "Danish"},
                {"nl", "Dutch"},
                {"en", "English"},
                {"eo", "Esperanto"},
                {"et", "Estonian"},
                {"tl", "Filipino"},
                {"fi", "Finnish"},
                {"fr", "French"},
                {"gl", "Galician"},
                {"ka", "Georgian"},
                {"de", "German"},
                {"el", "Greek"},
                {"gu", "Gujarati"},
                {"ht", "Haitian Creole"},
                {"iw", "Hebrew"},
                {"hi", "Hindi"},
                {"hu", "Hungarian"},
                {"is", "Icelandic"},
                {"id", "Indonesian"},
                {"ga", "Irish"},
                {"it", "Italian"},
                {"ja", "Japanese"},
                {"kn", "Kannada"},
                {"km", "Khmer"},
                {"ko", "Korean"},
                {"lo", "Lao"},
                {"la", "Latin"},
                {"lv", "Latvian"},
                {"lt", "Lithuanian"},
                {"mk", "Macedonian"},
                {"ms", "Malay"},
                {"mt", "Maltese"},
                {"no", "Norwegian"},
                {"fa", "Persian"},
                {"pl", "Polish"},
                {"pt", "Portuguese"},
                {"ro", "Romanian"},
                {"ru", "Russian"},
                {"sr", "Serbian"},
                {"sk", "Slovak"},
                {"sl", "Slovenian"},
                {"es", "Spanish"},
                {"sw", "Swahili"},
                {"sv", "Swedish"},
                {"ta", "Tamil"},
                {"te", "Telugu"},
                {"th", "Thai"},
                {"tr", "Turkish"},
                {"uk", "Ukrainian"},
                {"ur", "Urdu"},
                {"vi", "Vietnamese"},
                {"cy", "Welsh"},
                {"yi", "Yiddish"}
            };


        void FillComboBoxes()
        {
            cmbSrc.DisplayMember = "Value";
            cmbSrc.ValueMember = "Key";

            cmbDesc.DisplayMember = "Value";
            cmbDesc.ValueMember = "Key";
           

            foreach (var k in _languages)
            {
                cmbSrc.Items.Add(k);
                if (k.Key == "auto")
                    continue;
                cmbDesc.Items.Add(k);
            }
            cmbSrc.SelectedIndex = 0;
            cmbDesc.Text = "Persian";
        }
    }
}
