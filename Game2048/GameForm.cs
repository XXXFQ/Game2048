using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game2048
{
    public partial class GameForm : Form
    {
        // ツール情報
        const string GAME_NAME = "2048 Game";
        const string VERSION = "v1.1";
        const string AUTHOR = "アーム";
        const string TWITTER_ID = "@40414";

        private Game game = null;
        private Panel[] tile = null;
        private Label[] tileLabel = null;

        // ベストスコア
        private int bestScore = 0;

        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム起動時の処理
        /// </summary>
        private void GameForm_Load(object sender, EventArgs e)
        {
            // 移動ボタン無効化
            MoveUpButton.Enabled = MoveLeftButton.Enabled =
                MoveRightButton.Enabled = MoveDownButton.Enabled = false;

            // 戻るボタン無効化
            ReturnButton.Enabled = false;
        }

        /// <summary>
        /// バージョン情報
        /// </summary>
        private void MenuVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                GAME_NAME + " " + VERSION + "\n\n© 2023 " + AUTHOR + "<Twitter:" + TWITTER_ID + ">",
                "バージョン情報",
                MessageBoxButtons.OK);
        }

        /// <summary>
        /// 対数(log10)を取って数値の桁数を調べる
        /// </summary>
        public int Digit(int value)
        {
            // NegativeInfinityを回避
            return (value == 0) ? 1 : ((int)Math.Log10(value) + 1);
        }

        public void NoGameInstanceErrorMsg()
        {
            MessageBox.Show(
                    "Gameクラスのインスタンスが生成されていません。", "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        /// <summary>
        /// Gameクラスのインスタンスに対応してタイルを生成
        /// </summary>
        private void NewTileObjetToForm()
        {
            // Gameクラスのインスタンスが生成されていない場合
            if (this.game == null) {
                NoGameInstanceErrorMsg();
                return;
            }

            // 生成するタイルの数(ボードの大きさ)
            int boardSize = this.game.Board.BoardSize;

            this.tile = new Panel[boardSize];
            this.tileLabel = new Label[boardSize];

            for (int index = 0; index < boardSize; index++)
            {
                // パネルの設定
                this.tile[index] = new Panel();
                this.tile[index].BackColor = Color.FromArgb(238, 228, 218);
                this.tile[index].BorderStyle = BorderStyle.FixedSingle;
                this.tile[index].Size = new Size(100, 100);

                // 値を格納するラベルの設定
                this.tileLabel[index] = new Label();
                this.tileLabel[index].AutoSize = false;
                this.tileLabel[index].Font = new Font("Ubuntu Mono", 40);
                this.tileLabel[index].TextAlign = ContentAlignment.MiddleCenter;
                this.tileLabel[index].Size = new Size(92, 73);
                this.tileLabel[index].Location = new Point(3, 12);
            }
        }

        /// <summary>
        /// 格納されている値に対応して、タイルをデザインする
        /// </summary>
        /// <param name="index">デザイン調整したいタイルのインデックス</param>
        private void TileDesign(int index)
        {
            int data = this.game.Board.Tiles[index].Data;
            this.tile[index].ForeColor = Color.Black;

            switch (data)
            {
                // タイルの色付け
                case 2:
                    this.tile[index].BackColor = Color.FromArgb(238, 228, 218);
                    break;
                case 4:
                    this.tile[index].BackColor = Color.FromArgb(237, 224, 192);
                    break;
                case 8:
                    this.tile[index].BackColor = Color.FromArgb(242, 177, 121);
                    break;
                case 16:
                    this.tile[index].BackColor = Color.FromArgb(245, 149, 99);
                    break;
                case 32:
                    this.tile[index].BackColor = Color.FromArgb(246, 124, 95);
                    break;
                case 64:
                    this.tile[index].BackColor = Color.FromArgb(246, 94, 59);
                    break;
                case 128:
                    this.tile[index].BackColor = Color.FromArgb(237, 207, 114);
                    break;
                case 256:
                    this.tile[index].BackColor = Color.FromArgb(237, 204, 97);
                    break;
                case 512:
                    this.tile[index].BackColor = Color.FromArgb(243, 215, 116);
                    break;
                case 1024:
                    this.tile[index].BackColor = Color.FromArgb(183, 148, 115);
                    break;
                case 2048:
                    this.tile[index].BackColor = Color.FromArgb(151, 111, 67);
                    break;
                default:
                    this.tile[index].BackColor = Color.FromArgb(0, 0, 0);
                    this.tile[index].ForeColor = Color.White;
                    break;
            }

            // フォントサイズの調整
            int fontSize = Digit(data) < 6 ? 40 - 7 * (Digit(data) - 2) : 17;
            this.tileLabel[index].Font = new Font("Ubuntu Mono", fontSize);
        }

        /// <summary>
        /// Gameクラスのインスタンスに対応してタイルの状態を更新する
        /// </summary>
        private void UpdateTileToForm()
        {
            // Gameクラスのインスタンスが生成されていない場合
            if (this.game == null) {
                NoGameInstanceErrorMsg();
                return;
            }

            for (int index = 0; index < this.game.Board.BoardSize; index++)
            {
                this.game.Board.Tiles[index].EditLock = false;

                if (!this.game.Board.Tiles[index].IsExist) {
                    this.tile[index].Visible = false;
                    continue;
                }

                int posX = this.game.Board.Tiles[index].Column;
                int posY = this.game.Board.Tiles[index].Row;

                // パネルの配置位置設定
                this.tile[index].Visible = false;
                this.tile[index].Name = "Tile" + Convert.ToString(posX + "_" + posY);
                this.tile[index].Location = new Point(
                    (posX + 1) * 6 + posX * 100,
                    (posY + 1) * 20 + posY * 86);

                // 値を格納するラベルの設定
                this.tileLabel[index].Name = "TileData" + Convert.ToString(posX + "_" + posY);
                this.tileLabel[index].Text = Convert.ToString(game.Board.Tiles[index].Data);

                // タイルデザインの調整
                this.TileDesign(index);

                // タイルの配置
                this.GameBoard.Controls.Add(this.tile[index]);
                this.tile[index].Controls.Add(this.tileLabel[index]);
                this.tile[index].Visible = true;
            }

            // スコア表の更新
            this.ScoreLabel.Text = Convert.ToString(this.game.Board.Score);
            this.BestScoreLabel.Text = Convert.ToString(this.game.BestScore);
            this.bestScore = this.game.BestScore;
        }

        /// <summary>
        /// ゲームの結果を調べて、それに対応した処理を行う
        /// </summary>
        private void CheckResult()
        {
            // ゲームオーバーになったか調べる
            if (this.game.IsGameOver) {
                ReturnButton.Enabled = false;
                GotGameOver();
                return;
            }

            // ゲームクリアになったか調べる
            if (this.game.IsGameClear) {
                GotGameClear();
            }

            // 戻るボタン有効化
            ReturnButton.Enabled = true;
        }

        /// <summary>
        /// ゲームオーバーになった時の処理
        /// </summary>
        private void GotGameOver()
        {
            // 移動ボタンの無効化
            MoveUpButton.Enabled = MoveLeftButton.Enabled =
            MoveRightButton.Enabled = MoveDownButton.Enabled = false;
            
            MessageBox.Show("GameOverになりました。", "残念!",MessageBoxButtons.OK);
        }

        /// <summary>
        /// ゲームクリアになった時の処理
        /// </summary>
        private void GotGameClear()
        {
            if (!this.game.CheckedGameClear) {
                MessageBox.Show("2048タイルが完成しました!\n引き続き遊ぶことが出来ます。",
                    "おめでとうございます!",
                    MessageBoxButtons.OK);
                this.game.CheckedGameClear = true;
            }
        }

        /// <summary>
        /// スタートボタンを押したときの処理
        /// </summary>
        private void StartButton_Click(object sender, EventArgs e)
        {
            // 誤作動防止のメッセージボックスを表示
            if (this.game != null) {
                if (!this.game.IsGameOver) {
                    DialogResult result = MessageBox.Show(
                        "始めからやり直しますか?", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.No) { return; }
                }
            }

            // Gameクラスのインスタンス生成
            this.game = new Game(this.bestScore);

            // ゲームを開始する
            this.game.Start();

            // 移動ボタン有効化
            MoveUpButton.Enabled = MoveLeftButton.Enabled =
            MoveRightButton.Enabled = MoveDownButton.Enabled = true;

            // 戻るボタン無効化
            ReturnButton.Enabled = false;

            // タイルを生成する
            if (this.tile == null) {
                this.NewTileObjetToForm();
            }

            // タイルの配置
            this.UpdateTileToForm();
        }

        /// <summary>
        /// タイルを上方向に移動する
        /// </summary>
        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesUp()) {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// タイルを左方向に移動する
        /// </summary>
        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesLeft()) {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// タイルを右方向に移動する
        /// </summary>
        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesRight()) {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// タイルを下方向に移動する
        /// </summary>
        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesDown()) {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// 戻るボタンを押したときの処理
        /// </summary>
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.game.Board.RestoreTiles();
            this.UpdateTileToForm();

            // 戻るボタン無効化
            ReturnButton.Enabled = false;
        }
    }
}
