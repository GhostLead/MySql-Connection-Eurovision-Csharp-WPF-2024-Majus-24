using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppEurovizio
{
    internal class Dal
    {


        private int id;
        private int ev;
        private string orszag;
        private string eloado;
        private string cim;
        private int helyezes;
        private int pontszam;

        public int Id { get => id; set => id = value; }
        public int Ev { get => ev; set => ev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public string Eloado { get => eloado; set => eloado = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }

        public Dal(MySqlDataReader olvaso)
        {
            Id = olvaso.GetInt32(0);

            Ev = olvaso.GetInt32(1);

            Orszag = olvaso.GetString(2);

            Eloado = olvaso.GetString(3);

            Cim = olvaso.GetString(4);

            Helyezes = olvaso.GetInt32(5);

            Pontszam = olvaso.GetInt32(6);
        }

    }
}
