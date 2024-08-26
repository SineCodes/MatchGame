using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            var animalEmojis = new List<string>()
            {
                "🐯","🐯",
                "🐊","🐊",
                "🐌","🐌",
                "🐳","🐳",
                "🐍","🐍",
                "🦧","🦧",
                "🐶","🐶",
                "🦆,","🦆",
            };
            Random random = new Random();
            foreach (TextBlock textblock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmojis.Count);
                string nextEmoji = animalEmojis[index];
                textblock.Text = nextEmoji;
                animalEmojis.RemoveAt(index);
            }
        }
    }
}
