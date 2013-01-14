using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace revtext
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 f = new Form1();
            Application.Run(f);
        }

        static public string RevAlpha(string str)
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

        static public string Reverse(string str)
        {
            string ret = "";
            for (int i = 0; i < str.Length; ++i)
            {
                ret += str[str.Length - i - 1];
            }
            return ret;
        }

        static public string HiraToKana(string str)
        {
            string ret = "";
            foreach (char c in str)
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
                if (c == 'さ') { ret += 'サ'; continue; }
                if (c == 'し') { ret += 'シ'; continue; }
                if (c == 'す') { ret += 'ス'; continue; }
                if (c == 'せ') { ret += 'セ'; continue; }
                if (c == 'そ') { ret += 'ソ'; continue; }
                if (c == 'た') { ret += 'タ'; continue; }
                if (c == 'ち') { ret += 'チ'; continue; }
                if (c == 'つ') { ret += 'ツ'; continue; }
                if (c == 'て') { ret += 'テ'; continue; }
                if (c == 'と') { ret += 'ト'; continue; }
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
                ret += c;
            }
            return ret;
        }
    }
}
