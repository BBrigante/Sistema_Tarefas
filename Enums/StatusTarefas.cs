using System.ComponentModel;

namespace SistemaDeTarefas.Enums
{
    public enum StatusTarefas
    {
        [Description("A Fazer")]
        aFazer = 1,
        [Description("Em Andamento")]
        EmAndamento = 2,
        [Description("Concluído")]
        Concluido = 3

    }
}
