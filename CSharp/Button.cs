using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Button
    {
        public delegate void OnClickHandler();
        public event OnClickHandler? OnCLick;
        public void ClickButton()
        {
            Console.WriteLine("Button clicked");
            OnCLick?.Invoke();
        }
    }
}
