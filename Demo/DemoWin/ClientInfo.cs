using DemoLib;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class ClientInfo : Form
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        public void SetClient(Client client)
        {
            CompanyNameTextBox.Text = client.Name;
            PhoneNumberTextBox.Text = client.PhoneNumber;
            textBoxDirector.Text = client.Director;
            textBoxRating.Text = client.Rating.ToString();
            textBoxDiscount.Text = Convert.ToString(client.Discount);
        }
    }
}
