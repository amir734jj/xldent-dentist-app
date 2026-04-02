namespace XLDENTProxy.Models;

internal partial class Especgrupo
{
    public uint? CodEspec { get; set; }

    public uint? CodGrupo { get; set; }

    public uint? CodSubGrupo { get; set; }

    public string? Descricao { get; set; }

    public string ShowNumbers { get; set; } = null!;

    public uint OfficeId { get; set; }
}
