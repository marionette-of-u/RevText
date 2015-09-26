using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Text.RegularExpressions;

namespace RevText
{
    static class Program
    {
        static Form1 form;

        // 設定ファイル名
        static string configFileName = "config.txt";

        // ホットキー
        public static Keys hotKey;

        // ホットキーを透過する
        public static bool through;

        // 旧仮名に変換する
        public static bool qKana;

        // 旧字に変換する
        public static bool qJi;

        // 文字参照コードに変換する
        public static bool translateCode;

        public static void WriteConfig()
        {
            using (StreamWriter sw = new StreamWriter(configFileName, false, Encoding.GetEncoding("UTF-8"))) {
                sw.WriteLine(hotKey.ToString());
                sw.WriteLine(through.ToString());
                sw.WriteLine(qKana.ToString());
                sw.WriteLine(qJi.ToString());
                sw.WriteLine(translateCode.ToString());
            }
        }

        public static void ReadConfig(Form1 f)
        {
            form = f;
            while (true)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(configFileName))
                    {
                        // ホットキーの読み込み
                        switch (sr.ReadLine())
                        {
                            case "A":
                            case "a":
                                hotKey = Keys.A;
                                break;

                            case "B":
                            case "b":
                                hotKey = Keys.B;
                                break;

                            case "C":
                            case "c":
                                hotKey = Keys.C;
                                break;

                            case "D":
                            case "d":
                                hotKey = Keys.D;
                                break;

                            case "E":
                            case "e":
                                hotKey = Keys.E;
                                break;

                            case "F":
                            case "f":
                                hotKey = Keys.F;
                                break;

                            case "G":
                            case "g":
                                hotKey = Keys.G;
                                break;

                            case "H":
                            case "h":
                                hotKey = Keys.H;
                                break;

                            case "I":
                            case "i":
                                hotKey = Keys.I;
                                break;

                            case "J":
                            case "j":
                                hotKey = Keys.J;
                                break;

                            case "K":
                            case "k":
                                hotKey = Keys.K;
                                break;

                            case "L":
                            case "l":
                                hotKey = Keys.L;
                                break;

                            case "M":
                            case "m":
                                hotKey = Keys.M;
                                break;

                            case "N":
                            case "n":
                                hotKey = Keys.N;
                                break;

                            case "O":
                            case "o":
                                hotKey = Keys.O;
                                break;

                            case "P":
                            case "p":
                                hotKey = Keys.P;
                                break;

                            case "Q":
                            case "q":
                                hotKey = Keys.Q;
                                break;

                            case "R":
                            case "r":
                                hotKey = Keys.R;
                                break;

                            case "S":
                            case "s":
                                hotKey = Keys.S;
                                break;

                            case "T":
                            case "t":
                                hotKey = Keys.T;
                                break;

                            case "U":
                            case "u":
                                hotKey = Keys.U;
                                break;

                            case "V":
                            case "v":
                                hotKey = Keys.V;
                                break;

                            case "W":
                            case "w":
                                hotKey = Keys.W;
                                break;

                            case "X":
                            case "x":
                                hotKey = Keys.X;
                                break;

                            case "Y":
                            case "y":
                                hotKey = Keys.Y;
                                break;

                            case "Z":
                            case "z":
                                hotKey = Keys.Z;
                                break;

                            case "1":
                                hotKey = Keys.D1;
                                break;

                            case "2":
                                hotKey = Keys.D2;
                                break;

                            case "3":
                                hotKey = Keys.D3;
                                break;

                            case "4":
                                hotKey = Keys.D4;
                                break;

                            case "5":
                                hotKey = Keys.D5;
                                break;

                            case "6":
                                hotKey = Keys.D6;
                                break;

                            case "7":
                                hotKey = Keys.D7;
                                break;

                            case "8":
                                hotKey = Keys.D8;
                                break;

                            case "9":
                                hotKey = Keys.D9;
                                break;

                            case "0":
                                hotKey = Keys.D0;
                                break;

                            case "F1":
                                hotKey = Keys.F1;
                                break;

                            case "F2":
                                hotKey = Keys.F2;
                                break;

                            case "F3":
                                hotKey = Keys.F3;
                                break;

                            case "F4":
                                hotKey = Keys.F4;
                                break;

                            case "F5":
                                hotKey = Keys.F5;
                                break;

                            case "F6":
                                hotKey = Keys.F6;
                                break;

                            case "F7":
                                hotKey = Keys.F7;
                                break;

                            case "F8":
                                hotKey = Keys.F8;
                                break;

                            case "F9":
                                hotKey = Keys.F9;
                                break;

                            case "F10":
                                hotKey = Keys.F10;
                                break;

                            case "F11":
                                hotKey = Keys.F11;
                                break;

                            case "F12":
                                hotKey = Keys.F12;
                                break;

                            default:
                                throw new Exception();
                        }

                        // キー透過の読み込み
                        through = bool.Parse(sr.ReadLine());
                        f.throughHotKeyToolStripMenuItem.Checked = through;

                        // 旧仮名変換の読み込み
                        qKana = bool.Parse(sr.ReadLine());
                        f.kanaToolStripMenuItem.Checked = qKana;

                        // 旧字変換の読み込み
                        qJi = bool.Parse(sr.ReadLine());
                        f.kanjiToolStripMenuItem.Checked = qJi;

                        // 文字参照コード変換の読み込み
                        translateCode = bool.Parse(sr.ReadLine());
                        f.translateCodeToolStripMenuItem.Checked = translateCode;
                    }
                }
                catch (Exception)
                {
                    WriteDefault();
                    continue;
                }

                break;
            }
        }

        static void WriteDefault()
        {
            hotKey = Keys.Q;
            through = false;
            qKana = true;
            qJi = true;
            translateCode = true;

            WriteConfig();
        }

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //ShinjiToQji("祈れ！");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form = new Form1());
        }

        static public string RevProc(string str)
        {
            str = str.Replace("\r\n", "\n");
            string[] array = str.Split('\n');
            string rev = "";
            string q = "";
            for (int i = 0; i < array.Length; ++i)
            {
                if (i != 0)
                {
                    rev += "\r\n";
                }
                rev += Reverse(HiraToKana(RevAlpha(array[i])));
            }
            q = ShinjiToQji(rev);
            return q;
        }

        static string ShinjiToQji(string str)
        {
            if (!qJi)
            {
                return str;
            }
            int length = str.Length;
            byte[] unicodeByteStr = new byte[(length + 3) * 5];
            int unicodeByteStrCounter = 0;
            char[] charArray = new char[length];
            for (int i = 0; i < str.Length; ++i)
            {
                UInt16 charCode = (UInt16)str[i];
                int n = Search(charCode, neworderNew);
                if (n < 0)
                {
                    unicodeByteStr[unicodeByteStrCounter + 0] = (byte)(charCode & 0xFF);
                    unicodeByteStr[unicodeByteStrCounter + 1] = (byte)((charCode >> 8) & 0xFF);
                    unicodeByteStrCounter += 2;
                }
                else
                {
                    UInt16 a = neworderOld[n];
                    if (/*translateCode*/ true)
                    {
                        string code = "&#" + a.ToString() + ";";
                        for (int j = 0; j < code.Length; ++j)
                        {
                            UInt16 c = (UInt16)code[j];
                            unicodeByteStr[unicodeByteStrCounter + 0] = (byte)(c & 0xFF);
                            unicodeByteStr[unicodeByteStrCounter + 1] = (byte)((c >> 8) & 0xFF);
                            unicodeByteStrCounter += 2;
                        }
                    }
                    else
                    {
                        unicodeByteStr[unicodeByteStrCounter + 0] = (byte)(a & 0xFF);
                        unicodeByteStr[unicodeByteStrCounter + 1] = (byte)((a >> 8) & 0xFF);
                        unicodeByteStrCounter += 2;
                    }
                }
            }
            System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding();
            byte[] utf8Bytes = System.Text.Encoding.Convert(new System.Text.UnicodeEncoding(), utf8, unicodeByteStr, 0, unicodeByteStrCounter);
            char[] utf8Chars = new char[utf8.GetCharCount(utf8Bytes)];
            utf8Chars = utf8.GetChars(utf8Bytes, 0, utf8Bytes.Length);
            return new string(utf8Chars);
        }
        
        static int Search(UInt16 value, UInt16[] table)
        {
            int mid, left = 0, right = table.Length;
            while (left < right)
            {
                if (table[mid = (left + right) >> 1] < value)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            if (left < table.Length && table[left] == value)
            {
                return left;
            }
            return -1;
        }
        
        static string RevAlpha(string str)
        {
            string ret = str;
            Regex r = new Regex(@"[a-zA-Z]+");
            MatchCollection collection = r.Matches(str);
            foreach (Match m in collection)
            {
                int n = m.Groups[0].Value.Length + m.Groups[0].Index;
                ret = ret.Substring(0, m.Groups[0].Index) + Reverse(m.Groups[0].Value) + ret.Substring(n, ret.Length - n);
            }
            return ret;
        }

        static string Reverse(string str)
        {
            string ret = "";
            for (int i = 0; i < str.Length; ++i)
            {
                ret += str[str.Length - i - 1];
            }
            return ret;
        }

        static string HiraToKana(string str)
        {
            string ret = "";
            foreach (char c in str)
            {
                if (qKana)
                {
                    if (c == 'あ') { ret += 'ア'; continue; }
                    if (c == 'い') { ret += 'ヰ'; continue; }
                    if (c == 'う') { ret += 'ウ'; continue; }
                    if (c == 'え') { ret += 'ヱ'; continue; }
                    if (c == 'お') { ret += 'ヲ'; continue; }
                    if (c == 'か') { ret += 'カ'; continue; }
                    if (c == 'き') { ret += 'キ'; continue; }
                    if (c == 'く') { ret += 'ク'; continue; }
                    if (c == 'け') { ret += 'ケ'; continue; }
                    if (c == 'こ') { ret += 'コ'; continue; }
                    if (c == 'が') { ret += 'ガ'; continue; }
                    if (c == 'ぎ') { ret += 'ギ'; continue; }
                    if (c == 'ぐ') { ret += 'グ'; continue; }
                    if (c == 'げ') { ret += 'ゲ'; continue; }
                    if (c == 'ご') { ret += 'ゴ'; continue; }
                    if (c == 'さ') { ret += 'サ'; continue; }
                    if (c == 'し') { ret += 'シ'; continue; }
                    if (c == 'す') { ret += 'ス'; continue; }
                    if (c == 'せ') { ret += 'セ'; continue; }
                    if (c == 'そ') { ret += 'ソ'; continue; }
                    if (c == 'ざ') { ret += 'ザ'; continue; }
                    if (c == 'じ') { ret += 'ジ'; continue; }
                    if (c == 'ず') { ret += 'ズ'; continue; }
                    if (c == 'ぜ') { ret += 'ゼ'; continue; }
                    if (c == 'ぞ') { ret += 'ゾ'; continue; }
                    if (c == 'た') { ret += 'タ'; continue; }
                    if (c == 'ち') { ret += 'チ'; continue; }
                    if (c == 'つ') { ret += 'ツ'; continue; }
                    if (c == 'て') { ret += 'テ'; continue; }
                    if (c == 'と') { ret += 'ト'; continue; }
                    if (c == 'だ') { ret += 'ダ'; continue; }
                    if (c == 'ぢ') { ret += 'ヂ'; continue; }
                    if (c == 'づ') { ret += 'ヅ'; continue; }
                    if (c == 'で') { ret += 'デ'; continue; }
                    if (c == 'ど') { ret += 'ド'; continue; }
                    if (c == 'な') { ret += 'ナ'; continue; }
                    if (c == 'に') { ret += 'ニ'; continue; }
                    if (c == 'ぬ') { ret += 'ヌ'; continue; }
                    if (c == 'ね') { ret += 'ネ'; continue; }
                    if (c == 'の') { ret += 'ノ'; continue; }
                    if (c == 'は') { ret += 'ハ'; continue; }
                    if (c == 'ひ') { ret += 'ヒ'; continue; }
                    if (c == 'ふ') { ret += 'フ'; continue; }
                    if (c == 'へ') { ret += 'ヘ'; continue; }
                    if (c == 'ほ') { ret += 'ホ'; continue; }
                    if (c == 'ば') { ret += 'バ'; continue; }
                    if (c == 'び') { ret += 'ビ'; continue; }
                    if (c == 'ぶ') { ret += 'ブ'; continue; }
                    if (c == 'べ') { ret += 'ベ'; continue; }
                    if (c == 'ぼ') { ret += 'ボ'; continue; }
                    if (c == 'ぱ') { ret += 'パ'; continue; }
                    if (c == 'ぴ') { ret += 'ピ'; continue; }
                    if (c == 'ぷ') { ret += 'プ'; continue; }
                    if (c == 'ぺ') { ret += 'ペ'; continue; }
                    if (c == 'ぽ') { ret += 'ポ'; continue; }
                    if (c == 'ま') { ret += 'マ'; continue; }
                    if (c == 'み') { ret += 'ミ'; continue; }
                    if (c == 'む') { ret += 'ム'; continue; }
                    if (c == 'め') { ret += 'メ'; continue; }
                    if (c == 'も') { ret += 'モ'; continue; }
                    if (c == 'や') { ret += 'ヤ'; continue; }
                    if (c == 'ゆ') { ret += 'ユ'; continue; }
                    if (c == 'よ') { ret += 'ヨ'; continue; }
                    if (c == 'ら') { ret += 'ラ'; continue; }
                    if (c == 'り') { ret += 'リ'; continue; }
                    if (c == 'る') { ret += 'ル'; continue; }
                    if (c == 'れ') { ret += 'レ'; continue; }
                    if (c == 'ろ') { ret += 'ロ'; continue; }
                    if (c == 'わ') { ret += 'ワ'; continue; }
                    if (c == 'を') { ret += 'ヲ'; continue; }
                    if (c == 'ん') { ret += 'ン'; continue; }
                    if (c == 'ア') { ret += 'あ'; continue; }
                    if (c == 'ヰ' || c == 'イ') { ret += 'い'; continue; }
                    if (c == 'ウ') { ret += 'う'; continue; }
                    if (c == 'ヱ' || c == 'エ') { ret += 'え'; continue; }
                    if (c == 'ヲ' || c == 'オ') { ret += 'お'; continue; }
                    if (c == 'カ') { ret += 'か'; continue; }
                    if (c == 'キ') { ret += 'き'; continue; }
                    if (c == 'ク') { ret += 'く'; continue; }
                    if (c == 'ケ') { ret += 'け'; continue; }
                    if (c == 'コ') { ret += 'こ'; continue; }
                    if (c == 'ガ') { ret += 'が'; continue; }
                    if (c == 'ギ') { ret += 'ぎ'; continue; }
                    if (c == 'グ') { ret += 'ぐ'; continue; }
                    if (c == 'ゲ') { ret += 'げ'; continue; }
                    if (c == 'ゴ') { ret += 'ご'; continue; }
                    if (c == 'サ') { ret += 'さ'; continue; }
                    if (c == 'シ') { ret += 'し'; continue; }
                    if (c == 'ス') { ret += 'す'; continue; }
                    if (c == 'セ') { ret += 'せ'; continue; }
                    if (c == 'ソ') { ret += 'そ'; continue; }
                    if (c == 'ザ') { ret += 'ざ'; continue; }
                    if (c == 'ジ') { ret += 'じ'; continue; }
                    if (c == 'ズ') { ret += 'ず'; continue; }
                    if (c == 'ゼ') { ret += 'ぜ'; continue; }
                    if (c == 'ゾ') { ret += 'ぞ'; continue; }
                    if (c == 'タ') { ret += 'た'; continue; }
                    if (c == 'チ') { ret += 'ち'; continue; }
                    if (c == 'ツ') { ret += 'つ'; continue; }
                    if (c == 'テ') { ret += 'て'; continue; }
                    if (c == 'ト') { ret += 'と'; continue; }
                    if (c == 'ダ') { ret += 'だ'; continue; }
                    if (c == 'ヂ') { ret += 'ぢ'; continue; }
                    if (c == 'ヅ') { ret += 'づ'; continue; }
                    if (c == 'デ') { ret += 'で'; continue; }
                    if (c == 'ド') { ret += 'ど'; continue; }
                    if (c == 'ナ') { ret += 'な'; continue; }
                    if (c == 'ニ') { ret += 'に'; continue; }
                    if (c == 'ヌ') { ret += 'ぬ'; continue; }
                    if (c == 'ネ') { ret += 'ね'; continue; }
                    if (c == 'ノ') { ret += 'の'; continue; }
                    if (c == 'ハ') { ret += 'は'; continue; }
                    if (c == 'ヒ') { ret += 'ひ'; continue; }
                    if (c == 'フ') { ret += 'ふ'; continue; }
                    if (c == 'ヘ') { ret += 'へ'; continue; }
                    if (c == 'ホ') { ret += 'ほ'; continue; }
                    if (c == 'バ') { ret += 'ば'; continue; }
                    if (c == 'ビ') { ret += 'び'; continue; }
                    if (c == 'ブ') { ret += 'ぶ'; continue; }
                    if (c == 'ベ') { ret += 'べ'; continue; }
                    if (c == 'ボ') { ret += 'ぼ'; continue; }
                    if (c == 'パ') { ret += 'ぱ'; continue; }
                    if (c == 'ピ') { ret += 'ぴ'; continue; }
                    if (c == 'プ') { ret += 'ぷ'; continue; }
                    if (c == 'ペ') { ret += 'ぺ'; continue; }
                    if (c == 'ポ') { ret += 'ぽ'; continue; }
                    if (c == 'マ') { ret += 'ま'; continue; }
                    if (c == 'ミ') { ret += 'み'; continue; }
                    if (c == 'ム') { ret += 'む'; continue; }
                    if (c == 'メ') { ret += 'め'; continue; }
                    if (c == 'モ') { ret += 'も'; continue; }
                    if (c == 'ヤ') { ret += 'や'; continue; }
                    if (c == 'ユ') { ret += 'ゆ'; continue; }
                    if (c == 'ヨ') { ret += 'よ'; continue; }
                    if (c == 'ラ') { ret += 'ら'; continue; }
                    if (c == 'リ') { ret += 'り'; continue; }
                    if (c == 'ル') { ret += 'る'; continue; }
                    if (c == 'レ') { ret += 'れ'; continue; }
                    if (c == 'ロ') { ret += 'ろ'; continue; }
                    if (c == 'ワ') { ret += 'わ'; continue; }
                    if (c == 'ヲ') { ret += 'を'; continue; }
                    if (c == 'ン') { ret += 'ん'; continue; }
                    if (c == 'ぁ') { ret += 'ァ'; continue; }
                    if (c == 'ァ') { ret += 'ぁ'; continue; }
                    if (c == 'ぃ') { ret += 'ィ'; continue; }
                    if (c == 'ィ') { ret += 'ぃ'; continue; }
                    if (c == 'ぅ') { ret += 'ゥ'; continue; }
                    if (c == 'ゥ') { ret += 'ぅ'; continue; }
                    if (c == 'ぇ') { ret += 'ェ'; continue; }
                    if (c == 'ぉ') { ret += 'ォ'; continue; }
                    if (c == 'ォ') { ret += 'ぉ'; continue; }
                    if (c == 'っ') { ret += 'ッ'; continue; }
                    if (c == 'ッ') { ret += 'っ'; continue; }
                    if (c == 'ゃ') { ret += 'ャ'; continue; }
                    if (c == 'ャ') { ret += 'ゃ'; continue; }
                    if (c == 'ゅ') { ret += 'ュ'; continue; }
                    if (c == 'ュ') { ret += 'ゅ'; continue; }
                    if (c == 'ょ') { ret += 'ョ'; continue; }
                    if (c == 'ョ') { ret += 'ょ'; continue; }
                    if (c == 'ゎ') { ret += 'ヮ'; continue; }
                    if (c == 'ヮ') { ret += 'ゎ'; continue; }
                }
                if (c == '0' || c == '０') { ret += '〇'; continue; }
                if (c == '1' || c == '１') { ret += '一'; continue; }
                if (c == '2' || c == '２') { ret += '二'; continue; }
                if (c == '3' || c == '３') { ret += '三'; continue; }
                if (c == '4' || c == '４') { ret += '四'; continue; }
                if (c == '5' || c == '５') { ret += '五'; continue; }
                if (c == '6' || c == '６') { ret += '六'; continue; }
                if (c == '7' || c == '７') { ret += '七'; continue; }
                if (c == '8' || c == '８') { ret += '八'; continue; }
                if (c == '9' || c == '９') { ret += '九'; continue; }
                if (c == '（') { ret += '）'; continue; }
                if (c == '〔') { ret += '〕'; continue; }
                if (c == '『') { ret += '』'; continue; }
                if (c == '〈') { ret += '〉'; continue; }
                if (c == '《') { ret += '》'; continue; }
                if (c == '【') { ret += '】'; continue; }
                if (c == '［') { ret += '］'; continue; }
                if (c == '｛') { ret += '｝'; continue; }
                if (c == '「') { ret += '」'; continue; }
                if (c == '＜') { ret += '＞'; continue; }
                if (c == '）') { ret += '（'; continue; }
                if (c == '〕') { ret += '〔'; continue; }
                if (c == '』') { ret += '『'; continue; }
                if (c == '〉') { ret += '〈'; continue; }
                if (c == '》') { ret += '《'; continue; }
                if (c == '】') { ret += '【'; continue; }
                if (c == '］') { ret += '｛'; continue; }
                if (c == '｝') { ret += '｛'; continue; }
                if (c == '」') { ret += '「'; continue; }
                if (c == '＞') { ret += '＜'; continue; }
                if (c == '(') { ret += ')'; continue; }
                if (c == ')') { ret += '('; continue; }
                if (c == '<') { ret += '>'; continue; }
                if (c == '>') { ret += '<'; continue; }
                if (c == '{') { ret += '}'; continue; }
                if (c == '}') { ret += '{'; continue; }
                if (c == '[') { ret += ']'; continue; }
                if (c == ']') { ret += '['; continue; }
                ret += c;
            }
            return ret;
        }

        static UInt16[] neworderNew =
        {
            19975, 19982, 20001, 20006, 20055, 20081, 20096, 20104, 20105, 20120, 20124, 20175, 20206, 20250, 20253, 20307, 20313, 20341, 20385, 20398, 20537, 20605, 20711, 20813, 20816, 20826, 20870, 20874, 20889, 20966, 21091, 21092, 21104, 21169, 21172, 21177, 21189, 21193, 21220, 21223, 21234, 21306, 21307, 21329, 21336, 21363, 21427, 21442, 21452, 21454, 21465, 21488, 21495, 21917, 21942, 22022, 22065, 22120, 22243, 22258, 
            22259, 22269, 22287, 22311, 22549, 22592, 22593, 22618, 22633, 22679, 22696, 22730, 22732, 22766, 22768, 22769, 22770, 22793, 22885, 22888, 23330, 23398, 23453, 23455, 23515, 23517, 23550, 23551, 23554, 23558, 23597, 23613, 23626, 23646, 23652, 23731, 23777, 24012, 24035, 24059, 24111, 24112, 24193, 24195, 24259, 24266, 24321, 24321, 24321, 24336, 24357, 24382, 24403, 24452, 24467, 24499, 24500, 24540, 24651, 24658, 
            24693, 24724, 24745, 24746, 24808, 24910, 24936, 24974, 25040, 25074, 25126, 25135, 25147, 25173, 25244, 25246, 25285, 25309, 25312, 25313, 25369, 25375, 25407, 25436, 25522, 25594, 25666, 25731, 25935, 25968, 25993, 25998, 26029, 26082, 26087, 26172, 26187, 26217, 26241, 26257, 26278, 26391, 26465, 26469, 26530, 26628, 26716, 26719, 26757, 26908, 27004, 27005, 27010, 27096, 27097, 27177, 27178, 27396, 27424, 27431, 
            27475, 27497, 27503, 27508, 27531, 27572, 27578, 27579, 27598, 27671, 27809, 27810, 27972, 27973, 27996, 28023, 28057, 28167, 28168, 28169, 28171, 28179, 28186, 28201, 28286, 28287, 28288, 28381, 28382, 28450, 28508, 28716, 28783, 28809, 28857, 28858, 28988, 29038, 29344, 29366, 29420, 29421, 29471, 29482, 29486, 29539, 29730, 29814, 29942, 30011, 30067, 30196, 30330, 30423, 30476, 30495, 30740, 30741, 30865, 31036, 
            31038, 31048, 31049, 31056, 31062, 31069, 31070, 31077, 31108, 31109, 31117, 31118, 31119, 31192, 31216, 31282, 31296, 31298, 31311, 31331, 31361, 31363, 31452, 31680, 31883, 31899, 31992, 32076, 32117, 32153, 32154, 32207, 32209, 32210, 32244, 32257, 32260, 32294, 32321, 32330, 32566, 32626, 32763, 32773, 32865, 32884, 32966, 33075, 33235, 33261, 33294, 33303, 33398, 33464, 33550, 33624, 33879, 34101, 34219, 34220, 
            34394, 34396, 34411, 34453, 34509, 34542, 34907, 35013, 35088, 35090, 35207, 35222, 35226, 35239, 35251, 35302, 35379, 35388, 35465, 35501, 35576, 35585, 35617, 35641, 35698, 35914, 36051, 36059, 36104, 36341, 36578, 36605, 36766, 36794, 36883, 36920, 36933, 36965, 37070, 37111, 37117, 37204, 37304, 37320, 37444, 37489, 37549, 37619, 37676, 37682, 37806, 38306, 38360, 38501, 38522, 38534, 38543, 38560, 38583, 38609, 
            38627, 38666, 38745, 38911, 38971, 38972, 38996, 38997, 39006, 39154, 39365, 39366, 39442, 39443, 39620, 39658, 40335, 40614, 40644, 40658, 40665, 40802
        };

        static UInt16[] neworderOld =
        {
            33836, 33287, 20841, 31453, 20056, 20098, 40860, 35947, 29229, 20121, 20126, 20315, 20551, 26371, 20659, 39636, 39192, 20482, 20729, 64048, 20745, 20702, 64049, 64050, 20818, 40680, 22291, 20876, 23531, 34389, 21133, 21137, 21097, 21237, 21214, 25928, 25941, 64051, 64052, 21240, 21235, 21312, 37291, 64053, 21934, 21373, 22196, 21443, 38617, 25910, 25933, 33274, 34399, 64054, 29151, 64055, 22225, 64056, 22296, 22285, 
            22294, 22283, 22280, 22739, 22702, 64057, 22744, 64016, 40573, 22686, 64058, 22750, 22756, 22767, 32882, 22777, 36067, 35722, 22887, 22892, 23363, 23416, 23542, 23526, 23532, 23522, 23565, 22781, 23560, 23559, 22575, 30433, 23622, 23660, 64059, 23997, 23805, 24022, 24034, 21367, 24118, 27512, 24307, 24291, 24290, 63784, 36776, 29923, 36783, 36019, 24396, 24392, 30070, 24465, 24478, 24503, 24501, 25033, 25088, 24646, 
            24800, 64061, 24817, 24801, 24920, 24892, 64062, 64063, 25079, 64064, 25136, 25138, 25150, 25282, 25300, 25799, 25812, 25308, 25818, 25844, 25831, 25406, 25554, 25628, 25581, 25622, 25885, 25802, 64065, 25976, 40778, 40779, 26039, 64066, 33290, 26205, 26185, 26202, 26313, 64067, 26310, 63785, 26781, 20358, 27166, 27054, 27387, 26855, 64068, 27298, 27155, 27138, 27114, 27171, 27079, 27402, 27243, 63773, 32570, 27472, 
            27489, 27493, 40786, 27511, 27544, 27590, 63856, 27580, 27599, 27683, 27794, 28580, 28136, 28154, 28657, 64069, 28122, 28212, 28639, 28041, 28545, 28330, 64070, 28331, 28771, 28629, 28415, 28711, 28399, 64071, 28507, 28712, 29128, 29200, 40670, 29234, 29138, 64072, 29351, 29376, 29544, 29433, 29557, 64022, 29563, 29560, 64074, 29796, 29953, 30059, 30090, 30305, 30332, 30428, 32291, 30494, 30799, 30862, 64075, 31150, 
            64076, 64078, 64077, 64079, 64080, 64081, 64025, 64026, 31103, 31146, 64082, 64083, 64027, 31061, 31281, 31291, 64084, 31319, 31337, 31344, 64085, 31434, 40845, 64086, 31929, 32901, 32114, 32147, 32362, 32380, 32396, 32317, 32160, 32214, 64087, 32227, 32361, 32305, 64089, 32406, 32592, 64090, 39132, 64091, 32880, 32893, 33213, 33126, 33247, 64092, 33293, 33302, 33399, 34269, 33686, 33674, 64095, 34255, 34224, 34277, 
            34395, 63798, 34802, 34870, 34722, 34875, 34910, 35037, 64096, 35139, 38712, 64097, 35258, 35261, 35264, 35320, 35695, 35657, 35709, 35712, 64034, 64098, 35616, 64099, 35731, 35920, 64100, 36106, 64101, 36368, 36681, 36629, 36781, 37002, 36958, 64103, 36978, 36953, 37086, 37141, 64038, 37257, 37312, 37323, 37941, 37979, 37666, 37956, 37706, 37636, 37805, 38364, 39722, 38519, 38570, 63964, 38568, 38577, 38584, 38620, 
            64104, 38728, 38748, 64105, 64106, 36084, 38991, 39023, 63952, 39150, 39515, 39493, 39479, 39511, 39635, 39662, 40388, 40613, 40643, 40657, 40664, 40801
        };

        static bool[] neworderUnicode = 
        {
            false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, true, false, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, true, false, true, false, false, false, false, false, false, false, true, false, true, false, true, false, false, false, false, false, false, false, true, false, true, false, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true, false, false, false, true, false, false, false, false, false, false, true, false, false, false, false, false, false, false, false, false, true, true, false, false, false, false, true, false, false, false, false, true, true, false, true, false, false, true, false, false, false, false, false, false, false, false, false, false, false, true, false, false, true, true, false, false, false, false, true, false, false, false, true, false, true, true, true, false, false, false, false, false, false, true, false, false, false, true, false, false, false, true, true, false, false, false, true, false, true, false, false, true, false, true, false, false, false, false, false, false, true, true, true, false, true, false, false, true, true, false, false, false, false, false, true, false, true, false, false, false, false, false, true, false, true, false, false, false, true, false, false, true, false, true, false, false, false, false, false, false, false, true, false, true, false, 
            true, true, true, true, true, true, true, true, false, false, true, true, true, false, false, false, true, false, false, false, true, false, false, true, false, false, false, false, false, false, false, false, true, true, true, true, false, false, true, false, false, true, false, true, false, false, false, false, false, true, false, false, false, false, false, false, true, false, true, false, true, true, false, false, false, false, false, false, true, false, false, true, false, false, false, false, false, false, false, false, true, true, false, true, false, false, true, false, true, false, false, false, false, false, false, true, false, false, true, true, true, false, false, false, false, false, false, false, true, true, false, false, false, false, false, true, false, false, false, false, true, false, false, true, true, true, false, false, true, false, false, false, false, false, false, false, false, false, true, true, false, false
        };
    }
}
