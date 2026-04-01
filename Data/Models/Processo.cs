namespace Data.Models;

internal partial class Processo
{
    public uint Mecano { get; set; }

    public uint? Especialidade { get; set; }

    public uint Processo1 { get; set; }

    public DateTime Dia { get; set; }

    public DateTime? Popen { get; set; }

    public DateTime? Pclose { get; set; }

    public string? Titulo { get; set; }

    public string? Obs { get; set; }

    public int TipoProcesso { get; set; }

    public string? Descricao { get; set; }

    public string? ObsDescricao { get; set; }

    public uint OfficeId { get; set; }
}
