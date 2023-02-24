
namespace Game2048
{
    partial class GameForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameBoard = new System.Windows.Forms.GroupBox();
            this.TileBase = new System.Windows.Forms.Panel();
            this.TileDataBase = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.MoveRightButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.Logo2048 = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHelpEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.BestScoreBox = new System.Windows.Forms.GroupBox();
            this.BestScoreLabel = new System.Windows.Forms.Label();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.GameBoard.SuspendLayout();
            this.TileBase.SuspendLayout();
            this.ScoreBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.BestScoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameBoard
            // 
            this.GameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.GameBoard.Controls.Add(this.TileBase);
            this.GameBoard.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GameBoard.Location = new System.Drawing.Point(21, 104);
            this.GameBoard.Name = "GameBoard";
            this.GameBoard.Size = new System.Drawing.Size(429, 445);
            this.GameBoard.TabIndex = 0;
            this.GameBoard.TabStop = false;
            // 
            // TileBase
            // 
            this.TileBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.TileBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TileBase.Controls.Add(this.TileDataBase);
            this.TileBase.Location = new System.Drawing.Point(6, 20);
            this.TileBase.Name = "TileBase";
            this.TileBase.Size = new System.Drawing.Size(100, 100);
            this.TileBase.TabIndex = 0;
            this.TileBase.Visible = false;
            // 
            // TileDataBase
            // 
            this.TileDataBase.Font = new System.Drawing.Font("Ubuntu Mono", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TileDataBase.Location = new System.Drawing.Point(3, 12);
            this.TileDataBase.Name = "TileDataBase";
            this.TileDataBase.Size = new System.Drawing.Size(92, 73);
            this.TileDataBase.TabIndex = 1;
            this.TileDataBase.Text = "2";
            this.TileDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(122)))), ((int)(((byte)(104)))));
            this.StartButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.Info;
            this.StartButton.Location = new System.Drawing.Point(635, 483);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(105, 56);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.BackColor = System.Drawing.Color.BurlyWood;
            this.MoveUpButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MoveUpButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoveUpButton.Location = new System.Drawing.Point(578, 242);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(65, 59);
            this.MoveUpButton.TabIndex = 2;
            this.MoveUpButton.Text = "↑";
            this.MoveUpButton.UseVisualStyleBackColor = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.BackColor = System.Drawing.Color.BurlyWood;
            this.MoveLeftButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MoveLeftButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoveLeftButton.Location = new System.Drawing.Point(507, 296);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(65, 59);
            this.MoveLeftButton.TabIndex = 3;
            this.MoveLeftButton.Text = "←";
            this.MoveLeftButton.UseVisualStyleBackColor = false;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // MoveRightButton
            // 
            this.MoveRightButton.BackColor = System.Drawing.Color.BurlyWood;
            this.MoveRightButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MoveRightButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoveRightButton.Location = new System.Drawing.Point(649, 296);
            this.MoveRightButton.Name = "MoveRightButton";
            this.MoveRightButton.Size = new System.Drawing.Size(65, 59);
            this.MoveRightButton.TabIndex = 4;
            this.MoveRightButton.Text = "→";
            this.MoveRightButton.UseVisualStyleBackColor = false;
            this.MoveRightButton.Click += new System.EventHandler(this.MoveRightButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.BackColor = System.Drawing.Color.BurlyWood;
            this.MoveDownButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MoveDownButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MoveDownButton.Location = new System.Drawing.Point(578, 351);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(65, 59);
            this.MoveDownButton.TabIndex = 5;
            this.MoveDownButton.Text = "↓";
            this.MoveDownButton.UseVisualStyleBackColor = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // Logo2048
            // 
            this.Logo2048.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Logo2048.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Logo2048.Location = new System.Drawing.Point(12, 37);
            this.Logo2048.Name = "Logo2048";
            this.Logo2048.Size = new System.Drawing.Size(153, 64);
            this.Logo2048.TabIndex = 7;
            this.Logo2048.Text = "2048";
            this.Logo2048.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScoreBox
            // 
            this.ScoreBox.Controls.Add(this.ScoreLabel);
            this.ScoreBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScoreBox.Location = new System.Drawing.Point(475, 55);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(143, 79);
            this.ScoreBox.TabIndex = 8;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "SCORE";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ScoreLabel.Location = new System.Drawing.Point(6, 33);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(131, 36);
            this.ScoreLabel.TabIndex = 9;
            this.ScoreLabel.Text = "0";
            this.ScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHelpEdit
            // 
            this.MenuHelpEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuVersion});
            this.MenuHelpEdit.Name = "MenuHelpEdit";
            this.MenuHelpEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.MenuHelpEdit.ShowShortcutKeys = false;
            this.MenuHelpEdit.Size = new System.Drawing.Size(65, 20);
            this.MenuHelpEdit.Text = "ヘルプ(&H)";
            // 
            // MenuVersion
            // 
            this.MenuVersion.Name = "MenuVersion";
            this.MenuVersion.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuVersion.ShowShortcutKeys = false;
            this.MenuVersion.Size = new System.Drawing.Size(160, 22);
            this.MenuVersion.Text = "バージョン情報(&A)...";
            this.MenuVersion.Click += new System.EventHandler(this.MenuVersion_Click);
            // 
            // BestScoreBox
            // 
            this.BestScoreBox.Controls.Add(this.BestScoreLabel);
            this.BestScoreBox.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BestScoreBox.Location = new System.Drawing.Point(624, 55);
            this.BestScoreBox.Name = "BestScoreBox";
            this.BestScoreBox.Size = new System.Drawing.Size(143, 79);
            this.BestScoreBox.TabIndex = 10;
            this.BestScoreBox.TabStop = false;
            this.BestScoreBox.Text = "BEST";
            // 
            // BestScoreLabel
            // 
            this.BestScoreLabel.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BestScoreLabel.Location = new System.Drawing.Point(6, 33);
            this.BestScoreLabel.Name = "BestScoreLabel";
            this.BestScoreLabel.Size = new System.Drawing.Size(131, 36);
            this.BestScoreLabel.TabIndex = 9;
            this.BestScoreLabel.Text = "0";
            this.BestScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnButton
            // 
            this.ReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(122)))), ((int)(((byte)(104)))));
            this.ReturnButton.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ReturnButton.ForeColor = System.Drawing.SystemColors.Info;
            this.ReturnButton.Location = new System.Drawing.Point(532, 483);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(62, 56);
            this.ReturnButton.TabIndex = 11;
            this.ReturnButton.Text = "↻";
            this.ReturnButton.UseVisualStyleBackColor = false;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 563);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.BestScoreBox);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.Logo2048);
            this.Controls.Add(this.MoveDownButton);
            this.Controls.Add(this.MoveRightButton);
            this.Controls.Add(this.MoveLeftButton);
            this.Controls.Add(this.MoveUpButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.GameBoard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GameForm";
            this.Text = "2048 Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.GameBoard.ResumeLayout(false);
            this.TileBase.ResumeLayout(false);
            this.ScoreBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.BestScoreBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GameBoard;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button MoveLeftButton;
        private System.Windows.Forms.Button MoveRightButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Panel TileBase;
        private System.Windows.Forms.Label TileDataBase;
        private System.Windows.Forms.Label Logo2048;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpEdit;
        private System.Windows.Forms.ToolStripMenuItem MenuVersion;
        private System.Windows.Forms.GroupBox BestScoreBox;
        private System.Windows.Forms.Label BestScoreLabel;
        private System.Windows.Forms.Button ReturnButton;
    }
}

