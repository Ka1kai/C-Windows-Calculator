using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace step10
{
    static class MyDetection
    {  
        /// <summary>
        /// 文字が数字かどうかを判定
        /// </summary>
        /// <param name="input">判定したい文字</param>
        /// <returns>数値か数値ではないか</returns>
        public static Boolean IsValue( Char value )
        {
            if ( ( value > 47 && value < 58 ) )
            {
                // 数字
                return true;
            }

            // 数字以外
            return false;
        }

        /// <summary>
        /// 文字が演算子の＋かーかどうかを判定
        /// </summary>
        /// <param name="value">判定したい文字</param>
        /// <returns>演算子の＋かーかどうか</returns>
        public static Boolean IsAddOrSub(Char value)
        {
            if (value == '+' || value == '-')
            {
                // ＋かー
                return true;
            }

            // ＋とー以外
            return false;
        }

        /// <summary>
        /// 文字が演算子（＋，－，×，÷，＝）かどうかを判定
        /// </summary>
        /// <param name="value">判定したい文字</param>
        /// <returns>演算子かどうか</returns>
        public static Boolean IsOperator(Char value)
        {
            if (value == '+' || value == '-' || value == '*' || value == '/' || value == '=')
            {
                // 四則演算子
                return true;
            }

            // 四則演算子以外
            return false;
        }

        /// <summary>
        /// 値が少数かどうか判定
        /// </summary>
        /// <param name="value">判定したい値</param>
        /// <returns>少数か少数ではないか</returns>
        public static Boolean IsValueToDot( decimal value )
        {
            String work;
            work = value.ToString();

            // 格納した値に小数点が含まれているかどうか
            if ( work.Contains( '.' ) )
            {
                // 少数である
                return true;
            }

            // 少数ではない
            return false;
        }

        /// <summary>
        /// 値が負数かどうか判定
        /// </summary>
        /// <param name="value">判定したい値</param>
        /// <returns>負の数かどうか</returns>
        public static Boolean IsNegativeValue(decimal value)
        {
            if (value < 0)
            {
                // 値が負の数
                return true;
            }

            // 値は正の数
            return false;
        }

        /// <summary>
        /// 文字が英語かどうか判定
        /// </summary>
        /// <param name="value">判定したい文字</param>
        /// <returns>英語か英語ではないか</returns>
        public static Boolean IsEnglish(Char value)
        {
            if (value >= 'A' && value <= 'Z' || value >= 'a' && value <= 'z' )
            {
                // 値が英語
                return true;
            }

            // 値は英語ではない
            return false;
        }

        /// <summary>
        /// 文字列の右端が点かどうか判定
        /// </summary>
        /// <param name="str">判定したい文字列</param>
        /// <returns>右端が点かどうか</returns>
        public static Boolean IsEndToDot( String str )
        {
            if ( str.EndsWith(".") )
            {
                // 右端は点である
                return true;
            }

            // 右端は点ではない
            return false;
        }

        /// <summary>
        /// 文字列が電卓の初期画面 0. かどうか
        /// </summary>
        /// <param name="str">判定対象文字列</param>
        /// <returns>電卓の初期画面かどうか</returns>
        public static Boolean IsCalcFormat( String str )
        {
            if ( str == Common.CALC_FORMAT )
            {
                // 電卓の初期表示である
                return true;
            }

            // 電卓の初期表示ではない
            return false;
        }
      
        /// <summary>
        /// 文字列にエラーメッセージが表示されているか判定
        /// </summary>
        /// <param name="str">判定対象文字列</param>
        /// <returns>エラーメッセージが表示されているかどうか</returns>
        public static Boolean IsErrorMsg( String str )
        {
            if ( str == Common.ERROR1 || str == Common.ERROR2 || str == Common.ERROR3 )
            {
                // エラーメッセージが表示されている
                return true;
            }

            // 表示されていない
            return false;
        }

        /// <summary>
        /// 指定文字列全てが半角文字列かどうかを判定
        /// </summary>
        /// <param name="strValue ">判定対象文字列</param>
        /// <returns>半角文字列かどうか</returns>
        public static Boolean IsHalfWidth(string strValue)
        {
            Encoding sjisEncoding = Encoding.GetEncoding("Shift_JIS");
            if (sjisEncoding.GetByteCount(strValue) == strValue.Length)
            {
                return true;
            }

            return false;
        }

    }
}
