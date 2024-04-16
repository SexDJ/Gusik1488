using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Gusik1488
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == true)
            {
                string filename = openFileDialog.FileName;
                string text = File.ReadAllText(filename);
                textBox.Text = text;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, textBox.Text);
            }
        }

        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            if (saveFileDialog.ShowDialog() == true)
            {
                string filename = saveFileDialog.FileName;
                File.WriteAllText(filename, textBox.Text);
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.SelectedText != "")
                textBox.Copy();
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            textBox.Paste();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.CanUndo)
                textBox.Undo();
        }

        private void Font_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для выбора шрифта
            if (sender is Button)
            {
                // Пример изменения шрифта на "Arial"
                textBox.FontFamily = new FontFamily("Arial");
            }
        }

        private void FontSize_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для выбора размера шрифта
            if (sender is Button)
            {
                // Пример изменения размера шрифта на 16
                textBox.FontSize = 16;
            }
        }

        private void FontWeight_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для выбора насыщенности шрифта
            if (sender is Button)
            {
                // Пример изменения насыщенности шрифта на "Bold"
                textBox.FontWeight = FontWeights.Bold;
            }
        }

        private void Italic_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для наклона шрифта
            if (sender is Button)
            {
                // Пример изменения стиля шрифта на курсив
                FontStyle italic = FontStyles.Italic;
                textBox.FontStyle = italic;
            }
        }

        private void Underline_Click(object sender, RoutedEventArgs e)
        {
            // Добавьте код для подчеркивания текста
            if (sender is Button)
            {
                // Пример добавления подчеркивания
                textBox.TextDecorations = TextDecorations.Underline;
            }
        }
    }
}