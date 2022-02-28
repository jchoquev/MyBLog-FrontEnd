namespace DatabaseSettings.Models;

public class DBSettings
{
    public string? ConnectionString { get; set; }

    public string? DatabaseName { get; set; }

    public List<string> CollectionNames { get; set; }=null!;
}