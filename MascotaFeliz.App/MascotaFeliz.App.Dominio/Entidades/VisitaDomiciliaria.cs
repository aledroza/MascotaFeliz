using System;

namespace MascotaFeliz.App.Dominio
{
    public class VisitaDomiciliaria
    {
        public int CodigoMascota {get; set;}
        public int IdentificacionMedico {get; set;}
        public string FechaVisita {get; set;}
        public string Peso {get; set;}
        public string FrecuenciaCardiaca {get; set;}
        public string EstadodeAnimo {get; set;}
        public string Recomendaciones {get; set;}
        public Mascota Mascota {set; get;}
        public Medico Medico {set; get;}

    }
}