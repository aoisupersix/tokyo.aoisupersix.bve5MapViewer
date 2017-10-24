using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokyo.aoisupersix.bve5MapViewer
{
    public partial class Core : Form
    {
        public Core()
        {
            InitializeComponent();
        }

        /// <summary>
        /// シナリオ選択フォームを表示する
        /// </summary>
        private void ToolStripMenuItem_SelectScenario_Click(object sender, EventArgs e)
        {
            Form scenarioForm = new SelectScenariosForm();
            scenarioForm.ShowDialog(this);
        }
    }
}
