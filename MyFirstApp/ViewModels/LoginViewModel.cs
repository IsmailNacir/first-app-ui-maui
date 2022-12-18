using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MyFirstApp.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    string email;

    [ObservableProperty]
    string password;

    [ObservableProperty]
    string bindingText;

    [RelayCommand]
    void LoginFunc()
    {
        bindingText = "Binding OK";
    }
}
