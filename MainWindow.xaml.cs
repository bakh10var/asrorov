using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace asrorov1
{
        public partial class MainWindow : Window
        {
            private SolidColorBrush currentBrushColor = Brushes.Black;
            private double currentBrushSize = 10;
            private string currentMode = "Рисование";

            public MainWindow()
            {
                InitializeComponent();
            }

            // Обработчик выбора цвета кисти
            private void BrushColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                var selectedColor = ((ComboBoxItem)BrushColorComboBox.SelectedItem).Content.ToString();
                switch (selectedColor)
                {
                    case "Черный":
                        currentBrushColor = Brushes.Black;
                        break;
                    case "Красный":
                        currentBrushColor = Brushes.Red;
                        break;
                    case "Зеленый":
                        currentBrushColor = Brushes.Green;
                        break;
                    case "Синий":
                        currentBrushColor = Brushes.Blue;
                        break;
                }
            }

            // Обработчик изменения размера кисти
            private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                currentBrushSize = e.NewValue;
            }

            // Обработчик переключения режимов
            private void ModeRadioButton_Checked(object sender, RoutedEventArgs e)
            {
                if (DrawModeRadioButton.IsChecked == true)
                {
                    currentMode = "Рисование";
                }
                else if (EditModeRadioButton.IsChecked == true)
                {
                    currentMode = "Редактирование";
                }
                else if (DeleteModeRadioButton.IsChecked == true)
                {
                    currentMode = "Удаление";
                }
            }

            // Рисование на холсте
            private void DrawingCanvas_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (currentMode == "Рисование")
                {
                    Ellipse ellipse = new Ellipse
                    {
                        Fill = currentBrushColor,
                        Width = currentBrushSize,
                        Height = currentBrushSize
                    };
                    Canvas.SetLeft(ellipse, e.GetPosition(DrawingCanvas).X - currentBrushSize / 2);
                    Canvas.SetTop(ellipse, e.GetPosition(DrawingCanvas).Y - currentBrushSize / 2);
                    DrawingCanvas.Children.Add(ellipse);
                }
            }

            // Движение мыши для добавления точек
            private void DrawingCanvas_MouseMove(object sender, MouseEventArgs e)
            {
                if (e.LeftButton == MouseButtonState.Pressed && currentMode == "Рисование")
                {
                    Ellipse ellipse = new Ellipse
                    {
                        Fill = currentBrushColor,
                        Width = currentBrushSize,
                        Height = currentBrushSize
                    };
                    Canvas.SetLeft(ellipse, e.GetPosition(DrawingCanvas).X - currentBrushSize / 2);
                    Canvas.SetTop(ellipse, e.GetPosition(DrawingCanvas).Y - currentBrushSize / 2);
                    DrawingCanvas.Children.Add(ellipse);
                }
            }
        }
    }

