using System;
using Pennerooney_Cookbook.ViewModels;

namespace Pennerooney_Cookbook.Factories;

public class PageFactory(Func<Type, PageViewModel> factory)
{
    public PageViewModel GetPageViewModel<T>(Action<T>? afterCreation = null)
        where T: PageViewModel
    {
        var viewModel = factory(typeof(T));
        
        afterCreation?.Invoke((T)viewModel);
        
        return viewModel;
    }
}