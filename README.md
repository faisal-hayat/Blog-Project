# Blog Project 
[Source](https://www.youtube.com/watch?v=jhj9ouy7x1g&ab_channel=SameerSaini)

--- ---

## Required Tools

- Entity Framework Core
- Entity Framework Sql Server
- Entity Framework Core Tools

--- ---

## Add DbContext

```C#
using Microsoft.EntityFrameworkCore;

namespace BlogProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
    }

    // Here we will be adding the subsequent models
}

```
--- ---

## Setting in **_program.cs_**

```C#
builder.Services.AddDbContext<BlogProject.Models.ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")));
```

--- ---

## Migrate the Database

```shell
Add-Migration "migration message"
update-database
```

--- ---

## Routing in ASP.Net Core

- Rouing following rules **_Model/action_method/View_**



--- ---