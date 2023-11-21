﻿// ***********************************************************************
// Assembly         : FCS.Lib.BrReg
// Author           : 
// Created          : 2023-10-02
// 
// Last Modified By : root
// Last Modified On : 2023-10-13 07:33
// ***********************************************************************
// <copyright file="BrRegCompanyType.cs" company="FCS">
//     Copyright (C) 2015 - 2023 FCS Fredes Computer Service.
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU Affero General Public License as
//     published by the Free Software Foundation, either version 3 of the
//     License, or (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU Affero General Public License for more details.
// 
//     You should have received a copy of the GNU Affero General Public License
//     along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace FCS.Lib.BrReg;

/// <summary>
///     Class BrCompanyTypeModel
/// </summary>
public class BrRegCompanyType
{
    /// <summary>
    ///     BrReg business code
    /// </summary>
    public string Kode { get; set; } = "";

    /// <summary>
    ///     BrReg description
    /// </summary>
    public string Beskrivelse { get; set; } = "";

    /// <summary>
    ///     BrReg discontinued
    /// </summary>
    public string Utgaatt { get; set; } = "";
}