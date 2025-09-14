# OpenfileDialog

```cs
//// Create OpenFileDialog new instance
var _dialog = new Microsoft.Win32.OpenFileDialog();
_dialog.FileName = "Document"; // Open new Window to show dirdctory in the file list
_dialog.DefaultExt = ""; // Defualt file extansion
_dialog.Filter = "All Files (*,*)|*.*|Text Document (.txt)|*.txt";

//// Show Openfile Dialog
bool? result = _dialog.ShowDialog();

//// Process open file dialog box results
if (result == true)
{
    string filename = _dialog.FileName;
    MessageBox.Show($"선택한 파일: {filename}");
}
```