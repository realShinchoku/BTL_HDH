using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JPKey;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
internal class KeyboardHook
{
    public delegate IntPtr KeyboardHookDelegate(int nCode, IntPtr wParam, IntPtr lParam);

    private readonly Queue<Keys> _listOfKeys = new();
    private IntPtr _hookHandle = IntPtr.Zero;

    private KeyboardHookDelegate _hookProc;

    private bool _isKatakana;

    public KeyboardHook()
    {
        _listOfKeys.Enqueue(Keys.None);
        _listOfKeys.Enqueue(Keys.None);
        _listOfKeys.Enqueue(Keys.None);
        _listOfKeys.Enqueue(Keys.None);
        _listOfKeys.Enqueue(Keys.None);
    }

    // destructor
    ~KeyboardHook()
    {
        Uninstall();
    }

    public void Install(bool isKatakana = false)
    {
        _isKatakana = isKatakana;
        _hookProc = KeyboardHookProc;
        _hookHandle = SetupHook(_hookProc);
        if (_hookHandle == IntPtr.Zero)
            throw new Win32Exception(Marshal.GetLastWin32Error());
    }

    private IntPtr SetupHook(KeyboardHookDelegate hookProc)
    {
        var hInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);

        return SetWindowsHookEx(WhKeyboardLl, hookProc, hInstance, 0);
    }

    private IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0)
        {
            var virtualKey = Marshal.ReadInt32(lParam);

            if (wParam == WmKeydown)
            {
                _listOfKeys.Enqueue((Keys)virtualKey);
                if (_listOfKeys.Count > 5)
                    _listOfKeys.Dequeue();
                var jpChar = new JpChar(_listOfKeys);
                if (_isKatakana ? jpChar.SendCharKatakana() : jpChar.SendCharHiragana())
                    return 1;
            }
        }

        return CallNextHookEx(_hookHandle, nCode, wParam, lParam);
    }

    public void Uninstall()
    {
        UnhookWindowsHookEx(_hookHandle);
    }

    #region Khởi tạo các hàm từ thư viện win32

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, KeyboardHookDelegate lpfn, IntPtr hMod, int dwThreadId);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    private const int WhKeyboardLl = 13;

    private const int WmKeydown = 0x0100;

    #endregion Khởi tạo các hàm từ thư viện win32
}