using CommunityToolkit.Mvvm.ComponentModel;
using Pennerooney_Cookbook.Data;

namespace Pennerooney_Cookbook.ViewModels;

public partial class PageViewModel : ViewModelBase
{
    [ObservableProperty]
    private PageNames _pageName;

    protected PageViewModel(PageNames pageName)
    {
        _pageName = pageName;

        if (Avalonia.Controls.Design.IsDesignMode)
            OnDesignTimeConstructor();
    }
    
    protected virtual void OnDesignTimeConstructor() {}
}