namespace Data.Models;

internal partial class Tratexecor
{
    public uint Mecano { get; set; }

    public string InicialTrat { get; set; } = null!;

    public string Dente { get; set; } = null!;

    public sbyte TipoCor { get; set; }

    public uint OfficeId { get; set; }
}
