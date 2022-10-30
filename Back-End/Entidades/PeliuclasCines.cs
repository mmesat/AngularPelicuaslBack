namespace Back_End.Entidades
{
    public class PeliuclasCines
    {
        public int PeliculaId { get; set; }
        public int CineId { get; set; }
        public Pelicula Pelicula { get; set; }
        public Cine Cine { get; set; }

    }
}
