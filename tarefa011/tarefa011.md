
  # Tarefa 011 - Padrões de Codificação (Leiaute e estilo), Reflexão e Programação defensiva

  # Padrões de codificação<br>

Com a constante evolução das tecnologias relacionadas ao desenvolvimento de softwares, padronizar é um conceito chave para se obter sucesso e qualidade. A padronização pode ser definida como especificações técnicas que auxiliem na maximização da compatibilidade, reprodutibilidade, segurança ou qualidade de determinado processo, produto ou serviço. Relacionado ao mundo de desenvolvimento, a padronização está ligada ao uso de codificações e implementações legíveis, facilitanto a comunição entre diversos desenvolvedores, para que todos consigam absorver o real propósito daquele código.

A utilização de padrões de codificação aumentam a qualidade e legibilidade dos códigos, pois dessa forma, todo e qualquer participante pode conseguir interpretar o código de forma simples e clara.

Em algumas empresas, este tipo de padrão é adotado para várias coisas, para declarar nome de métodos, nomes de variáveis, nome de classes, como por exemplo:

    Nome de métodos ou propriedades do tipo boolean com o prefixo "Eh": EhParaEmitirLogoMarca, EhContextoAluno;
    Nome de interfaces com o prefixo I: IRepositorioAluno, IConsultaContasContabeis;
    Utilização do CamelCase para os nomes de propriedades e Métodos: NomeAluno, CalcularJuros;


# Reflexão: 

A reflexão é utilizado nas linguagens de programação para moficar/manipular os valores de uma determinada propriedade do código, durante o desenvolvimento de uma forma genérica.Desta forma, pode-se obter as informações a respeito de uma classe, propriedade, invocação de um método, etc.

Este tipo de abordagem é utilizada para se obter informações em tempo de execução a respeito de classes, como por exemplo o Type(tipo) de uma terminada classe, atributos, ou até instanciar uma determinada classe em um contexto específico.Em algumas linguagens é possível utilizá-lá da seguinte forma:

    Para se criar uma instância de um determinado tipo:
    (Animal)Activator.CreateInstance(typeof(Cachorro("Nome da classe por exemplo"));

    Para se obter o Type(tipo de uma propriedade):
    Animal animal = new Cacorro();
    animal.GetType();
 
# Programação defensiva

A programação defensiva está ligado com o desenvolvimento de códigos que tem por objetivo "defender", evitar que determinados problemas possam vir a acontecer, está relacionado com prevenção de "bugs" ou erros que impessam o sistema de exercer determinada funcionalidade.
Este conceito, deve ser utilizado em locais onde se tem uma determinada interação com o usuário, como parâmetros que são esperado que venha por determinada escolha.

Desta forma, alguns exemplos que se pode ter relacionado a este conceito, é o uso de validações que evitem que sejam enviados dados inválidos(como valores null) para um determinado método específico.

    public void DepositarDinheiro(RequisicaoModel requisicao)
    {
        //.Valor é uma propriedade da classe RequisicaoModel, que não foi informado pelo usuário
        if (requisicao.Valor is null)
        {
            Console.WriteLine("Valor para depósito não informado");
            return;
        }
        Saldo  += requisicao.Valor;
    }
 