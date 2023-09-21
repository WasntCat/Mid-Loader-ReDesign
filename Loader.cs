using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KIUIPaided
{
    public partial class Loader : Form
    {
        #region Form
        public Loader()
        {
            InitializeComponent();
        }
        private void Loader_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region Buttons
        private void SpooferButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Spoofer";
            label3.Text = "1 Day"; // If your using keyauth just use the built in check to replace the text and split the
            // Api Response like  label3.Text = {Keyauth.subCheckect} + " Days" or Day;
            label3.Location = new Point(108, 38);

            label4.Text = "last used : Null"; // Do the same with your api just Check when the client last connected
            label5.Text = "last Updated : Null"; // You could use the Keyauth api to check when your hash last changed throu
            // The web panel and change the date from them or just manauly update it through a Loader p-p

            CleanerToggle.Visible = true;
            label2.Visible = true;
        }
        private void ExampleOtherButton_Click(object sender, EventArgs e)
        {
            label1.Text = "EspHeck";

            label3.Text = "69 Days";
            label3.Location = new Point(108, 38);

            label4.Text = "last used : Null";
            label5.Text = "last Updated : Null";

            CleanerToggle.Visible = false;
            label2.Visible = false;
        }
        private void ExampleLoad3_Click(object sender, EventArgs e)
        {
            label1.Text = "CsgoRad";

            label3.Text = "240 Days";
            label3.Location = new Point(95, 38);

            label4.Text = "last used : Null";
            label5.Text = "last Updated : Null";

            CleanerToggle.Visible = false;
            label2.Visible = false;
        }
        #endregion
    }
}
