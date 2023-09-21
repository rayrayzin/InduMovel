using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Movel
    {
        public int MovelId { get; set; }
        [Required(ErrorMessage = "Informe o nome do Movel")]
        [Display(Name = "Nome Movel")]
        [MinLength(4, ErrorMessage = "Movel dever ter no minimo {1} caracteres")]
        [MaxLength(20, ErrorMessage = "Movel dever ter no maximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o nome da Descrição")]
        [Display(Name = "Descrição")]
        [MinLength(20, ErrorMessage = "Descrição dever ter no minimo {1} caracteres")]
        [MaxLength(150, ErrorMessage = "Descrição dever ter no maximo {1} caracteres")]
        public string Descricao { get; set; }

        [Display(Name = "Cor")]
        [MaxLength(20, ErrorMessage = "Cor dever ter no maximo {1} caracteres")]
        public string Cor { get; set; }
        [Display(Name = "Imagem Grande")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Imagem pequena")]
        public string ImagemPequena { get; set; }
        [Display(Name = "Em Produção")]
        public bool EmProducao { get; set; }
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }
        [Required(ErrorMessage = "Informe a Categoria")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}