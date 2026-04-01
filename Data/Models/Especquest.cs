namespace Data.Models;

internal partial class Especquest
{
    public uint? CodEspec { get; set; }

    public uint? CodGrupo { get; set; }

    public uint? CodGrupoTitulo { get; set; }

    public uint? CodTitulo { get; set; }

    public uint? CodSubGrupo { get; set; }

    public string? Question { get; set; }

    public string Tipo { get; set; } = null!;

    public uint? LinesTxt { get; set; }

    public string QuestionBold { get; set; } = null!;

    public uint OfficeId { get; set; }
}
