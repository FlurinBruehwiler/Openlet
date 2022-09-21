using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Openlet.Models;

namespace Openlet.Services;

public class UserService
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;
    private readonly OpenletContext _openletContext;

    public UserService(AuthenticationStateProvider authenticationStateProvider, OpenletContext openletContext)
    {
        _authenticationStateProvider = authenticationStateProvider;
        _openletContext = openletContext;
    }
    
    public async Task<User> GetUser()
    {
        var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();

        var username = authState.User.Identity?.Name;

        var user = await _openletContext.Users.FirstOrDefaultAsync(x => x.Email == username);

        if (user is null)
            throw new Exception("User not found");

        return user;
    }   
}