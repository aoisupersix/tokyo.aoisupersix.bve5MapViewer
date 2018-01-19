using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

using Bve5_Parsing.ScenarioGrammar;
using Hnx8.ReadJEnc;

namespace tokyo.aoisupersix.bve5MapViewer.Parser
{
    /// <summary>
    /// シナリオを管理するクラス
    /// </summary>
    class Scenario
    {
        /// <summary>
        /// シナリオファイル
        /// </summary>
        public FileInfo File { get; set; }
        
        /// <summary>
        /// シナリオのデータ
        /// </summary>
        public ScenarioData Data { get; set; }

        /// <summary>
        /// シナリオのサムネイルを縦横比を固定して返します。
        /// </summary>
        /// <param name="path">サムネイル画像のファイルパス</param>
        /// <param name="width">サムネイルの横幅</param>
        /// <param name="height">サムネイルの縦幅</param>
        /// <returns>引数に指定した大きさのサムネイル画像</returns>
        private Image CreateThumbnail(string path, int width, int height)
        {
            Bitmap originalBitmap = new Bitmap(path);
            //縦横比の計算
            int x, y;
            double w = (double)width / originalBitmap.Width;
            double h = (double)height / originalBitmap.Height;
            if(w <= h)
            {
                x = width;
                y = (int)(width * (w / h));
            }
            else
            {
                x = (int)(height * (h / w));
                y = height;
            }

            //描画位置を計算
            int sx = (width - x) / 2;
            int sy = (height - y) / 2;

            //imagelistに合わせたサムネイルを描画
            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.DrawImage(originalBitmap, sx, sy, x, y);

            return bitmap;
        }

        /// <summary>
        /// シナリオをファイルパスを指定して作成します。
        /// </summary>
        /// <param name="path">シナリオファイルのファイルパス</param>
        public Scenario(string path)
        {
            File = new FileInfo(path);
        }

        /// <summary>
        /// シナリオファイルを読み込む
        /// </summary>
        /// <returns>シナリオファイルが読み込めたかどうか</returns>
        public bool LoadScenario()
        {
            //ReadJEncを利用してファイルの読み込み
            using (Hnx8.ReadJEnc.FileReader reader = new FileReader(this.File))
            {
                Hnx8.ReadJEnc.CharCode c = reader.Read(this.File);
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine("Loading ScenarioFile【{0}】...", this.File.Name);
                string text = reader.Text;
                if (c is CharCode.Text)
                {
                    //読み込んだファイルがテキスト
                    Console.WriteLine("Encoding: {0}", c.Name);
                    ScenarioGrammarParser parser = new ScenarioGrammarParser();

                    try
                    {
                        this.Data = parser.Parse(text);
                        Console.WriteLine("Parse Successful !");
                        return true;
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine("Scenario: 【{0}】header mismatched.", this.File.FullName);
                    }
                }
                else
                {
                    //テキストファイルではない
                    Console.Error.WriteLine("【{0}】is not text file.", this.File.FullName);
                }
            }
            Console.Error.WriteLine("Scenario: header mismatched.");
            return false;
        }

        /// <summary>
        /// リストビューにシナリオ項目を追加する
        /// </summary>
        /// <param name="listView">追加する対象のリストビュー</param>
        /// <returns>追加後のリストビュー</returns>
        public ListView AddListViewItem(ListView listView)
        {
            ListViewItem item = new ListViewItem(Data.Title);
            item.Name = Data.Title;
            item.Text = Data.Title;

            //画像の追加
            string dirName = this.File.DirectoryName + @"\";
            if (Data.Image != null && System.IO.File.Exists(dirName + Data.Image))
            {
                //画像登録
                try
                {
                    if (!listView.LargeImageList.Images.ContainsKey(Data.Image))
                        listView.LargeImageList.Images.Add(Data.Image, CreateThumbnail(dirName + Data.Image, 128, 128));
                    Image img = Image.FromFile(dirName + Data.Image);
                    item.ImageIndex = listView.LargeImageList.Images.IndexOfKey(Data.Image);
                }
                catch (Exception) { Console.Error.WriteLine("Scenario: Image not active format."); }

            }

            //グループの追加
            if (Data.RouteTitle != null)
            {
                int groupIndex = -1;
                for (int i = 0; i < listView.Groups.Count; i++)
                {
                    if (listView.Groups[i].Header.Equals(Data.RouteTitle))
                        groupIndex = i;
                }
                if(groupIndex == -1)
                {
                    //グループがないので登録
                    ListViewGroup group = new ListViewGroup(Data.RouteTitle, HorizontalAlignment.Left);
                    listView.Groups.Add(group);
                    groupIndex = listView.Groups.Count - 1;
                }

                item.Group = listView.Groups[groupIndex];
            }

            //リストビューに登録
            listView.Items.Add(item);

            return listView;
        }
    }
}
