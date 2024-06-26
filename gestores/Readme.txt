Scaffold-DbContext "Server=DESKTOP-JTTRPKK;Database=BDCLINICA;User ID=SA;Password=1234;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -DataAnnotations -Force

  <connectionStrings>
    <add name="BloggingDatabase"
         connectionString="Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;" />
  </connectionStrings>
</configuration>

optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["BloggingDatabase"].ConnectionString);
