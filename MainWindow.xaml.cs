using System.IO.Enumeration;
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

using View.Dialog;

//using Options;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

namespace ProjectA;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Openfile_btn(object Sender, RoutedEventArgs e)
    {
        var win = new View.Dialog.File();
        win.Open();
    }

    private void Savefile_btn(object Sender, RoutedEventArgs e)
    {
        var win = new View.Dialog.File();
        win.Save();
    }

    private void Openfolder_btn(object Sender, RoutedEventArgs e)
    {
        var win = new View.Dialog.Folder();
        win.Open();
    }
}