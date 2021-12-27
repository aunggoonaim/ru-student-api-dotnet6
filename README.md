# How to migration ?

## Database first ?

`dotnet ef dbcontext scaffold "Host=pgserver;Database=ru_data_center;Username=postgres;Password=admin1234" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir Models --context-dir Contexts --data-annotations --force`

## Docker in localhost

`docker run -d -it --name pgserver -e POSTGRES_PASSWORD=admin1234 -p 5432:5432 -e PGDATA=/var/lib/postgresql/data/pgdata -v ./pgdata:/var/lib/postgresql/data postgres`