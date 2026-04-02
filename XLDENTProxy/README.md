# XLDENT utility

This project contains the EF Core `DbContext` and entity models scaffolded from the `DRDATA` MySQL database.

## Re-scaffolding from the database

Run from the solution root. This overwrites existing generated files.

```bash
dotnet ef dbcontext scaffold \
  "server=localhost;uid=root;pwd=<password>;port=3306;database=DRDATA" \
  MySql.EntityFrameworkCore \
  --output-dir Models \
  --context-dir . \
  --context DrDataContext \
  --no-onconfiguring \
  --project Data/Data.csproj \
  --force
```
