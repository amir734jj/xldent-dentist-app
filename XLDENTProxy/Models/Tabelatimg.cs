namespace XLDENTProxy.Models;

internal partial class Tabelatimg
{
    public uint Especialidade { get; set; }

    public string CodT { get; set; } = null!;

    public uint Entidade { get; set; }

    public string Dente { get; set; } = null!;

    public byte[]? OclusalM { get; set; }

    public byte[]? OclusalO { get; set; }

    public byte[]? OclusalD { get; set; }

    public byte[]? OclusalV { get; set; }

    public byte[]? OclusalL { get; set; }

    public byte[]? VestibularM { get; set; }

    public byte[]? VestibularV { get; set; }

    public byte[]? VestibularD { get; set; }

    public byte[]? LingualM { get; set; }

    public byte[]? LingualL { get; set; }

    public byte[]? LingualD { get; set; }

    public byte[]? CoroaO { get; set; }

    public byte[]? CoroaV { get; set; }

    public byte[]? CoroaL { get; set; }

    public byte[]? RaizV { get; set; }

    public byte[]? RaizL { get; set; }

    public uint OfficeId { get; set; }
}
