using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdonGuidInputForm
{
    public partial class MainForm : Form
    {
        private const string TABLE_NAME = "UDON_SHOP";

        private Dictionary<string, int> holidays = new Dictionary<string, int>();
        private StringBuilder builder = new StringBuilder(300);

        public MainForm()
        {
            InitializeComponent();
            holidays.Add("日曜日", 0);
            holidays.Add("月曜日", 1);
            holidays.Add("火曜日", 2);
            holidays.Add("水曜日", 3);
            holidays.Add("木曜日", 4);
            holidays.Add("金曜日", 5);
            holidays.Add("土曜日", 6);
            holidays.Add("不明", 7);
            holidays.Add("なし", 8);
            holidays.Add("日祝", 9);


            listBoxHolidays.DataSource = holidays.Keys.ToList();
            listBoxHolidays.SelectionMode = SelectionMode.MultiSimple;
            listBoxHolidays.SelectedIndex = -1;
            dateTimePickerStart.Value = new DateTime(2021, 5, 6, 9, 0, 0);
            dateTimePickerEnd.Value = new DateTime(2021, 5, 6, 12, 0, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 終了時間を開始時間より前にできないように設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            //店舗名
            string shopName = textBoxShopName.Text;
            //店舗の種類
            string shopType = "";
            shopType = radioButtonNormal.Checked ? "0" : shopType;
            shopType = radioButtonSelft.Checked ? "1" : shopType;
            shopType = radioButtonFactory.Checked ? "2" : shopType;
            //営業開始時間
            DateTime start = dateTimePickerStart.Value;
            DateTime end = dateTimePickerEnd.Value;
            //定休日
            string holiday = "";
            foreach(string key in listBoxHolidays.SelectedItems)
            {
                holiday += holidays[key];
            }
            //コインパーキングあり
            bool existsCoin = checkBoxCoin.Checked ? true : false;
            //駐車場有
            bool existsParking = checkBoxParking.Checked ? true : false;
            //コメント
            string comment = textBoxComment.Text;


            //追加
            AddSql(shopName, shopType, holiday, start.ToString("hh:mm:ss"), end.ToString("hh:mm:ss"), existsCoin, existsParking, comment);
            
            //クリア
            textBoxShopName.Text = "";
            textBoxComment.Text = "";
            radioButtonNormal.Checked = false;
            radioButtonSelft.Checked = false;
            radioButtonFactory.Checked = false;
            listBoxHolidays.SelectedIndex = -1;
            dateTimePickerStart.Value = new DateTime(2021, 5, 6, 9, 0, 0);
            dateTimePickerEnd.Value = new DateTime(2021, 5, 6, 12, 0, 0);
            checkBoxCoin.Checked = false;
            checkBoxParking.Checked = false;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using(var dialog = new SaveFileDialog())
            {
                dialog.Filter = "SQLファイル(*.sql)|*.sql";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, builder.ToString());
                    MessageBox.Show("保存が完了しました。", dialog.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    builder.Clear();
                    listBoxAdded.Items.Clear();
                }
            }
        }

        private async void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            using(var dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSVファイル(*.csv)|*.csv";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    await LoadCSV(dialog.FileName);
                    MessageBox.Show("CSVの読み取りが完了しました", dialog.FileName);
                }
            }
        }

        /// <summary>
        /// StringBuilderにSQLを追加する
        /// ListBoxにも追加する
        /// </summary>
        /// <param name="shopName"></param>
        /// <param name="shopType"></param>
        /// <param name="holiday"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="existsCoin"></param>
        /// <param name="existsParking"></param>
        /// <param name="comment"></param>
        private void AddSql(string shopName, string shopType, string holiday, string start, string end, bool existsCoin, bool existsParking, string comment)
        {
            builder.Append($"INSERT INTO {TABLE_NAME}");
            builder.Append("(ShopName,ShopType,StartTime,EndTime,Holidays,ExistsCoinParking,ExistsParking,Comment) VALUES(");
            //ShopName
            builder.Append($"'{shopName}',");
            //ShopType
            builder.Append($"'{shopType}',");
            //StartTime
            builder.Append($"'{start}',");
            //EndTime
            builder.Append($"'{end}',");
            //Holidays
            builder.Append($"'{holiday}',");
            //ExistsCoin
            builder.Append($"{existsCoin.ToString().ToLower()},");
            //ExistsParking
            builder.Append($"{existsParking.ToString().ToLower()},");
            //comment
            builder.Append($"'{comment}'");

            builder.AppendLine(");");

            listBoxAdded.Items.Add(shopName);
        }

        /// <summary>
        /// CSVを読み取ってStringBuilderに追加する
        /// </summary>
        /// <param name="path"></param>
        private async Task LoadCSV(string path)
        {
            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                List<string> contents = new List<string>();
                string line = null;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    //ヘッダは飛ばす
                    if (line.StartsWith("#")) { continue; }
                    //定休日説明は飛ばす
                    if (line.Contains("定休日(0:日 1:月 2:火 3:水 4:木 5:金 6:土 7:不明,8:なし, 9:日祝)")) { continue; }
                    //空文字は飛ばす
                    if (line.Length == 0) { continue; }

                    contents.Add(line);
                }

                int idx = 1;
                contents.ForEach(line =>
                {
                    string[] lines = line.Split(',');                    
                    if(lines.Length == 8)
                    {
                        //店舗名
                        string shopName = lines[0];
                        //店舗の種類
                        string shopType = lines[1];
                        //定休日
                        string holiday = lines[2];
                        //開始時間
                        string start = lines[3];
                        //終了時間
                        string end = lines[4];
                        //コインパーキング
                        bool existsCoin = lines[5] == "1" ? true : false;
                        //駐車場有
                        bool existstParking = lines[6] == "1" ? true : false;
                        //コメント
                        string comment = lines[7];

                        AddSql(shopName, shopType, holiday, start, end, existsCoin, existstParking, comment);
                    }
                    else
                    {
                        MessageBox.Show($"{line}\nのフォーマットに誤りがあります。", $"[{idx}/{contents.Count}]エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    idx++;
                });
                
            }
        }
    }
}
