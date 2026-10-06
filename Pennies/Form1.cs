namespace Pennies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int days;

            if (!int.TryParse(txtDays.Text, out days) || days <= 0)
            {
                MessageBox.Show("Please enter a valid number of days.");
                return;
            }

            lstResult.Items.Clear();
            double total = 0;

            for (int day = 1; day <= days; day++)
            {
                double pay = Math.Pow(2, day - 1) * 0.01;
                total += pay;
                lstResult.Items.Add($"Day {day}: {pay:C}");
            }

            lblTotal.Text =total.ToString("C");
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtDays.Clear();
            lstResult.Items.Clear();
            lblTotal.Text = "";
            txtDays.Focus();
        }
    }
}