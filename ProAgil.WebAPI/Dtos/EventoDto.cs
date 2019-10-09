using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProAgil.WebAPI.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }
        
        [Required (ErrorMessage="O {0} deve ser Preenchido")]
        [StringLength (100, MinimumLength=3, ErrorMessage="O Tema deve no minumo 3 e máximo 100 Caraters")]
        public string Tema { get; set; }
        [Range (2, 1200, ErrorMessage="A quantidade de pessoas deve ser maior que 2 e menor que 1200")]
        public int QtdPessoas { get; set; }
        public string ImagemUrl { get; set; }
        public string Telefone { get; set; }
        [EmailAddress (ErrorMessage="Informe um e-mail válido")]
        public string Email { get; set; }
        public List<LoteDto> Lotes { get; set; }
        public List<RedeSocialDto> RedesSociais { get;set; }
        public List<PalestranteDto> Palestrantes { get;set; }
    }
}