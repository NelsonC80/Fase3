/*-----------------------------------------------------------------------
<copyright file="Quartos.cs" company="IPCA">
Copyright (c) IPCA. All rights reserved.</copyright>
-----------------------------------------------------------------------
<author>Emanuel Gomes</author>
<author>Nelson Cunha</author>
<desc> Hostel System Management - Basics in C#</desc>
<Date> 20 / 5 / 2020 </Date>
<version>1.1</version>
----------------------------------------------------------------------- */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace Dados
{
    static class Quartos
    {
        static List<Quarto> quartos;

        static Quartos()
        {
            quartos = new List<Quarto>();
        }
        static bool AddQuartos(Quarto x)
        {
            quartos.Add(x);
            return true;
        }
    }
}
