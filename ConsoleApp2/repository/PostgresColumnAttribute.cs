namespace It_PlanetaApi.repository;
[AttributeUsage(AttributeTargets.Property)]
public class PostgresNameAttribute : Attribute
{
    public string PostgresName { get; set; }
    public PostgresNameAttribute(string name)
    {
        PostgresName = name;
    }
}