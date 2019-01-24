using System;

namespace estudo.Models
{
    public class Mecanico
    {
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Responsavel { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string DDDTelefone { get; set; }
        public string Celular { get; set; }
        public string DDDCelular { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Mecanica { get; set; }
        public bool Eletrica { get; set; }
        public bool Suspensao { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}