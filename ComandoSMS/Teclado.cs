using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoSMS
{
    public class Teclado
    {
        IDictionary<char, string> comandos = new Dictionary<char, String>()
            {
                {'A', "2"  },
                {'B', "22" },
                {'C', "222"},

                {'D', "3"  },
                {'E', "33" },
                {'F', "333"},

                {'G', "4"  },
                {'H', "44" },
                {'I', "444"},

                {'J', "5"  },
                {'K', "55" },
                {'L', "555"},

                {'M', "6"  },
                {'N', "66" },
                {'O', "666"},

                {'P', "7"   },
                {'Q', "77"  },
                {'R', "777" },
                {'S', "7777"},

                {'T', "8"},
                {'U', "88"},
                {'V',"888"},

                {'W', "9"   },
                {'X', "99"  },
                {'Y', "999" },
                {'Z', "9999"},

                {' ', "0"}
            };

        public String MostrarComando(String mensagem)
        {
            String comandoStr = "";
            char[] caracteres = mensagem.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                String aux = "";
                aux = comandos[caracteres[i]].ToString();

                if (comandoStr.EndsWith(aux.Substring(0, 1))) comandoStr += "_" + comandos[caracteres[i]];
                else comandoStr += comandos[caracteres[i]];
            }

            return comandoStr;
        }
    }
}
