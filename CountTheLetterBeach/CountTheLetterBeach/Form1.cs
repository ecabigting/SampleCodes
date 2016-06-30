using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountTheLetterBeach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLettersToCount.Text = "";
            lstShowCount.Items.Clear();
        }

        private void btnCountBitch_Click(object sender, EventArgs e)
        {
            //abcdefghijklmnopqrstuvwxyz1234567890
            int startingPage = Int32.Parse(cmbStartPage.Text.ToString());
            Dictionary<string, int> dictShowCounts = dictBuildCharDictionary("abcdefghijklmnopqrstuvwxyz1234567890");
            char[] countThisBitch = txtLettersToCount.Text.Replace(" ","").ToLower().ToCharArray();
            foreach (char inLetter in countThisBitch) {
                dictShowCounts[inLetter.ToString()] += 1;
            }
            lstShowCount.Items.Clear();
            foreach (KeyValuePair<string, int> kvp in dictShowCounts) {
                if (kvp.Value != 0) {
                    string addToLst = "pg:" + startingPage.ToString() + " - " + kvp.Key + " - " + kvp.Value;
                    lstShowCount.Items.Add(addToLst);
                }
                startingPage++;
            }
        }

        private Dictionary<string, int> dictBuildCharDictionary(string charList)
        {
            Dictionary<string, int> dictFinal = new Dictionary<string, int>();
            char[] charactersBitch = charList.ToCharArray();
            foreach (char partChar in charactersBitch)
            {
                try
                {
                    dictFinal.Add(partChar.ToString(), 0);
                }
                catch (ArgumentException)
                {
                }
            }
            return dictFinal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillCMB();
        }

        private void fillCMB()
        {
            for(int x = 1; x < 5; x++)
            {
                ComboboxItem cbItem = new ComboboxItem();
                cbItem.Text = x.ToString();
                cbItem.Value = x.ToString();
                cmbStartPage.Items.Add(cbItem);
            }
            cmbStartPage.SelectedIndex = 0;
        }

        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
