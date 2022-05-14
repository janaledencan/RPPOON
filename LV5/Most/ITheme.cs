using System;
using System.Collections.Generic;
using System.Text;

namespace Most
{
    interface ITheme
    {
        void SetBackgroundColor();
        void SetFontColor();
        string GetHeader(int width);
        string GetFooter(int width);
    }
}
