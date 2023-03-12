using System.Drawing;
using System.Windows.Forms;

using Game2048.Utils;

namespace Game2048.Game
{
    class Tile
    {
        // タイルが配置されている座標
        private readonly int[] position = new int[2];

        public Tile(int row, int column)
        {
            // パネルの初期化
            this.TilePanel = new Panel
            {
                BackColor = Color.FromArgb(238, 228, 218),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(100, 100)
            };

            // 値を格納するラベルの初期化
            this.TileLabel = new Label
            {
                AutoSize = false,
                Font = new Font("Ubuntu Mono", 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(92, 73),
                Location = new Point(3, 12)
            };

            // 位置の初期化
            this.position[0] = row;
            this.position[1] = column;
        }

        /// <summary>
        /// フォーム上で表示されるタイルのパネルオブジェクト
        /// </summary>
        public Panel TilePanel { get; set; }

        /// <summary>
        /// フォーム上で表示されるタイルのラベルオブジェクト
        /// </summary>
        public Label TileLabel { get; set; }

        /// <summary>
        /// タイルに格納されている数値データを設定、取得する。
        /// </summary>
        /// <returns>格納されている数値</returns>
        public int Data { get; set; }

        /// <summary>
        /// タイルが配置されている行の位置を取得する
        /// </summary>
        /// <returns>行の位置</returns>
        public int Row => this.position[0];

        /// <summary>
        /// タイルが配置されている列の位置を取得する
        /// </summary>
        /// <returns>列の位置</returns>
        public int Column => this.position[1];

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

        /// <summary>
        /// 格納されている値に対応して、タイルをデザインする
        /// </summary>
        public void ToDesign()
        {
            this.TilePanel.ForeColor = Color.Black;

            // タイルの色付け
            switch (Data)
            {
                case 2:
                    this.TilePanel.BackColor = Color.FromArgb(238, 228, 218);
                    break;
                case 4:
                    this.TilePanel.BackColor = Color.FromArgb(237, 224, 192);
                    break;
                case 8:
                    this.TilePanel.BackColor = Color.FromArgb(242, 177, 121);
                    break;
                case 16:
                    this.TilePanel.BackColor = Color.FromArgb(245, 149, 99);
                    break;
                case 32:
                    this.TilePanel.BackColor = Color.FromArgb(246, 124, 95);
                    break;
                case 64:
                    this.TilePanel.BackColor = Color.FromArgb(246, 94, 59);
                    break;
                case 128:
                    this.TilePanel.BackColor = Color.FromArgb(237, 207, 114);
                    break;
                case 256:
                    this.TilePanel.BackColor = Color.FromArgb(237, 204, 97);
                    break;
                case 512:
                    this.TilePanel.BackColor = Color.FromArgb(243, 215, 116);
                    break;
                case 1024:
                    this.TilePanel.BackColor = Color.FromArgb(183, 148, 115);
                    break;
                case 2048:
                    this.TilePanel.BackColor = Color.FromArgb(151, 111, 67);
                    break;
                default:
                    this.TilePanel.BackColor = Color.FromArgb(0, 0, 0);
                    this.TilePanel.ForeColor = Color.White;
                    break;
            }

            // フォントサイズの調整
            int fontSize = 40 - 7 * (MathUtils.GetDigitCount(Data) - 2);

            if (MathUtils.GetDigitCount(Data) >= 6) {
                fontSize = 17;
            }
            this.TileLabel.Font = new Font("Ubuntu Mono", fontSize);
        }
    }
}