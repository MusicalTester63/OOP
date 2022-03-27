namespace CV08_Enhanced
{
    public partial class Form1 : Form 
    {

        private bool loadButtonWasClicked = false;

        string pathWrite = @"writerTeploty.txt";
        string pathRead = @"readerTeploty.txt";

        ArchivTeplot teploty = new ArchivTeplot();
                     

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            teploty.Load(pathRead);            
            this.temperatures.Text = teploty.TiskTeplot();
            this.averageTemperatures.Text = teploty.TiskPrumernychTeplot();
            loadButtonWasClicked = true;

        }


        private void calibrateButton_Click(object sender, EventArgs e)
        {
            if (loadButtonWasClicked==true)
            {
                double cal = Convert.ToDouble(calConstantMenu.Value);
                this.calibratedTemperatures.Text = teploty.Kalibrace(cal);
            }
            else
            {
                MessageBox.Show("Please load temperatures to continue", "Error: Temperatures not loaded", MessageBoxButtons.OK);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (loadButtonWasClicked == true)
            {
                teploty.Save(pathWrite);
            }
            else
            {
                MessageBox.Show("Please load temperatures to continue", "Error: Temperatures not loaded", MessageBoxButtons.OK);
            }

        }

        private void searchSubmitButton_Click(object sender, EventArgs e)
        {
            if (loadButtonWasClicked == true)
            {                    
                if (int.TryParse(this.searchTextBox.Text, out int value))
                {
                    int searchYear = Convert.ToInt16(this.searchTextBox.Text);
                    this.searchResultTextBox.Text = teploty.Vyhledej(searchYear);

                }
                else
                {

                    MessageBox.Show("You haven't entered search variable", "Error: Could not serach", MessageBoxButtons.OK);

                }                
            }
            else
            {
                MessageBox.Show("Please load temperatures to continue", "Error: Temperatures not loaded", MessageBoxButtons.OK);
            }
        }

        private void temperatures_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void averageTemperatures_TextChanged(object sender, EventArgs e)
        {

            

        }

       
    }
}