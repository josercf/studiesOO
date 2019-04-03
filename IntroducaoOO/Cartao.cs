using System;
using System.Collections.Generic;
using System.Text;

namespace IntroducaoOO
{
     public class Cartao
    {
        //Propriedade
        public string Numero { get;private set; }

        public bool AutorizarCompra(string senha)
        {
            if (senha == "123")
                return true;
            else
                return false;
        }

        // Modificadores de Acesso
        //private      - Acesso apenas no escopo da classe
        //internal     - Apenas dentro do pacote
        //protected    - Apenas para os herdeiros
        //public       - Visivel a todos
    }
}



