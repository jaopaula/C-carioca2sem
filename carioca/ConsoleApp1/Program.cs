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

            var funcionario1 = new Funcionario("Joao1", 22838484, 1500); //método construtor (muito melhor)
            var funcionario2 = new Funcionario("Joao2", 22838484, 2500);
            var funcionario3 = new Funcionario("Joao3", 22838484, 3500);
            var funcionario4 = new Funcionario("Joao4", 22838484, 2000);

            //funcionarioDinheiro.dinheiro = 1000;
            //var dinheiro = funcionario1.dinheiro;

            listaFuncionarios.Add(funcionario1);
            listaFuncionarios.Add(funcionario2);
            listaFuncionarios.Add(funcionario3);
            listaFuncionarios.Add(funcionario4);

            float total = 0;

            foreach (Funcionario funcionario in listaFuncionarios)
            {
                total += funcionario.getSalario();
            }
            var media = total / listaFuncionarios.Count;

            foreach (var funcionario in listaFuncionarios)
            {
                if (funcionario.getSalario() > media)
                {
                    Console.WriteLine("Nome = " + funcionario.getNome());
                    Console.WriteLine("Matricula = " + funcionario.getMatricula());
                }
            }

            Console.WriteLine(media);
            Console.ReadKey();
        }
    }
}

class Funcionario
{
    public Funcionario(string nome, int matricula, float salario)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.salario = salario;
    }
    private string nome;
    private int matricula;
    private float salario;

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