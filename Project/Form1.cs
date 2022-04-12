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
            var checkedFiles = getCheckItems();


            foreach (var path in Directory.GetFiles(@"C:/Users/David/Moje veci/Documents/OOP/Project/textArchive/"))
            {
                fileList.Add(System.IO.Path.GetFileName(path), path);
            }
            
            return fileList;
        }


        public Dictionary<string,string> getCheckedFilesList()
        {
            var checkedFilesList = new Dictionary<string, string>();
            var checkedFiles = getCheckItems();

            foreach (var path in Directory.GetFiles(@"C:/Users/David/Moje veci/Documents/OOP/Project/textArchive/"))
            {
                foreach (var item in checkedFiles)
                {
                    if (item == System.IO.Path.GetFileName(path))
                    {
                        checkedFilesList.Add(System.IO.Path.GetFileName(path), path);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }           

            return checkedFilesList;
        }


        public string Analyze(Dictionary<string,string> fileList)
        {
            string result = "";
            int wordsToCount = Convert.ToInt32(this.numericUpDownWords.Value);
                        
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


        public string AnalyzeAll(Dictionary<string,string> fileList)
        {

            int wordsToCount = Convert.ToInt32(this.numericUpDownWords.Value);
            string result = "rit";
            string text = "";
            
            foreach (var file in fileList.Values)
            {
                text += File.ReadAllText(file);
            }
            
            StringAnalysis testString = new StringAnalysis(text);   //Tu to je            
            
            //Výpis počtu slov
            result += "Word count: " + Convert.ToString(testString.CountWords()) + Environment.NewLine;
            
            //Výpis počtu riadkov
            result += "Line count: " + Convert.ToString(testString.CountLines()) + Environment.NewLine;

            //Výpis počtu viet
            result += "Sentence count: " + testString.CountSentences() + Environment.NewLine;

            //Výpis 3 najdlhších slov
            result += wordsToCount + " Longest words:  ";
            foreach (var word in testString.LongestWords().Take(wordsToCount))
            {
                result += word + ",  ";
            }
            result += Environment.NewLine;

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
            }
            result += Environment.NewLine;

            //Výpis abecedne zoradených slov
            result += "Alphabetically ordered text: ";
            foreach (var word in testString.sortABC())
            {
                result += word + ", ";
            }
            result += Environment.NewLine;
            result += Environment.NewLine;
            return result;
        }


        public List<string> getCheckItems()
        {
            var fileChecked = new List<string>();

            int i;
            for (i = 0; i <= (checkedListBoxFiles.Items.Count - 1); i++)
            {
                if (checkedListBoxFiles.GetItemChecked(i))
                {                    
                    fileChecked.Add(checkedListBoxFiles.Items[i].ToString());  
                }
            }
            return fileChecked;
        }


        public void refreshCheckbox()
        {
            var fileList = loadFiles();
            var checkItems = getCheckItems();

            this.checkedListBoxFiles.Items.Clear();
            this.fileSelection.Items.Clear();


            



            foreach (var fileName in fileList.Keys)
            {              

                if (this.checkedListBoxFiles.Items.Count == fileList.Count)
                {
                    break;
                }
                else
                {
                    this.checkedListBoxFiles.Items.AddRange(new object[] { fileName });

                }

            }            
        }


        public void refreshAnalysis() 
        {
            this.textBoxSelectedFiles.Clear();
            this.textBoxAllFiles.Clear();


            var fileList = loadFiles();

            string selected = this.fileSelection.GetItemText(this.fileSelection.SelectedItem);
            var checkedFiles = getCheckedFilesList();
            var selectedFile = new Dictionary<string, string>();

            foreach (var file in checkedFiles)
            {
                if (file.Key == selected)
                {
                    selectedFile.Add(file.Key, file.Value);
                    break;
                }
            }
            this.textBoxAllFiles.Text = AnalyzeAll(fileList);
            this.textBoxSelectedFiles.Text += Analyze(selectedFile);

        }





        public Form1()
        {
            InitializeComponent();
            var fileList = loadFiles();
            //Vypíše načítané súbory do checkbox poľa
            foreach (var fileName in fileList.Keys)
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
            this.textBoxAllFiles.Text = AnalyzeAll(fileList);
        }
                


        private void checkedListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fileChecked = getCheckItems();
            this.fileSelection.Items.Clear();
            foreach(var item in fileChecked)
            { 
                this.fileSelection.Items.Add(item.ToString());
            }
            
        }


        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            string selected = this.fileSelection.GetItemText(this.fileSelection.SelectedItem);
            var checkedFiles = getCheckedFilesList();
            var allFiles = loadFiles();
            var selectedFile = new Dictionary<string, string>();

            foreach (var file in checkedFiles)
            {
                if(file.Key == selected)
                {
                    selectedFile.Add(file.Key, file.Value);
                    break;
                }
            }
            
            this.textBoxSelectedFiles.Clear();
            this.textBoxSelectedFiles.Text += Analyze(selectedFile);
            this.textBoxAllFiles.Text = AnalyzeAll(allFiles);
            
        }


        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    File.Copy(filePath, @"C:/Users/David/Moje veci/Documents/OOP/Project/textArchive/" + System.IO.Path.GetFileName(filePath));
                    refreshCheckbox();

                }
                catch (Exception ex) 
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
            }
        }


        private void fileSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = this.fileSelection.GetItemText(this.fileSelection.SelectedItem);
            
            var checkedFiles = getCheckedFilesList();
            var allFiles = loadFiles();
            var selectedFile = new Dictionary<string, string>();

            foreach (var file in checkedFiles)
            {
                if (file.Key == selected)
                {
                    selectedFile.Add(file.Key, file.Value);
                    break;
                }
            }

            this.textBoxSelectedFiles.Clear();
            this.textBoxSelectedFiles.Text += Analyze(selectedFile);
            this.textBoxAllFiles.Text = AnalyzeAll(allFiles);
        }

        private void numericUpDownWords_ValueChanged(object sender, EventArgs e)
        {
            refreshAnalysis();
        }
    }
}
