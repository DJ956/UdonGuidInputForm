
namespace UdonGuidInputForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxShopName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.radioButtonSelft = new System.Windows.Forms.RadioButton();
            this.radioButtonFactory = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxHolidays = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCoin = new System.Windows.Forms.CheckBox();
            this.checkBoxParking = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxAdded = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoadCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "店名:";
            // 
            // textBoxShopName
            // 
            this.textBoxShopName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxShopName.Location = new System.Drawing.Point(57, 12);
            this.textBoxShopName.Name = "textBoxShopName";
            this.textBoxShopName.Size = new System.Drawing.Size(282, 29);
            this.textBoxShopName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "店舗タイプ:";
            // 
            // radioButtonNormal
            // 
            this.radioButtonNormal.AutoSize = true;
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Location = new System.Drawing.Point(84, 59);
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.Size = new System.Drawing.Size(61, 19);
            this.radioButtonNormal.TabIndex = 3;
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.Text = "一般店";
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelft
            // 
            this.radioButtonSelft.AutoSize = true;
            this.radioButtonSelft.Location = new System.Drawing.Point(151, 59);
            this.radioButtonSelft.Name = "radioButtonSelft";
            this.radioButtonSelft.Size = new System.Drawing.Size(53, 19);
            this.radioButtonSelft.TabIndex = 4;
            this.radioButtonSelft.Text = "セルフ";
            this.radioButtonSelft.UseVisualStyleBackColor = true;
            // 
            // radioButtonFactory
            // 
            this.radioButtonFactory.AutoSize = true;
            this.radioButtonFactory.Location = new System.Drawing.Point(210, 59);
            this.radioButtonFactory.Name = "radioButtonFactory";
            this.radioButtonFactory.Size = new System.Drawing.Size(61, 19);
            this.radioButtonFactory.TabIndex = 5;
            this.radioButtonFactory.Text = "製麺所";
            this.radioButtonFactory.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "定休日:";
            // 
            // listBoxHolidays
            // 
            this.listBoxHolidays.FormattingEnabled = true;
            this.listBoxHolidays.ItemHeight = 15;
            this.listBoxHolidays.Location = new System.Drawing.Point(69, 94);
            this.listBoxHolidays.MultiColumn = true;
            this.listBoxHolidays.Name = "listBoxHolidays";
            this.listBoxHolidays.Size = new System.Drawing.Size(202, 154);
            this.listBoxHolidays.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "開始時間";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStart.Location = new System.Drawing.Point(78, 266);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(87, 23);
            this.dateTimePickerStart.TabIndex = 10;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(241, 266);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(87, 23);
            this.dateTimePickerEnd.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "終了時間";
            // 
            // checkBoxCoin
            // 
            this.checkBoxCoin.AutoSize = true;
            this.checkBoxCoin.Location = new System.Drawing.Point(17, 308);
            this.checkBoxCoin.Name = "checkBoxCoin";
            this.checkBoxCoin.Size = new System.Drawing.Size(115, 19);
            this.checkBoxCoin.TabIndex = 13;
            this.checkBoxCoin.Text = "コインパーキングあり";
            this.checkBoxCoin.UseVisualStyleBackColor = true;
            // 
            // checkBoxParking
            // 
            this.checkBoxParking.AutoSize = true;
            this.checkBoxParking.Location = new System.Drawing.Point(152, 308);
            this.checkBoxParking.Name = "checkBoxParking";
            this.checkBoxParking.Size = new System.Drawing.Size(74, 19);
            this.checkBoxParking.TabIndex = 14;
            this.checkBoxParking.Text = "駐車場有";
            this.checkBoxParking.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "コメント";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxComment.Location = new System.Drawing.Point(17, 359);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxComment.Size = new System.Drawing.Size(322, 101);
            this.textBoxComment.TabIndex = 16;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.buttonGenerate.Location = new System.Drawing.Point(241, 466);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(98, 25);
            this.buttonGenerate.TabIndex = 17;
            this.buttonGenerate.Text = "SQL追加";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "生成SQL";
            // 
            // listBoxAdded
            // 
            this.listBoxAdded.FormattingEnabled = true;
            this.listBoxAdded.ItemHeight = 15;
            this.listBoxAdded.Location = new System.Drawing.Point(17, 497);
            this.listBoxAdded.Name = "listBoxAdded";
            this.listBoxAdded.Size = new System.Drawing.Size(322, 124);
            this.listBoxAdded.TabIndex = 19;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(253, 624);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "保存...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoadCSV
            // 
            this.buttonLoadCSV.Location = new System.Drawing.Point(12, 627);
            this.buttonLoadCSV.Name = "buttonLoadCSV";
            this.buttonLoadCSV.Size = new System.Drawing.Size(97, 25);
            this.buttonLoadCSV.TabIndex = 21;
            this.buttonLoadCSV.Text = "CSV読み込み...";
            this.buttonLoadCSV.UseVisualStyleBackColor = true;
            this.buttonLoadCSV.Click += new System.EventHandler(this.buttonLoadCSV_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 659);
            this.Controls.Add(this.buttonLoadCSV);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listBoxAdded);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxParking);
            this.Controls.Add(this.checkBoxCoin);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxHolidays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButtonFactory);
            this.Controls.Add(this.radioButtonSelft);
            this.Controls.Add(this.radioButtonNormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxShopName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "うどんガイドブック入力フォーム";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxShopName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.RadioButton radioButtonSelft;
        private System.Windows.Forms.RadioButton radioButtonFactory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxHolidays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCoin;
        private System.Windows.Forms.CheckBox checkBoxParking;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxAdded;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoadCSV;
    }
}