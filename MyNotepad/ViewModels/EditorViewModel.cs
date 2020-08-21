using MyNotepad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyNotepad.ViewModels
{
    class EditorViewModel
    {
        public ICommand FormatCommand { get; }
        public ICommand WrapCommand { get; }
        public FormatModel Format { get; set; }
        public DocumentModel Document { get; set; }

        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelyCommand(OpenStyleDialog);
            WrapCommand = new RelyCommand(ToggleWrap);
        }
        private void OpenStyleDialog()
        {
            var fontDialog = new FontDialog();
            fontDialog.DataContext = Format;
            fontDialog.ShowDialog();
        }
        private void ToggleWrap()
        {
            if(Format.Wrap == System.Windows.TextWrapping.Wrap)
            {
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.Wrap = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}
