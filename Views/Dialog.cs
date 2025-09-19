using System.Windows;

struct StatusType
{
    public const bool enable = true;
    public const bool disable = false;
}

struct DefaultElement
{
    public const string DefaultFileName = "";
    public const string DefaultDirectory = "";
    public const string DefaultExt = "";
}

struct FilterType
{
    public const string AllFiles = "All Files (*,*)|*.*";
    public const string TextDocument = "Text Document (.txt)|*.txt";
    public const string CSharp = "C# (.cs)|*.cs";
    public const string Go = "Go (.go, .mod, .sum)|*.go, *.mod, *.sum";
    public const string Markdown = "Markdown (.md)|*.md";
}

namespace View.Dialog
{
    public class File
    {
        public void Open()
        {
            var _dialog = new Microsoft.Win32.OpenFileDialog()
            {
                // _dialog.Title = "Open File";
                // _dialog.FileName = DefaultElement.DefaultFileName; // Open new Window to show dirdctory in the file list
                // _dialog.DefaultExt = DefaultElement.DefaultExt; // Defualt file extansion
                // _dialog.Filter = string.Join("|", new[] {
                //     FilterType.AllFiles,
                //     FilterType.TextDocument,
                //     FilterType.CSharp,
                //     FilterType.Go,
                //     FilterType.Markdown
                // });

                Title = "Open File",
                FileName = DefaultElement.DefaultFileName,
                DefaultExt = DefaultElement.DefaultExt,
                Filter = string.Join("|", new[] {
                FilterType.AllFiles,
                FilterType.TextDocument,
                FilterType.CSharp,
                FilterType.Go,
                FilterType.Markdown
            })
            };

            bool? result = _dialog.ShowDialog();

            if (result == StatusType.enable)
            {
                string filename = _dialog.FileName;
                MessageBox.Show($"Select File : {filename}");
            }
        }

        public void Save()
        {
            var _dialog = new Microsoft.Win32.SaveFileDialog()
            {
                Title = "Save File",
                FileName = DefaultElement.DefaultFileName,
                DefaultExt = DefaultElement.DefaultExt,
                Filter = string.Join("|", new[] {
                FilterType.AllFiles,
                FilterType.TextDocument,
                FilterType.CSharp,
                FilterType.Go,
                FilterType.Markdown
            })
            };

            bool? result = _dialog.ShowDialog();

            // if (_dialog.FileName == null)
            // {
            //     MessageBox.Show("Not input file name");
            // }

            // if (result == StatusType.enable)
            // {
            //     string filename = _dialog.FileName;
            //     MessageBox.Show($"Save File : {filename}");
            // }
        }
    }
    public class Folder
    {
        public void Open()
        {
            var _dialog = new Microsoft.Win32.OpenFolderDialog()
            {
                // _dialog.Title = "Select a folder";
                // _dialog.DefaultDirectory = DefaultElement.DefaultDirectory; // Default view to directory open dialog

                Title = "Open Folder",
                DefaultDirectory = DefaultElement.DefaultDirectory
            };

            bool? result = _dialog.ShowDialog();
        }
    }
}