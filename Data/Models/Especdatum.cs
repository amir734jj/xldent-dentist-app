namespace Data.Models;

internal partial class Especdatum
{
    public uint? CodEspec { get; set; }

    public uint? CodGrupo { get; set; }

    public uint? CodGrupoQuest { get; set; }

    public uint? CodQuest { get; set; }

    public uint Mecano { get; set; }

    public string? Texto { get; set; }

    public string Tipo { get; set; } = null!;

    public uint OfficeId { get; set; }
}
