namespace ArrayProgramTutorial2
{
    public partial class Form1 : Form
    {
        //create the integer array
        int[] intArray = new int[10];

        //have an index to track the size of the array
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        /**
         * Checks if the textbox has a number and if so, adds
         * it to the array
         */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtNewElement.Text != "")
            {
                int parsedInteger;
                bool success = int.TryParse(txtNewElement.Text, out parsedInteger);
                if(!success)
                {
                    MessageBox.Show("Please only enter integers.");
                }
                else
                {
                    //add the element, increment the index and display new value.
                    intArray[index] = parsedInteger;
                    index++;
                    lblArraySize.Text = index.ToString();

                    //clear text box after number is added
                    txtNewElement.Text = "";

                    //disable add button when array is full
                    if(index >= intArray.Length)
                    {
                        btnAdd.Enabled = false;
                    }else if(index > 1)
                        //enable sort button when two elements are added.
                    {
                        btnSort.Enabled = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("You can't add nothing to an array!");
            }
        }
    }
}
