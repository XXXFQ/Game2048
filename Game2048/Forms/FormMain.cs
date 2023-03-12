using System;
using System.Drawing;
using System.Windows.Forms;

using Game2048.Game;
using Game2048.Properties;

namespace Game2048.Forms
{
    public partial class FormMain : Form
    {
        private GameMain game = null;

        public FormMain()
        {
            InitializeComponent();

            //ApplicationExitイベントハンドラを追加
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
        }

        /// <summary>
        /// フォーム起動時の処理
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // 移動ボタン無効化
            Btn_MoveUp.Enabled = Btn_MoveLeft.Enabled =
                Btn_MoveRight.Enabled = Btn_MoveDown.Enabled = false;

            // 戻るボタン無効化
            Btn_Return.Enabled = false;

            // ベストスコアの読み込み
            this.Lbl_BestScore.Text = Convert.ToString(Settings.Default.BestScore);
        }

        /// <summary>
        /// ApplicationExitイベントハンドラ
        /// </summary>
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            // ベストスコアの保存
            Settings.Default.BestScore = this.game.BestScore;
            Settings.Default.Save();

            //ApplicationExitイベントハンドラを削除
            Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }

        /// <summary>
        /// バージョン情報
        /// </summary>
        private void Tsmi_Version_Click(object sender, EventArgs e)
        {
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var assemblyName = assembly.GetName();
            var fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
            var title = fileVersionInfo.FileDescription;

            string message = $"{title} v{assemblyName.Version.ToString(3)}\n{fileVersionInfo.LegalCopyright}";
            MessageBox.Show(message, Resources.VersionInfo);
        }

        /// <summary>
        /// スタートボタンを押したときの処理
        /// </summary>
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            // 誤作動防止のメッセージボックスを表示
            if (this.game != null)
            {
                if (!this.game.IsGameOver)
                {
                    DialogResult result = MessageBox.Show(
                        Resources.Message_StartOver, Resources.Attention,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.No) return;
                }
            }

            // ボード上のタイルを全てクリア
            this.Gbx_GameBoard.Controls.Clear();

            // Gameクラスのインスタンス生成
            this.game = new GameMain();

            // ゲームを開始する
            this.game.Start();

            // 移動ボタン有効化
            Btn_MoveUp.Enabled = Btn_MoveLeft.Enabled =
            Btn_MoveRight.Enabled = Btn_MoveDown.Enabled = true;

            // 戻るボタン無効化
            Btn_Return.Enabled = false;

            // タイルの配置
            this.UpdateTileToForm();
        }

        /// <summary>
        /// タイルを上方向に移動する
        /// </summary>
        private void Btn_MoveUp_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesUp())
            {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// タイルを左方向に移動する
        /// </summary>
        private void Btn_MoveLeft_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesLeft())
            {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// タイルを右方向に移動する
        /// </summary>
        private void Btn_MoveRight_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesRight())
            {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// タイルを下方向に移動する
        /// </summary>
        private void Btn_MoveDown_Click(object sender, EventArgs e)
        {
            if (this.game.Board.MoveTilesDown())
            {
                this.UpdateTileToForm();
                CheckResult();
            }
        }

        /// <summary>
        /// 戻るボタンを押したときの処理
        /// </summary>
        private void Btn_Return_Click(object sender, EventArgs e)
        {
            this.game.Board.RestoreTiles();
            this.UpdateTileToForm();

            // 戻るボタン無効化
            Btn_Return.Enabled = false;
        }

        /// <summary>
        /// Gameクラスのインスタンスに対応してタイルの状態を更新する
        /// </summary>
        private void UpdateTileToForm()
        {
            // Gameクラスのインスタンスが生成されていない場合
            if (this.game is null)
            {
                MessageBox.Show(Resources.Message_GameInstance, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var tile in this.game.Board.Tiles)
            {
                tile.EditLock = false;

                if (!tile.IsExist)
                {
                    tile.TilePanel.Visible = false;
                    continue;
                }

                int posX = tile.Column;
                int posY = tile.Row;

                // パネルの配置位置設定
                tile.TilePanel.Visible = false;
                tile.TilePanel.Name = $"Tile{Convert.ToString($"{posX}_{posY}")}";
                tile.TilePanel.Location = new Point(
                    (posX + 1) * 6 + posX * 100,
                    (posY + 1) * 20 + posY * 86);

                // 値を格納するラベルの設定
                tile.TileLabel.Name = $"TileData{Convert.ToString($"{posX}_{posY}")}";
                tile.TileLabel.Text = Convert.ToString(tile.Data);

                // タイルデザインの調整
                tile.ToDesign();

                // タイルの配置
                this.Gbx_GameBoard.Controls.Add(tile.TilePanel);
                tile.TilePanel.Controls.Add(tile.TileLabel);
                tile.TilePanel.Visible = true;
            }

            // スコア表の更新
            this.Lbl_Score.Text = Convert.ToString(this.game.Board.Score);
            this.Lbl_BestScore.Text = Convert.ToString(this.game.BestScore);
        }

        /// <summary>
        /// ゲームの結果を調べて、それに対応した処理を行う
        /// </summary>
        private void CheckResult()
        {
            // ゲームオーバーになったか調べる
            if (this.game.IsGameOver)
            {
                Btn_Return.Enabled = false;
                GotGameOver();
                return;
            }

            // ゲームクリアになったか調べる
            if (this.game.IsGameClear)
            {
                GotGameClear();
            }

            // 戻るボタン有効化
            Btn_Return.Enabled = true;
        }

        /// <summary>
        /// ゲームオーバーになった時の処理
        /// </summary>
        private void GotGameOver()
        {
            // 移動ボタンの無効化
            Btn_MoveUp.Enabled = Btn_MoveLeft.Enabled =
            Btn_MoveRight.Enabled = Btn_MoveDown.Enabled = false;
            
            MessageBox.Show(Resources.Message_GameOver, Resources.TooBad, MessageBoxButtons.OK);
        }

        /// <summary>
        /// ゲームクリアになった時の処理
        /// </summary>
        private void GotGameClear()
        {
            if (!this.game.CheckedGameClear) {
                MessageBox.Show(Resources.Message_Completed, Resources.Congratulations, MessageBoxButtons.OK);
                this.game.CheckedGameClear = true;
            }
        }
    }
}
