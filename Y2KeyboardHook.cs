using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;

namespace BTL_HDH
{

    class Y2KeyboardHook
    {

        #region Win32 API Functions and Constants

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            KeyboardHookDelegate lpfn, IntPtr hMod, int dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private const int WH_KEYBOARD_LL = 13;

        private const int WM_KEYDOWN = 0x0100;

        #endregion

        private bool status = false, isKatakana = false;

        private List<Keys> listOfCharater = new List<Keys>() {0,0,0,0,0 };

        private KeyboardHookDelegate _hookProc;
        private IntPtr _hookHandle = IntPtr.Zero;

        public delegate IntPtr KeyboardHookDelegate(int nCode, IntPtr wParam, IntPtr lParam);

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardHookStruct
        {
            public int VirtualKeyCode;
            public int ScanCode;
            public int Flags;
            public int Time;
            public int ExtraInfo;
        }

        // constructor
        public Y2KeyboardHook(bool status = false, bool isKatakana = false)
        {
            this.status = status;
            this.isKatakana = isKatakana;
        }


        // destructor
        ~Y2KeyboardHook()
        {
            Uninstall();
        }

        public void Install()
        {
            _hookProc = KeyboardHookProc;
            _hookHandle = SetupHook(_hookProc);

            if (_hookHandle == IntPtr.Zero)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }
        private IntPtr SetupHook(KeyboardHookDelegate hookProc)
        {
            IntPtr hInstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);

            return SetWindowsHookEx(WH_KEYBOARD_LL, hookProc, hInstance, 0);
        }

        private IntPtr KeyboardHookProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                KeyboardHookStruct kbStruct = (KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHookStruct));

                if (wParam == (IntPtr)WM_KEYDOWN)
                {
                    if ((int)kbStruct.VirtualKeyCode >= 65 && (int)kbStruct.VirtualKeyCode <= 90)
                    {
                        listOfCharater.Add((Keys)kbStruct.VirtualKeyCode);
                        if (listOfCharater.Count > 5)
                            listOfCharater.RemoveAt(0);
                        JPChar jpchar = new JPChar(listOfCharater, isKatakana);
                        if (jpchar.sendChar())
                            return (IntPtr)1;
                    }
                }
            }

            return CallNextHookEx(_hookHandle, nCode, wParam, lParam);
        }
       

        public void Uninstall()
        {
            UnhookWindowsHookEx(_hookHandle);
        }

    }
}