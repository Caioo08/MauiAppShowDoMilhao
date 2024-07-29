using MauiAppShowDoMilhao.Models;

namespace MauiAppShowDoMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?",
                Alternativas = new()
                {
                    new Alternativa { Correta = false, Descricao= "LÍQUIDO"},
                    new Alternativa { Correta = true, Descricao= "SÓLIDO" },
                    new Alternativa { Correta = false, Descricao= "GASOSO" },
                    new Alternativa { Correta = false, Descricao= "VAPOROSO" },
                }
            },
            new Pergunta
            {
                Id= 2,
                Enunciado = "Em que estado brasileiro nasceu a apresentadora Xuxa?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao="RIO DE JANEIRO" },
                    new Alternativa{ Correta = true, Descricao="RIO GRANDE DO SUL" },
                    new Alternativa{ Correta = false, Descricao="SANTA CATARINA" },
                    new Alternativa{ Correta = false, Descricao="GOIÁS" },
            },
            new Pergunta
            {
                Id= 3,
                Enunciado = "Quem é a namorada do Mickey?",
                Alternativas = new()
                {
                    new Alternativa{ Correta = false, Descricao="MARGARIDA" },
                    new Alternativa{ Correta = false, Descricao="A PEQUENA SEREIA" },
                    new Alternativa{ Correta = true, Descricao="MINNIE" },
                    new Alternativa{ Correta = false, Descricao="OLÍVIA PALITO" },
            },
            new Pergunta
            {
                Id= 4, 
                Enunciado = "Qual é o personagem do folclore brasileiro que tem uma perna só?",
                Alternativas = new()
                {
                    new Alternativa{ Correta= false, Descricao="CUCA" },
                    new Alternativa{ Correta= false, Descricao="NEGRINHO DO PASTOREIO" },
                    new Alternativa{ Correta= false, Descricao="BOITATÁ" },
                    new Alternativa{ Correta= true, Descricao="SACI-PERERÊ" },
                }
            },
            new Pergunta
            {
                Id = 5,
                Enunciado = "Fidel Castro nasceu em que país?",
                Alternativas = new()
                {
                    new Alternativa{ Correta=false, Descricao="JAMAICA" },
                    new Alternativa{ Correta=true, Descricao="CUBA" },
                    new Alternativa{ Correta=false, Descricao="EL SALVADOR" },
                    new Alternativa{ Correta=false, Descricao="MÉXICO" },
                }
            },
            new Pergunta 
            {
                Id = 6,
                Enunciado = "Quem proclamou a República no Brasil em 1889?",
                Alternativas = new()
                {
                    new Alternativa{ Correta=false, Descricao="DUQUE DE CAXIAS"},
                    new Alternativa{ Correta=false, Descricao="MARECHAL RONDON" },
                    new Alternativa{ Correta=false, Descricao="DOM PEDRO II" },
                    new Alternativa{ Correta=true, Descricao="MARECHAL DEODORO" },
                },
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
