namespace Data.Models;

internal partial class Medicamrec
{
    public int Mecano { get; set; }

    public DateTime Dia { get; set; }

    public int Receita { get; set; }

    public string CodMedicam { get; set; } = null!;

    public uint OfficeId { get; set; }
}
