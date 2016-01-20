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
            Dictionary<string, int> dictShowCounts = dictBuildCharDictionary("abcdefghijklmnopqrstuvwxyz1234567890");
            char[] countThisBitch = txtLettersToCount.Text.Replace(" ","").ToLower().ToCharArray();
            foreach (char inLetter in countThisBitch) {
                dictShowCounts[inLetter.ToString()] += 1;
            }
            lstShowCount.Items.Clear();
            foreach (KeyValuePair<string, int> kvp in dictShowCounts) {
                if (kvp.Value != 0) {
                    string addToLst = kvp.Key + " - " + kvp.Value;
                    lstShowCount.Items.Add(addToLst);
                }
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

    }
}
