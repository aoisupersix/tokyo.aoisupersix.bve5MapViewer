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
        /// <summary>
        /// シナリオのインスタンス
        /// </summary>
        private List<Parser.Scenario> Scenarios = new List<Parser.Scenario>();

        /// <summary>
        /// シナリオに設定されたサムネイルの大きさ
        /// </summary>
        public static Size ThumbnailSize { get; private set; }

        #region シナリオ表示方法の切り替えイベント

        private void DisplayToolStripButton_ButtonClick(object sender, EventArgs e)
        {
            //listViewの表示方法を切り替え
            switch (ScenarioListView.View)
            {
                case View.LargeIcon:
                    ScenarioListView.View = View.Details;
                    break;
                case View.Details:
                    ScenarioListView.View = View.Tile;
                    break;
                case View.Tile:
                    ScenarioListView.View = View.LargeIcon;
                    break;
            }
        }

        private void DisplayToolStripItem_Icon_Click(object sender, EventArgs e)
        {
            ScenarioListView.View = View.LargeIcon;
        }

        private void DisplayToolStripItem_Details_Click(object sender, EventArgs e)
        {
            ScenarioListView.View = View.Details;
        }

        private void DisplayToolStripItem_Tile_Click(object sender, EventArgs e)
        {
            ScenarioListView.View = View.Tile;
        }
        #endregion シナリオ表示方法の切り替えイベント

        public SelectScenariosForm()
        {
            ThumbnailSize = new Size(128, 128);

            InitializeComponent();
            LoadScenarios();
        }

        /// <summary>
        /// 現在のディレクトリにあるシナリオファイルの読み込み
        /// </summary>
        private void LoadScenarios()
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = ThumbnailSize;
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
