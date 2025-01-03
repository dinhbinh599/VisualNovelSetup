using System;
using System.IO;
using Avalonia.Controls;
using Avalonia.Platform.Storage;

namespace VisualNovelSetup.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private async void SelectFolder_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        // Create and show the folder selection dialog
        var result = await this.StorageProvider.OpenFolderPickerAsync(new FolderPickerOpenOptions
        {
            Title = "Select a Folder",
            AllowMultiple = true
        });
        
        Console.WriteLine(result[0].Path.LocalPath);
    }
}