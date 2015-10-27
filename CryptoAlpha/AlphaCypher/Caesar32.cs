using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlphaCypher
{
   public  class Caesar32
    {
        private List<Char> _vettAlfabeto;
        private int _spiazzamento;

        public Caesar32():base()
        {

        }
        public Caesar32 (int spiazzamento) : base()
        {
            _spiazzamento = spiazzamento;
        }

        public string Codifica(string testo, int spiazzamento)
        {
            string resp = "";

            resp = base.Codifica(testo, spiazzamento);
            return resp;
        }
    }
}
