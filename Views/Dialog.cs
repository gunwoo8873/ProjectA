struct StatusType
{
    public const bool enable = true;
    public const bool disable = false;
}

namespace View.Dialog
{
    public class File
    {
        public void Open()
        {
            var _dialog = new Microsoft.Win32.OpenFileDialog();
            _dialog.Title = "Open File";
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

        public void Save()
        {
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
                    MessageBox.Show("파일 저장이 취소되었습니다.");
                }
                else
                {
                    string filename = _dialog.FileName;
                    MessageBox.Show($"파일이 저장되었습니다: {filename}");
                }
            }
        }
    }

    public class Folder
    {
        public void Open()
        {
            var _dialog = new Microsoft.Win32.OpenFolderDialog();
            _dialog.Title = "Select a folder";
            _dialog.DefaultDirectory = ""; // Default view to directory open dialog
        }
    }
}