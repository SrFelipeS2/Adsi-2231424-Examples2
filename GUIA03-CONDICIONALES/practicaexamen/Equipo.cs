using System;
using System.Collections.Generic;
using System.Text;

namespace practicaexamen
{
    class Equipo
    {
        public string NombreEquipo { get; set; }
        public string Pais { get; set; }
        private List<Jugador> listadejuagaroes = new List<Jugador>();
        public Equipo() { }
        public Equipo(string nombreT, string paisT)
        {
            this.NombreEquipo = nombreT;
            this.Pais = paisT;
        }

        public List<Jugador> getListaJuagadores() { return this.listadejuagaroes; }
        public void agregarjugador(Jugador jugadotT)
        {
            this.listadejuagaroes.Add(jugadotT);
        }
    }
}
