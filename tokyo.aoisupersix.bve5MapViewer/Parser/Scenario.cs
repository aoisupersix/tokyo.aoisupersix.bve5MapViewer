using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Irony.Interpreter;
using Irony.Parsing;

namespace tokyo.aoisupersix.bve5MapViewer.Parser
{
    /// <summary>
    /// シナリオファイル
    /// </summary>
    class Scenario
    {
        public string ScenarioPath;

        //以下シナリオファイルのデータ達
        public string RoutePath { get; private set; }
        public string VehiclePath { get; private set; }
        public string ImagePath { get; private set; }
        public string TitleName { get; private set; }
        public string RouteTitleName { get; private set; }
        public string VehicleTitleName { get; private set; }
        public string AuthorName { get; private set; }
        public string Comment { get; private set; }

        public Scenario(string path)
        {
            ScenarioPath = path;
        }

        /// <summary>
        /// 取得した情報をメンバに代入する
        /// </summary>
        /// <param name="key">ステートメントキー名</param>
        /// <param name="value">ステートメントの値</param>
        private void setData(string key, string value)
        {
            switch (key)
            {
                case "Route":
                    RoutePath = value;
                    break;
                case "Vehicle":
                    VehiclePath = value;
                    break;
                case "Image":
                    ImagePath = value;
                    break;
                case "Title":
                    TitleName = value;
                    break;
                case "RouteTitle":
                    RouteTitleName = value;
                    break;
                case "VehicleTitle":
                    VehicleTitleName = value;
                    break;
                case "Author":
                    AuthorName = value;
                    break;
                case "Comment":
                    Comment = value;
                    break;
            }
        }


        /// <summary>
        /// シナリオファイルを読み込む
        /// </summary>
        /// <returns>シナリオファイルが読み込めたかどうか</returns>
        public bool LoadScenario()
        {
            //ファイルの読み込み
            string scenario;
            try
            {
                StreamReader sr = new StreamReader(ScenarioPath);
                scenario = sr.ReadToEnd();
            }
            catch (IOException e)
            {
                Console.Error.WriteLine("Scenario: FileNotFound : {0}", e.Message);
                return false;
            }

            //シナリオヘッダと一致させる。ヘッダのバージョンは現時点では無視 -> TODO
            int pos;
            if ((pos = Regex.Match(scenario, FileHeaders.SCENARIO, RegexOptions.IgnoreCase).Index) != -1)
            {
                //ヘッダ部分を削除
                int firstLine = scenario.IndexOf('\n', pos) + 1;
                scenario = scenario.Substring(firstLine);
                Console.WriteLine("scenario:{0}", scenario);

                Dictionary<string, string> ScenarioData;
                try
                {
                    ScriptApp app = new ScriptApp(new LanguageData(new ScenariosGrammar()));
                    ScenarioData = (Dictionary<string, string>)app.Evaluate(scenario);
                }
                catch (ScriptException e)
                {
                    Console.Error.WriteLine("Scenario: ParseError : {0}:{1}", e.Location, e.Message);
                    return false;
                }
                if (ScenarioData.ContainsKey("Route") && ScenarioData.ContainsKey("Vehicle"))
                {
                    //読み込んだファイルの文法が正しい
                    Console.WriteLine("Scenario: LoadScenarioData:{0}", ScenarioPath);
                    foreach (var p in ScenarioData)
                    {
                        Console.WriteLine("Key:{0} -> Value:{1}", p.Key, p.Value);
                        setData(p.Key, p.Value);
                    }
                    //RoutePathがあれば正常とする
                    if (RoutePath != null)
                        return true;
                }
            }
            Console.Error.WriteLine("Scenario: header mismatched.");
            return false;
        }

        public ListView AddListViewItem(ListView listView)
        {
            string dirName = System.IO.Path.GetDirectoryName(ScenarioPath) + @"\";
            if(ImagePath != null && System.IO.File.Exists(dirName + ImagePath))
            {

                ListViewItem item = new ListViewItem(TitleName);
                item.Name = TitleName;
                item.Text = TitleName;

                //画像の登録
                if (!listView.LargeImageList.Images.ContainsKey(ImagePath))
                {
                    listView.LargeImageList.Images.Add(ImagePath, Image.FromFile(dirName + ImagePath));
                    item.ImageIndex = listView.LargeImageList.Images.IndexOfKey(ImagePath);
                }

                //リストビューに登録
                listView.Items.Add(item);
            }
            return listView;
        }
    }
}
