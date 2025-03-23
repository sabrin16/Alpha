using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Webapp.Models;

namespace Webapp.Data;

public class DataContext(DbContextOptions<DataContext> options) : IdentityDbContext<AppUser>(options)
{

}