namespace Data.Models;

internal partial class Sala
{
    public uint? NumSala { get; set; }

    public string Nome { get; set; } = null!;

    public string AbvSala { get; set; } = null!;

    public string? Obs { get; set; }

    public uint OfficeId { get; set; }
}
