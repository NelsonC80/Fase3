/*-----------------------------------------------------------------------
<copyright file="Pessoa.cs" company="IPCA">
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
   public class Pessoa
    {
        #region Variables

        string nome;
        string morada;
        string telefone;
        string email;

        #endregion


        #region Constructor
        /// <summary>
        /// Construstor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="morada"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Pessoa(string nome, string morada, string telefone, string email) // 4 paramaetros na pessoa
        {
            this.nome = nome;
            this.morada = morada;
            this.telefone = telefone;
            this.email = email;
        }

        #endregion


    }
}
