﻿using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
                Console.WriteLine("Loading ScenarioFile【{0}】...", this.File.Name);
                string text = reader.Text;
                if (c is CharCode.Text)
                {
                    //読み込んだファイルがテキスト
                    Console.WriteLine("Encoding: {0}", c.Name);
                }
                else
                {
                    //テキストファイルではない
                    //TODO
                    Console.Error.WriteLine("【{0}】is not text file.", this.File.FullName);
                }
            }

            ////シナリオヘッダと一致させる。ヘッダのバージョンは現時点では無視 -> TODO
            //int pos;
            //if ((pos = Regex.Match(scenario, FileHeaders.SCENARIO, RegexOptions.IgnoreCase).Index) != -1)
            //{
            //    //ヘッダ部分を削除
            //    int firstLine = scenario.IndexOf('\n', pos) + 1;
            //    scenario = scenario.Substring(firstLine);
            //    Console.WriteLine("scenario:{0}", scenario);

            //    Dictionary<string, string> ScenarioData;
            //    try
            //    {
            //        ScriptApp app = new ScriptApp(new LanguageData(new ScenariosGrammar()));
            //        ScenarioData = (Dictionary<string, string>)app.Evaluate(scenario);
            //    }
            //    catch (ScriptException e)
            //    {
            //        Console.Error.WriteLine("Scenario: ParseError : {0}:{1}", e.Location, e.Message);
            //        return false;
            //    }
            //    if (ScenarioData.ContainsKey("Route"))
            //    {
            //        //読み込んだファイルの文法が正しい
            //        Console.WriteLine("Scenario: LoadScenarioData:{0}", ScenarioPath);
            //        foreach (var p in ScenarioData)
            //        {
            //            Console.WriteLine("Key:{0} -> Value:{1}", p.Key, p.Value);
            //            setData(p.Key, p.Value);
            //        }
            //        return true;
            //    }
            //}
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
                        listView.LargeImageList.Images.Add(Data.Image, Image.FromFile(dirName + Data.Image));

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
