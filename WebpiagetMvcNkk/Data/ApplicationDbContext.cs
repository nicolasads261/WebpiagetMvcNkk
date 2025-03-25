using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebpiagetMvcNkk.Models;

namespace WebpiagetMvcNkk.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

public DbSet<WebpiagetMvcNkk.Models.Aluno> Aluno { get; set; } = default!;
}
