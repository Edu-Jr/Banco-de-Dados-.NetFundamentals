using System;

namespace ProjetoDotNet
{
    public class Series : EntidadeBase
    {
        // Atributos
    private Genero Genero {get ; set;}
    private string Titulo {get; set;}
    private string Descricao {get; set;}
    private string Diretor {get; set;}
    private int Ano {get; set;}
    private bool Excluido {get; set;}
    
    // métodos

    public Series (int id, Genero genero, string titulo, string descricao, string diretor, int ano)
    {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Diretor = diretor;
        this.Ano = ano;
        this.Excluido = false;

    }

    public override string ToString()
    {
        string retorno = "";
        retorno += "Gênero: " + this.Genero + Environment.NewLine;
        retorno += "Título: " + this.Titulo + Environment.NewLine;
        retorno += "Descricao: " + this.Descricao + Environment.NewLine;
        retorno += "Diretor: " + this.Diretor + Environment.NewLine;
        retorno += "Ano de início: " + this.Ano + Environment.NewLine;
        retorno += "Item excluído: " + this.Excluido;
        return retorno;

    }
    public string retornaTitulo()
    {
        return this.Titulo;
    }
    public int retornaId()
    {
        return this.Id;

    }

    public bool retornaExcluido()
    {
        return this.Excluido;
    }


    public void Excluir()
    {
        this.Excluido = true;
    }


        
    }
}