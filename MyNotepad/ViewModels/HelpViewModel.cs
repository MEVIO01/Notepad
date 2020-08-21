using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyNotepad.ViewModels
{
    class HelpViewModel : ObservableObject
    {
        public ICommand HelpCommand { get; }
        public HelpViewModel()
        {
            HelpCommand = new RelyCommand(DisplayAbout);
        }
        private void DisplayAbout()
        {

        }
    }
}
