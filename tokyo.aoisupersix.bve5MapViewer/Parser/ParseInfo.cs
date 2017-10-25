using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokyo.aoisupersix.bve5MapViewer.Parser
{
    /// <summary>
    /// ファイル関係の情報をまとめて管理するシングルトンクラス
    /// </summary>
    public sealed class ParseInfo
    {
        private static ParseInfo _parseInfoInstance = new ParseInfo();
        public static ParseInfo GetInstance() { return _parseInfoInstance; }

        public string CurrentDirPath { get; set; }

        private ParseInfo()
        {
            //TODO
            CurrentDirPath = @"F:\Library\Documents\Bvets\Scenarios";
        }
    }
}
