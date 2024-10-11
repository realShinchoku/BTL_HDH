using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;

namespace JPKey;

[SuppressMessage("Interoperability", "CA1416:Validate platform compatibility")]
internal class JpChar
{
    private readonly List<Keys> _l;

    public JpChar(Queue<Keys> listOfCharacter)
    {
        _l = listOfCharacter.ToList();
    }

    private static void SendBackspace(int count = 1)
    {
        for (var i = 0; i < count; i++) SendKeys.Send("{BACKSPACE}");
    }

    private static bool SendCharacter(string character, int backspaceCount = 1)
    {
        try
        {
            SendBackspace(backspaceCount);
            SendKeys.Send(character);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool SendCharHiragana()
    {
        return _l[4] switch
        {
            Keys.A => SendHiragana(Keys.A),
            Keys.I => SendHiragana(Keys.I),
            Keys.U => SendHiragana(Keys.U),
            Keys.E => SendHiragana(Keys.E),
            Keys.O => SendHiragana(Keys.O),
            Keys.N => SendCharacter("ん"),
            _ => false
        };
    }

    private bool SendHiragana(Keys key)
    {
        return key switch
        {
            Keys.A => SendHiraganaA(),
            Keys.I => SendHiraganaI(),
            Keys.U => SendHiraganaU(),
            Keys.E => SendHiraganaE(),
            Keys.O => SendHiraganaO(),
            _ => false
        };
    }

    private bool SendHiraganaA()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("か"),
            Keys.G => SendCharacter("が"),
            Keys.S => SendCharacter("さ"),
            Keys.Z => SendCharacter("ざ"),
            Keys.T => SendCharacter("た"),
            Keys.D => SendCharacter("だ"),
            Keys.N => SendCharacter("な"),
            Keys.H => SendHiraganaH("は", "しゃ", "ちゃ"),
            Keys.B => SendCharacter("ば"),
            Keys.M => SendCharacter("ま"),
            Keys.P => SendCharacter("ぱ"),
            Keys.R => SendCharacter("ら"),
            Keys.Y => SendHiraganaY("や", "きゃ", "にゃ", "ひゃ", "みゃ", "りゃ", "ぎゃ", "びゃ", "ぴゃ"),
            Keys.J => SendCharacter("じゃ"),
            Keys.W => SendCharacter("わ"),
            _ => SendCharacter("あ", 0)
        };
    }

    private bool SendHiraganaI()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("き"),
            Keys.G => SendCharacter("ぎ"),
            Keys.D => SendCharacter("ぢ"),
            Keys.N => SendCharacter("に"),
            Keys.H => SendHiraganaH("ひ", "し", "ち"),
            Keys.B => SendCharacter("び"),
            Keys.M => SendCharacter("み"),
            Keys.P => SendCharacter("ぴ"),
            Keys.R => SendCharacter("り"),
            Keys.J => SendCharacter("じ"),
            _ => SendCharacter("い", 0)
        };
    }

    private bool SendHiraganaU()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("く"),
            Keys.G => SendCharacter("ぐ"),
            Keys.S => SendHiraganaS("す", "つ"),
            Keys.Z => SendCharacter("ず"),
            Keys.D => SendCharacter("づ"),
            Keys.N => SendCharacter("ぬ"),
            Keys.H => SendHiraganaH("ふ", "しゅ", "ちゅ"),
            Keys.F => SendCharacter("ふ"),
            Keys.B => SendCharacter("ぶ"),
            Keys.M => SendCharacter("む"),
            Keys.P => SendCharacter("ぷ"),
            Keys.R => SendCharacter("る"),
            Keys.Y => SendHiraganaY("ゆ", "きゅ", "にゅ", "ひゅ", "みゅ", "りゅ", "ぎゅ", "びゅ", "ぴゅ"),
            Keys.J => SendCharacter("じゅ"),
            _ => SendCharacter("う", 0)
        };
    }

    private bool SendHiraganaE()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("け"),
            Keys.G => SendCharacter("げ"),
            Keys.S => SendCharacter("せ"),
            Keys.Z => SendCharacter("ぜ"),
            Keys.T => SendCharacter("て"),
            Keys.D => SendCharacter("で"),
            Keys.N => SendCharacter("ね"),
            Keys.H => SendCharacter("へ"),
            Keys.B => SendCharacter("べ"),
            Keys.M => SendCharacter("め"),
            Keys.P => SendCharacter("ぺ"),
            Keys.R => SendCharacter("れ"),
            _ => SendCharacter("え", 0)
        };
    }

    private bool SendHiraganaO()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("こ"),
            Keys.G => SendCharacter("ご"),
            Keys.S => SendCharacter("そ"),
            Keys.Z => SendCharacter("ぞ"),
            Keys.T => SendCharacter("と"),
            Keys.D => SendCharacter("ど"),
            Keys.N => SendCharacter("の"),
            Keys.H => SendHiraganaH("ほ", "しょ", "ちょ"),
            Keys.B => SendCharacter("ぼ"),
            Keys.M => SendCharacter("も"),
            Keys.P => SendCharacter("ぽ"),
            Keys.R => SendCharacter("ろ"),
            Keys.Y => SendHiraganaY("よ", "きょ", "にょ", "ひょ", "みょ", "りょ", "ぎょ", "びょ", "ぴょ"),
            Keys.J => SendCharacter("じょ"),
            Keys.W => SendCharacter("を"),
            _ => SendCharacter("お", 0)
        };
    }

    public bool SendCharKatakana()
    {
        return _l[4] switch
        {
            Keys.A => SendKatakana(Keys.A),
            Keys.I => SendKatakana(Keys.I),
            Keys.U => SendKatakana(Keys.U),
            Keys.E => SendKatakana(Keys.E),
            Keys.O => SendKatakana(Keys.O),
            Keys.N => SendCharacter("ン"),
            _ => false
        };
    }

    private bool SendKatakana(Keys key)
    {
        return key switch
        {
            Keys.A => SendKatakanaA(),
            Keys.I => SendKatakanaI(),
            Keys.U => SendKatakanaU(),
            Keys.E => SendKatakanaE(),
            Keys.O => SendKatakanaO(),
            _ => false
        };
    }

    private bool SendKatakanaA()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("カ"),
            Keys.G => SendCharacter("ガ"),
            Keys.S => SendCharacter("サ"),
            Keys.Z => SendCharacter("ザ"),
            Keys.T => SendCharacter("タ"),
            Keys.D => SendCharacter("ダ"),
            Keys.N => SendCharacter("ナ"),
            Keys.H => SendKatakanaH("ハ", "シャ", "チャ"),
            Keys.B => SendCharacter("バ"),
            Keys.M => SendCharacter("マ"),
            Keys.P => SendCharacter("パ"),
            Keys.R => SendCharacter("ラ"),
            Keys.Y => SendKatakanaY("ヤ", "キャ", "ニャ", "ヒャ", "ミャ", "リャ", "ギャ", "ビャ", "ピャ"),
            Keys.J => SendCharacter("ジャ"),
            Keys.W => SendCharacter("ワ"),
            _ => SendCharacter("ア", 0)
        };
    }

    private bool SendKatakanaI()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("キ"),
            Keys.G => SendCharacter("ギ"),
            Keys.D => SendCharacter("ヂ"),
            Keys.N => SendCharacter("ニ"),
            Keys.H => SendKatakanaH("ヒ", "シ", "チ"),
            Keys.B => SendCharacter("ビ"),
            Keys.M => SendCharacter("ミ"),
            Keys.P => SendCharacter("ピ"),
            Keys.R => SendCharacter("リ"),
            Keys.J => SendCharacter("ジ"),
            _ => SendCharacter("イ", 0)
        };
    }

    private bool SendKatakanaU()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("ク"),
            Keys.G => SendCharacter("グ"),
            Keys.S => SendKatakanaS("ス", "ツ"),
            Keys.Z => SendCharacter("ズ"),
            Keys.D => SendCharacter("ヅ"),
            Keys.N => SendCharacter("ヌ"),
            Keys.H => SendKatakanaH("フ", "シュ", "チュ"),
            Keys.F => SendCharacter("フ"),
            Keys.B => SendCharacter("ブ"),
            Keys.M => SendCharacter("ム"),
            Keys.P => SendCharacter("プ"),
            Keys.R => SendCharacter("ル"),
            Keys.Y => SendKatakanaY("ユ", "キュ", "ニュ", "ヒュ", "ミュ", "リュ", "ギュ", "ビュ", "ピュ"),
            Keys.J => SendCharacter("ジュ"),
            _ => SendCharacter("ウ", 0)
        };
    }

    private bool SendKatakanaE()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("ケ"),
            Keys.G => SendCharacter("ゲ"),
            Keys.S => SendCharacter("セ"),
            Keys.Z => SendCharacter("ゼ"),
            Keys.T => SendCharacter("テ"),
            Keys.D => SendCharacter("デ"),
            Keys.N => SendCharacter("ネ"),
            Keys.H => SendCharacter("ヘ"),
            Keys.B => SendCharacter("ベ"),
            Keys.M => SendCharacter("メ"),
            Keys.P => SendCharacter("ペ"),
            Keys.R => SendCharacter("レ"),
            _ => SendCharacter("エ", 0)
        };
    }

    private bool SendKatakanaO()
    {
        return _l[3] switch
        {
            Keys.K => SendCharacter("コ"),
            Keys.G => SendCharacter("ゴ"),
            Keys.S => SendCharacter("ソ"),
            Keys.Z => SendCharacter("ゾ"),
            Keys.T => SendCharacter("ト"),
            Keys.D => SendCharacter("ド"),
            Keys.N => SendCharacter("ノ"),
            Keys.H => SendKatakanaH("ホ", "ショ", "チョ"),
            Keys.B => SendCharacter("ボ"),
            Keys.M => SendCharacter("モ"),
            Keys.P => SendCharacter("ポ"),
            Keys.R => SendCharacter("ロ"),
            Keys.Y => SendKatakanaY("ヨ", "キョ", "ニョ", "ヒョ", "ミョ", "リョ", "ギョ", "ビョ", "ピョ"),
            Keys.J => SendCharacter("ジョ"),
            Keys.W => SendCharacter("ウォ"),
            _ => SendCharacter("オ", 0)
        };
    }

    private bool SendHiraganaH(string defaultChar, string char1, string char2)
    {
        return _l[2] switch
        {
            Keys.S => SendCharacter(char1, 2),
            Keys.C => SendCharacter(char2, 2),
            _ => SendCharacter(defaultChar)
        };
    }

    private bool SendHiraganaY(string defaultChar, string char1, string char2, string char3, string char4, string char5, string char6, string char7, string char8)
    {
        return _l[2] switch
        {
            Keys.K => SendCharacter(char1),
            Keys.N => SendCharacter(char2),
            Keys.H => SendCharacter(char3),
            Keys.M => SendCharacter(char4),
            Keys.R => SendCharacter(char5),
            Keys.G => SendCharacter(char6),
            Keys.B => SendCharacter(char7),
            Keys.P => SendCharacter(char8),
            _ => SendCharacter(defaultChar, 0)
        };
    }

    private bool SendHiraganaS(string defaultChar, string char1)
    {
        return _l[2] switch
        {
            Keys.T => SendCharacter(char1, 2),
            _ => SendCharacter(defaultChar)
        };
    }

    private bool SendKatakanaH(string defaultChar, string char1, string char2)
    {
        return _l[2] switch
        {
            Keys.S => SendCharacter(char1, 2),
            Keys.C => SendCharacter(char2, 2),
            _ => SendCharacter(defaultChar)
        };
    }

    private bool SendKatakanaY(string defaultChar, string char1, string char2, string char3, string char4, string char5, string char6, string char7, string char8)
    {
        return _l[2] switch
        {
            Keys.K => SendCharacter(char1),
            Keys.N => SendCharacter(char2),
            Keys.H => SendCharacter(char3),
            Keys.M => SendCharacter(char4),
            Keys.R => SendCharacter(char5),
            Keys.G => SendCharacter(char6),
            Keys.B => SendCharacter(char7),
            Keys.P => SendCharacter(char8),
            _ => SendCharacter(defaultChar, 0)
        };
    }

    private bool SendKatakanaS(string defaultChar, string char1)
    {
        return _l[2] switch
        {
            Keys.T => SendCharacter(char1, 2),
            _ => SendCharacter(defaultChar)
        };
    }
}