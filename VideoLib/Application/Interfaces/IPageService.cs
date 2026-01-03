using System;
using System.Windows.Forms;

namespace VideoLib.Application.Interfaces
{
    public interface IPageService
    {
        Type GetPageType(string key);

        UserControl GetPage(string key);
    }
}
