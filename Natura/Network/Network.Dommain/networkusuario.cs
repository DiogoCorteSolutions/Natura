using System;
using System.Collections.Generic;

namespace Network.Dommain
{
    public partial class networkusuario
    {
        public int IdUsuario { get; set; }
        public string NomeFuncionario { get; set; }
        public string CodigoFuncionario { get; set; }
        public string Setor { get; set; }
        public string DataEmissao { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public string Carteiratrabalho { get; set; }
        public string CarteiraMotorista { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Ud { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public Nullable<bool> Status { get; set; }
        public string Senha { get; set; }
        public string Perfil { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Cargo { get; set; }
    }
}
