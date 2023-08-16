namespace MeuTodoApp.Models;

public class Todo
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public bool Feito { get; set; }
    public DateTime Criacao { get; set; } = DateTime.Now;
    public DateTime UltimaModificacao { get; set; } = DateTime.Now;
    public string Usuario { get; set; }
}