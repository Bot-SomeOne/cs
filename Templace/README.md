# Contact:
- **Mail**: *lytranvinh.work@gmail.com*

# How to run:
- Run database in docker:
    + **Note**: changle path volume.
    + After running
    ```
        docker compose up -d
    ```
- Init table db
    + **Note**: Install `dotnet ef global`
    ```bash
      dotnet tool install --global dotnet-ef

    ```
    +  If database first:
        ````
            dotnet ef dbcontext scaffold ... --context-dir Data --output-dir Models

        ````

    +  Create table, ex: 
        ```
            dotnet ef database update --context IdentityDbContext
        ```
    + use ConfigurationManager.ConnectionStrings:
    ```
        string connectionStrings = ConfigurationManager.ConnectionStrings["..."].ConnectionString;
    ```

- File db factory:
```
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;


namespace QLDT_WPF.Data
{
    public class IdentityDbContextFactory : IDesignTimeDbContextFactory<IdentityDbContext>
    {
        public IdentityDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<IdentityDbContext>();
            // Set the connection string or any other options here
            string connectionStrings = ConfigurationManager.ConnectionStrings["IdentityDbConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionStrings);

            return new IdentityDbContext(optionsBuilder.Options);
        }
    }
}
```