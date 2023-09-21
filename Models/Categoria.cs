using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId{get;set;}
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Categoria")]
        [MinLength(3,ErrorMessage ="Categoria deve ter no minimo {1}")]
        [MaxLength(20, ErrorMessage ="Categoria deve ter no maximo {1} caracteres")]
        public string Nome{get;set;}
        public List<Movel> Moveis{get;set;}
    }
}