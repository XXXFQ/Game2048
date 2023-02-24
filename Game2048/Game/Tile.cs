using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    class Tile
    {
        // タイルに格納されている数値
        private int data = 0;

        // タイルが配置されている座標
        private int[] position = new int[2];

        // ボード上に表示するかどうか
        private bool isExist = false;

        // タイルに対して編集を許可するかどうか
        private bool editLock = false;

        public Tile(int row, int column)
        {
            this.position[0] = row;
            this.position[1] = column;
        }

        /// <summary>
        /// タイルに格納されている数値データを設定、取得する。
        /// </summary>
        /// <returns>格納されている数値</returns>
        public int Data
        {
            set {
                this.data = value;
            }
            get {
                return this.data;
            }
        }

        /// <summary>
        /// タイルが配置されている行の位置を取得する
        /// </summary>
        /// <returns>行の位置</returns>
        public int Row
        {
            get {
                return this.position[0];
            }
        }

        /// <summary>
        /// タイルが配置されている列の位置を取得する
        /// </summary>
        /// <returns>列の位置</returns>
        public int Column
        {
            get {
                return this.position[1];
            }
        }

        /// <summary>
        /// タイルがボード上に存在するか設定する
        /// </summary>
        /// <returns>ボード上に存在する場合True、その逆の場合はFalseを返す</returns>
        public bool IsExist
        {
            set {
                this.isExist = value;
            }
            get {
                return this.isExist;
            }
        }

        /// <summary>
        /// タイルに対して編集を許可するかどうか設定する
        /// </summary>
        /// <returns>許可する場合True、その逆の場合はFalseを返す</returns>
        public bool EditLock
        {
            set {
                this.editLock = value;
            }
            get {
                return this.editLock;
            }
        }
    }
}