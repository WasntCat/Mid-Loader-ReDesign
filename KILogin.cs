using System;
using System.Windows.Forms;

namespace KIUIPaided
{
    public partial class KILogin : Form
    {
        #region Form
        public KILogin()
        {
            InitializeComponent();
        }
        private void KILogin_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
        #endregion

        #region Button
        private void LoginButton_Click(object sender, EventArgs e)
        {

            Loader Loader = new Loader();
            Loader.Show();
            this.Hide();
        }
        #endregion
    }
}
