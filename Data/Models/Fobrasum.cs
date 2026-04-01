namespace Data.Models;

internal partial class Fobrasum
{
    public uint Pac { get; set; }

    public int Obra { get; set; }

    public DateTime? Iniciada { get; set; }

    public DateTime? Concluida { get; set; }

    public DateTime? Debitada { get; set; }

    public string? DescTratamento { get; set; }

    public byte? MedObra { get; set; }

    public string? Coordena { get; set; }

    public uint OfficeId { get; set; }
}
