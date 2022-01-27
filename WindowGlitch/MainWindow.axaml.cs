using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace WindowGlitch
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var panel = new StackPanel
            {
                Orientation = Avalonia.Layout.Orientation.Horizontal,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
            };
            
            var showWindow = new Button();
            showWindow.Click += Show_Window;
            showWindow.Content = "Show Window";
            
            panel.Children.Add(showWindow);

            Content = panel;
        }

        private static void Show_Window(object? sender, RoutedEventArgs e)
        {
            
            var grid = new Grid
            {
                Background = new SolidColorBrush(Colors.Red),
                Children = { new TextBlock()
                {
                    Text = "Mac FullScreen Glitch", Margin = new Thickness(100)
                } }
            };
            
            var newWindow = new Window()
            {
                Content = grid,
                Height = 250,
                Width = 250,
                Position = new PixelPoint(0,0),
                SystemDecorations = SystemDecorations.BorderOnly
            };
            
            newWindow.Show();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}