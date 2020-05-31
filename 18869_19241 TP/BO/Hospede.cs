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

namespace BO
{
    public class Hospede : Pessoa //utilizar método/atributo do Pai
    {
        #region Variables
        string contribuinte;

        #endregion

        #region Construtors
        public Hospede(string nome, string morada, string telefone, string email, string contribuinte) : base(nome, morada, telefone, email)
        {
            this.contribuinte = contribuinte; //utilizar método /atributo do objeto corrente

        }
    }

    #endregion
}

