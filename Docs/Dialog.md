# Dialog Struct

| Property         | Description                                           |
| ---------------- | ----------------------------------------------------- |
| Title            | The title of the dialog window                        |
| FileName         | The default file name displayed in the dialog         |
| DefaultDirectory | The initial directory displayed when the dialog opens |
| DefaultExt       | The default file extension for the file name          |
| Filter           | The file type filter for the dialog                   |


## OpenfileDialog

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
    MessageBox.Show($"������ ����: {filename}");
}
```

## SaveFileDialog

```cs
var _dialog = new Microsoft.Win32.SaveFileDialog();
_dialog.Title = "Save a File";
_dialog.FileName = "";
_dialog.DefaultDirectory = "";
_dialog.DefaultExt = "";
_dialog.Filter = "All Files (*,*)|*.*|Text Document (.txt)|*.txt|C# (.cs)|*.cs|Go (.go, .mod, .sum)|*.go, *mod, *sum";

bool? result = _dialog.ShowDialog();

if (_dialog.FileName != "")
{
    if (result == StatusType.disable)
    {
        MessageBox.Show("���� ������ ��ҵǾ����ϴ�.");
    }
    else
    {
        string filename = _dialog.FileName;
        MessageBox.Show($"������ ����Ǿ����ϴ�: {filename}");
    }
}
```