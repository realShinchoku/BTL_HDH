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
                            SendKeys.Send("き");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぎ");
                            break;
                        // case Keys.S:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("し");
                        //     break;
                        // case Keys.Z:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("ざ");
                        //     break;
                        // case Keys.T:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("た");
                        //     break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぢ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("に");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ひ");
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("び");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("み");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぴ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("り");
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
                            SendKeys.Send("く");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぐ");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("す");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ず");
                            break;
                        // case Keys.T:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("た");
                        //     break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("づ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぬ");
                            break;
                        // case Keys.H:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.S:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("しゃ");
                        //             break;
                        //         case Keys.C:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ちゃ");
                        //             break;
                        //         default: SendKeys.Send("は"); break;
                        //     }
                        //     break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぶ");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("む");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぷ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("る");
                            break;
                        // case Keys.Y:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.K:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("きゃ");
                        //             break;
                        //         case Keys.N:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("にゃ");
                        //             break;
                        //         case Keys.H:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ひゃ");
                        //             break;
                        //         case Keys.M:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("みゃ");
                        //             break;
                        //         case Keys.R:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("りゃ");
                        //             break;
                        //         case Keys.G:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぎゃ");
                        //             break;
                        //         case Keys.B:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("びゃ");
                        //             break;
                        //         case Keys.P:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぴゃ");
                        //             break;
                        //         default: SendKeys.Send("や"); break;
                        //     }
                        //     break;
                        // case Keys.J:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("じゃ");
                        //     break;
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
                            SendKeys.Send("け");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("げ");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("せ");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぜ");
                            break;
                        case Keys.T:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("て");
                            break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("で");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ね");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("へ");
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("べ");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("め");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぺ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("れ");
                            break;
                        // case Keys.E:
                        //     SendKeys.Send("え");
                        //     break;
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
                            SendKeys.Send("こ");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ご");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("そ");
                            break;
                        case Keys.Z: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぞ");
                            break;
                        case Keys.T: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("と");
                            break;
                        case Keys.D: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ど");
                            break;
                        case Keys.N: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("の");
                            break;
                        // case Keys.H:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.S:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("しゃ");
                        //             break;
                        //         case Keys.C:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ちゃ");
                        //             break;
                        //         default: SendKeys.Send("は"); break;
                        //     }
                        //     break;
                        case Keys.B: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぼ");
                            break;
                        case Keys.M: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("も");
                            break;
                        case Keys.P: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ぽ");
                            break;
                        case Keys.R: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ろ");
                            break;
                        // case Keys.Y:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.K:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("きゃ");
                        //             break;
                        //         case Keys.N:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("にゃ");
                        //             break;
                        //         case Keys.H:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ひゃ");
                        //             break;
                        //         case Keys.M:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("みゃ");
                        //             break;
                        //         case Keys.R:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("りゃ");
                        //             break;
                        //         case Keys.G:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぎゃ");
                        //             break;
                        //         case Keys.B:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("びゃ");
                        //             break;
                        //         case Keys.P:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぴゃ");
                        //             break;
                        //         default: SendKeys.Send("や"); break;
                        //     }
                        //     break;
                        // case Keys.J:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("じゃ");
                        //     break;
                        case Keys.W:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("を");
                            break;
                        // case Keys.O:
                        //     SendKeys.Send("う");
                        //     break;
                        default: SendKeys.Send("お"); break;
                    }
                    break;
                #endregion
                case Keys.N: SendKeys.Send("ん"); break;
                default: return false;
            }
            return true;
        }

        public bool sendCharKatakana()
        {
            switch (l[4])
            {
                #region âm a
                case Keys.A:
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("カ");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ガ");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("サ");
                            break;
                        case Keys.Z: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ザ");
                            break;
                        case Keys.T: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("タ");
                            break;
                        case Keys.D: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ダ");
                            break;
                        case Keys.N: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ナ");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.S:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("シャ");
                                    break;
                                case Keys.C:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("チャ");
                                    break;
                                default: SendKeys.Send("ハ"); break;
                            }
                            break;
                        case Keys.B: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("バ");
                            break;
                        case Keys.M: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("マ");
                            break;
                        case Keys.P: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("パ");
                            break;
                        case Keys.R: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ラ");
                            break;
                        case Keys.Y:
                            SendKeys.Send("{BACKSPACE}");
                            switch (l[2])
                            {
                                case Keys.K:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("キャ");
                                    break;
                                case Keys.N:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ニャ");
                                    break;
                                case Keys.H:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ヒャ");
                                    break;
                                case Keys.M:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ミャ");
                                    break;
                                case Keys.R:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("リャ");
                                    break;
                                case Keys.G:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ギャ");
                                    break;
                                case Keys.B:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ビャ");
                                    break;
                                case Keys.P:
                                    SendKeys.Send("{BACKSPACE}");
                                    SendKeys.Send("ピャ");
                                    break;
                                default: SendKeys.Send("ヤ"); break;
                            }
                            break;
                        case Keys.J:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ジャ");
                            break;
                        case Keys.W:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ワ");
                            break;
                        default: SendKeys.Send("ア"); break;
                    }
                    break;
#endregion

                #region âm i
                case Keys.I:
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("キ");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ギ");
                            break;
                        // case Keys.S:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("し");
                        //     break;
                        // case Keys.Z:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("ざ");
                        //     break;
                        // case Keys.T:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("た");
                        //     break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ヂ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ニ");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ヒ");
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ビ");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ミ");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ピ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("リ");
                            break;
                        default: SendKeys.Send("イ"); break;
                    }
                    break;
#endregion

                #region âm ư
                case Keys.U :
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ク");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("グ");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ス");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ズ");
                            break;
                        // case Keys.T:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("た");
                        //     break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ヅ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ヌ");
                            break;
                        // case Keys.H:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.S:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("しゃ");
                        //             break;
                        //         case Keys.C:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ちゃ");
                        //             break;
                        //         default: SendKeys.Send("は"); break;
                        //     }
                        //     break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ブ");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ム");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("プ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ル");
                            break;
                        // case Keys.Y:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.K:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("きゃ");
                        //             break;
                        //         case Keys.N:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("にゃ");
                        //             break;
                        //         case Keys.H:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ひゃ");
                        //             break;
                        //         case Keys.M:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("みゃ");
                        //             break;
                        //         case Keys.R:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("りゃ");
                        //             break;
                        //         case Keys.G:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぎゃ");
                        //             break;
                        //         case Keys.B:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("びゃ");
                        //             break;
                        //         case Keys.P:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぴゃ");
                        //             break;
                        //         default: SendKeys.Send("や"); break;
                        //     }
                        //     break;
                        // case Keys.J:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("じゃ");
                        //     break;
                        default: SendKeys.Send("ウ"); break;
                    }
                    break;
#endregion

                #region âm ê
                case Keys.E :
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ケ");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ゲ ");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("セ");
                            break;
                        case Keys.Z:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ゼ");
                            break;
                        case Keys.T:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("テ");
                            break;
                        case Keys.D:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("デ");
                            break;
                        case Keys.N:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ネ");
                            break;
                        case Keys.H:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ヘ");
                            break;
                        case Keys.B:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ベ");
                            break;
                        case Keys.M:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("メ");
                            break;
                        case Keys.P:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ペ");
                            break;
                        case Keys.R:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("レ");
                            break;
                        // case Keys.E:
                        //     SendKeys.Send("え");
                        //     break;
                        default: SendKeys.Send("エ"); break;
                    }
                    break;
                #endregion

                #region âm ô
                case Keys.O :
                    switch (l[3])
                    {
                        case Keys.K:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("コ");
                            break;
                        case Keys.G:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ゴ");
                            break;
                        case Keys.S:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ソ");
                            break;
                        case Keys.Z: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ゾ");
                            break;
                        case Keys.T: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ト");
                            break;
                        case Keys.D: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ド");
                            break;
                        case Keys.N: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ノ");
                            break;
                        // case Keys.H:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.S:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("しゃ");
                        //             break;
                        //         case Keys.C:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ちゃ");
                        //             break;
                        //         default: SendKeys.Send("は"); break;
                        //     }
                        //     break;
                        case Keys.B: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ボ");
                            break;
                        case Keys.M: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("モ");
                            break;
                        case Keys.P: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ポ");
                            break;
                        case Keys.R: 
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ロ");
                            break;
                        // case Keys.Y:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     switch (l[2])
                        //     {
                        //         case Keys.K:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("きゃ");
                        //             break;
                        //         case Keys.N:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("にゃ");
                        //             break;
                        //         case Keys.H:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ひゃ");
                        //             break;
                        //         case Keys.M:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("みゃ");
                        //             break;
                        //         case Keys.R:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("りゃ");
                        //             break;
                        //         case Keys.G:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぎゃ");
                        //             break;
                        //         case Keys.B:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("びゃ");
                        //             break;
                        //         case Keys.P:
                        //             SendKeys.Send("{BACKSPACE}");
                        //             SendKeys.Send("ぴゃ");
                        //             break;
                        //         default: SendKeys.Send("や"); break;
                        //     }
                        //     break;
                        // case Keys.J:
                        //     SendKeys.Send("{BACKSPACE}");
                        //     SendKeys.Send("じゃ");
                        //     break;
                        case Keys.W:
                            SendKeys.Send("{BACKSPACE}");
                            SendKeys.Send("ウォ");
                            break;
                        // case Keys.O:
                        //     SendKeys.Send("う");
                        //     break;
                        default: SendKeys.Send("オ"); break;
                    }
                    break;
                #endregion
                case Keys.N: SendKeys.Send("ン"); break;
                default: return false;
            }
            return true;
        }

    }
}
