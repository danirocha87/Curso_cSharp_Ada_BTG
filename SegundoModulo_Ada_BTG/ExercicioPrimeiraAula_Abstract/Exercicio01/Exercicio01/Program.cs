
    //Classe abastrata
    abstract class EsporteBase
    {
        //Conhecido por: Atributos ou Propriedade
        public abstract int QuantidadeJogadoresPorTime { get; set; }
        //Conhecido por: Atributos ou Propriedade
        public abstract int TempoDeJogoEmMinutos { get; set; }

        //Método abastrato
        public abstract string Iniciar();
        //Método abastrato
        public abstract string Finalizar();
        //Método abastrato
        public abstract string ExibirDescricao();
    }

    //Classe que herda de uma classe abstrata com métodos e propriedades abastratos
    //Quando herda de uma clase assim, é necessário implementar todas as métodos e propriedades 
    class Futebol : EsporteBase
    {
        //Herdou da classe EsporteBase no momento que implementou a classe
        //E implementou a regra de negócio da classe Futebol
        public override int QuantidadeJogadoresPorTime { get; set; }

        //Herdou da classe EsporteBase no momento que implementou a classe
        //E implementou a regra de negócio da classe Futebol
        public override int TempoDeJogoEmMinutos { get; set; }

        //Construtor da classe Futebol
        public Futebol()
        {
            QuantidadeJogadoresPorTime = 11;
            TempoDeJogoEmMinutos = 90;
        }

        //Herdou da classe EsporteBase no momento que implementou a classe
        // E implementou a regra de negócio da classe futebol
        public override string ExibirDescricao()
        {
            return $"O futebol é um esporte praticado por {QuantidadeJogadoresPorTime} jogadores em cada time durante {TempoDeJogoEmMinutos} minutos";
        }

        //Herdou da classe EsporteBase no momento que implementou a classe
        // E implementou a regra de negócio da classe futebol
        public override string Finalizar()
        {
            return "O jogo foi finalizado";
        }

        //Herdou da classe EsporteBase no momento que implementou a classe
        // E implementou a regra de negócio da classe futebol
        public override string Iniciar()
        {
            return "O jogo foi iniciado";
        }
    }