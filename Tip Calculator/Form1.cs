using Microsoft.VisualBasic.Logging;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        //For check user enter only numberic value in bill field
        private void Bill_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar!='.')) { 

                e.Handled = true;
            }
           if((e.KeyChar=='.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
 
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // check user enter numberic value or not in Tip Textbox
        private void Tip_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {

                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }
        // Increment Button of Tip count
        private void IncrementTip_Click(object sender, EventArgs e)
        {
            Tip.Text =Convert.ToString(float.Parse(Tip.Text) + 1);
        }
        //Decrement Button of Tip Count
        private void DecrementTip_Click(object sender, EventArgs e)
        {
            if (float.Parse(Tip.Text) <= 0)
            {
                MessageBox.Show("Enter positive number only");
            }
            else
            {
                Tip.Text = Convert.ToString(float.Parse(Tip.Text) - 1);
            }

        }
        private void PeopleCount_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
            }
            


        }
        // Increment Button of People count
        private void IncrementPeople_Click(object sender, EventArgs e)
        {
            PeopleCount.Text = Convert.ToString(Int64.Parse(PeopleCount.Text) + 1);
        }
        //Decrement Button of People Count
        private void DecrementPeople_Click(object sender, EventArgs e)
        {
            //Check people count value negative or not
            if (Int64.Parse(PeopleCount.Text) <= 0)
            {
                MessageBox.Show("Enter positive number only");
            }
            else
            { 
                PeopleCount.Text = Convert.ToString(Int64.Parse(PeopleCount.Text) - 1);
            }
        }
       //calculating the total per person and tip per person
        private void Calculate_Click(object sender, EventArgs e)
        {
            if (Int64.Parse(PeopleCount.Text) == 0)
            {
                MessageBox.Show("Enter number of people");
            }
            else if (float.Parse(Bill.Text) == 0)
            {
                MessageBox.Show("Please Enter Bill Amount");
            }
            else
            {
                
                double TotalTip = (double.Parse(Bill.Text) * double.Parse(Tip.Text)) / 100;
                double  TotalPerPerson = (double.Parse(Bill.Text) + TotalTip) / Int64.Parse(PeopleCount.Text);
                double TipPerPerson = TotalTip / Int64.Parse(PeopleCount.Text);
              
                TipPerson.Text = "₹" +TipPerPerson.ToString("r"); 
                TotalPerson.Text = "₹" + TotalPerPerson.ToString("r");
            }
            
        }


    }
}