﻿using System;
using System.Linq;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Reversi.Model;
using Reversi.Model.classes;
using Reversi.ViewModel;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace Reversi.View
{

    /// <summary>
    ///     それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class ScoreBoard:Page
    {
        public ScoreBoardPageViewModel ScoreBoardPageViewModel { get; set; } = new ScoreBoardPageViewModel(Window.Current.Content as Frame);

        private readonly ScoreClient _scoreUtil;

        public ScoreBoard() 
        {
            _scoreUtil = new ScoreClient();
            InitializeComponent();

            SystemNavigationManager.GetForCurrentView().BackRequested += (sender, args) =>
            {
                var rootframe = Window.Current.Content as Frame;
                if ((rootframe != null) && rootframe.CanGoBack && (args.Handled == false))
                {
                    args.Handled = true;
                    rootframe.GoBack();
                }
            };
        }



        /// <summary>
        ///     スコアがない場合にテキストを表示させる
        /// </summary>
        private  void UpdateScoreDataText()
            => NonScoreText.Visibility =  _scoreUtil.ScoreData.Count == 0 ? Visibility.Visible : Visibility.Collapsed;

        /// <summary>
        ///     リストのデータを端末に保存されているデータを利用して再読み込みする
        /// </summary>
        private  void UpdateListData() => ScoreList.ItemsSource =  _scoreUtil.ScoreData.ToList();


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var rootframe = Window.Current.Content as Frame;
            if ((rootframe != null) && rootframe.CanGoBack)
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
                    AppViewBackButtonVisibility.Visible;
        }

        private async void DeleteScore(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("保存されているスコアを初期化します。");
            await dialog.ShowAsync();
            _scoreUtil.ClearScore();
            UpdateScoreDataText();
            UpdateListData();
        }

        private  void Page_Loaded(object sender, RoutedEventArgs e)
        {
#if DEBUG
            _scoreUtil.ClearScore();
            
            for (var i = 0; i < 100; i++)
            {
                 _scoreUtil.AddScore(GenerateDummyScoreData());
            }

#endif
            UpdateScoreDataText();
            UpdateListData();
        }

        private static ScoreData GenerateDummyScoreData()
        {
            return new ScoreData(new Random().Next(30), new Random().Next(30));
        }

        //スコアを初期化する
    }
}