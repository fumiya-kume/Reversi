﻿namespace Reversi
{
    public class ReversiLib
    {

    }

    public class ReversiBoard
    {
        public Stone[,] Board { get; set; }

        public ReversiBoard()
        {
            #region StoneBoard
            Board = new[,]
            {
                { new Stone {X = 0,Y = 0},new Stone {X = 1,Y = 0},new Stone {X = 2,Y = 0},new Stone {X = 3,Y = 0},new Stone {X = 4,Y = 0},new Stone {X = 5,Y = 0},new Stone {X = 6,Y = 0},new Stone {X = 7,Y = 0},new Stone {X = 8,Y = 0}},
                { new Stone {X = 0,Y = 1},new Stone {X = 1,Y = 1},new Stone {X = 2,Y = 1},new Stone {X = 3,Y = 1},new Stone {X = 4,Y = 1},new Stone {X = 5,Y = 1},new Stone {X = 6,Y = 1},new Stone {X = 7,Y = 1},new Stone {X = 8,Y = 1}},
                { new Stone {X = 0,Y = 2},new Stone {X = 1,Y = 2},new Stone {X = 2,Y = 2},new Stone {X = 3,Y = 2},new Stone {X = 4,Y = 2},new Stone {X = 5,Y = 2},new Stone {X = 6,Y = 2},new Stone {X = 7,Y = 2},new Stone {X = 8,Y = 2}},
                { new Stone {X = 0,Y = 3},new Stone {X = 1,Y = 3},new Stone {X = 2,Y = 3},new Stone {X = 3,Y = 3},new Stone {X = 4,Y = 3},new Stone {X = 5,Y = 3},new Stone {X = 6,Y = 3},new Stone {X = 7,Y = 3},new Stone {X = 8,Y = 3}},
                { new Stone {X = 0,Y = 4},new Stone {X = 1,Y = 4},new Stone {X = 2,Y = 4},new Stone {X = 3,Y = 4},new Stone {X = 4,Y = 4},new Stone {X = 5,Y = 4},new Stone {X = 6,Y = 4},new Stone {X = 7,Y = 4},new Stone {X = 8,Y = 4}},
                { new Stone {X = 0,Y = 5},new Stone {X = 1,Y = 5},new Stone {X = 2,Y = 5},new Stone {X = 3,Y = 5},new Stone {X = 4,Y = 5},new Stone {X = 5,Y = 5},new Stone {X = 6,Y = 5},new Stone {X = 7,Y = 5},new Stone {X = 8,Y = 5}},
                { new Stone {X = 0,Y = 6},new Stone {X = 1,Y = 6},new Stone {X = 2,Y = 6},new Stone {X = 3,Y = 6},new Stone {X = 4,Y = 6},new Stone {X = 5,Y = 6},new Stone {X = 6,Y = 6},new Stone {X = 7,Y = 6},new Stone {X = 8,Y = 6}},
                { new Stone {X = 0,Y = 7},new Stone {X = 1,Y = 7},new Stone {X = 2,Y = 7},new Stone {X = 3,Y = 7},new Stone {X = 4,Y = 7},new Stone {X = 5,Y = 7},new Stone {X = 6,Y = 7},new Stone {X = 7,Y = 7},new Stone {X = 8,Y = 7}},
                { new Stone {X = 0,Y = 8},new Stone {X = 1,Y = 8},new Stone {X = 2,Y = 8},new Stone {X = 3,Y = 8},new Stone {X = 4,Y = 8},new Stone {X = 5,Y = 8},new Stone {X = 6,Y = 8},new Stone {X = 7,Y = 8},new Stone {X = 8,Y = 8}}
            };
            #endregion

        }

        /// <summary>
        /// 石の色が変化するか判定する
        /// </summary>
        /// <param name="nowstone">判定元となる石の情報</param>
        /// <returns>石の色を変更するかどうか</returns>
        public bool IsChangeStoneColor(Stone nowstone)
        {
            var enemyColor = GetEnemyStone(nowstone);
            if (enemyColor == GetTopStone(nowstone).StoneColor &&
                enemyColor == GetUnderStone(nowstone).StoneColor) return true;

            if (enemyColor == GetRightStone(nowstone).StoneColor &&
                enemyColor == GetLeftStone(nowstone).StoneColor) return true;

            return false;
        }

        /// <summary>
        /// 敵の石の色を取得する
        /// </summary>
        /// <param name="nowColorList">現在の石の色</param>
        /// <returns>敵の色の情報</returns>
        public Stone.StoneColorList GetEnemyStone(Stone nowColorList)
            => nowColorList.StoneColor == Stone.StoneColorList.Black
            ? Stone.StoneColorList.White
            : Stone.StoneColorList.Black;

        /// <summary>
        /// 上の石の情報を取得する
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>上にある石の情報</returns>
        protected Stone GetTopStone(Stone nowStone) 
            => nowStone.Y == 0
            ? new Stone()
            : Board[nowStone.X, nowStone.Y - 1];

        /// <summary>
        /// 下にある石の情報を取得する
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>下にある石の情報</returns>
        protected Stone GetUnderStone(Stone nowStone) 
            => nowStone.Y == Board.GetLength(0)
            ? new Stone()
            : Board[nowStone.X, nowStone.Y + 1];

        /// <summary>
        /// 右にある石の情報を取得する
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>右にある石の情報</returns>
        protected Stone GetRightStone(Stone nowStone) 
            => nowStone.X == Board.GetLength(1)
            ? new Stone()
            : Board[nowStone.X + 1, nowStone.Y];

        /// <summary>
        /// 左にある石の情報
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>左にある石の情報</returns>
        protected Stone GetLeftStone(Stone nowStone) 
            => nowStone.X == 0
            ? new Stone()
            : Board[nowStone.X - 1, nowStone.Y];
    }

    public class Stone
    {
        public enum StoneColorList
        {
            None,
            White,
            Black
        }
        public StoneColorList StoneColor { get; set; } = StoneColorList.None;
        public int X { get; set; }
        public int Y { get; set; }


    }
}