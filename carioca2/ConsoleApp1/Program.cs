using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var listaFuncionarios = new List<Funcionario>();
            //var funcionarioDinheiro = new Funcionario();

            //var funcionarioGeter = new Funcionario();

            //funcionarioGeter.setNome("maria");    //ctrl+k+c comenta
            //funcionarioGeter.setMatricula(1234);  //Ctrl+k+u descomenta
            //funcionarioGeter.setSalario(1000);    <-----------método normal

            var funcionario1 = new Funcionario();
            //método construtor (muito melhor)
            funcionario1.Nome = "Brenda";
            funcionario1.Matricula = 1000;
            funcionario1.Salario = 1200f;

            var funcionario2 = new Funcionario();
            funcionario2.Nome = "Maria";
            funcionario2.Matricula = 1001;
            funcionario2.Salario = 2500f;
            var funcionario3 = new Funcionario();
            funcionario3.Nome = "Iarllon";
            funcionario3.Matricula = 1002;
            funcionario3.Salario = 3600f;
            var funcionario4 = new Funcionario();
            funcionario4.Nome = "Joao";
            funcionario4.Matricula = 1003;
            funcionario4.Salario = 5000f;

            //funcionarioDinheiro.dinheiro = 1000;
            //var dinheiro = funcionario1.dinheiro;

            listaFuncionarios.Add(funcionario1);
            listaFuncionarios.Add(funcionario2);
            listaFuncionarios.Add(funcionario3);
            listaFuncionarios.Add(funcionario4);

            float total = 0;

            foreach (Funcionario funcionario in listaFuncionarios)
            {
                total += funcionario.Salario;
            }
            var media = total / listaFuncionarios.Count;

            foreach (var funcionario in listaFuncionarios)
            {
                if (funcionario.Salario > media)
                {
                    Console.WriteLine("Nome = " + funcionario.Nome);
                    Console.WriteLine("Matricula = " + funcionario.Matricula);
                }
            }

            Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}

class Funcionario
{

    private string nome;
    private int matricula;
    private float salario;

    public string Nome { 
        get { return nome; } 
        set { nome = value; } 
    }public int Matricula { 
        get { return matricula; } 
        set { matricula = value; } 
    }public float Salario { 
        get { return salario; } 
        set { salario = value; } 
    }

    public string getNome()
    {
        return this.nome;
    }
    public int getMatricula()
    {
        return this.matricula;
    }
    public float getSalario()
    {
        return this.salario;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }
    public void setMatricula(int matricula)
    {
        this.matricula = matricula;
    }
    public void setSalario(float salario)
    {
        this.salario = salario;
    }
}