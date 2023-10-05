using Microsoft.AspNetCore.Components;
using MyApp.Application.Models;
using MyApp.Pages.Shared;

namespace MyApp.Pages;

public partial class Dashboard
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout.User;
}
