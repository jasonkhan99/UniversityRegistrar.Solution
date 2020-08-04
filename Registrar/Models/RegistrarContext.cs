using Microsoft.EntityFrameworkCore;

namespace Registrar.Models
{
  public class RegistrarContext : DbContext
  {
    public RegistrarContext(DbContextOptions options) : base(options) { }
  }
}