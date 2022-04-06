﻿// ***********************************************************************
// Assembly         : FCS.Lib.Virk
// Author           : FH
// Created          : 02-21-2022
//
// Last Modified By : FH
// Last Modified On : 04-06-2022
// ***********************************************************************
// <copyright file="BrVatInfoMapper.cs" company="FCS">
//    Copyright (C) 2022 FCS Frede's Computer Services.
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Affero General Public License as
//    published by the Free Software Foundation, either version 3 of the
//    License, or (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Affero General Public License for more details.
//
//    You should have received a copy of the GNU Affero General Public License
//    along with this program.  If not, see [https://www.gnu.org/licenses]
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using FCS.Lib.BrReg.Models;
using FCS.Lib.Common;

namespace FCS.Lib.BrReg
{
    public class BrVatInfoMapper
    {
        public BaseVatInfo MapBrToCrm(BrCompanyModel brCompany)
        {

            var c = new BaseVatInfo
            {
                Name = brCompany.Navn,
                Address = string.Join("\n", brCompany.Forretningsadresse.Adresse),
                ZipCode = brCompany.Forretningsadresse.Postnummer,
                City = brCompany.Forretningsadresse.Poststed,
                VatNumber = brCompany.Organisasjonsnummer,
                RequestDate = DateTime.Now.ToString(CultureInfo.InvariantCulture),
                CoName = "",
                VatNumberValid = 1
            };
            if (brCompany.Konkurs || brCompany.UnderAvvikling || brCompany.UnderTvangsavviklingEllerTvangsopplosning ||
                !string.IsNullOrWhiteSpace(brCompany.Organisasjonsform.Utgaatt))
                c.HasFolded = 1;

            return c;
        }
    }
}