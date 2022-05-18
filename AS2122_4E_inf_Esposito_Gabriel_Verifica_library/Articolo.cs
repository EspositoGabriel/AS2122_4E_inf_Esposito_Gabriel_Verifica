using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2122_4E_inf_Esposito_Gabriel_Verifica_library
{
    public class Articolo

    {
        string  codice;
        string  descrizione;
        string  unitadimisura;
        string  prezzo;


        public string Codice { get { return codice; } }
        public string Descrizione {get { return descrizione; } }
        public string Unitadimisura {get { return unitadimisura; } }
        public string Prezzo {get { return prezzo; } }


        public Articolo(string codice, string descrizione, string unitadimisura, string prezzo)
        {
            this.codice = codice;
            this.descrizione = descrizione;
            this.unitadimisura = unitadimisura;
            this.prezzo = prezzo;


        }
        public override string ToString()
        {
            return $"{descrizione} {unitadimisura} {prezzo} {codice}"; 


            }
        }


    }
    







}
