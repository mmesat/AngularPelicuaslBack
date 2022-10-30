namespace Back_End.DTOs
{
    public class PaginacionDTO
    {
        public int Pagina { get; set; } = 1;
        private int recodsPorPagina = 10;
        private readonly int cantidadMaximaRecordsPagina = 50;
        public int RecordsPorPagina
        {
            get 
            { 
                return recodsPorPagina; 
            }
            set 
            { 
                recodsPorPagina = (value > cantidadMaximaRecordsPagina) ? cantidadMaximaRecordsPagina : value;  
            }
        }
    }
}
