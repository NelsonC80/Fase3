/*-----------------------------------------------------------------------
<copyright file="Hospedes.cs" company="IPCA">
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
    public static class Hospedes
    {
        static List<Hospede> hospedes;

        static Hospedes()
        {
            hospedes = new List<Hospede>();
        }
        public static bool AddHospedes(Hospede x)
        {
            hospedes.Add(x);
            return true;
        }






    }



}
