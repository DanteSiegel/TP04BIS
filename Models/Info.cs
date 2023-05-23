using System;
using System.Collections.Generic;


namespace TuProyecto.Models
{
    public static class Info
    {
        private static List<Pais> listaPaises;

        static Info()
        {
            InicializarLista();
        }

        private static void InicializarLista()
        {
            listaPaises = new List<Pais>();

            
            listaPaises.Add(new Pais("Argentina", "p1.png", 45000000, DateTime.Parse("09/07/1816"), "Asado"));
            listaPaises.Add(new Pais("Inglaterra", "p2.png", 55000000, DateTime.Parse("03/09/1783"), "No saltar/Robar islas"));
            listaPaises.Add(new Pais("Jamaica", "p3.png", 2800000, DateTime.Parse("06/08/1962"), "Surfear"));
            listaPaises.Add(new Pais("Brasil", "p5.png", 214000000, DateTime.Parse("07/09/1882"), "Futbol"));
            listaPaises.Add(new Pais("Peru", "p4.png", 37000000, DateTime.Parse("28/08/1821"), "Cevichee"));
        }

        public static List<Pais> ListarPaises()
        {
            if (listaPaises == null)
            {
                InicializarLista();
            }

            return listaPaises;
        }

        public static Pais DetallePais(string nombre)
        {
    foreach (var pais in listaPaises)
    {
        if (pais.Nombre == nombre)
        {
            return pais;
        }
    }
    
    return null;
        }
    }
}