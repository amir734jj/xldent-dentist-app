using Api.Data.Entities;
using Api.Extensions;
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
    private Guid CurrentUserId => User.GetUserId();

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var all = users.Users.ToList();
        var result = new List<UserDto>();
        foreach (var u in all)
        {
            var roles = await users.GetRolesAsync(u);
            result.Add(new UserDto(u.Id, u.Email!, u.IsActive, roles.ToList(), u.LastLoginAt));
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
        if (id == CurrentUserId)
        {
            return BadRequest("You cannot deactivate your own account.");
        }

        var user = await users.FindByIdAsync(id.ToString());
        if (user is null)
        {
            return NotFound();
        }

        user.IsActive = false;
        await users.UpdateAsync(user);
        return Ok();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        if (id == CurrentUserId)
        {
            return BadRequest("You cannot delete your own account.");
        }

        var user = await users.FindByIdAsync(id.ToString());
        if (user is null)
        {
            return NotFound();
        }

        await users.DeleteAsync(user);
        return NoContent();
    }
}
