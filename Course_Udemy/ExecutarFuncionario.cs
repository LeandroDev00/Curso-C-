using System;
using System.Globalization;
using System.Collections.Generic;
using Registro;

namespace ExecutarEmployees
{
    class Employees
    {
        public static void RunEmployees()
        {
            //Solicita o numero de funcionarios a serem registrados
            Console.Write("How many employees wll be registered ? ");
            int n = int.Parse(Console.ReadLine());

            //Crio minha lista com base no numero de funcionarios registrados
            List<Funcionario> list = new List<Funcionario>();

            //Crio um laço para registrar os funcionarios
            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Emplyoee #" + i + " :");

                // Digita o ID
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                //Digita o nome
                Console.Write("Name: ");
                string name = Console.ReadLine();

                //Digita o Salario
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();

                //Cria um objeto funcionario com as informações digitadas
                Funcionario newfuncionario = new Funcionario(id, name, salary);

                //Adiciona na Lista
                list.Add(newfuncionario);
            }
            Console.WriteLine();

            // Solicita o ID do funcionario para buscar
            Console.Write("Enter the employee id that will have salary increase : ");
            int idFunc = int.Parse(Console.ReadLine());

            // Procura o funcionario na lista criada, busca pelo ID.
            Funcionario existfuncionario = list.Find(x => x.Id == idFunc);

            //Verifica se funcionario já existe
            if (existfuncionario != null)
            {
                //Solicita o percentual para calcular o aumento de salario.
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Utiliza o método do objeto funcionario para aumentar o salario.
                existfuncionario.IncreaseSalary(percentage);
            }
            else
            {
                //Caso não encontrado o funcionario será retornado mensagem.
                Console.WriteLine("This ID does not exists!");
            }

            Console.WriteLine();

            // Percorre a lista criada com as informações dos funcionarios atualizados e Exibe na tela
            Console.WriteLine("Updated list of Employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj.ToString());
            }


            Console.ReadLine();
        }
    }
}