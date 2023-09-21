using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    
    public class Movel
    {
    public int MovelId{get;set;}
    [Required(ErrorMessage ="Informe o nome da Móvel")]
    [Display(Name ="Móvel")]
    [MinLength(3,ErrorMessage ="Móvel {1}")]
    [MaxLength(30, ErrorMessage ="Móvel deve ter no maximo {1} caracteres")]

    public string Nome{get;set;}

    [Required(ErrorMessage ="Informe o nome da Descrição")]
    [Display(Name ="Descrição")]
    [MinLength(3,ErrorMessage ="Descrição deve ter no minimo {1}")]
    [MaxLength(200, ErrorMessage ="Descrição deve ter no maximo {1} caracteres")]

    public string Descricao{get;set;}

    [Display(Name ="Cor")]
    [MaxLength(20, ErrorMessage ="Cor deve ter no maximo {1} caracteres")]

        public string Cor{get;set;}

    [Display(Name ="Caminho da imagem")]

        public string ImagemUrl{get;set;}

    [Display(Name ="Caminho da imagem pequena")]
    
        public string ImagemPequena{get;set;}
    [Required(ErrorMessage ="Informe o valor")]
    [Display(Name ="valor")]
    [Range(1,999999.99, ErrorMessage ="O valor de estar entre {1} e {2}")]

        public double Valor {get;set;}
    
    [Display(Name = "Em linha de produção")]
    public string EmProducao{get;set;}
    [Display(Name = "Ativo")]
        public string Ativo{get;set;}
    [Required(ErrorMessage ="Informe a categoria")]
        public string CategoriaId{get;set;}

        public virtual Categoria Categoria{get; set;}
    }
}