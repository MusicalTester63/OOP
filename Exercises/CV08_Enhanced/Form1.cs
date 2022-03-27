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
                this.calibratedTemperatures.Text = teploty.Kalibrace(1);
            }
            else
            {
                MessageBox.Show("Please load temperatures to continue", "Error: Temperatures not loaded", MessageBoxButtons.OK);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (loadButtonWasClicked == false)
            {
                MessageBox.Show("Please load temperatures to continue", "Error: Temperatures not loaded", MessageBoxButtons.OK);
            }
            else
            {
                teploty.Save(pathWrite);
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