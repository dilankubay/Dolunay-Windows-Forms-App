using System;
using System.Collections.Generic;

namespace DolunaySuAritma.Models;

public partial class BakimFormlari
{
    public int Id { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public string? TelNo { get; set; }

    public string? Adres { get; set; }

    public DateTime? UcFiltreTarih { get; set; }

    public DateTime? MembranTarih { get; set; }

    public DateTime? TatlandiriciTarih { get; set; }

    public DateTime? CesmeTarih { get; set; }

    public DateTime? TankTarih { get; set; }
}
