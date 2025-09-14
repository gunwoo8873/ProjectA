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

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

struct StatusType
{
    public const bool enable = true;
    public const bool disable = false;
}

namespace Dialog
{
    public class OpenWindow
    {
        public void Open()
        {
            var _dialog = new Microsoft.Win32.OpenFileDialog();
            _dialog.FileName = "Document"; // Open new Window to show dirdctory in the file list
            _dialog.DefaultExt = ""; // Defualt file extansion
            _dialog.Filter = "All Files (*,*)|*.*|Text Document (.txt)|*.txt|C# (.cs)|*.cs|Go (.go, .mod, .sum)|*.go, *mod, *sum";

            bool? result = _dialog.ShowDialog();

            if (result == StatusType.enable)
            {
                string filename = _dialog.FileName;
                MessageBox.Show($"선택한 파일: {filename}");
            }
        }
    }
}

namespace ProjectA
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Openfile_Window_btn(object Sender, RoutedEventArgs e)
        {
            var win = new Dialog.OpenWindow();
            win.Open();
        }
    }
}