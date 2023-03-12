using Game2048.Properties;

namespace Game2048.Game
{
    class GameMain
    {
        // 行、列の大きさ
        private const int ROW_SIZE = 4;
        private const int COLUMN_SIZE = 4;

        // 初期配置するタイルの枚数
        private const int INITIAL_PANEL_NUM = 2;

        // ベストスコア
        private int bestScore = Settings.Default.BestScore;

        public GameMain()
        {
            // ボードの情報を生成
            this.Board = new GameBoard(ROW_SIZE, COLUMN_SIZE);
        }

        /// <summary>
        /// ボードの情報を取得
        /// </summary>
        /// <returns>ボードの情報</returns>
        public GameBoard Board { get; }

        /// <summary>
        /// ベストスコアを取得
        /// </summary>
        /// <returns>ベストスコア</returns>
        public int BestScore
        {
            get {
                if (this.Board.Score > this.bestScore) {
                    this.bestScore = Settings.Default.BestScore = this.Board.Score;
                }
                return this.bestScore;
            }
        }

        /// <summary>
        /// ゲームをスタートする時の動作
        /// </summary>
        public void Start()
        {
            this.Board.CreateNewTile(INITIAL_PANEL_NUM);
        }

        /// <summary>
        /// ゲームオーバーしたかどうか
        /// </summary>
        /// <returns>ゲームオーバーしている場合trueを返す。そうでない場合はfalseを返す。</returns>
        public bool IsGameOver
        {
            get {
                return !this.Board.CanMoveTilesUp && !this.Board.CanMoveTilesLeft &&
                    !this.Board.CanMoveTilesRight && !this.Board.CanMoveTilesDown;
            }
        }

        /// <summary>
        /// ゲームクリアを確認したかどうか
        /// </summary>
        /// <returns>確認した場合trueを返す。そうでない場合はfalseを返す。</returns>
        public bool CheckedGameClear { get; set; }

        /// <summary>
        /// ゲームクリアしたかどうか
        /// </summary>
        /// <returns>ゲームクリアしている場合trueを返す。そうでない場合はfalseを返す。</returns>
        public bool IsGameClear
        {
            get {
                for (int index = 0; index < this.Board.BoardSize; index++) {
                    if (this.Board.Tiles[index].IsExist && this.Board.Tiles[index].Data == 2048) {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}