using System.ComponentModel.DataAnnotations;

namespace CrudRazor.Model;

public class Produto
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Nome Produto")]
    public string Nome { get; set; }
    [Display(Name = "Quantidade ")]
    public int Quantidade { get; set; }
}
