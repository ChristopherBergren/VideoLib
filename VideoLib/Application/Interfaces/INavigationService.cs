using System;
using System.Windows.Forms;

namespace VideoLib.Application.Interfaces
{
    public interface INavigationService
    {

        void Initialize(Panel shellFrame);


        bool NavigateTo(string pageKey, object parameter = null, bool clearNavigation = false);
    }
}
