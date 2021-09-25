namespace MascotaFeliz.App.Dominio
{
    public class Mascota
    {
        public int CodigoMascota {get; set;}
        public string NombreMascota {get; set;}
        public int Edad {get; set;}
        public string Raza {get; set;}
        public string Tipo {get; set;}
        public Plan Plan {get; set;}
        public int IdentificacionDueño {get; set;}
        public Dueño Dueño {set; get;}
    }
}