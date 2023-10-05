using Microsoft.AspNetCore.Components;
using MyApp.Application.Models;

namespace MyApp.Pages.Shared;

public partial class NavMenu
{
    [CascadingParameter]
    public MainLayout? Layout { get; set; }
    private User? user => Layout?.User;
}
