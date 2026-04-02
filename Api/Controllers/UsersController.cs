using Api.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Contracts;

namespace Api.Controllers;

[ApiController]
[Route("api/users")]
[Authorize(Roles = Roles.Admin)]
public sealed class UsersController(UserManager<User> users) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var all = users.Users.ToList();
        var result = new List<UserDto>();
        foreach (var u in all)
        {
            var roles = await users.GetRolesAsync(u);
            result.Add(new UserDto(u.Id, u.Email!, u.IsActive, roles.ToList()));
        }
        return Ok(result);
    }

    [HttpPost("{id:guid}/activate")]
    public async Task<IActionResult> Activate(Guid id)
    {
        var user = await users.FindByIdAsync(id.ToString());
        if (user is null)
        {
            return NotFound();
        }

        user.IsActive = true;
        await users.UpdateAsync(user);
        return Ok();
    }

    [HttpPost("{id:guid}/deactivate")]
    public async Task<IActionResult> Deactivate(Guid id)
    {
        var user = await users.FindByIdAsync(id.ToString());
        if (user is null)
        {
            return NotFound();
        }

        user.IsActive = false;
        await users.UpdateAsync(user);
        return Ok();
    }
}
