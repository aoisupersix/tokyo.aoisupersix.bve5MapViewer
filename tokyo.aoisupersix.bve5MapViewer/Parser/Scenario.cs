using System;
using System.IO;
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
        public Dictionary<string, string> ScenarioData { get; set; }

        public Scenario(string path)
        {
            ScenarioPath = path;
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
            if((pos = Regex.Match(scenario, FileHeaders.SCENARIO, RegexOptions.IgnoreCase).Index) != -1)
            {
                //ヘッダ部分を削除
                int firstLine = scenario.IndexOf('\n', pos) + 1;
                scenario = scenario.Substring(firstLine);
                Console.WriteLine("scenario:{0}", scenario);
                try
                {
                    ScriptApp app = new ScriptApp(new LanguageData(new ScenariosGrammar()));
                    ScenarioData = (Dictionary<string, string>)app.Evaluate(scenario);
                }
                catch(ScriptException e)
                {
                    Console.Error.WriteLine("Scenario: ParseError : {0}:{1}", e.Location, e.Message);
                    return false;
                }
                if(ScenarioData.ContainsKey("Route") && ScenarioData.ContainsKey("Vehicle"))
                {
                    //正常に読み込めた
                    Console.WriteLine("Scenario: LoadScenarioData:{0}", ScenarioPath);
                    foreach(var p in ScenarioData)
                    {
                        Console.WriteLine("Key:{0} -> Value:{1}", p.Key, p.Value);
                    }
                    return true;
                }
            }
            Console.Error.WriteLine("Scenario: header mismatched.");
            return false;
        }
    }
}
