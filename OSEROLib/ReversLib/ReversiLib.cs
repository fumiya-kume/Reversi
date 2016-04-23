﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversLib
{
    public class ReversiLib
    {

    }

    public class ReversiBoard
    {
        public StoneInfo[,] BoardInfos { get; set; }
        public Exception NoneStoneException;

        public ReversiBoard()
        {
            #region StoneBoard
            BoardInfos = new[,]
            {
                { new StoneInfo {StonePositionX = 0,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 0},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 0}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 1},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 1}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 2},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 2}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 3},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 3}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 4},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 4}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 5},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 5}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 6},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 6}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 7},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 7}},
                { new StoneInfo {StonePositionX = 0,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 1,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 2,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 3,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 4,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 5,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 6,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 7,StonePositonY = 8},
                  new StoneInfo {StonePositionX = 8,StonePositonY = 8}}
            };
            #endregion

        }

        public StoneInfo.StoneColorList GetEnemyColor(StoneInfo nowstoneInfo) => nowstoneInfo.StoneColor == StoneInfo.StoneColorList.Black
            ? StoneInfo.StoneColorList.White
            : StoneInfo.StoneColorList.Black;

        /// <summary>
        /// 上の石の情報を取得する
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>上にある石の情報</returns>
        protected StoneInfo GetTopStoneInfo(StoneInfo nowStone) => nowStone.StonePositonY == 0
            ? new StoneInfo { StoneColor = StoneInfo.StoneColorList.None }
            : BoardInfos[nowStone.StonePositionX, nowStone.StonePositonY - 1];

        /// <summary>
        /// 下にある石の情報を取得する
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>下にある石の情報</returns>
        protected StoneInfo GetUnderStoneInfo(StoneInfo nowStone) => nowStone.StonePositonY == BoardInfos.GetLength(0)
            ? new StoneInfo { StoneColor = StoneInfo.StoneColorList.None }
            : BoardInfos[nowStone.StonePositionX, nowStone.StonePositonY + 1];

        /// <summary>
        /// 右にある石の情報を取得する
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>右にある石の情報</returns>
        protected StoneInfo GetRightStoneInfo(StoneInfo nowStone) => nowStone.StonePositionX == BoardInfos.GetLength(1)
            ? new StoneInfo { StoneColor = StoneInfo.StoneColorList.None }
            : BoardInfos[nowStone.StonePositionX + 1, nowStone.StonePositonY];

        /// <summary>
        /// 左にある石の情報
        /// </summary>
        /// <param name="nowStone">起点となる石の情報</param>
        /// <returns>左にある石の情報</returns>
        protected StoneInfo GetLeftStoneInfo(StoneInfo nowStone) => nowStone.StonePositionX == 0
            ? new StoneInfo { StoneColor = StoneInfo.StoneColorList.None }
            : BoardInfos[nowStone.StonePositionX - 1, nowStone.StonePositonY];
    }

    public struct StoneInfo
    {
        public enum StoneColorList
        {
            None,
            White,
            Black
        }
        public StoneColorList StoneColor { get; set; }
        public int StonePositionX { get; set; }
        public int StonePositonY { get; set; }
    }
}