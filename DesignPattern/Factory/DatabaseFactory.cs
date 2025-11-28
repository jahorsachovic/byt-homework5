using DesignPattern.Exceptions;

namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType dbType)
        {
            switch (dbType)
            {
                case DatabaseType.Oracle:
                    return new OracleDatabase();
                
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase();
                
                default:
                    throw new IllegalDatabaseType($"Database {dbType} is not supported");
            }
            
            
        }
    }
}
