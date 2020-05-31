/*-----------------------------------------------------------------------
<copyright file="Booking.cs" company="IPCA">
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
    public class Booking
    {

        #region Variables

        // a classe tem um construtur com 7 argumentos: os 4 primeiros para iniciar o utilizador (user) que é objeto de Pessoa, o segundo seria para iniciar o quarto (ojecto do Quarto) e o último argumento para fazer o set da dataIN (data de entrada)
        string hospedeContribuinte;
        int quartoId;
        DateTime dataIn; //representa a data quando o booking começa
        DateTime dataOut; // representa a data quando o booking acaba
        int funcionarioId;
        DateTime dia = Convert.ToDateTime(0);
        int numBooking = 0; //contador de nº de reserva

        #endregion

        #region contrutor

        public Booking(string hospedeContribuinte, int quartoId, DateTime IN, DateTime OUT, int funcionarioId)
        {
            this.hospedeContribuinte = hospedeContribuinte;
            this.quartoId = quartoId;
            this.dataIn = IN; //representa a data quando o booking começa
            this.dataOut = OUT; // representa a data quando o booking acaba
            this.funcionarioId = funcionarioId;

            this.dia = DateTime.Now;
            this.numBooking = numBooking++;  //cont
        }
        #endregion

    }
}
