using System;

public class Funcionario
{
    public string Id { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Datnascimento { get; set; }
    public double Salario { get; set; }
    public string Telefone { get; set; }
    public string Funcao { get; set; }
    public string EstCivil { get; set; }

    public Funcionario(string Id, string Nome, string Cpf, string Endereco, string Cidade, string Estado,
        string Datnascimento, double Salario, string Telefone, string Funcao, string EstCivil)
    {
        this.Id = Id;
        this.Nome = Nome;
        this.Cpf = Cpf;
        this.Endereco = Endereco;
        this.Cidade = Cidade;
        this.Estado = Estado;
        this.Datnascimento = Datnascimento;
        this.Salario = Salario;
        this.Telefone = Telefone;
        this.Funcao = Funcao;
        this.EstCivil = EstCivil;
    }
}



