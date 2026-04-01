namespace Data.Models;

internal partial class Apday
{
    public uint SpDaysAuxId { get; set; }

    public string? SpecialDateName { get; set; }

    public string? IsHoliday { get; set; }

    public string? Enabled { get; set; }

    public int? Color { get; set; }

    public byte? Aday { get; set; }

    public sbyte? Amonth { get; set; }

    public DateTime? SpDate { get; set; }

    public string? FixedDay { get; set; }

    public uint OfficeId { get; set; }
}
