using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace step10
{
    public partial class NormalCalculator : Form
    {
        // クリアのステータス
        private enum CLEAR_STATUS
        {
            CALC_INIT,      // アプリが起動
            CLEAR,          // Cボタン
            CLEAR_ENTRY,    // CEボタン
            CLEAR_MEMORY    // MCボタン
        };

        // 変数宣言
        private String display;           　// 表示用文字列
        private Boolean isDot;              // 小数点フラグ
        private Boolean isSeparat;          // 桁区切りフラグ
        private Char operatorStorage;       // 演算子保存用
        private Char beforInput;            // 前回入力された内容保存用
        private Char beforOperator;         // 前回入力された演算子保存用
        private decimal total;              // 合計値
        private decimal calcBuff;           // 計算用バッファ値
        private decimal memory;             // メモリー値

        // フォームのイベント
        #region

        // キーダウンイベント
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    this.zeroBtn_Click(sender, e);
                    break;

                case Keys.D0:
                    this.zeroBtn_Click(sender, e);
                    break;

                case Keys.NumPad1:
                    this.oneBtn_Click(sender, e);
                    break;

                case Keys.D1:
                    this.oneBtn_Click(sender, e);
                    break;

                case Keys.NumPad2:
                    this.twoBtn_Click(sender, e);
                    break;

                case Keys.D2:
                    this.twoBtn_Click(sender, e);
                    break;

                case Keys.NumPad3:
                    this.threeBtn_Click(sender, e);
                    break;

                case Keys.D3:
                    this.threeBtn_Click(sender, e);
                    break;

                case Keys.NumPad4:
                    this.fourBtn_Click(sender, e);
                    break;

                case Keys.D4:
                    this.fourBtn_Click(sender, e);
                    break;

                case Keys.NumPad5:
                    this.fiveBtn_Click(sender, e);
                    break;

                // Shift + 5 %
                case Keys.D5:
                    if (e.Shift == true)
                        this.percentBtn_Click(sender, e);
                    
                    else
                        this.fiveBtn_Click(sender, e);

                    break;

                case Keys.NumPad6:
                    this.sixBtn_Click(sender, e);
                    break;

                case Keys.D6:
                    this.sixBtn_Click(sender, e);
                    break;

                case Keys.NumPad7:
                    this.sevenBtn_Click(sender, e);
                    break;

                case Keys.D7:
                    this.sevenBtn_Click(sender, e);
                    break;

                case Keys.NumPad8:
                    this.eightBtn_Click(sender, e);
                    break;

                case Keys.D8:
                    this.eightBtn_Click(sender, e);
                    break;

                case Keys.NumPad9:
                    this.nineBtn_Click(sender, e);
                    break;

                case Keys.D9:
                    this.nineBtn_Click(sender, e);
                    break;

                case Keys.Add:
                    this.addBtn_Click(sender, e);
                    break;

                case Keys.Subtract:
                    this.subBtn_Click(sender, e);
                    break;

                case Keys.OemMinus:
                    if (e.Shift == true)
                        // シフトキーが押されていた場合はイコールの処理
                        this.equalBtn_Click(sender, e);

                    else
                        // 押されていない場合はマイナスの処理
                        this.subBtn_Click(sender, e);

                    break;

                case Keys.Multiply:
                    this.multiBtn_Click(sender, e);
                    break;

                case Keys.Divide:
                    this.divBtn_Click(sender, e);
                    break;

                case Keys.Escape:
                    this.clearBtn_Click(sender, e);
                    break;

                case Keys.Delete:
                    this.clearEntryBtn_Click(sender, e);
                    break;

                case Keys.Decimal:
                    this.dotBtn_Click(sender, e);
                    break;

                case Keys.OemPeriod:
                    this.dotBtn_Click(sender, e);
                    break;

                case Keys.Back:
                    this.backBtn_Click(sender, e);
                    break;

                case Keys.F9:
                    this.addToSubBtn_Click(sender, e);
                    break;

                case Keys.F12:
                    this.Close();
                    break;

                // シフトと＋ボタン
                case Keys.Oemplus:
                    if (e.Shift == true)
                        this.addBtn_Click(sender, e);

                    break;

                // シフトと*ボタン
                case Keys.OemSemicolon:
                    if (e.Shift == true)
                        this.multiBtn_Click(sender, e);

                    break;

                // /ボタン
                case Keys.OemQuestion:
                    this.divBtn_Click(sender, e);
                    break;

                // 円周率＋ Ctrl + P memoryAddボタン
                case Keys.P:
                    if (e.Control == true)
                        this.memoryAddBtn_Click(sender, e);

                    else
                        display = Common.PI;
                        resultTxt.Text = display;

                    break;

                // Ctrl + M memoryStoreボタン
                case Keys.M:
                    if (e.Control == true)
                        this.memoryStoreBtn_Click(sender, e);

                    break;

                // R 1/xボタン Ctrl + R memoryRecallボタン
                case Keys.R:
                    if (e.Control == true)
                        this.memoryRecallBtn_Click(sender, e);

                    else
                        this.xDivOneBtn_Click(sender, e);

                    break;

                // Ctrl + L memoryClearボタン
                case Keys.L:
                    if (e.Control == true)
                        this.memoryClearBtn_Click(sender, e);

                    break;

                // @キー
                case Keys.Oemtilde:
                    this.sqrtBtn_Click(sender, e);
                    break;
            }
        }

        // フォームの初期化
        public NormalCalculator()
        {
            InitializeComponent();

            // 電卓アプリの初期化
            this.ClearApply(CLEAR_STATUS.CALC_INIT);
        }

        // ENTERキーの制御
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // ENTERキーが押されたら＝の処理
            if (e.KeyCode == Keys.Enter)
                this.equalBtn_Click(sender, e);
        }

        #endregion

        /// <summary>
        /// 電卓のクリア処理
        /// </summary>
        /// <param name="btnStatus">クリアするステータス:btnStatus</param>
        private void ClearApply(CLEAR_STATUS btnStatus)
        {
            switch (btnStatus)
            {
                // 電卓アプリが最初にＯＮになったときの初期化
                case CLEAR_STATUS.CALC_INIT:
                    isDot = false;
                    operatorStorage = '\0';
                    beforInput = '\0';
                    beforOperator = '\0';
                    total = 0;
                    calcBuff = 0;
                    memory = 0;
                    display = Common.CALC_FORMAT;
                    isSeparat = false;
                    break;

                // Clear用初期化
                case CLEAR_STATUS.CLEAR:
                    isDot = false;
                    operatorStorage = '\0';
                    beforInput = '\0';
                    beforOperator = '\0';
                    total = 0;
                    calcBuff = 0;
                    display = Common.CALC_FORMAT;
                    break;

                // ClearEntry用初期化
                case CLEAR_STATUS.CLEAR_ENTRY:
                    display = Common.CALC_FORMAT;
                    break;

                // ClearMemory用初期化
                case CLEAR_STATUS.CLEAR_MEMORY:
                    memory = 0;
                    memoryLabel.Text = String.Empty;
                    break;
            }

            resultTxt.Text = display;
        }

        /// <summary>
        /// 数字ボタンのメイン処理
        /// </summary>
        /// <param name="btnTxt">数字</param>
        /// <returns>成功か失敗</returns>
        private Boolean ClickMainValue(String valueTxt)
        {
            if (MyDetection.IsErrorMsg(display) == false)
            {
                display = CalcManager.UpDigit(display, valueTxt,ref beforInput,isDot);  // 桁上げ処理
                display = CalcManager.ThousandSeparator(isSeparat, display);            // 桁数処理
                resultTxt.Text = display;   // 表示を更新

                return true;
            }

            return false;
        }

        /// <summary>
        /// 演算子ボタンのメイン処理(＝は例外)
        /// </summary>
        /// <param name="opeTxt">演算子名</param>
        /// <returns>成功か失敗</returns>
        private Boolean ClickMainOperator(char opeTxt)
        {
            // エラーメッセージが表示されていないかどうか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // 前回の入力が今回と同じかどうか
                if (beforInput != opeTxt)
                {
                    calcBuff = decimal.Parse(display);

                    // 前の処理が＝演算子もしくは演算子の場合は代入のみ
                    if (beforInput == Common.EQUAL || MyDetection.IsValue(beforInput) == false || beforOperator == Common.EQUAL)
                        operatorStorage = '\0';

                    Calculate(opeTxt);  // 演算処理
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 演算処理
        /// </summary>
        private void Calculate(Char operat)
        {
            beforInput = operat;        // 前回入力された内容に演算子を入力された代入
            beforOperator = operat;     // 前回入力された演算子に入力された演算子代入

            switch (operatorStorage)
            {
                // 加算処理
                case Common.ADD:
                    total = total + calcBuff;
                    break;

                // 減産処理
                case Common.SUB:
                    total = total - calcBuff;
                    break;

                // 乗算処理
                case Common.MULTIPLY:
                    total = total * calcBuff;
                    break;

                // 除算処理
                case Common.DIVIDE:
                    if (calcBuff == 0)
                    {
                        if (total == 0)
                        {
                            // 0÷0の計算
                            display = Common.ERROR1;
                            break;
                        }
                        else
                        {
                            // X÷0の計算
                            display = Common.ERROR2;
                            break;
                        }
                    }
                    total = total / calcBuff;   // エラーではない場合は普通に計算
                    break;

                // 合計に代入するだけ
                default:
                    total = calcBuff;
                    break;
            }

            // エラーがdisplayに入っていないか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                if (operat != Common.EQUAL)
                    // ＝演算子は代入しない
                    operatorStorage = operat;

                // 数値を文字列化し表示用文字列に代入
                display = total.ToString();

                // 少数かどうか判定し，少数ではない場合は結果に小数点を付与
                if (MyDetection.IsValueToDot(total) == false)
                    display += '.';

                // 小数点以下無駄な0を省く
                display = CalcManager.DotAdjust(display);

                isDot = false;  // 小数点フラグOFF
            }

            // 桁区切り
            display = CalcManager.ThousandSeparator(isSeparat, display);
            resultTxt.Text = display;
        }

        // ボタンクリックイベント
        #region

        // 数字
        #region 
        // 1 Click
        private void oneBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(oneBtn.Text);
        }

        // 2 Click
        private void twoBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(twoBtn.Text);
        }

        // 3 Click
        private void threeBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(threeBtn.Text);
        }

        // 4 Click
        private void fourBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(fourBtn.Text);
        }

        // 5 Click
        private void fiveBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(fiveBtn.Text);
        }

        // 6 Click
        private void sixBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(sixBtn.Text);
        }

        // 7 Click
        private void sevenBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(sevenBtn.Text);
        }

        // 8 Click
        private void eightBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(eightBtn.Text);
        }

        // 9 Click
        private void nineBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(nineBtn.Text);
        }

        // 0 Click
        private void zeroBtn_Click(object sender, EventArgs e)
        {
            ClickMainValue(zeroBtn.Text);
        }

        #endregion
        
        // Clear系ボタン
        #region

        // Clear Click
        private void clearBtn_Click(object sender, EventArgs e)
        {
            this.ClearApply(CLEAR_STATUS.CLEAR);
        }

        // CEボタン
        private void clearEntryBtn_Click(object sender, EventArgs e)
        {
            ClearApply(CLEAR_STATUS.CLEAR_ENTRY);
        }

        // Back Click
        private void backBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されていない場合
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // 前回の入力が数字のときのみ消す
                if (MyDetection.IsValue(beforInput) == true)
                {
                    display = display.Replace(",", ""); // 桁区切り用
                    display = CalcManager.DownDigit(display,ref isDot);       // 桁下げ
                    display = CalcManager.ThousandSeparator(isSeparat, display);
                    resultTxt.Text = display;
                }
            }
        }

        #endregion

        // 演算子ボタン
        #region

        // equal Click
        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // 前回の入力が＝ではない
                if (beforInput != Common.EQUAL)
                {
                    // クリア後最初は別処理
                    if (operatorStorage == '\0')
                        calcBuff = decimal.Parse(display);

                    // 前回の入力が演算子
                    else if (MyDetection.IsValue(beforInput) == false)
                        calcBuff = decimal.Parse(display);

                    // 前回の入力された演算子がイコール
                    else if (beforOperator == Common.EQUAL){}

                    // それ以外は基本的に表示している文字列を計算用バッファに入れてから演算処理を行う
                    else
                        calcBuff = decimal.Parse(display);
                }

                Calculate(Common.EQUAL);    // 演算処理
            }
        }

        // add Click
        private void addBtn_Click(object sender, EventArgs e)
        {
            ClickMainOperator(char.Parse(addBtn.Text));
        }

        // sub Click
        private void subBtn_Click(object sender, EventArgs e)
        {
            ClickMainOperator(char.Parse(subBtn.Text));
        }

        // multi Click
        private void multiBtn_Click(object sender, EventArgs e)
        {
            ClickMainOperator(char.Parse(multiBtn.Text));
        }

        // div Click
        private void divBtn_Click(object sender, EventArgs e)
        {
            ClickMainOperator(char.Parse(divBtn.Text));
        }        

        #endregion

        // メモリー系ボタン
        #region

        // MemoryClearボタン
        private void memoryClearBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されているかどうか
            if (MyDetection.IsErrorMsg(display) == false)
                ClearApply(CLEAR_STATUS.CLEAR_MEMORY);
        }

        // MemoryRecollボタン
        private void memoryRecallBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されているかどうか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                display = memory.ToString();    // 今のメモリに表示されている数字を表示用文字列に保存

                // 少数かどうか
                if (MyDetection.IsValueToDot(memory) == false)
                    display += '.';

                resultTxt.Text = display;       // 表示
                beforInput = Common.M;
            }
        }

        // Memory+ボタン
        private void memoryAddBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されているかどうか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // Mの表示がまだない場合
                if (memoryLabel.Text != "M")     
                    this.memoryStoreBtn_Click(sender, e);   // メモリーストアと同じ処理

                else
                    // ある場合は今のメモリに保存されている内容と今表示されている内容を加算してメモリに保存
                    memory = memory + decimal.Parse(display);   
            }

            beforInput = Common.M;
        }

        // MemoryStoreボタン
        private void memoryStoreBtn_Click(object sender, EventArgs e)
        {
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // 少数桁以下の無駄な0を削除
                display = CalcManager.DotAdjust(display);

                // 表示用文字列が0だけではなかったら
                if (MyDetection.IsCalcFormat(display) == false)
                {
                    memory = decimal.Parse(display);
                    
                    // ラベルにテキスト描画
                    if (memoryLabel.Text == "")
                        memoryLabel.Text = "M";
                
                }
                
                resultTxt.Text = display;
            }
        }

        #endregion

        // その他のボタン
        #region

        // dot Click
        private void dotBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されているかどうか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // 前回の入力が数字かどうか判定
                if (MyDetection.IsValue(beforInput) == false)
                {   // 前回の入力は演算子
                    display = Common.CALC_FORMAT;
                    isDot = true;
                }
                else
                {
                    // 小数点フラグがOFFならONにする
                    if (isDot == false)
                        isDot = true;

                }
                resultTxt.Text = display;
            }
        }

        // +/-ボタン
        private void addToSubBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されているかどうか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // 前回の入力が演算子かどうか
                if (MyDetection.IsOperator(beforInput) == false)
                {
                    decimal work = decimal.Parse(display);  // 表示文字列をワークに代入
                    work *= -1;                                         // 符号を逆にする
                    display = work.ToString();                          // 文字列化して保存

                    // 値が小数かどうか
                    if (MyDetection.IsValueToDot(work) == false)
                        display += '.';  // 値が少数ではないなら一番右端に 点(.)を追加
                }
                else
                {   // もし演算子なら表示を0.に戻す
                    display = Common.CALC_FORMAT;
                    isDot = false;
                }

                // 桁区切り
                display = CalcManager.ThousandSeparator(isSeparat, display);
                resultTxt.Text = display;
            }
        }

        // %ボタン
        private void percentBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示の判定と今の表示が0.かどうか判定
            if (display != Common.CALC_FORMAT && MyDetection.IsErrorMsg(display) == false)
            {
                decimal work = decimal.Parse(display) * (total / 100);

                // 小数点があるかどうか
                if (MyDetection.IsValueToDot(work) == true)
                    // あれば桁下げもしておく
                    display = CalcManager.DotAdjust(work.ToString());
                
                else
                    // なければ最下位桁に点を追加
                    display = work.ToString() + '.';

                // 桁区切り
                display = CalcManager.ThousandSeparator(isSeparat, display);
                resultTxt.Text = display;
            }
        }

        // 1/xボタン
        private void xDivOneBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示の判定と今の表示が0.かどうか判定
            if (display != Common.CALC_FORMAT && MyDetection.IsErrorMsg(display) == false)
            {
                decimal work = decimal.Parse(display);
                work = 1 / work;

                // 小数点があるかどうか
                if (MyDetection.IsValueToDot(work) == true)
                    // あれば桁下げしておく
                    display = CalcManager.DotAdjust(work.ToString());

                else
                    // なければ最下位桁に点を追加
                    display = work.ToString() + '.';

                // 桁区切り
                display = CalcManager.ThousandSeparator(isSeparat, display);
                resultTxt.Text = display;
            }

        }

        // sqrtボタン
        private void sqrtBtn_Click(object sender, EventArgs e)
        {
            // エラーメッセージが表示されているか
            if (MyDetection.IsErrorMsg(display) == false)
            {
                // decimal型に変換
                decimal work = decimal.Parse(display);

                // 変換した値がマイナスだった場合はエラー
                if (MyDetection.IsNegativeValue(work) == true)
                    display = Common.ERROR3;

                else
                {
                    work = CalcManager.DecimalSqrt(work);   // 平方根に直す

                    // 小数点があるかどうかを調べる
                    if (MyDetection.IsValueToDot(decimal.Parse(work.ToString())))
                        display = CalcManager.DotAdjust(work.ToString());

                    else
                        // ない場合は右端に点(.)をつける
                        display = work.ToString() + '.';
                }

                // 桁区切り
                display = CalcManager.ThousandSeparator(isSeparat, display);
                resultTxt.Text = display;
            }
        }

        #endregion

        #endregion

        // ツールバーにあるメニューのイベント
        #region

        // コピー(メニュー)
        private void menuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();  // クリップボードの初期化

            // エラーメッセージが表示されていないか確認
            if (MyDetection.IsErrorMsg(display) == false)
            {
                decimal work2 = decimal.Parse(display);
                Clipboard.SetText(work2.ToString());
            }
        }

        // 貼り付け(メニュー)
        private void menuPaste_Click(object sender, EventArgs e)
        {
            String str = Clipboard.GetText();   // クリップボードから取得

            // 文字列を一つずつ貼り付けていく
            for (int i = 0; i < str.Length; ++i)
            {
                // 半角数字のみかどうか調べる
                if (MyDetection.IsHalfWidth(str.Substring(i, 1)) == true)
                {
                    // 最初のみ一度表示を消す
                    if (i == 0)
                        display = Common.CALC_FORMAT;

                    display = CalcManager.UpDigit(display, str.Substring(i, 1),ref beforInput,isDot);
                    display = CalcManager.ThousandSeparator(isSeparat, display);

                    resultTxt.Text = display;
                    this.Refresh();
                }
                else
                    // 半角数字以外のものが見つかった場合は即終了
                    break;
            }

            resultTxt.Text = display;
            this.Refresh();             // 表示を更新
        }

        // 桁区切り(メニュー)
        private void menuThousandSeparator_Click(object sender, EventArgs e)
        {
            isSeparat ^= true;   // フラグ変更
            menuThousandSeparator.Checked = isSeparat; // チェックのON OFF

            display = CalcManager.ThousandSeparator(isSeparat, display);
            resultTxt.Text = display;
        }
        
        #endregion

    }
}
