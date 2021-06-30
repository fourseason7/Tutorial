
dotnet tool install --global dotnet-ef --version 5.0.7

dotnet ef dbcontext scaffold "Server=p4nets.ddns.net, 20143;Initial Catalog=P4N_HRM_DEV;User ID=p4net_user;Password=p4net_u52r;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;" Microsoft.EntityFrameworkCore.SqlServer -o Models 
