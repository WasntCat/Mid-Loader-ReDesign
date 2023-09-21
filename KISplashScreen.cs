using System;
using System.Windows.Forms;

namespace KIUIPaided
{
    public partial class KISplashScreen : Form
    {
        #region Form
        public KISplashScreen()
        {
            InitializeComponent();
        }
        private void KISplashScreen_Load(object sender, EventArgs e)
        {
            StartMe();
            guna2ShadowForm1.SetShadowForm(this);
        }
        private void LoadLogin_Tick(object sender, EventArgs e)
        {
            BottomTaskBar.Increment(2);

            DotAnimation();

            if (BottomTaskBar.Value == 100)
            {
                LoadLogin.Enabled = false;

                KILogin KILogin = new KILogin();
                KILogin.Show();
                this.Hide();
            }
        }
        #endregion

        #region Animation
        internal void StartMe()
        {
            LoadLogin.Enabled = true;
        }

        internal void DotAnimation()
        {
            Dot1.Visible = BottomTaskBar.Value % 4 == 0;
            Dot2.Visible = BottomTaskBar.Value % 8 >= 4 && BottomTaskBar.Value % 8 <= 7;
            Dot3.Visible = BottomTaskBar.Value % 13 == 0 || BottomTaskBar.Value % 17 == 0 ||
                           BottomTaskBar.Value % 25 == 0 || BottomTaskBar.Value % 29 == 0 ||
                           BottomTaskBar.Value % 34 == 0 || BottomTaskBar.Value % 39 == 0 ||
                           BottomTaskBar.Value % 45 == 0 || BottomTaskBar.Value % 48 == 0 ||
                           BottomTaskBar.Value % 53 == 0 || BottomTaskBar.Value % 57 == 0 ||
                           BottomTaskBar.Value % 60 == 0 || BottomTaskBar.Value % 64 == 0 ||
                           BottomTaskBar.Value % 69 == 0 || BottomTaskBar.Value % 74 == 0 ||
                           BottomTaskBar.Value % 79 == 0 || BottomTaskBar.Value % 83 == 0 ||
                           BottomTaskBar.Value % 86 == 0 || BottomTaskBar.Value % 89 == 0 ||
                           BottomTaskBar.Value % 94 == 0 || BottomTaskBar.Value % 98 == 0 ||
                           BottomTaskBar.Value == 100;
        }
        #endregion
    }
}
