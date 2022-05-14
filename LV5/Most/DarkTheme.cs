using System;
using System.Collections.Generic;
using System.Text;

/*5.zad Napisati još jednu temu za zabilješke po vlastitom ukusu te ju testirati.*/
namespace Most
{
    class DarkTheme:ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string GetHeader(int width)
        {
            return new string('-', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}
