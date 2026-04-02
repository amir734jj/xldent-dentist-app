namespace XLDENTProxy.Models;

internal partial class Materiai
{
    public uint CodMat { get; set; }

    public uint? ParentId { get; set; }

    public string? NomMat { get; set; }

    public byte? Familia1 { get; set; }

    public byte? Familia2 { get; set; }

    public byte? Familia3 { get; set; }

    public decimal? ValorVenda { get; set; }

    public decimal? ValorCompra { get; set; }

    public decimal? ValorPmp { get; set; }

    public DateTime? DiaUltCompra { get; set; }

    public string? Localizacao { get; set; }

    public uint? Iva { get; set; }

    public uint? Unidade { get; set; }

    public decimal? QtdMinima { get; set; }

    public decimal? QtdMaxima { get; set; }

    public decimal? QtdPontoEnc { get; set; }

    public decimal? QtdEncomendada { get; set; }

    public decimal? QtdExistencia { get; set; }

    public decimal? QtdReservada { get; set; }

    public string? Obs { get; set; }

    public string? Active { get; set; }

    public uint OfficeId { get; set; }
}
