/*-----------------------------------------------------------------------
<copyright file="Funcionario.cs" company="IPCA">
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
    class Funcionario : Pessoa  //utilizar método/atributo do Pai
    {
        #region Variables
        int id;

        #endregion

        #region Constructors
        public Funcionario(string nome, string morada, string telefone, string email, int id) : base(nome, morada, telefone, email)
        {
            this.id = id; // utilizar método/atributo do objeto corrente

        }

        #endregion
    }
}
