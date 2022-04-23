using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HDH
{
    class JPChar
    {
        private List<Keys> l = new List<Keys>() { 0, 0, 0, 0, 0 };
        private bool isKatakana = false;
        public JPChar(List<Keys> listOfCharater, bool isKatakana = false) 
        {
            this.l = listOfCharater;
            this.isKatakana = isKatakana;
        }

        public bool sendChar()
        {
            switch (l[4])
            {
                #region âm a
                case Keys.A:
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("か");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("が");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("さ");
                            break;
                        case Keys.Z: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ざ");
                            break;
                        case Keys.T: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("た");
                            break;
                        case Keys.D: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("だ");
                            break;
                        case Keys.N: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("な");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.S:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("しゃ");
                                    break;
                                case Keys.C:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ちゃ");
                                    break;
                                default: SendKeys.Send("は"); break;
                            }
                            break;
                        case Keys.B: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ば");
                            break;
                        case Keys.M: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ま");
                            break;
                        case Keys.P: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぱ");
                            break;
                        case Keys.R: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ら");
                            break;
                        case Keys.Y:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.K:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("きゃ");
                                    break;
                                case Keys.N:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("にゃ");
                                    break;
                                case Keys.H:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ひゃ");
                                    break;
                                case Keys.M:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("みゃ");
                                    break;
                                case Keys.R:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("りゃ");
                                    break;
                                case Keys.G:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ぎゃ");
                                    break;
                                case Keys.B:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("びゃ");
                                    break;
                                case Keys.P:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ぴゃ");
                                    break;
                                default: SendKeys.Send("や"); break;
                            }
                            break;
                        case Keys.J:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("じゃ");
                            break;
                        case Keys.W:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("わ");
                            break;
                        default: SendKeys.Send("あ"); break;
                    }
                    break;
#endregion

                #region âm i
                case Keys.I:
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("か");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("が");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("さ");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ざ");
                            break;
                        case Keys.T:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("た");
                            break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("だ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("な");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("は");
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ば");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ま");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぱ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ら");
                            break;
                        default: SendKeys.Send("い"); break;
                    }
                    break;
#endregion

                #region âm ư
                case Keys.U :
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("か");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("が");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("さ");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ざ");
                            break;
                        case Keys.T:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("た");
                            break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("だ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("な");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.S:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("しゃ");
                                    break;
                                case Keys.C:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ちゃ");
                                    break;
                                default: SendKeys.Send("は"); break;
                            }
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ば");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ま");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぱ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ら");
                            break;
                        case Keys.Y:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.K:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("きゃ");
                                    break;
                                case Keys.N:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("にゃ");
                                    break;
                                case Keys.H:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ひゃ");
                                    break;
                                case Keys.M:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("みゃ");
                                    break;
                                case Keys.R:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("りゃ");
                                    break;
                                case Keys.G:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ぎゃ");
                                    break;
                                case Keys.B:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("びゃ");
                                    break;
                                case Keys.P:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ぴゃ");
                                    break;
                                default: SendKeys.Send("や"); break;
                            }
                            break;
                        case Keys.J:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("じゃ");
                            break;
                        default: SendKeys.Send("う"); break;
                    }
                    break;
#endregion

                #region âm ê
                case Keys.E :
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("か");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("が");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("さ");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ざ");
                            break;
                        case Keys.T:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("た");
                            break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("だ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("な");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("は");
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ば");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ま");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぱ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ら");
                            break;
                        case Keys.E:
                            SendKeys.Send("い");
                            break;
                        default: SendKeys.Send("え"); break;
                    }
                    break;
                #endregion

                #region âm ô
                case Keys.O :
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("か");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("が");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("さ");
                            break;
                        case Keys.Z: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ざ");
                            break;
                        case Keys.T: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("た");
                            break;
                        case Keys.D: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("だ");
                            break;
                        case Keys.N: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("な");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.S:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("しゃ");
                                    break;
                                case Keys.C:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ちゃ");
                                    break;
                                default: SendKeys.Send("は"); break;
                            }
                            break;
                        case Keys.B: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ば");
                            break;
                        case Keys.M: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ま");
                            break;
                        case Keys.P: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぱ");
                            break;
                        case Keys.R: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ら");
                            break;
                        case Keys.Y:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.K:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("きゃ");
                                    break;
                                case Keys.N:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("にゃ");
                                    break;
                                case Keys.H:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ひゃ");
                                    break;
                                case Keys.M:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("みゃ");
                                    break;
                                case Keys.R:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("りゃ");
                                    break;
                                case Keys.G:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ぎゃ");
                                    break;
                                case Keys.B:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("びゃ");
                                    break;
                                case Keys.P:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ぴゃ");
                                    break;
                                default: SendKeys.Send("や"); break;
                            }
                            break;
                        case Keys.J:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("じゃ");
                            break;
                        case Keys.W:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("わ");
                            break;
                        case Keys.O:
                            SendKeys.Send("う");
                            break;
                        default: SendKeys.Send("お"); break;
                    }
                    break;
                #endregion
                case Keys.N: SendKeys.Send("ん"); break;
                default: return false;
            }
            return true;
        }

    }
}
