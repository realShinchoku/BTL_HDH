using System;
using System.Windows.Forms;

namespace BTL_HDH
{
    public partial class JPKey : Form
    {
        private KeyboardHook jpkeyapp;
        private bool status = false, isKatakana = false;

        public JPKey()
        {
            InitializeComponent();
            jpkeyapp = new KeyboardHook();
        }

        private void JPKey_Load(object sender, EventArgs e)
        {
            JPkeyApp();
        }

        private void typeOfCharbtn_Click(object sender, EventArgs e)
        {
            if (isKatakana)
            {
                isKatakana = false;
                btn_typeOfChar.Text = "Hiragana";
            }
            else
            {
                isKatakana = true;
                btn_typeOfChar.Text = "Katakana";
            }
            jpkeyapp.Uninstall();
            JPkeyApp();
        }

        private void JPKey_btn_Click(object sender, EventArgs e)
        {
            if (status)
            {
                jpkeyapp.Uninstall();
                status = false;
                btn_JPKey.Text = "Tắt";
            }
            else
            {
                status = true;
                jpkeyapp.Install(isKatakana);
                btn_JPKey.Text = "Bật";
            }
        }

        private void JPkeyApp()
        {
            if (status)
                jpkeyapp.Install(isKatakana);
            else
                jpkeyapp.Uninstall();
        }
    }
}