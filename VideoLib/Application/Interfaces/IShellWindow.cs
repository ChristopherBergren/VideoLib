using System.Windows.Forms;

namespace VideoLib.Application.Interfaces
{
    public interface IShellWindow
    {


        Panel GetNavigationFrame();

        void ShowWindow();

        void CloseWindow();
    }
}
