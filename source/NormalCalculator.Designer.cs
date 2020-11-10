namespace step10
{
    partial class NormalCalculator
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.resultTxt = new System.Windows.Forms.Label();
            this.menuCopy = new System.Windows.Forms.MenuItem();
            this.menuPaste = new System.Windows.Forms.MenuItem();
            this.menuNormalCalc = new System.Windows.Forms.MenuItem();
            this.menuScientificCalc = new System.Windows.Forms.MenuItem();
            this.menuThousandSeparator = new System.Windows.Forms.MenuItem();
            this.menuTopicSearch = new System.Windows.Forms.MenuItem();
            this.menuVersionInfo = new System.Windows.Forms.MenuItem();
            this.menuEdit = new System.Windows.Forms.MenuItem();
            this.menuDisp = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.clearBtn = new NormalCalclator.MyButton();
            this.clearEntryBtn = new NormalCalclator.MyButton();
            this.backBtn = new NormalCalclator.MyButton();
            this.memoryClearBtn = new NormalCalclator.MyButton();
            this.memoryRecallBtn = new NormalCalclator.MyButton();
            this.memoryStoreBtn = new NormalCalclator.MyButton();
            this.memoryAddBtn = new NormalCalclator.MyButton();
            this.sqrtBtn = new NormalCalclator.MyButton();
            this.percentBtn = new NormalCalclator.MyButton();
            this.xDivOneBtn = new NormalCalclator.MyButton();
            this.equalBtn = new NormalCalclator.MyButton();
            this.addBtn = new NormalCalclator.MyButton();
            this.subBtn = new NormalCalclator.MyButton();
            this.multiBtn = new NormalCalclator.MyButton();
            this.divBtn = new NormalCalclator.MyButton();
            this.dotBtn = new NormalCalclator.MyButton();
            this.addToSubBtn = new NormalCalclator.MyButton();
            this.sevenBtn = new NormalCalclator.MyButton();
            this.eightBtn = new NormalCalclator.MyButton();
            this.nineBtn = new NormalCalclator.MyButton();
            this.sixBtn = new NormalCalclator.MyButton();
            this.fiveBtn = new NormalCalclator.MyButton();
            this.fourBtn = new NormalCalclator.MyButton();
            this.threeBtn = new NormalCalclator.MyButton();
            this.twoBtn = new NormalCalclator.MyButton();
            this.oneBtn = new NormalCalclator.MyButton();
            this.zeroBtn = new NormalCalclator.MyButton();
            this.SuspendLayout();
            // 
            // memoryLabel
            // 
            this.memoryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.memoryLabel.Location = new System.Drawing.Point(17, 37);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(32, 24);
            this.memoryLabel.TabIndex = 38;
            this.memoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resultTxt
            // 
            this.resultTxt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.resultTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultTxt.Location = new System.Drawing.Point(12, 2);
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.Size = new System.Drawing.Size(275, 22);
            this.resultTxt.TabIndex = 39;
            this.resultTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuCopy
            // 
            this.menuCopy.Index = 0;
            this.menuCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.menuCopy.Text = "コピー(&C)";
            this.menuCopy.Click += new System.EventHandler(this.menuCopy_Click);
            // 
            // menuPaste
            // 
            this.menuPaste.Index = 1;
            this.menuPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.menuPaste.Text = "貼り付け(&V)";
            this.menuPaste.Click += new System.EventHandler(this.menuPaste_Click);
            // 
            // menuNormalCalc
            // 
            this.menuNormalCalc.Checked = true;
            this.menuNormalCalc.Index = 0;
            this.menuNormalCalc.RadioCheck = true;
            this.menuNormalCalc.Text = "普通の電卓(&T)";
            // 
            // menuScientificCalc
            // 
            this.menuScientificCalc.Index = 1;
            this.menuScientificCalc.Text = "関数電卓(&S)";
            // 
            // menuThousandSeparator
            // 
            this.menuThousandSeparator.Index = 3;
            this.menuThousandSeparator.Text = "桁を区切る(&I)";
            this.menuThousandSeparator.Click += new System.EventHandler(this.menuThousandSeparator_Click);
            // 
            // menuTopicSearch
            // 
            this.menuTopicSearch.Index = 0;
            this.menuTopicSearch.Text = "トピックの検索(&H)";
            // 
            // menuVersionInfo
            // 
            this.menuVersionInfo.Index = 2;
            this.menuVersionInfo.Text = "バージョン情報(&A)";
            // 
            // menuEdit
            // 
            this.menuEdit.Index = 0;
            this.menuEdit.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuCopy,
            this.menuPaste});
            this.menuEdit.Text = "編集(&E)";
            // 
            // menuDisp
            // 
            this.menuDisp.Index = 1;
            this.menuDisp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNormalCalc,
            this.menuScientificCalc,
            this.menuItem1,
            this.menuThousandSeparator});
            this.menuDisp.Text = "表示(&V)";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 2;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuTopicSearch,
            this.menuItem2,
            this.menuVersionInfo});
            this.menuHelp.Text = "ヘルプ(&H)";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuEdit,
            this.menuDisp,
            this.menuHelp});
            // 
            // clearBtn
            // 
            this.clearBtn.ForeColor = System.Drawing.Color.Red;
            this.clearBtn.Location = new System.Drawing.Point(217, 35);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(70, 26);
            this.clearBtn.TabIndex = 69;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.ForeColor = System.Drawing.Color.Red;
            this.clearEntryBtn.Location = new System.Drawing.Point(141, 36);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(70, 26);
            this.clearEntryBtn.TabIndex = 68;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.Color.Red;
            this.backBtn.Location = new System.Drawing.Point(65, 36);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(70, 26);
            this.backBtn.TabIndex = 67;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // memoryClearBtn
            // 
            this.memoryClearBtn.ForeColor = System.Drawing.Color.Red;
            this.memoryClearBtn.Location = new System.Drawing.Point(12, 69);
            this.memoryClearBtn.Name = "memoryClearBtn";
            this.memoryClearBtn.Size = new System.Drawing.Size(42, 26);
            this.memoryClearBtn.TabIndex = 66;
            this.memoryClearBtn.Text = "MC";
            this.memoryClearBtn.UseVisualStyleBackColor = true;
            this.memoryClearBtn.Click += new System.EventHandler(this.memoryClearBtn_Click);
            // 
            // memoryRecallBtn
            // 
            this.memoryRecallBtn.ForeColor = System.Drawing.Color.Red;
            this.memoryRecallBtn.Location = new System.Drawing.Point(12, 98);
            this.memoryRecallBtn.Name = "memoryRecallBtn";
            this.memoryRecallBtn.Size = new System.Drawing.Size(42, 26);
            this.memoryRecallBtn.TabIndex = 65;
            this.memoryRecallBtn.Text = "MR";
            this.memoryRecallBtn.UseVisualStyleBackColor = true;
            this.memoryRecallBtn.Click += new System.EventHandler(this.memoryRecallBtn_Click);
            // 
            // memoryStoreBtn
            // 
            this.memoryStoreBtn.ForeColor = System.Drawing.Color.Red;
            this.memoryStoreBtn.Location = new System.Drawing.Point(12, 128);
            this.memoryStoreBtn.Name = "memoryStoreBtn";
            this.memoryStoreBtn.Size = new System.Drawing.Size(42, 26);
            this.memoryStoreBtn.TabIndex = 64;
            this.memoryStoreBtn.Text = "MS";
            this.memoryStoreBtn.UseVisualStyleBackColor = true;
            this.memoryStoreBtn.Click += new System.EventHandler(this.memoryStoreBtn_Click);
            // 
            // memoryAddBtn
            // 
            this.memoryAddBtn.ForeColor = System.Drawing.Color.Red;
            this.memoryAddBtn.Location = new System.Drawing.Point(12, 158);
            this.memoryAddBtn.Name = "memoryAddBtn";
            this.memoryAddBtn.Size = new System.Drawing.Size(42, 26);
            this.memoryAddBtn.TabIndex = 63;
            this.memoryAddBtn.Text = "M+";
            this.memoryAddBtn.UseVisualStyleBackColor = true;
            this.memoryAddBtn.Click += new System.EventHandler(this.memoryAddBtn_Click);
            // 
            // sqrtBtn
            // 
            this.sqrtBtn.ForeColor = System.Drawing.Color.Blue;
            this.sqrtBtn.Location = new System.Drawing.Point(245, 69);
            this.sqrtBtn.Name = "sqrtBtn";
            this.sqrtBtn.Size = new System.Drawing.Size(42, 26);
            this.sqrtBtn.TabIndex = 62;
            this.sqrtBtn.Text = "sqrt";
            this.sqrtBtn.UseVisualStyleBackColor = true;
            this.sqrtBtn.Click += new System.EventHandler(this.sqrtBtn_Click);
            // 
            // percentBtn
            // 
            this.percentBtn.ForeColor = System.Drawing.Color.Blue;
            this.percentBtn.Location = new System.Drawing.Point(245, 98);
            this.percentBtn.Name = "percentBtn";
            this.percentBtn.Size = new System.Drawing.Size(42, 26);
            this.percentBtn.TabIndex = 61;
            this.percentBtn.Text = "%";
            this.percentBtn.UseVisualStyleBackColor = true;
            this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
            // 
            // xDivOneBtn
            // 
            this.xDivOneBtn.ForeColor = System.Drawing.Color.Blue;
            this.xDivOneBtn.Location = new System.Drawing.Point(245, 127);
            this.xDivOneBtn.Name = "xDivOneBtn";
            this.xDivOneBtn.Size = new System.Drawing.Size(42, 26);
            this.xDivOneBtn.TabIndex = 60;
            this.xDivOneBtn.Text = "1/x";
            this.xDivOneBtn.UseVisualStyleBackColor = true;
            this.xDivOneBtn.Click += new System.EventHandler(this.xDivOneBtn_Click);
            // 
            // equalBtn
            // 
            this.equalBtn.ForeColor = System.Drawing.Color.Red;
            this.equalBtn.Location = new System.Drawing.Point(245, 158);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(42, 26);
            this.equalBtn.TabIndex = 59;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.ForeColor = System.Drawing.Color.Red;
            this.addBtn.Location = new System.Drawing.Point(201, 158);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(42, 26);
            this.addBtn.TabIndex = 58;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // subBtn
            // 
            this.subBtn.ForeColor = System.Drawing.Color.Red;
            this.subBtn.Location = new System.Drawing.Point(201, 128);
            this.subBtn.Name = "subBtn";
            this.subBtn.Size = new System.Drawing.Size(42, 26);
            this.subBtn.TabIndex = 57;
            this.subBtn.Text = "-";
            this.subBtn.UseVisualStyleBackColor = true;
            this.subBtn.Click += new System.EventHandler(this.subBtn_Click);
            // 
            // multiBtn
            // 
            this.multiBtn.ForeColor = System.Drawing.Color.Red;
            this.multiBtn.Location = new System.Drawing.Point(201, 98);
            this.multiBtn.Name = "multiBtn";
            this.multiBtn.Size = new System.Drawing.Size(42, 26);
            this.multiBtn.TabIndex = 56;
            this.multiBtn.Text = "*";
            this.multiBtn.UseVisualStyleBackColor = true;
            this.multiBtn.Click += new System.EventHandler(this.multiBtn_Click);
            // 
            // divBtn
            // 
            this.divBtn.ForeColor = System.Drawing.Color.Red;
            this.divBtn.Location = new System.Drawing.Point(201, 69);
            this.divBtn.Name = "divBtn";
            this.divBtn.Size = new System.Drawing.Size(42, 26);
            this.divBtn.TabIndex = 55;
            this.divBtn.Text = "/";
            this.divBtn.UseVisualStyleBackColor = true;
            this.divBtn.Click += new System.EventHandler(this.divBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.ForeColor = System.Drawing.Color.Blue;
            this.dotBtn.Location = new System.Drawing.Point(156, 158);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(42, 26);
            this.dotBtn.TabIndex = 54;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // addToSubBtn
            // 
            this.addToSubBtn.ForeColor = System.Drawing.Color.Blue;
            this.addToSubBtn.Location = new System.Drawing.Point(111, 158);
            this.addToSubBtn.Name = "addToSubBtn";
            this.addToSubBtn.Size = new System.Drawing.Size(42, 26);
            this.addToSubBtn.TabIndex = 53;
            this.addToSubBtn.Text = "+/-";
            this.addToSubBtn.UseVisualStyleBackColor = true;
            this.addToSubBtn.Click += new System.EventHandler(this.addToSubBtn_Click);
            // 
            // sevenBtn
            // 
            this.sevenBtn.ForeColor = System.Drawing.Color.Blue;
            this.sevenBtn.Location = new System.Drawing.Point(66, 69);
            this.sevenBtn.Name = "sevenBtn";
            this.sevenBtn.Size = new System.Drawing.Size(42, 26);
            this.sevenBtn.TabIndex = 52;
            this.sevenBtn.Text = "7";
            this.sevenBtn.UseVisualStyleBackColor = true;
            this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
            // 
            // eightBtn
            // 
            this.eightBtn.ForeColor = System.Drawing.Color.Blue;
            this.eightBtn.Location = new System.Drawing.Point(111, 69);
            this.eightBtn.Name = "eightBtn";
            this.eightBtn.Size = new System.Drawing.Size(42, 26);
            this.eightBtn.TabIndex = 51;
            this.eightBtn.Text = "8";
            this.eightBtn.UseVisualStyleBackColor = true;
            this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
            // 
            // nineBtn
            // 
            this.nineBtn.ForeColor = System.Drawing.Color.Blue;
            this.nineBtn.Location = new System.Drawing.Point(156, 69);
            this.nineBtn.Name = "nineBtn";
            this.nineBtn.Size = new System.Drawing.Size(42, 26);
            this.nineBtn.TabIndex = 50;
            this.nineBtn.Text = "9";
            this.nineBtn.UseVisualStyleBackColor = true;
            this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
            // 
            // sixBtn
            // 
            this.sixBtn.ForeColor = System.Drawing.Color.Blue;
            this.sixBtn.Location = new System.Drawing.Point(156, 99);
            this.sixBtn.Name = "sixBtn";
            this.sixBtn.Size = new System.Drawing.Size(42, 26);
            this.sixBtn.TabIndex = 49;
            this.sixBtn.Text = "6";
            this.sixBtn.UseVisualStyleBackColor = true;
            this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
            // 
            // fiveBtn
            // 
            this.fiveBtn.ForeColor = System.Drawing.Color.Blue;
            this.fiveBtn.Location = new System.Drawing.Point(111, 98);
            this.fiveBtn.Name = "fiveBtn";
            this.fiveBtn.Size = new System.Drawing.Size(42, 26);
            this.fiveBtn.TabIndex = 48;
            this.fiveBtn.Text = "5";
            this.fiveBtn.UseVisualStyleBackColor = true;
            this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
            // 
            // fourBtn
            // 
            this.fourBtn.ForeColor = System.Drawing.Color.Blue;
            this.fourBtn.Location = new System.Drawing.Point(66, 98);
            this.fourBtn.Name = "fourBtn";
            this.fourBtn.Size = new System.Drawing.Size(42, 26);
            this.fourBtn.TabIndex = 47;
            this.fourBtn.Text = "4";
            this.fourBtn.UseVisualStyleBackColor = true;
            this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
            // 
            // threeBtn
            // 
            this.threeBtn.ForeColor = System.Drawing.Color.Blue;
            this.threeBtn.Location = new System.Drawing.Point(156, 128);
            this.threeBtn.Name = "threeBtn";
            this.threeBtn.Size = new System.Drawing.Size(42, 26);
            this.threeBtn.TabIndex = 46;
            this.threeBtn.Text = "3";
            this.threeBtn.UseVisualStyleBackColor = true;
            this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
            // 
            // twoBtn
            // 
            this.twoBtn.ForeColor = System.Drawing.Color.Blue;
            this.twoBtn.Location = new System.Drawing.Point(111, 127);
            this.twoBtn.Name = "twoBtn";
            this.twoBtn.Size = new System.Drawing.Size(42, 26);
            this.twoBtn.TabIndex = 45;
            this.twoBtn.Text = "2";
            this.twoBtn.UseVisualStyleBackColor = true;
            this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
            // 
            // oneBtn
            // 
            this.oneBtn.ForeColor = System.Drawing.Color.Blue;
            this.oneBtn.Location = new System.Drawing.Point(66, 128);
            this.oneBtn.Name = "oneBtn";
            this.oneBtn.Size = new System.Drawing.Size(42, 26);
            this.oneBtn.TabIndex = 44;
            this.oneBtn.Text = "1";
            this.oneBtn.UseVisualStyleBackColor = true;
            this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
            // 
            // zeroBtn
            // 
            this.zeroBtn.ForeColor = System.Drawing.Color.Blue;
            this.zeroBtn.Location = new System.Drawing.Point(66, 159);
            this.zeroBtn.Name = "zeroBtn";
            this.zeroBtn.Size = new System.Drawing.Size(42, 26);
            this.zeroBtn.TabIndex = 43;
            this.zeroBtn.Text = "0";
            this.zeroBtn.UseVisualStyleBackColor = true;
            this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
            // 
            // NormalCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(297, 192);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.clearEntryBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.memoryClearBtn);
            this.Controls.Add(this.memoryRecallBtn);
            this.Controls.Add(this.memoryStoreBtn);
            this.Controls.Add(this.memoryAddBtn);
            this.Controls.Add(this.sqrtBtn);
            this.Controls.Add(this.percentBtn);
            this.Controls.Add(this.xDivOneBtn);
            this.Controls.Add(this.equalBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.subBtn);
            this.Controls.Add(this.multiBtn);
            this.Controls.Add(this.divBtn);
            this.Controls.Add(this.dotBtn);
            this.Controls.Add(this.addToSubBtn);
            this.Controls.Add(this.sevenBtn);
            this.Controls.Add(this.eightBtn);
            this.Controls.Add(this.nineBtn);
            this.Controls.Add(this.sixBtn);
            this.Controls.Add(this.fiveBtn);
            this.Controls.Add(this.fourBtn);
            this.Controls.Add(this.threeBtn);
            this.Controls.Add(this.twoBtn);
            this.Controls.Add(this.oneBtn);
            this.Controls.Add(this.zeroBtn);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.memoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu;
            this.Name = "NormalCalculator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "電卓";
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Label resultTxt;
        private System.Windows.Forms.MenuItem menuCopy;
        private System.Windows.Forms.MenuItem menuPaste;
        private System.Windows.Forms.MenuItem menuNormalCalc;
        private System.Windows.Forms.MenuItem menuScientificCalc;
        private System.Windows.Forms.MenuItem menuThousandSeparator;
        private System.Windows.Forms.MenuItem menuTopicSearch;
        private System.Windows.Forms.MenuItem menuVersionInfo;
        private System.Windows.Forms.MenuItem menuEdit;
        private System.Windows.Forms.MenuItem menuDisp;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private NormalCalclator.MyButton zeroBtn;
        private NormalCalclator.MyButton oneBtn;
        private NormalCalclator.MyButton twoBtn;
        private NormalCalclator.MyButton threeBtn;
        private NormalCalclator.MyButton fourBtn;
        private NormalCalclator.MyButton fiveBtn;
        private NormalCalclator.MyButton sixBtn;
        private NormalCalclator.MyButton nineBtn;
        private NormalCalclator.MyButton eightBtn;
        private NormalCalclator.MyButton sevenBtn;
        private NormalCalclator.MyButton addToSubBtn;
        private NormalCalclator.MyButton dotBtn;
        private NormalCalclator.MyButton divBtn;
        private NormalCalclator.MyButton multiBtn;
        private NormalCalclator.MyButton subBtn;
        private NormalCalclator.MyButton addBtn;
        private NormalCalclator.MyButton equalBtn;
        private NormalCalclator.MyButton xDivOneBtn;
        private NormalCalclator.MyButton percentBtn;
        private NormalCalclator.MyButton sqrtBtn;
        private NormalCalclator.MyButton memoryAddBtn;
        private NormalCalclator.MyButton memoryStoreBtn;
        private NormalCalclator.MyButton memoryRecallBtn;
        private NormalCalclator.MyButton memoryClearBtn;
        private NormalCalclator.MyButton backBtn;
        private NormalCalclator.MyButton clearEntryBtn;
        private NormalCalclator.MyButton clearBtn;
    }
}
