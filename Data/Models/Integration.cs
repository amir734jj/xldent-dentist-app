namespace Data.Models;

internal partial class Integration
{
    public int Id { get; set; }

    public string ConstIntegrationName { get; set; } = null!;

    public string EntityName { get; set; } = null!;

    public string EntityId { get; set; } = null!;

    public int Attempts { get; set; }

    public string Error { get; set; } = null!;

    public string EntryType { get; set; } = null!;
}
