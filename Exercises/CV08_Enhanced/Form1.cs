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

            this.temperatures.Clear();
            this.averageTemperatures.Clear();
            this.calibratedTemperatures.Clear();
            this.searchResultTextBox.Clear();

            this.temperatures.Text = teploty.TiskTeplot();
            this.averageTemperatures.Text = teploty.TiskPrumernychTeplot();
            loadButtonWasClicked = true;

        }


        private void calibrateButton_Click(object sender, EventArgs e)
        {
            if (loadButtonWasClicked==true)
            {
                this.searchResultTextBox.Clear();
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
                if (teploty.Save(pathWrite))
                {
                    MessageBox.Show("Temperatures have been saved", "Saved", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("There was an error saving temperatures", "Error", MessageBoxButtons.OK);
                }
                
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
                else if (String.IsNullOrEmpty(this.searchTextBox.Text))
                {

                    this.searchResultTextBox.Text = "";

                }
                else
                {

                    MessageBox.Show("Wrong input", "Error: Could not serach", MessageBoxButtons.OK);

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

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (loadButtonWasClicked == true)
            {
                if (int.TryParse(this.searchTextBox.Text, out int value))
                {
                    this.searchResultTextBox.Clear();
                    int searchYear = Convert.ToInt16(this.searchTextBox.Text);
                    this.searchResultTextBox.Text = teploty.Vyhledej(searchYear);

                }
                else if (String.IsNullOrEmpty(this.searchTextBox.Text))
                {

                    this.searchResultTextBox.Text = "";

                }
                else
                {
                    this.searchResultTextBox.Text = "Wrong input";
                }
            }
            else
            {
                this.searchResultTextBox.Text = "Wrong input";
            }
        }
    }
}