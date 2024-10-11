using System;
using System.Windows.Forms;

namespace JPKey;

public partial class JpKey : Form
{
    private readonly KeyboardHook _jpKeyApp;
    private bool _status, _isKatakana;

    public JpKey()
    {
        InitializeComponent();
        _jpKeyApp = new KeyboardHook();
    }

    private void JPKey_Load(object sender, EventArgs e)
    {
        JPkeyApp();
    }

    private void typeOfBtnChar_Click(object sender, EventArgs e)
    {
        if (_isKatakana)
        {
            _isKatakana = false;
            btn_typeOfChar.Text = @"Hiragana";
        }
        else
        {
            _isKatakana = true;
            btn_typeOfChar.Text = @"Katakana";
        }

        _jpKeyApp.Uninstall();
        JPkeyApp();
    }

    private void JPKey_btn_Click(object sender, EventArgs e)
    {
        if (_status)
        {
            _jpKeyApp.Uninstall();
            _status = false;
            btn_JPKey.Text = @"Tắt";
        }
        else
        {
            _status = true;
            _jpKeyApp.Install(_isKatakana);
            btn_JPKey.Text = @"Bật";
        }
    }

    private void JPkeyApp()
    {
        if (_status)
            _jpKeyApp.Install(_isKatakana);
        else
            _jpKeyApp.Uninstall();
    }
}