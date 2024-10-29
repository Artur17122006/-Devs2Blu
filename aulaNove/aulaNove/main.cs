using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaNove
{
    public class Executor
    {
        //mão na massa interfaces
        public interface IAutenticavel 
        {
            void Autenticar();
            void Deslogar();
        }
        public class UsuarioSistema: IAutenticavel
        {
            public void Autenticar() 
            {
                Console.WriteLine("Logando...");
            }
            public void Deslogar() 
            {
                Console.WriteLine("Deslogando...");
            }
        }

        //exemplos de interfaces
        public interface IMotor 
        {
            void Ligar();
            void Desligar();
        }
        public interface ICambioManual 
        {
            void ColocarMarchaAcima();
            void ColocarMarchaAbaixo();
        }

        public class Gol: Carro, IMotor, ICambioManual
        {
            public void Ligar() 
            {
                Console.WriteLine("Ligando o motor...");
            }
            public void Desligar()
            {
                Console.WriteLine("Desligando o motor...");
            }
            public void ColocarMarchaAcima() 
            {
                Console.WriteLine("Trocou a marcha!");
            }
            public void ColocarMarchaAbaixo()
            {
                Console.WriteLine("Trocou a marcha!");
            }
        }

        //Exemplos de abstração

        public abstract class Forma
        {
            public int Base { get; set; }
            public int Altura { get; set; }
            public abstract void CalcularPerimetro();
        }
        //public class Retangulo : Forma
        //{
        //    public override void CalcularPerimtro() { Console.WriteLine($"O resultado do cálculo é: {Base * Altura}"); }
        //}
        //public class Triangulo : Forma
        //{
        //    public override void CalcularPerimtro() { Console.WriteLine($"O resultado do cálculo é: {(Base * Altura) / 2}"); }
        //}

        //abaixo chatgpt

        //public abstract class Forma
        //{
        //    public abstract double CalcularPerimetro();
        //}
        //public class Retangulo : Forma
        //{
        //    public double Largura { get; set; }
        //    public double Altura { get; set; }

        //    public Retangulo(double largura, double altura)
        //    {
        //        Largura = largura;
        //        Altura = altura;
        //    }

        //    public override double CalcularPerimetro()
        //    {
        //        return 2 * (Largura + Altura);
        //    }
        //}
        //class Triangulo : Forma
        //{
        //    public double LadoA { get; set; }
        //    public double LadoB { get; set; }
        //    public double LadoC { get; set; }

        //    public Triangulo(double ladoA, double ladoB, double ladoC)
        //    {
        //        LadoA = ladoA;
        //        LadoB = ladoB;
        //        LadoC = ladoC;
        //    }

        //    public override double CalcularPerimetro()
        //    {
        //        return LadoA + LadoB + LadoC;
        //    }
        //}

        //public class RegistroDB 
        //{
        //    protected abstract string NomeTabela { get; }
        //    public void Select() 
        //    {
        //        var Select = $"SELECT * FROM {NomeTabela}";
        //        Console.WriteLine($"Executando select no banco de dados: {Select}");
        //    }
        //}
        //public class PessoaDB: RegistroDB 
        //{
        //    protected override string NomeTabela { get => "PESSOAS"; }
        //}
        //public class ProdutoDB: RegistroDB 
        //{
        //    //protected override string NomeTabela => "PRODUTOS";
        //    protected override string NomeTabela { get => "PRODUTOS"; } 
        //}
        public class InstrumentoMusical
        {
            protected string Som { get; set; }
            protected string Nome { get; set; }
            public void Tocar()
            {
                Console.WriteLine($"O {Nome} está tocando, fazendo o som {Som}");
            }
        }
        public class Violino : InstrumentoMusical
        {
            public Violino()
            {
                Som = "som de violino";
            }
        }
        public class Flauta : InstrumentoMusical
        {
            public Flauta()
            {
                Som = "som de flauta";
            }
        }
        public class Tambor : InstrumentoMusical
        {
            public Tambor()
            {
                Som = "som de tambor";
            }
        }

        public enum DiasSemana
        {
            Domingo = 1,
            Segunda = 2,
            Terca = 3,
            Quarta = 4,
            Quinta = 5,
            Sexta = 6,
            Sabado = 7
        }
        public static void ExibirMensagemConsole(string mensagem1, string mensagem2 = "NADA!")
        {
            Console.WriteLine(mensagem1);
            Console.WriteLine(mensagem2);
        }
        DiasSemana numero = (DiasSemana)2;

        public class produto
        {
            private string nome;
            private decimal preco;

            public void AlterarNome(string novoNome)
            {
                nome = novoNome;
                Console.WriteLine("Nome alterado.");
            }
            public void AlterarPreco(decimal novoPreco)
            {
                if (novoPreco > 0)
                {
                    preco = novoPreco;
                    Console.WriteLine("Preço alterado.");
                }
                else { Console.WriteLine("Preço não alterado."); }
            }
        }

        public class Veiculo
        {
            public int Velocidade { get; set; }
            public void mover()
            {
                Console.WriteLine("O veículo está se movendo.");
            }
        }
        public class Carro : Veiculo
        {
            public void Buzinar()
            {
                Console.WriteLine("Bee!");
            }
        }

        public class Animal
        {
            protected string Som { get; set; }
            public void EmitirSom()
            {
                Console.WriteLine($"O animal está emitindo o som: {Som}!");
            }
        }
        public class Cachorro : Animal
        {
            public Cachorro() { Som = "Au"; }
        }
        public class Gato : Animal
        {
            public Gato() { Som = "Miau"; }
        }
        public class Marreco : Animal
        {
            public Marreco() { Som = "Quack"; }
        }



        //public override string ToString()
        //{
        //    return $"Dados do Produto\nNome: {Nome};\nPreço: {Preco}";
        //}

        public static void Executar()
        {
            var Usuario = new UsuarioSistema();
            Usuario.Autenticar();

            //var gato = new Gato();
            //gato.EmitirSom();

            //var cao = new Cachorro();
            //cao.EmitirSom();

            //List<Animal> animais = new List<Animal>();
            //animais.Add(new Cachorro());
            //animais.Add(new Gato());
            //animais.Add(new Marreco());
            //foreach (var animal in animais) 
            //{
            //    animal.EmitirSom();
            //}

            //InstrumentoMusical[] instrumentosMusicais = new InstrumentoMusical[3];
            //instrumentosMusicais[0] = new Violino();
            //instrumentosMusicais[1] = new Flauta();
            //instrumentosMusicais[2] = new Tambor();
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(instrumentosMusicais[i].Tocar);
            //}

        }
    }
}

