﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehicleBuddy.Client.Models;

public class Vehicle
{
    [Key]
    public int VehicleId { get; set; }
    [ForeignKey("MakeId")]
    public int MakeId { get; set; }
    [ForeignKey("ModelId")]
    public int ModelId { get; set; }
    [ForeignKey("PackageId")]
    public int PackageId { get; set; }
    [MaxLength(20)]
    public string VIN { get; set; } = default!;
    public int Year { get; set; }
    public bool IsAutomatic { get; set; }
    [MaxLength(50)]
    public string Color { get; set; } = default!;

    public DateTime DateAcquired { get; set; }

    public DateTime DateSold { get; set; }


}
