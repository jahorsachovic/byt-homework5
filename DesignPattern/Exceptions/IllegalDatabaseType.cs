namespace DesignPattern.Exceptions;

public class IllegalDatabaseType : Exception
{
    public IllegalDatabaseType()
    {
        
    }

    public IllegalDatabaseType(string message) : base(message)
    {
        
    }

    public IllegalDatabaseType(string message, Exception inner) : base(message, inner)
    {
        
    }
}