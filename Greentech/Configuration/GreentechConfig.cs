namespace Greentech.Configuration;

public class GreentechConfig
{
    public const string SectionName = "GreentechConfig";
    public EmailSettings? EmailSettings { get; set; }
}

public class EmailSettings
{
    public string? From { get; set; }
    public string? To { get; set; }
}