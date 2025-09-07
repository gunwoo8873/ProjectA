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

namespace ProjectA;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

public partial class MainWindow : Window
{
  public MainWindow()
  {
    InitializeComponent();
  }

  private void Name_Add_Btn(object sender, RoutedEventArgs e)
  {
    if (!string.IsNullOrEmpty(txtName.Text) && !listNames.Items.Contains(txtName.Text))
    {
      listNames.Items.Add(txtName.Text);
      txtName.Clear();
    }
  }

  private void Name_Delete_Btn(object sender, RoutedEventArgs e)
  {
    while (listNames.Items.Contains(txtName.Text))
    {
      listNames.Items.Remove(txtName.Text);
    }
  }

  private void Name_Clear_Btn(object sender, RoutedEventArgs e)
  {
    listNames.Items.Clear();
  }
}