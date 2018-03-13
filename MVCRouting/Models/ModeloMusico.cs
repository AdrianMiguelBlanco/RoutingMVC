using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRouting.Models
{
    public class ModeloMusico
    {
        ContextoMusica contexto;

        public ModeloMusico()
        {
            this.contexto = new ContextoMusica();
        }

        public List<MUSICOS> GetMusicos()
        {
            var consulta = from datos in contexto.MUSICOS
                           select datos;
            return consulta.ToList();
        }

        public MUSICOS BuscarMusico(int idmusico)
        {
            var consulta = from datos in contexto.MUSICOS
                           where datos.ID == idmusico
                           select datos;
            return consulta.FirstOrDefault();
        }

        public void EliminarMusico(int inscripcion)
        {
            MUSICOS enfermo = this.BuscarMusico(inscripcion);
            this.contexto.MUSICOS.Remove(enfermo);
            this.contexto.SaveChanges();
        }

    }
}