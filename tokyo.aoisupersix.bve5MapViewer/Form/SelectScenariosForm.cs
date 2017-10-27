using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using Parser = tokyo.aoisupersix.bve5MapViewer.Parser;

namespace tokyo.aoisupersix.bve5MapViewer
{
    /// <summary>
    /// シナリオ選択フォーム
    /// </summary>
    public partial class SelectScenariosForm : Form
    {
        private List<Parser.Scenario> Scenarios = new List<Parser.Scenario>();

        public SelectScenariosForm()
        {
            InitializeComponent();
            LoadScenarios();
        }

        /// <summary>
        /// 現在のディレクトリにあるシナリオファイルの読み込み
        /// </summary>
        private void LoadScenarios()
        {
            ImageList imgList = new ImageList();
            ScenarioListView.LargeImageList = imgList;

            //デフォルトのパス TODO
            string defaultPath = @"F:\Library\Documents\Bvets\Scenarios";
            this.FilePathComboBox.Items.Add(defaultPath);
            this.FilePathComboBox.SelectedIndex = this.FilePathComboBox.Items.Count - 1;
            string[] files = System.IO.Directory.GetFiles(defaultPath, "*");

            //読み込み
            foreach(string file in files)
            {
                Parser.Scenario scenario = new Parser.Scenario(file);
                if (scenario.LoadScenario())
                {
                    Scenarios.Add(scenario);

                    //リストビューに登録
                    ScenarioListView = scenario.AddListViewItem(ScenarioListView);
                }
            }

            foreach(var group in ScenarioListView.Groups)
            {
                Console.WriteLine("group:.ToString -> {0}", group.ToString());
            }
        }
    }
}
