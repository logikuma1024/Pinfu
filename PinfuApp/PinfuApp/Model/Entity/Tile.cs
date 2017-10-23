using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PinfuApp.Model.Entity
{
    /// <summary>
    /// 麻雀牌エンティティ
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// シーケンス
        /// </summary>
        public Sequence Seq { get; }

        /// <summary>
        /// 数
        /// </summary>
        public int Number { get;}

        /// <summary>
        /// 赤牌
        /// </summary>
        public bool IsRed { get;}
    }

    /// <summary>
    /// 萬子・筒子・索子・字牌
    /// </summary>
    public enum Sequence
    {
        Characters, Circles, Bamboos, Honours
    }
}
