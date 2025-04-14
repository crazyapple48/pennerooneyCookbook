using System;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using System.Linq;
using Avalonia.Markup.Xaml;
using Avalonia.Metadata;
using Microsoft.Extensions.DependencyInjection;
using Pennerooney_Cookbook.Factories;
using Pennerooney_Cookbook.ViewModels;
using Pennerooney_Cookbook.Views;

[assembly: XmlnsDefinition("https://github.com/avaloniaui", "Pennerooney_Cookbook.Controls")]

namespace Pennerooney_Cookbook;

public partial class App : Application
{

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<MainViewModel>();

        services.AddTransient<HomePageViewModel>();
        services.AddTransient<NewRecipePageViewModel>();

        services.AddSingleton<PageFactory>();

        services.AddSingleton<Func<Type, PageViewModel>>(x => type => type switch
        {
            _ when type == typeof(HomePageViewModel) => x.GetRequiredService<HomePageViewModel>(),
            _ when type == typeof(NewRecipePageViewModel) => x.GetRequiredService<NewRecipePageViewModel>(),
            _ => throw new InvalidOperationException()
        });
    }
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);
        
        var services = serviceCollection.BuildServiceProvider();
        
        var vm = services.GetRequiredService<MainViewModel>();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // Avoid duplicate validations from both Avalonia and the CommunityToolkit. 
            // More info: https://docs.avaloniaui.net/docs/guides/development-guides/data-validation#manage-validationplugins
            DisableAvaloniaDataAnnotationValidation();
            desktop.MainWindow = new MainWindow
            {
                DataContext = vm
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = vm
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private void DisableAvaloniaDataAnnotationValidation()
    {
        // Get an array of plugins to remove
        var dataValidationPluginsToRemove =
            BindingPlugins.DataValidators.OfType<DataAnnotationsValidationPlugin>().ToArray();

        // remove each entry found
        foreach (var plugin in dataValidationPluginsToRemove)
        {
            BindingPlugins.DataValidators.Remove(plugin);
        }
    }
}