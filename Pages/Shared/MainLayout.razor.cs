﻿using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using MyApp.Application.Models;
using MyApp.Application.Services.Auth;

namespace MyApp.Pages.Shared;

public partial class MainLayout
{
    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationStateTask { get; set; } = default!;
    public User? User = new User();

    public string AppName = "";

    [Inject]
    public AuthService AuthService { get; set; } = default!;

    [Inject]
    public IConfiguration Config { get; set; } = default!;

    protected override async Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateTask;

        if (authState.User.Identity.IsAuthenticated)
        {
            User = await AuthService.GetAuthenticatedUser();
        }

        AppName = Config.GetValue<string>("Spark:App:Name");
    }
}
