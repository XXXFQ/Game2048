using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2048
{
    class GameBoard
    {
        // タイル情報を格納する配列
        private Tile[] tiles;

        // 過去のタイル情報を格納する配列
        private Tile[] pastTilesInfo;

        // 行、列の大きさ
        private int rowSize;
        private int columnSize;

        // ボード全体のサイズ
        private int boardSize;

        // スコア
        private int score = 0;

        // スコアへ加算する増分値
        private int scoreIncreaseValue = 0;

        public GameBoard(int rowSize, int columnSize)
        {
            // マスが2x2以上では無い場合、エラーを返す
            if (rowSize < 2 || columnSize < 2)
                throw new ArgumentOutOfRangeException("行と列の数は最低でも2つ必要です。");

            this.rowSize = rowSize;
            this.columnSize = columnSize;
            this.boardSize = this.rowSize * this.columnSize;

            // boardSizeに対応して、タイルの情報を格納する配列を生成
            this.tiles = new Tile[this.boardSize];
            this.pastTilesInfo = new Tile[this.boardSize];

            for (int index = 0; index < this.boardSize; index++)
            {
                // タイルの座標情報を取得
                int[] coordinates = this.ConvertToCoordinates(index);

                // 座標情報を基にタイルのインスタンスを生成
                this.tiles[index] = new Tile(coordinates[0], coordinates[1]);
                this.pastTilesInfo[index] = new Tile(coordinates[0], coordinates[1]);
            }
        }

        /// <summary>
        /// タイルの情報を取得
        /// </summary>
        /// <returns>タイルの情報</returns>
        public Tile[] Tiles
        {
            get {
                return this.tiles;
            }
        }

        /// <summary>
        /// 行の長さを取得
        /// </summary>
        /// <returns>行の長さ</returns>
        public int RowSize
        {
            get {
                return this.rowSize;
            }
        }

        /// <summary>
        /// 列の長さを取得
        /// </summary>
        /// <returns>列の長さ</returns>
        public int ColumnSize
        {
            get {
                return this.columnSize;
            }
        }

        /// <summary>
        /// 全てのマスの数(ボードの大きさ)を取得
        /// </summary>
        /// <returns>全てのマスの数(ボードの大きさ)</returns>
        public int BoardSize
        {
            get {
                return this.boardSize;
            }
        }

        /// <summary>
        /// スコアを取得する
        /// </summary>
        /// <returns>スコア</returns>
        public int Score
        {
            get {
                return this.score;
            }
        }

        /// <summary>
        /// スコアへ加算する増分値を取得する
        /// </summary>
        /// <returns>増分値</returns>
        public int ScoreIncreaseValue
        {
            get {
                return this.scoreIncreaseValue;
            }
        }

        /// <summary>
        /// インデックスを座標系に変換
        /// </summary>
        /// <param name="pos">変換するインデックス</param>
        /// <returns>変換した座標系</returns>
        public int[] ConvertToCoordinates(int pos)
        {
            int[] posIndex = new int[2];
            posIndex[0] = pos / this.rowSize;
            posIndex[1] = pos % this.columnSize;
            return posIndex;
        }

        /// <summary>
        /// 座標系をインデックスに変換
        /// </summary>
        /// <param name="row">行座標</param>
        /// <param name="column">列座標</param>
        /// <returns>変換したインデックス</returns>
        public int ConvertToTileIndex(int row, int column)
        {
            return row * this.rowSize + column;
        }

        /// <summary>
        /// 新しいタイルを生成する
        /// </summary>
        /// <param name="count">生成するタイルの数</param>
        public void CreateNewTile(int count)
        {
            Random r = new Random();

            // 最初に"4"がマスに格納される確率(1/n)
            int probabilityAppear4 = 10;
            
            // 空のマス目の位置を格納
            int[] emptyGridPos = new int[0];

            for (int i = 0; i < this.BoardSize; i++)
            {
                if (!this.Tiles[i].IsExist) {
                    Array.Resize(ref emptyGridPos, emptyGridPos.Length + 1);
                    emptyGridPos[emptyGridPos.Length - 1] = i;
                }
            }

            // 初期位置をランダムに決める
            for (int i = 0; i < emptyGridPos.Length; i++)
            {
                int j = r.Next(0, emptyGridPos.Length);

                if (i != j) {
                    int swap = emptyGridPos[i];
                    emptyGridPos[i] = emptyGridPos[j];
                    emptyGridPos[j] = swap;
                }
            }

            // 並び替えた配列の先頭から情報を取得
            for (int i = 0; i < count; i++)
            {
                // タイルを表示する
                this.Tiles[emptyGridPos[i]].IsExist = true;

                // タイルの初期値を決める(2か4)
                this.Tiles[emptyGridPos[i]].Data = 
                    r.Next(0, probabilityAppear4 + 1) != probabilityAppear4 ? 2 : 4;
            }
        }

        /// <summary>
        /// タイルを指定した場所に移動できるかどうか
        /// 以下が移動できると判断する条件である。
        /// ・移動先のマスが現在いるマスと異なる
        /// ・移動先のマスがロックされていない。
        /// ・移動先のマスにタイルが存在しないか、タイルに格納されている値が同じである。
        /// </summary>
        /// <param name="currentPos">移動させたいタイルのインデックス</param>
        /// <param name="nextPos">移動先のマスのインデックス</param>
        /// <returns>タイルが移動できる場合はtrue、そうでない場合はfalseを返す</returns>
        private bool CanMoveTile(int currentPos, int nextPos)
        {
            return currentPos != nextPos && !Tiles[nextPos].EditLock &&
                (!Tiles[nextPos].IsExist || Tiles[currentPos].Data == Tiles[nextPos].Data);
        }

        /// <summary>
        /// タイルを指定した場所に移動する
        /// </summary>
        /// <param name="currentPos">移動させたいタイルのインデックス</param>
        /// <param name="nextPos">移動先のマスのインデックス</param>
        /// <returns>タイルの移動に成功したかどうか</returns>
        private bool MoveTile(int currentPos, int nextPos)
        {
            if (!CanMoveTile(currentPos, nextPos)) { return false; }

            // 移動先のマスにタイルが存在し格納されている値が同じ場合、その値同士で加算を行う
            if (Tiles[nextPos].IsExist && Tiles[currentPos].Data == Tiles[nextPos].Data) {
                // タイルに格納されている値同士の加算
                Tiles[nextPos].Data += Tiles[currentPos].Data;
                Tiles[nextPos].EditLock = true;

                // スコアの更新
                this.score += Tiles[nextPos].Data;
                this.scoreIncreaseValue += Tiles[nextPos].Data;
            } else {
                // それ以外の場合、値の移動を行う
                Tiles[nextPos].Data = Tiles[currentPos].Data;
            }

            Tiles[currentPos].Data = 0;
            Tiles[currentPos].IsExist = Tiles[currentPos].EditLock = false;
            Tiles[nextPos].IsExist = true;

            return true;
        }

        /// <summary>
        /// 任意のタイルが次に上方向に移動する場所を返す
        /// </summary>
        /// <param name="currentPos">移動させたいタイルのインデックス</param>
        /// <returns>次に上方向に移動する場所のインデックス。無かった場合は-1</returns>
        private int GetNextMoveUpPosition(int currentPos)
        {
            for (int row = Tiles[currentPos].Row - 1; row >= 0; row--)
            {
                // 移動先のマスのインデックス
                int nextPos = ConvertToTileIndex(row, Tiles[currentPos].Column);

                // 移動先のマスにタイルが存在せず、調べている行が上限に達していない場合、スキップする
                if (!Tiles[nextPos].IsExist && row != 0) { continue; }

                // 移動先のマスにあるタイルと合成できるか調べる
                if (!CanMoveTile(currentPos, nextPos)) {
                    // 出来ない場合は、そのタイルの真下までスライドするようにする。
                    nextPos = ConvertToTileIndex(row + 1, Tiles[currentPos].Column);
                    if (currentPos == nextPos) { break; }
                }

                // 移動先の情報を返す。
                if (CanMoveTile(currentPos, nextPos)) { return nextPos; }
            }
            return -1;
        }

        /// <summary>
        /// 任意のタイルが次に左方向に移動する場所を返す
        /// </summary>
        /// <param name="currentPos">移動させたいタイルのインデックス</param>
        /// <returns>次に左方向に移動する場所のインデックス。無かった場合は-1</returns>
        private int GetNextMoveLeftPosition(int currentPos)
        {
            for (int column = Tiles[currentPos].Column - 1; column >= 0; column--)
            {
                // 移動先のマスのインデックス
                int nextPos = ConvertToTileIndex(Tiles[currentPos].Row, column);

                // 移動先のマスにタイルが存在せず、調べている行が上限に達していない場合、スキップする
                if (!Tiles[nextPos].IsExist && column != 0) { continue; }

                // 移動先のマスにあるタイルと合成できるか調べる
                if (!CanMoveTile(currentPos, nextPos)) {
                    // 出来ない場合は、そのタイルの真下までスライドするようにする。
                    nextPos = ConvertToTileIndex(Tiles[currentPos].Row, column + 1);
                    if (currentPos == nextPos) { break; }
                }

                // 移動先の情報を返す。
                if (CanMoveTile(currentPos, nextPos)) { return nextPos; }
            }
            return -1;
        }

        /// <summary>
        /// 任意のタイルが次に右方向に移動する場所を返す
        /// </summary>
        /// <param name="currentPos">移動させたいタイルのインデックス</param>
        /// <returns>次に右方向に移動する場所のインデックス。無かった場合は-1</returns>
        private int GetNextMoveRightPosition(int currentPos)
        {
            int columnIndexMax = this.ColumnSize - 1;

            for (int column = Tiles[currentPos].Column + 1; column <= columnIndexMax; column++)
            {
                // 移動先のマスのインデックス
                int nextPos = ConvertToTileIndex(Tiles[currentPos].Row, column);

                // 移動先のマスにタイルが存在せず、調べている行が上限に達していない場合、スキップする
                if (!Tiles[nextPos].IsExist && column != columnIndexMax) { continue; }

                // 移動先のマスにあるタイルと合成できるか調べる
                if (!CanMoveTile(currentPos, nextPos))
                {
                    // 出来ない場合は、そのタイルの真下までスライドするようにする。
                    nextPos = ConvertToTileIndex(Tiles[currentPos].Row, column - 1);
                    if (currentPos == nextPos) { break; }
                }

                // 移動先の情報を返す。
                if (CanMoveTile(currentPos, nextPos)) { return nextPos; }
            }
            return -1;
        }

        /// <summary>
        /// 任意のタイルが次に下方向に移動する場所を返す
        /// </summary>
        /// <param name="currentPos">移動させたいタイルのインデックス</param>
        /// <returns>次に下方向に移動する場所のインデックス。無かった場合は-1</returns>
        private int GetNextMoveDownPosition(int currentPos)
        {
            int rowIndexMax = this.RowSize - 1;

            for (int row = Tiles[currentPos].Row + 1; row <= rowIndexMax; row++)
            {
                // 移動先のマスのインデックス
                int nextPos = ConvertToTileIndex(row, Tiles[currentPos].Column);

                // 移動先のマスにタイルが存在せず、調べている行が上限に達していない場合、スキップする
                if (!Tiles[nextPos].IsExist && row != rowIndexMax) { continue; }

                // 移動先のマスにあるタイルと合成できるか調べる
                if (!CanMoveTile(currentPos, nextPos)) {
                    // 出来ない場合は、そのタイルの真下までスライドするようにする。
                    nextPos = ConvertToTileIndex(row - 1, Tiles[currentPos].Column);
                    if (currentPos == nextPos) { break; }
                }

                // 移動先の情報を返す。
                if (CanMoveTile(currentPos, nextPos)) { return nextPos; }
            }
            return -1;
        }

        /// <summary>
        /// 一つでもタイルが上方向に移動出来るかどうか
        /// </summary>
        /// <returns>移動可能の場合はtrue、出来ない場合はfalseを返す</returns>
        public bool CanMoveTilesUp
        {
            get {
                for (int currentPos = RowSize; currentPos < BoardSize; currentPos++) {
                    // 指定のマスにタイルが存在しない場合
                    if (!Tiles[currentPos].IsExist) { continue; }

                    if (GetNextMoveUpPosition(currentPos) != -1) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// 一つでもタイルが左方向に移動出来るかどうか
        /// </summary>
        /// <returns>移動可能の場合はtrue、出来ない場合はfalseを返す</returns>
        public bool CanMoveTilesLeft
        {
            get {
                for (int currentPos = 1; currentPos < BoardSize; currentPos++) {
                    // 指定のマスにタイルが存在しない場合
                    if (!Tiles[currentPos].IsExist || ConvertToCoordinates(currentPos)[1] == 0) { continue; }

                    if (GetNextMoveLeftPosition(currentPos) != -1) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// 一つでもタイルが右方向に移動出来るかどうか
        /// </summary>
        /// <returns>移動可能の場合はtrue、出来ない場合はfalseを返す</returns>
        public bool CanMoveTilesRight
        {
            get {
                int columnIndexMax = this.ColumnSize - 1;
                for (int currentPos = BoardSize - 2; currentPos >= 0; currentPos--) {
                    // 指定のマスにタイルが存在しない場合
                    if (!Tiles[currentPos].IsExist || ConvertToCoordinates(currentPos)[1] == columnIndexMax) {
                        continue;
                    }

                    if (GetNextMoveRightPosition(currentPos) != -1) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// 一つでもタイルが下方向に移動出来るかどうか
        /// </summary>
        /// <returns>移動可能の場合はtrue、出来ない場合はfalseを返す</returns>
        public bool CanMoveTilesDown
        {
            get {
                int rowIndexMax = this.RowSize - 1;
                for (int currentPos = BoardSize - this.ColumnSize - 1; currentPos >= 0; currentPos--) {
                    // 指定のマスにタイルが存在しない場合
                    if (!Tiles[currentPos].IsExist || ConvertToCoordinates(currentPos)[0] == rowIndexMax) {
                        continue;
                    }

                    if (GetNextMoveDownPosition(currentPos) != -1) { return true; }
                }
                return false;
            }
        }

        /// <summary>
        /// タイルを上方向に移動する
        /// </summary>
        /// <returns>タイルの移動に成功したかどうか</returns>
        public bool MoveTilesUp()
        {
            if (!CanMoveTilesUp) { return false; }

            bool movedTile = false;
            this.scoreIncreaseValue = 0;
            BackupOperationHistory();

            for (int currentPos = RowSize; currentPos < BoardSize; currentPos++)
            {
                // 指定のマスにタイルが存在しない場合
                if (!this.Tiles[currentPos].IsExist) { continue; }

                int nextPos = GetNextMoveUpPosition(currentPos);

                // 移動先が無かった場合、スキップする。
                if (nextPos == -1) { continue; }

                // タイルの移動を試みる
                if (MoveTile(currentPos, nextPos)) { movedTile = true; }
            }
            // 移動に成功した場合、タイルを生成する。
            if (movedTile) { this.CreateNewTile(1); }
            return movedTile;
        }

        /// <summary>
        /// タイルを左方向に移動する
        /// </summary>
        /// <returns>タイルの移動に成功したかどうか</returns>
        public bool MoveTilesLeft()
        {
            if (!CanMoveTilesLeft) { return false; }

            bool movedTile = false;
            this.scoreIncreaseValue = 0;
            BackupOperationHistory();

            for (int currentPos = 1; currentPos < BoardSize; currentPos++)
            {
                // 指定のマスにタイルが存在しない場合
                if (!Tiles[currentPos].IsExist || ConvertToCoordinates(currentPos)[1] == 0) { continue; }

                int nextPos = GetNextMoveLeftPosition(currentPos);

                // 移動先が無かった場合、スキップする。
                if (nextPos == -1) { continue; }

                // タイルの移動を試みる
                if (MoveTile(currentPos, nextPos)) { movedTile = true; }
            }
            // 移動に成功した場合、タイルを生成する。
            if (movedTile) { this.CreateNewTile(1); }
            return movedTile;
        }

        /// <summary>
        /// タイルを右方向に移動する
        /// </summary>
        /// <returns>タイルの移動に成功したかどうか</returns>
        public bool MoveTilesRight()
        {
            if (!CanMoveTilesRight) { return false; }

            bool movedTile = false;
            int columnIndexMax = this.ColumnSize - 1;
            this.scoreIncreaseValue = 0;
            BackupOperationHistory();

            for (int currentPos = BoardSize - 2; currentPos >= 0; currentPos--)
            {
                // 指定のマスにタイルが存在しない場合
                if (!Tiles[currentPos].IsExist || ConvertToCoordinates(currentPos)[1] == columnIndexMax) {
                    continue;
                }

                int nextPos = GetNextMoveRightPosition(currentPos);

                // 移動先が無かった場合、スキップする。
                if (nextPos == -1) { continue; }

                // タイルの移動を試みる
                if (MoveTile(currentPos, nextPos)) { movedTile = true; }
            }

            // 移動に成功した場合、タイルを生成する。
            if (movedTile) { this.CreateNewTile(1); }
            return movedTile;
        }

        /// <summary>
        /// タイルを下方向に移動する
        /// </summary>
        /// <returns>タイルの移動に成功したかどうか</returns>
        public bool MoveTilesDown()
        {
            if (!CanMoveTilesDown) { return false; }

            bool movedTile = false;
            int rowIndexMax = this.RowSize - 1;
            this.scoreIncreaseValue = 0;
            BackupOperationHistory();

            for (int currentPos = BoardSize - this.ColumnSize - 1; currentPos >= 0; currentPos--)
            {
                // 指定のマスにタイルが存在しない場合
                if (!this.Tiles[currentPos].IsExist || ConvertToCoordinates(currentPos)[0] == rowIndexMax) {
                    continue;
                }

                int nextPos = GetNextMoveDownPosition(currentPos);

                // 移動先が無かった場合、スキップする。
                if (nextPos == -1) { continue; }

                // タイルの移動を試みる
                if (MoveTile(currentPos, nextPos)) { movedTile = true; }
            }

            // 移動に成功した場合、タイルを生成する。
            if (movedTile) { this.CreateNewTile(1); }
            return movedTile;
        }

        /// <summary>
        /// タイルの状態を一つ前に戻す
        /// </summary>
        public void RestoreTiles()
        {
            for (int i = 0; i < this.pastTilesInfo.Length; i++) {
                this.tiles[i].Data = this.pastTilesInfo[i].Data;
                this.tiles[i].IsExist = this.pastTilesInfo[i].IsExist;
            }
            this.score -= this.ScoreIncreaseValue;
        }

        /// <summary>
        /// タイルの状態を記録する
        /// </summary>
        private void BackupOperationHistory()
        {
            for (int i = 0; i < this.Tiles.Length; i++) {
                this.pastTilesInfo[i].Data = this.Tiles[i].Data;
                this.pastTilesInfo[i].IsExist = this.Tiles[i].IsExist;
            }
        }
    }
}