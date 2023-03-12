
namespace Game2048.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Gbx_GameBoard = new System.Windows.Forms.GroupBox();
            this.Pnl_TileBase = new System.Windows.Forms.Panel();
            this.Lbl_TileDataBase = new System.Windows.Forms.Label();
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Btn_MoveUp = new System.Windows.Forms.Button();
            this.Btn_MoveLeft = new System.Windows.Forms.Button();
            this.Btn_MoveRight = new System.Windows.Forms.Button();
            this.Btn_MoveDown = new System.Windows.Forms.Button();
            this.Lbl_2048Logo = new System.Windows.Forms.Label();
            this.Gbx_Score = new System.Windows.Forms.GroupBox();
            this.Lbl_Score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Tsmi_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Tsmi_Version = new System.Windows.Forms.ToolStripMenuItem();
            this.Gbx_BestScore = new System.Windows.Forms.GroupBox();
            this.Lbl_BestScore = new System.Windows.Forms.Label();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.Gbx_GameBoard.SuspendLayout();
            this.Pnl_TileBase.SuspendLayout();
            this.Gbx_Score.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Gbx_BestScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbx_GameBoard
            // 
            this.Gbx_GameBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(173)))), ((int)(((byte)(160)))));
            this.Gbx_GameBoard.Controls.Add(this.Pnl_TileBase);
            this.Gbx_GameBoard.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Gbx_GameBoard.Location = new System.Drawing.Point(21, 104);
            this.Gbx_GameBoard.Name = "Gbx_GameBoard";
            this.Gbx_GameBoard.Size = new System.Drawing.Size(429, 445);
            this.Gbx_GameBoard.TabIndex = 0;
            this.Gbx_GameBoard.TabStop = false;
            // 
            // Pnl_TileBase
            // 
            this.Pnl_TileBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(228)))), ((int)(((byte)(218)))));
            this.Pnl_TileBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_TileBase.Controls.Add(this.Lbl_TileDataBase);
            this.Pnl_TileBase.Location = new System.Drawing.Point(6, 20);
            this.Pnl_TileBase.Name = "Pnl_TileBase";
            this.Pnl_TileBase.Size = new System.Drawing.Size(100, 100);
            this.Pnl_TileBase.TabIndex = 0;
            this.Pnl_TileBase.Visible = false;
            // 
            // Lbl_TileDataBase
            // 
            this.Lbl_TileDataBase.Font = new System.Drawing.Font("Ubuntu Mono", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TileDataBase.Location = new System.Drawing.Point(3, 12);
            this.Lbl_TileDataBase.Name = "Lbl_TileDataBase";
            this.Lbl_TileDataBase.Size = new System.Drawing.Size(92, 73);
            this.Lbl_TileDataBase.TabIndex = 1;
            this.Lbl_TileDataBase.Text = "2";
            this.Lbl_TileDataBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Start
            // 
            this.Btn_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(122)))), ((int)(((byte)(104)))));
            this.Btn_Start.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Start.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Start.Location = new System.Drawing.Point(635, 483);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(105, 56);
            this.Btn_Start.TabIndex = 1;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = false;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Btn_MoveUp
            // 
            this.Btn_MoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MoveUp.BackColor = System.Drawing.Color.BurlyWood;
            this.Btn_MoveUp.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_MoveUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MoveUp.Location = new System.Drawing.Point(578, 242);
            this.Btn_MoveUp.Name = "Btn_MoveUp";
            this.Btn_MoveUp.Size = new System.Drawing.Size(65, 59);
            this.Btn_MoveUp.TabIndex = 2;
            this.Btn_MoveUp.Text = "↑";
            this.Btn_MoveUp.UseVisualStyleBackColor = false;
            this.Btn_MoveUp.Click += new System.EventHandler(this.Btn_MoveUp_Click);
            // 
            // Btn_MoveLeft
            // 
            this.Btn_MoveLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MoveLeft.BackColor = System.Drawing.Color.BurlyWood;
            this.Btn_MoveLeft.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_MoveLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MoveLeft.Location = new System.Drawing.Point(507, 296);
            this.Btn_MoveLeft.Name = "Btn_MoveLeft";
            this.Btn_MoveLeft.Size = new System.Drawing.Size(65, 59);
            this.Btn_MoveLeft.TabIndex = 3;
            this.Btn_MoveLeft.Text = "←";
            this.Btn_MoveLeft.UseVisualStyleBackColor = false;
            this.Btn_MoveLeft.Click += new System.EventHandler(this.Btn_MoveLeft_Click);
            // 
            // Btn_MoveRight
            // 
            this.Btn_MoveRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MoveRight.BackColor = System.Drawing.Color.BurlyWood;
            this.Btn_MoveRight.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_MoveRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MoveRight.Location = new System.Drawing.Point(649, 296);
            this.Btn_MoveRight.Name = "Btn_MoveRight";
            this.Btn_MoveRight.Size = new System.Drawing.Size(65, 59);
            this.Btn_MoveRight.TabIndex = 4;
            this.Btn_MoveRight.Text = "→";
            this.Btn_MoveRight.UseVisualStyleBackColor = false;
            this.Btn_MoveRight.Click += new System.EventHandler(this.Btn_MoveRight_Click);
            // 
            // Btn_MoveDown
            // 
            this.Btn_MoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MoveDown.BackColor = System.Drawing.Color.BurlyWood;
            this.Btn_MoveDown.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_MoveDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_MoveDown.Location = new System.Drawing.Point(578, 351);
            this.Btn_MoveDown.Name = "Btn_MoveDown";
            this.Btn_MoveDown.Size = new System.Drawing.Size(65, 59);
            this.Btn_MoveDown.TabIndex = 5;
            this.Btn_MoveDown.Text = "↓";
            this.Btn_MoveDown.UseVisualStyleBackColor = false;
            this.Btn_MoveDown.Click += new System.EventHandler(this.Btn_MoveDown_Click);
            // 
            // Lbl_2048Logo
            // 
            this.Lbl_2048Logo.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_2048Logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.Lbl_2048Logo.Location = new System.Drawing.Point(12, 37);
            this.Lbl_2048Logo.Name = "Lbl_2048Logo";
            this.Lbl_2048Logo.Size = new System.Drawing.Size(153, 64);
            this.Lbl_2048Logo.TabIndex = 7;
            this.Lbl_2048Logo.Text = "2048";
            this.Lbl_2048Logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Gbx_Score
            // 
            this.Gbx_Score.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_Score.Controls.Add(this.Lbl_Score);
            this.Gbx_Score.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Gbx_Score.Location = new System.Drawing.Point(475, 55);
            this.Gbx_Score.Name = "Gbx_Score";
            this.Gbx_Score.Size = new System.Drawing.Size(143, 79);
            this.Gbx_Score.TabIndex = 8;
            this.Gbx_Score.TabStop = false;
            this.Gbx_Score.Text = "SCORE";
            // 
            // Lbl_Score
            // 
            this.Lbl_Score.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Score.Location = new System.Drawing.Point(6, 33);
            this.Lbl_Score.Name = "Lbl_Score";
            this.Lbl_Score.Size = new System.Drawing.Size(131, 36);
            this.Lbl_Score.TabIndex = 9;
            this.Lbl_Score.Text = "0";
            this.Lbl_Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Tsmi_Help
            // 
            this.Tsmi_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsmi_Version});
            this.Tsmi_Help.Name = "Tsmi_Help";
            this.Tsmi_Help.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.Tsmi_Help.ShowShortcutKeys = false;
            this.Tsmi_Help.Size = new System.Drawing.Size(65, 20);
            this.Tsmi_Help.Text = "ヘルプ(&H)";
            // 
            // Tsmi_Version
            // 
            this.Tsmi_Version.Name = "Tsmi_Version";
            this.Tsmi_Version.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Tsmi_Version.ShowShortcutKeys = false;
            this.Tsmi_Version.Size = new System.Drawing.Size(160, 22);
            this.Tsmi_Version.Text = "バージョン情報(&A)...";
            this.Tsmi_Version.Click += new System.EventHandler(this.Tsmi_Version_Click);
            // 
            // Gbx_BestScore
            // 
            this.Gbx_BestScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gbx_BestScore.Controls.Add(this.Lbl_BestScore);
            this.Gbx_BestScore.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Gbx_BestScore.Location = new System.Drawing.Point(624, 55);
            this.Gbx_BestScore.Name = "Gbx_BestScore";
            this.Gbx_BestScore.Size = new System.Drawing.Size(143, 79);
            this.Gbx_BestScore.TabIndex = 10;
            this.Gbx_BestScore.TabStop = false;
            this.Gbx_BestScore.Text = "BEST";
            // 
            // Lbl_BestScore
            // 
            this.Lbl_BestScore.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_BestScore.Location = new System.Drawing.Point(6, 33);
            this.Lbl_BestScore.Name = "Lbl_BestScore";
            this.Lbl_BestScore.Size = new System.Drawing.Size(131, 36);
            this.Lbl_BestScore.TabIndex = 9;
            this.Lbl_BestScore.Text = "0";
            this.Lbl_BestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Return
            // 
            this.Btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(122)))), ((int)(((byte)(104)))));
            this.Btn_Return.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_Return.ForeColor = System.Drawing.SystemColors.Info;
            this.Btn_Return.Location = new System.Drawing.Point(532, 483);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(62, 56);
            this.Btn_Return.TabIndex = 11;
            this.Btn_Return.Text = "↻";
            this.Btn_Return.UseVisualStyleBackColor = false;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(787, 563);
            this.Controls.Add(this.Btn_Return);
            this.Controls.Add(this.Gbx_BestScore);
            this.Controls.Add(this.Gbx_Score);
            this.Controls.Add(this.Lbl_2048Logo);
            this.Controls.Add(this.Btn_MoveDown);
            this.Controls.Add(this.Btn_MoveRight);
            this.Controls.Add(this.Btn_MoveLeft);
            this.Controls.Add(this.Btn_MoveUp);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.Gbx_GameBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(803, 602);
            this.Name = "FormMain";
            this.Text = "2048 Game";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Gbx_GameBoard.ResumeLayout(false);
            this.Pnl_TileBase.ResumeLayout(false);
            this.Gbx_Score.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Gbx_BestScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbx_GameBoard;
        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Button Btn_MoveUp;
        private System.Windows.Forms.Button Btn_MoveLeft;
        private System.Windows.Forms.Button Btn_MoveRight;
        private System.Windows.Forms.Button Btn_MoveDown;
        private System.Windows.Forms.Panel Pnl_TileBase;
        private System.Windows.Forms.Label Lbl_TileDataBase;
        private System.Windows.Forms.Label Lbl_2048Logo;
        private System.Windows.Forms.GroupBox Gbx_Score;
        private System.Windows.Forms.Label Lbl_Score;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Help;
        private System.Windows.Forms.ToolStripMenuItem Tsmi_Version;
        private System.Windows.Forms.GroupBox Gbx_BestScore;
        private System.Windows.Forms.Label Lbl_BestScore;
        private System.Windows.Forms.Button Btn_Return;
    }
}

