namespace Game2048.Game
{
    class Tile
    {
        // タイルが配置されている座標
        private readonly int[] position = new int[2];

        public Tile(int row, int column)
        {
            this.position[0] = row;
            this.position[1] = column;
        }

        /// <summary>
        /// タイルに格納されている数値データを設定、取得する。
        /// </summary>
        /// <returns>格納されている数値</returns>
        public int Data { get; set; }

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
        public bool IsExist { get; set; }

        /// <summary>
        /// タイルに対して編集を許可するかどうか設定する
        /// </summary>
        /// <returns>許可する場合True、その逆の場合はFalseを返す</returns>
        public bool EditLock { get; set; }
    }
}