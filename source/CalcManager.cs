using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace step10
{
    static class CalcManager
    {
        // デリゲート
        delegate decimal func(decimal x);
        delegate decimal dfunc(decimal x);

        /// <summary>
        /// 桁上げ
        /// </summary>
        /// <param name="str">桁上げしたい文字列</param>
        /// <param name="upVal">桁上げする数字</param>
        /// <param name="beforInput">前回入力された内容</param>
        /// <param name="isDot">小数点フラグ</param>
        /// <returns>桁上げした文字列</returns>
        public static String UpDigit(String str, String upVal,ref char beforInput,Boolean isDot)
        {
            String work = str;  // 今表示されている文字列をワークに格納

            // 前回の入力が演算子かどうか
            if (MyDetection.IsValue(beforInput) == false && beforInput != '\0')
            {   // 小数点フラグがONか
                if (isDot == true)
                    work += upVal;          // ワークに追加したい数字を追加
                else
                {
                    work = String.Empty;    // ワークを初期化
                    work += upVal + '.';    // 今回の内容を保存
                }
            }
            else
            {
                // 桁数チェック(桁数を超えていたら何もしない)
                if (work.Length != Common.DIGIT_MAX)
                {   // 小数点フラグのチェック
                    if (isDot == true)
                        // 小数点がついている場合はそのまま追加
                        work += upVal;
                    else
                    {
                        // 表示している文字列が 0. の場合は押された数字.を表示
                        if (MyDetection.IsCalcFormat(work) == true)
                            work = upVal + '.';

                        else
                            // 小数点もついておらず表示している文字列も 0. じゃない場合は桁上げ処理を行う
                            work = work.Insert(work.Length - 1, upVal);  // .を考慮している
                    }
                }
            }
            beforInput = Char.Parse(upVal);
            return work;
        }

        /// <summary>
        /// 桁下げ処理
        /// </summary>
        /// <param name="str">桁下げしたい文字列</param>
        /// <param name="isDot">小数点フラグ</param>
        /// <returns>桁下げした文字列</returns>
        public static String DownDigit(String str,ref Boolean isDot)
        {
            // 小数点があるかどうかを調べる
            if (isDot == true)
            {   // 小数点が一番右端にあるかどうかを判定
                if (MyDetection.IsEndToDot(str) == true)
                    // 一番右端の場合は小数点フラグOFF
                    // (小数点フラグだけが消える 表示は変わらない)
                    isDot = false;
                else
                    // 一番右端ではない場合は桁下げ
                    str = str.Remove(str.Length - 1);
            }
            else
            {   // 表示用文字列が 0.ではないかどうか（0.の場合は何もしない)
                if (MyDetection.IsCalcFormat(str) == false)
                {
                    // 一桁かどうか
                    if (str.Length - 1 == 1)
                        str = Common.CALC_FORMAT;   // 一桁の場合は 0.に表示を変える

                    else
                        str = str.Remove(str.Length - 2, 1);    // それ以外は桁下げ
                }
            }
            return str;
        }

        /// <summary>
        /// 少数桁の無駄な0を調整
        /// </summary>
        /// <param name="value">調整したい値:decimal</param>
        public static String DotAdjust(String str)
        {

            // DOTの位置になるまで繰り返し
            for (int i = str.Length; i > str.LastIndexOf(Common.DOT); --i)
            {
                if (str.EndsWith("0"))
                {
                    // 少数桁一番下の0の文字を省く
                    str = str.Remove(i - 1, 1);
                }
                else
                {
                    // 0ではなくなったら強制的に抜ける
                    break;
                }
            }

            return str;
        }

        /// <summary>
        /// 桁区切り
        /// </summary>
        /// <param name="isSep">桁区切りのフラグ</param>
        /// <param name="str">桁区切りしたい文字列</param>
        /// <returns>桁区切りされた文字列</returns>
        public static String ThousandSeparator(Boolean isSep, String str)
        {
            String work = str;

            work = work.Replace(",", "");

            // 桁区切りのフラグがONかどうか
            if (isSep)
            {
                // 右端が点(.)かどうか
                if (MyDetection.IsEndToDot(work))
                {
                    for (int i = work.Length - 4; i > 0; i -= 3)
                    {
                        work = work.Insert(i, ",");
                    }
                }
                // 右端に点がない(値が少数である)
                else
                {
                    for (int i = work.LastIndexOf('.') - 3; i > 0; i -= 3)
                    {
                        work = work.Insert(i, ",");
                    }
                }
            }

            return work;
        }

        /// <summary>
        /// 平方根を求めて返す
        /// </summary>
        /// <param name="value">平方根にしたい値</param>
        /// <returns>平方根(decimal型)</returns>
        public static decimal DecimalSqrt(decimal value)
        {
            decimal n = value;
            decimal result = (decimal)System.Math.Sqrt((double)n);
            for (int i = 0; i < 10; ++i)
            {
                result = newton(result, delegate(decimal x) { return x * x - n; }, delegate(decimal x) { return x + x; });
            }

            return result;
        }

        // 再帰関数
        static decimal newton(decimal x, func f, dfunc df)
        {
            return x - f(x) / df(x);
        }
    }
}
