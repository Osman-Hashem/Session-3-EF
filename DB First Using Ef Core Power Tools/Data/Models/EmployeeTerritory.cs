﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace DB_First_Using_Ef_Core_Power_Tools.Data.Models;

public partial class EmployeeTerritory
{
    public int EmployeeId { get; set; }

    public string TerritoryId { get; set; }

    public virtual Employee Employee { get; set; }
}