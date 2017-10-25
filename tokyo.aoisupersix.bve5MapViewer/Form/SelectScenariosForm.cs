using System;
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
        public SelectScenariosForm()
        {
            InitializeComponent();

            //読み込みテスト
            Parser.Scenario scenario = new Parser.Scenario(@"F:\Library\Documents\Bvets\Scenarios\mackoy.Keisei.txt");
            scenario.LoadScenario();
        }
    }
}
