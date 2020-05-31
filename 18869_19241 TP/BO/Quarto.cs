/*-----------------------------------------------------------------------
<copyright file="Quarto.cs" company="IPCA">
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

    #region Enums
    public enum TipoQuarto
    {
        SINGLE,
        CASAL,
        Dormitorio
    }

    # endregion

    /// <summary>
    /// Define o que é um quarto
    /// </summary>
    public class Quarto
    {
        #region Variables
        int quartoId;
        TipoQuarto tipo;
        int totalQuartos = 0;
        bool ocupado;
        //int numCamas;
        //decimal rate; //rate - tarifa do quarto

        #endregion

        #region Constructors
        /// <summary>
        /// Construtor quarto
        /// </summary>
        /// <param name="num"></param>
        /// <param name="o"></param>
        /// <param name="tipo"></param>
        public Quarto()
        {
            ocupado = false; // começa livre
            quartoId = totalQuartos++;

            tipo = TipoQuarto.Dormitorio; //por padrao
        }

        #endregion


        #region Proprieties
        /// <summary>
        /// Propriedades
        /// </summary>
        public int QuartoId
        {
            get => quartoId; //so get _> somente consulta -read only (nunca vamos alterar)
        }



        public TipoQuarto Tipo
        {
            get => tipo;
            set => tipo = value;
        }



        #endregion
    }
}
