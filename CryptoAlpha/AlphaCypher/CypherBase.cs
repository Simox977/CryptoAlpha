using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
namespace AlphaCypher
{
   public  abstract  class CypherBase
    {
        private List<Char> _vettAlfabeto;
        protected int _spiazzamento;


        public CypherBase()
        {
            _vettAlfabeto = new List<char>();
            InizializzaAlfabeto();
        }

        private void InizializzaAlfabeto()
        {
            for (int i = 0; i < 26; i++)
            {
                char tmp = (char)(i + 65);
                _vettAlfabeto.Add(tmp);
            }
        }


        public int RicercaPosizioneLettera(char tmp)
        {
            int resp = 0;
            for (int i = 0; i < _vettAlfabeto.Count; i++)
            {
                if (tmp == _vettAlfabeto[i])
                {
                    resp = i;
                }
            }
            return resp;
        }
        public string Codifica(string testo)
        {
            string resp = "";
            resp = Codifica(testo, _spiazzamento);
            return resp;
        }

        public string Codifica(char testo, char codice)
        {
            string resp = "";
            resp = this.Codifica(testo.ToString(), codice.ToString());
            return resp;
        }
        public string Codifica(string testo, string codice)
        {
            string resp = "";
            int spiazzamento = RicercaPosizioneLettera(codice.ToUpper()[0]) + 1;
            resp = Codifica(testo.ToUpper(), spiazzamento);
            return resp;
        }
        protected virtual  string Codifica(string testo, int spiazzamento)
        {
            string resp = "";
            char[] s = testo.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = RicercaPosizioneLettera(tmp);
                int posCodificata = (pos + spiazzamento) % 26;
                resp += _vettAlfabeto[posCodificata];
               
            }
            return resp;
        }

        protected virtual string Decodifica (string text, int cypher)
        {  
             
             string resp = "";
             string testo = "";
             int codice= 0;
             char[] s = testo.ToCharArray();  
             char[] t = text.ToCharArray();  
             for (int i = 0; i<s.Length; i++)  
            {  
              char tmp = s[i];  
              int pos = RicercaPosizioneLettera(tmp);  
              int posCodificata = (pos - codice  ) % 26;  
              resp += _vettAlfabeto[posCodificata];  
              int decodedPos = (pos - cypher + 26) % 26;  
              resp += _vettAlfabeto[decodedPos];  
             }  
             return resp;  
 
        }  

    }
}