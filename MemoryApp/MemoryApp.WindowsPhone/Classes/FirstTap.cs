using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MemoryApp.Classes
{
    public class FirstTap
    {
        private string firtsTap;
        public string _firstTap { get { return firtsTap; } set { firtsTap = value; } }
        private TextBlock previousButton;
        public TextBlock _previousButton { get { return previousButton; } set { previousButton = value; } }
        public FirstTap() {
            previousButton = new TextBlock();
            firtsTap = "20";
        }
    }
}
