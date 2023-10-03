using System.Data;


namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            foreach (Button el in mainGrid.Children)
            {
                if (el != deleteBtn) el.Clicked += Button_Clicked;
            }
            
        }

        
        private void Button_Clicked(object sender, EventArgs e)
        {
            string str = ((Button)sender).Text;
            try
            {
                if (str == "AC")
                {
                    lblOutput.Text = "";

                }
                else if (str == "=" && lblOutput.Text != null)
                {
                    string value = new DataTable().Compute(lblOutput.Text, null).ToString();
                    lblOutput.Text = value;
                }
                else if (str != "=")
                {
                    lblOutput.Text += str;

                }
            }
            catch (Exception ex)
            {

                
            }
            
        }


        private void deleteLastCh_Clicked(object sender, EventArgs e)
        {
            if (lblOutput.Text != null && lblOutput.Text != "")
            {

                lblOutput.Text = lblOutput.Text[..^1];
            }
            
        }

       




    }
}