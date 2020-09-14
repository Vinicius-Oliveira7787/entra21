using System;
using System.Collections.Generic;
using System.Linq;

namespace prova
{
    class Program
    {
        public string Exercise1(double hours, double minutes, double serviceHour)
        {
            // Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia 
            // e qual o valor/hora de seu serviço. Imprima quanto dinheiro 
            //ele ganha ao longo de um dia trabalhado. 
            // A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.

            double returnedValue = (hours + (minutes / 60)) * serviceHour;
            return $"{returnedValue.ToString("0,00")}";
        }
        
        public double Exercise2()
        {
            // Solicite ao usuário que informe uma palavra qualquer, porém ele deve digitar uma letra por vez.
            // Quando o usuário informar a palavra “Finalizar”, a aplicação deve apresentar a palavra inteira.

            
        }
    }
}