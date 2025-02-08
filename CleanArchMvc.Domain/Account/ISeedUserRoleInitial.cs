namespace CleanArchMvc.Domain.Account;
public interface ISeedUserRoleInitial
{
    Task SeedRolesAsync();
    Task SeedUsersAsync();
}
