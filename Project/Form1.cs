using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form1 : Form
    {

        public Dictionary<string,string> loadFiles()
        {            
            var fileList = new Dictionary<string,string>();

            foreach (var path in Directory.GetFiles(@"C:/Users/David/Moje veci/Documents/OOP/Project/textArchive/"))
            {                
                fileList.Add(System.IO.Path.GetFileName(path),path);
            }

            foreach(var fileName in fileList.Keys)             
            {                 

                if (this.checkedListBoxFiles.Items.Count == fileList.Count)
                {
                    continue;
                }
                else
                {
                    this.checkedListBoxFiles.Items.AddRange(new object[] { fileName });
                }

            }
            return fileList;
        }

        public string Analyze(Dictionary<string,string> fileList)
        {
            string result = "";
            int wordsToCount = Convert.ToInt32(this.numericUpDownWords.Value);

            //MessageBox.Show("Success", "Success",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            //this.textBoxAllFiles.Text = testString.getTextNoPunctuation();
            
            foreach (var file in fileList)
            {
                StringAnalysis testString = new StringAnalysis(File.ReadAllText(file.Value));

                //Výpis počtu slov
                result += file.Key.ToUpper() + ":" + Environment.NewLine + "Word count: " + Convert.ToString(testString.CountWords()) + Environment.NewLine;

                //Výpis počtu riadkov
                result += "Line count: " + Convert.ToString(testString.CountLines()) + Environment.NewLine;

                //Výpis počtu viet
                result += "Sentence count: " + testString.CountSentences() + Environment.NewLine;

                //Výpis 3 najdlhších slov
                result += wordsToCount + " Longest words:  ";
                foreach (var word in testString.LongestWords().Take(wordsToCount))
                {
                    result += word + ",  ";
                }result += Environment.NewLine;

                //Výpis 3 najkretších slov
                result += wordsToCount + " Shortest words:  ";
                foreach (var word in testString.ShortestWords().Take(wordsToCount))
                {
                    result += word + ",  ";
                }
                result += Environment.NewLine;


                //Výpis najčastejšieho slova
                result += "Most common word: ";
                foreach (var word in testString.MostOftenWords())
                {
                    result += word;
                }result += Environment.NewLine;

                //Výpis abecedne zoradených slov
                result += "Alphabetically ordered text: ";
                foreach (var word in testString.sortABC())
                {
                    result +=word + ", ";
                }result += Environment.NewLine;



                result += Environment.NewLine;
            }

            return result;

        }


        public Form1()
        {
            InitializeComponent();
            
            loadFiles();

        }


        private void checkedListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            this.textBoxAllFiles.Clear();
            var fileList = loadFiles();
           
           this.textBoxSelectedFiles.Text = Analyze(fileList);
           
        }

        private void numericUpDownWords_ValueChanged(object sender, EventArgs e)
        {



        }
    }
}
