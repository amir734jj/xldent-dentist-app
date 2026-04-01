namespace Data.Models;

internal partial class Medicdent
{
    public uint Pac { get; set; }

    public DateTime Dia { get; set; }

    public string Dnt { get; set; } = null!;

    public string Warning { get; set; } = null!;

    public string? CodMed { get; set; }

    public uint OfficeId { get; set; }
}
