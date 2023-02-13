using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    class Game
    {
        // 行、列の大きさ
        private int ROW_SIZE = 4;
        private int COLUMN_SIZE = 4;

        // 初期配置するタイルの枚数
        private const int INITIAL_PANEL_NUM = 2;

        // ボードの情報
        private GameBoard board;

        // ゲームクリアを確認したかどうか
        private bool checkedGameClear = false;

        // ベストスコア
        private int bestScore = 0;

        public int BestScore
        {
            get {
                if (this.Board.Score > this.bestScore) {
                    this.bestScore = this.Board.Score;
                }
                return this.bestScore;
            }
        }

        public Game()
        {
            // ボードの情報を生成
            this.board = new GameBoard(ROW_SIZE, COLUMN_SIZE);
        }

        public Game(int bestScore) : this()
        {
            this.bestScore = bestScore;
        }

        /// <summary>
        /// ボードの情報を取得
        /// </summary>
        /// <returns>ボードの情報</returns>
        public GameBoard Board
        {
            get {
                return this.board;
            }
        }

        /// <summary>
        /// ゲームをスタートする時の動作
        /// </summary>
        public void Start()
        {
            this.board.CreateNewTile(INITIAL_PANEL_NUM);
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

        /// <summary>
        /// ゲームクリアを確認したかどうか
        /// </summary>
        /// <returns>確認した場合trueを返す。そうでない場合はfalseを返す。</returns>
        public bool CheckedGameClear
        {
            set {
                this.checkedGameClear = value;
            }
            get {
                return this.checkedGameClear;
            }
        }
    }
}