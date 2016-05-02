﻿using System.Linq;
using System.Xml.Linq;
using Reversi;

namespace Reversi
{

    public class Stone
    {
        public enum StoneColorList { None, White, Black }
        public StoneColorList StoneColor { get; set; } = StoneColorList.None;
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ReversiBoard
    {
        public Stone[][] Board { get; } = {
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()},
                new[] {new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone(), new Stone()}
            };

        public int WhiteStone => Board.Sum(t => t.Count(stone => stone.StoneColor == Stone.StoneColorList.White));
        public int BlackStone => Board.Sum(t => t.Count(stone => stone.StoneColor == Stone.StoneColorList.Black));
        public int NoneStone => Board.Sum(t => t.Count(stone => stone.StoneColor == Stone.StoneColorList.None));

        public bool CheckBoardPointRange(int x, int y) => x >= 0 && x >= Board.Length && y >= 0 && y >= Board.Length;

        public Stone GetTopStone(Stone stone) => Board[stone.X - 1][stone.Y];
        public Stone GetUnderStone(Stone stone) => Board[stone.X + 1][stone.Y];
        public Stone GetRightStone(Stone stone) => Board[stone.X][stone.Y -1];
        public Stone GetLeftStone(Stone stone) => Board[stone.X][stone.Y + 1];

    }

}

public class ReversiLib
{
    public ReversiBoard ReversiBoard { get; } = new ReversiBoard();

    /// <summary>
    /// 石が置けた場合はTrue を返す
    /// </summary>
    /// <param name="stone"></param>
    /// <returns></returns>
    public bool PutStone(Stone stone)
    {
        if (stone == null) return false;
        if (ReversiBoard.Board[stone.X][stone.Y].StoneColor != Stone.StoneColorList.None) return false;
        if (IsChangeStoneColor(stone)) return false;
        //数字がおかしかったらダメよ！
        if (stone.X < 0 || stone.X > 8) return false;
        if (stone.Y < 0 || stone.Y > 8) return false;

        ReversiBoard.Board[stone.X][stone.Y] = stone;

        if (IsChangeStoneColor(stone))
        {
        }
        return true;
    }

    public void ChangeStoneColor(Stone stone)
    {
        ReversiBoard.Board[stone.X][stone.Y].StoneColor = GetEnemyColor(stone);
    }


    /// <summary>
    /// 石の色が変化するか判定する
    /// </summary>
    /// <param name="nowstone">判定元となる石の情報</param>
    /// <returns>石の色を変更するかどうか</returns>
    public bool IsChangeStoneColor(Stone nowstone)
    {
        var enemyColor = GetEnemyColor(nowstone);

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
    public Stone.StoneColorList GetEnemyColor(Stone nowColorList) =>
        nowColorList.StoneColor == Stone.StoneColorList.Black ?
        Stone.StoneColorList.White : Stone.StoneColorList.Black;

    /// <summary>
    /// 上の石の情報を取得する
    /// </summary>
    /// <param name="nowStone">起点となる石の情報</param>
    /// <returns>上にある石の情報</returns>
    protected Stone GetTopStone(Stone nowStone)
        => nowStone.Y == 0
        ? new Stone() : ReversiBoard.Board[nowStone.X][nowStone.Y - 1];

    /// <summary>
    /// 下にある石の情報を取得する
    /// </summary>
    /// <param name="nowStone">起点となる石の情報</param>
    /// <returns>下にある石の情報</returns>
    protected Stone GetUnderStone(Stone nowStone)
        => nowStone.Y == ReversiBoard.Board.Length
        ? new Stone() : ReversiBoard.Board[nowStone.X][nowStone.Y + 1];

    /// <summary>
    /// 右にある石の情報を取得する
    /// </summary>
    /// <param name="nowStone">起点となる石の情報</param>
    /// <returns>右にある石の情報</returns>
    protected Stone GetRightStone(Stone nowStone)
        => nowStone.X == 0
        ? new Stone() : ReversiBoard.Board[nowStone.X + 1][nowStone.Y];

    /// <summary>
    /// 左にある石の情報
    /// </summary>
    /// <param name="nowStone">起点となる石の情報</param>
    /// <returns>左にある石の情報</returns>
    protected Stone GetLeftStone(Stone nowStone)
        => nowStone.X == ReversiBoard.Board[0].Length
        ? new Stone() : ReversiBoard.Board[nowStone.X - 1][nowStone.Y];
}


}