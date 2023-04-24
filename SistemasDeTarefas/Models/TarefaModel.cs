using SistemasDeTarefas.Enums;

namespace SistemasDeTarefas.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public StatusTarefa Status { get; set; }
        public int? UsuarioId { get; set; }

        public virtual UsuarioModel? Usuario { get; set; }
    }
}
