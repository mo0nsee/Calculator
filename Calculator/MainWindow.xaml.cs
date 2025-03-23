using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Добавление в строку "0"
    /// </summary>
    private void Button_Click_0(object sender, RoutedEventArgs e)
    {
        result.Text += "0";
    }

    /// <summary>
    /// Добавление в строку ","
    /// </summary>
    private void Button_Click_Comma(object sender, RoutedEventArgs e)
    {
        result.Text += ",";
    }

    /// <summary>
    /// Добавление в строку "3"
    /// </summary>
    private void Button_Click_3(object sender, RoutedEventArgs e)
    {
        result.Text += "3";
    }

    /// <summary>
    /// Добавление в строку "2"
    /// </summary>
    private void Button_Click_2(object sender, RoutedEventArgs e)
    {
        result.Text += "2";
    }

    /// <summary>
    /// Добавление в строку "1"
    /// </summary>
    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
        result.Text += "1";
    }

    /// <summary>
    /// Добавление в строку ")"
    /// </summary>
    private void Button_Click_RightBracket(object sender, RoutedEventArgs e)
    {
        result.Text += ")";
    }

    /// <summary>
    /// Добавление в строку "6"
    /// </summary>
    private void Button_Click_6(object sender, RoutedEventArgs e)
    {
        result.Text += "6";
    }

    /// <summary>
    /// Добавление в строку "5"
    /// </summary>
    private void Button_Click_5(object sender, RoutedEventArgs e)
    {
        result.Text += "5";
    }

    /// <summary>
    /// Добавление в строку "4"
    /// </summary>
    private void Button_Click_4(object sender, RoutedEventArgs e)
    {
        result.Text += "4";
    }

    /// <summary>
    /// Добавление в строку "("
    /// </summary>
    private void Button_Click_LeftBracket(object sender, RoutedEventArgs e)
    {
        result.Text += "(";
    }

    /// <summary>
    /// Добавление в строку "9"
    /// </summary>
    private void Button_Click_9(object sender, RoutedEventArgs e)
    {
        result.Text += "9";
    }

    /// <summary>
    /// Добавление в строку "8"
    /// </summary>
    private void Button_Click_8(object sender, RoutedEventArgs e)
    {
        result.Text += "8";
    }

    /// <summary>
    /// Добавление в строку "7"
    /// </summary>
    private void Button_Click_7(object sender, RoutedEventArgs e)
    {
        result.Text += "7";
    }

    /// <summary>
    /// Удаление одного элемента строки
    /// </summary>
    private void Button_Click_Delete(object sender, RoutedEventArgs e)
    {
        if(!string.IsNullOrEmpty(result.Text))
        {
            var stringBuilder = new StringBuilder(result.Text);
            stringBuilder.Length--;
            result.Text = stringBuilder.ToString();
        }
    }

    /// <summary>
    /// Очистка строк
    /// </summary>
    private void Button_Click_Clear(object sender, RoutedEventArgs e)
    {
        if (!string.IsNullOrEmpty(result.Text))
            result.Text = string.Empty;

        if (!string.IsNullOrEmpty(history.Text))
            history.Text = string.Empty;
    }

    /// <summary>
    /// Добавление в строку "%"
    /// </summary>
    private void Button_Click_Remainder(object sender, RoutedEventArgs e)
    {
        result.Text += "%";
    }

    /// <summary>
    /// Добавление в строку "+"
    /// </summary>
    private void Button_Click_Plus(object sender, RoutedEventArgs e)
    {
        result.Text += "+";
    }

    /// <summary>
    /// Добавление в строку "-"
    /// </summary>
    private void Button_Click_Minus(object sender, RoutedEventArgs e)
    {
        result.Text += "-";
    }

    /// <summary>
    /// Добавление в строку "*"
    /// </summary>
    private void Button_Click_Multiplication(object sender, RoutedEventArgs e)
    {
        result.Text += "*";
    }

    /// <summary>
    /// Добавление в строку "/"
    /// </summary>
    private void Button_Click_Division(object sender, RoutedEventArgs e)
    {
        result.Text += "/";
    }
}