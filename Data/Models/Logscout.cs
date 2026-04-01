namespace Data.Models;

internal partial class Logscout
{
    public int Id { get; set; }

    public DateTime Datetime { get; set; }

    public string Message { get; set; } = null!;
}
