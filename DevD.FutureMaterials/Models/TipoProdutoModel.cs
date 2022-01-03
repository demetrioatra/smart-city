﻿using System.ComponentModel.DataAnnotations;

namespace DevD.FutureMaterials.Models
{
    public class TipoProdutoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Descrição Obrigatória!"),
         MaxLength(50, ErrorMessage = "Máximo de 50 caracteres!"),
         MinLength(3, ErrorMessage = "Mínimo de 3 caracteres!"),
         Display(Name = "Descrição:")]
        public string? Descricao { get; set; }

        [Display(Name = "Comercializado:")]
        public bool Comercializado { get; set; }
        public IList<ProdutoModel>? Produtos { get; set; }
    }
}