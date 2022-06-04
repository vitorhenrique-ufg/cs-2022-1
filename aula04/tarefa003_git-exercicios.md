### Tarefa 003: Git Exercícios - 03/06/2021.

Responda as questões abaixo (exercite os comandos do git correspondentes). Lembre-se de que o “interessante” não é exatamente o conjunto de respostas, mas o processo de obtê-las e a experiência obtida com a execução dos comandos.


1. Qual o comando para obter a versão instalada do Git?<br>
**R:** O comando a se utilizar e:  **git --version**

2. Qual o efeito da execução de cada um dos comandos abaixo?<br>
  a. git help<br>
  **R:** O comando git help exibe informações de ajuda sobre o git.<br><br>
  b. git help checkout<br>
  **R:** O comando git help checkout leva o usuário até uma pagina que contem informações a respeito de como funciona o comando **git-checkout**<br><br>
  c. git help merge<br>
  **R**: O comando git help merge leva o usuário até uma pagina que contem informações a respeito de como funciona o comando **git-merge**<br><br>
  d. git init<br>
  **R:** O comando git init cria um novo repositório do Git.<br><br>
  e. git add --all<br>
  **R:** O comando git add --all, adiciona alterações (para que possam ser comitadas) de todos os arquivos, sejam eles novos, modificados ou removidos. <br><br>
  f. git add -u<br>
  **R:** O comando git add -u coloca no Stage(para que possa ser comitado) os arquivos que foram modificados e removidos<br><br>
  g. git config -l<br>
  **R:** O comando git config -l lista todas as suas configurações, credenciais e dados presente no git<br><br>
  h. git mv a.txt b.txt<br>
  **R:** Este comando altera o nome do arquivo passado como primeiro parametro para o nome colocado no segundo parametro. Também pode ser utilizado para mover o arquivo para outra local dentro do diretório.<br><br>
  i. git reset --hard<br>
  **R:** Este comando redefine o indíce e a árvore de trabalho, descarta as alterações na área de stage como também reverte todas as alterações no diretório de trabalho para o estado do commit que foi especificado no comando.<br><br>
  j. git log -27<br>
  **R:** Este comando mostra a linha do tempo de commit feitos em um determinado branch, baseado no numero em que foi passado, neste caso, mostraria 27 commits, caso possuísse esse valor.

3. O fluxo “clássico” de interação com o Git é algo como “alterar um ou mais arquivos”, “acrescentar essas mudanças para serem contemplados no próximo commit” e, finalmente, executar um “commit”. Quais os comandos necessários para realizar os dois últimos “passos” desse fluxo?<br>
**R:** Para acrescentar os arquivos que foram modificados pode-se utilizar o comando **"git add ."**(Adiciona todas as modificações para o formato de stage) e para comitar as alterações  pode-se utilizar o comando **"git commit -m "(mensagem desejada)""**.

4. Qual o comando deve ser executado para identificar o que foi alterado desde o último “commit”?<br>
**R**: Com o comando **"git show"** é possível ver o que foi alterado desde o último commit.

5. Em um dado repositório, arquivos simplesmente copiados para lá, ou seja, _untracked_, podem ser exibidos/identificados com que comando?<br>
**R**: git status, mostra todas as modificações, adições e remoções feitas no repositório desejado.

6. Qual o comando para efetuar um _commit_?<br>
**R:** git commit -m "(mensagem do commit)".

7. Qual o comando que devemos empregar para descartar mudanças ocorridas no arquivo teste.txt, por exemplo?<br>
**R**: Podemos utilizar o comando **git stash** ou **git stash --include-untracked (para descartar mudanças quando tiverem sido adicionados arquivos novos)**. Estes comandos desfazem as mudanças feitas em um arquivo, e os salva em uma pilha de alterações.

8. O que deve ser feito para que um determinado diretório do seu repositório seja ignorado pelo Git? Faça uma busca por **.gitignore**.<br>
**R:** E preciso configurar um arquivo chamado **".gitignore"**, neste arquivo no git, você pode adicionar arquivos e diretórios que você deseja que sejam ignorados pelo git, desta forma, quando você tentar visualizar as alterações feitas, com o comando git status por exemplo, elas não apareceram na sua listagem.

9. O que acontece se o seu repositório local for acidentalmente removido?<br>
**R:** Neste caso é preciso fazer outro clone do repositório, com isto, suas alterações que não tiverem sido subidas para o repositório local ou comitadas, são perdidas.

10. Como clonar um repositório remoto?<br>
**R:** Basta utilizar o comando git clone **"code do repositório desejado"**

11. Em alguns cenários **git log** pode produzir extensos resultados. Se houver interesse em visualizar o histórico de um repositório, onde cada mudança é fornecida exatamente em uma única linha, qual o comando que deve ser empregado?<br>
**R:** Pode ser utilizado o comando  **"git log --oneline"**, onde é listada as alterações feitas(commits) e cada mudança é mostrada em uma única linha.

12. Em qual arquivo o Git armazena informações de configuração empregadas por usuário?<br>
**R:** Estas configurações ficam armazenadas no arquivo **config** localizada na pasta .git do seu repositório.

13. Qual o comando para criar um repositório local?<br>
**R:** O comando a se utilizar é o **git init**

14. Qual o nome do diretório criado pelo Git quando se executa o comando **git init**?<br>
**R:** O nome do repositório é **.git**, localizado na pasta raiz de onde foi executado o comando.

15. Qual o comando para adicionar todos os arquivos modificados? (Aqueles para os quais **git status** identificam como **modified**?)<br>
**R:** Pode-se utilizar o comando **"git add . "**

16. O Git faz uso do valor de hash conhecido por SHA1. O que isto significa? Qual o propósito? O que é SHA1?<br>
**R:** O SHA-1 é utilizado em sistemas de controle de revisão para identificar revisões, assim como detectar corrupção ou adulteração de dados.SHA-1 é uma função criptografia desenvolvida pela Agência de Segurança Nacional dos Estados Unidos sendo um padrão de Processamento de Informação publicado pelo Instituto Nacional de Padrões e Tecnologia.

17. Qual a palavra para indicar o último _commit_ em vez do valor de hash SHA1 correspondente?<br>
**R:** Através do comando **"git log -1"**

18. Quando se cria dois arquivos usando um editor de texto qualquer e, na sequência, executamos o comando **git add -u**, os dois arquivos criados passam de _untracked_ para _new file_?<br>
**R:** Não, pois o comando git add -u adiciona apenas os arquvios que foram modificados ou removidos.

19. Qual o efeito da execução dos dois comandos abaixo, nesta ordem, em um dado repositório?
**git reset --soft HEAD~1**
**git reset --hard**<br>
**R:** O primeiro comando retornará a um commit atrás e mantem as alterações realizadas neste commit e ao executar o segundo comando ele retornará um commit anterior e removerá as alterações realizadas neste commit.

20. Após o emprego de um ambiente integrado de desenvolvimento (IDE), é comum a criação de arquivos e diretórios. Qual o comando que podemos empregar para remover arquivos e diretórios _untracked_?<br>
**R:** Neste caso podemos utilizar o comando **"git clean -fd"**.

21. Qual o nome do arquivo no qual podemos inserir a indicação para o Git de arquivos e diretórios a serem ignorados?<br>
**R:** o arquivo é o **.gitignore**

22. Quando se cria o arquivo _MinhaClasse.class_ em um dado diretório e desejamos que arquivos com a extensão .class, como neste caso, sejam ignorados por todos os membros de uma equipe que estão contribuindo com um dado projeto, como devemos proceder?<br>
**R:** Devemos adicionar esta referencia de arquivos que devem ser ignorados ao arquivo de configuração .gitignore, com o comando **vi .gitignore**, no qual abrirá as listagens de arquivos que estão configurados para serem ignorados e com isso adicionamos a referencia destes arquivos com a extensao **".class"** .

23. jQuery é uma famosa biblioteca em JavaScript. Consulte detalhes em [jQuery](http://jquery.com). O repositório correspondente encontra-se em [gitRep](https://github.com/jquery/jquery.git). Faça o clone deste repositório.<br>
**R:** Basta utilizar o comando **"git clone https://github.com/jquery/jquery.git"**

24. No repositório **jqueryrepo**, criado no passo anterior, qual o efeito do comando
**git shortlog -sne**?<br>
**R:** Este comando resume a saída do comando git log, e com as opções -sne, temos que a opção<br>
    **s: Suprima a descrição do commit e forneça apenas um resumo da contagem dos commits**<br>  **n:Classifique a saída de acordo com a quantidade de commits feitas pelo autor, em vez da ordem alfabética do autor**<br>**e:Exibir o endereço de email de cada autor**.

25. No repositório **jqueryrepo**, qual o efeito de **git remote -v**?<br>
**R:** Este comando mostra as url's de repositórios remotos ao listar suas conexões remotas atuais(origin).

26. Um repositório Git pode ser etiquetado ao longo do tempo. Ou seja, _commits_ específicos podem ser “marcados” ou “etiquetados” para facilitar referências posteriores. Para listar todas as “etiquetas” (_tags_) estabelecidas para um dado repositório, qual comando deve ser executado?<br>
**R:** Deve se utilizar o comando **git tag**

27. Caso um dato repositório retorne muitas “marcas” ou “etiquetas” para o comando **git tag**, como retornar apenas aquelas que atendem a determinado padrão, por exemplo, iniciadas por 2.0?<br>
**R:** Neste caso deve-se utilizar o comando **git tag -l "2.0"(especificacao da TAG desejada)**

28. Qual o efeito do comando **git tag -a 3.4-gold -m “minha versão ouro”**?<br>
**R:** Com este comando será criada uma tag com o nome **3.4-gold** e com a mensagem **minha versão de ouro**

29. Após executado o comando acima, qual o efeito de **git show 3.4-gold**?<br>
**R:** É apresentado os commits que estão associados a tag mencionada

30. O que o comando **git push origin 3.4-gold** teria como efeito?<br>
**R:** Este comando realiza um push(envio dos dados) do branch local para o origin referenciado, ou seja, realiza o envio das alterações feitas localmente para os branch de commit associados a tag.

31. Após executar um commit, qual o efeito de **git commit --amend**?<br>
**R:** Este comando tem a funcionalidade de poder alterar uma mensagem de commit realizada.

32. Após executar **git add x.txt**, qual o efeito de **git reset HEAD x.txt**?<br>
**R:** Ele retorna o arquivo, neste caso o x.txt para o formato de untracked file.

33. Após alterar o conteúdo de um arquivo committed em passo anterior, qual o efeito do comando **git checkout -- a.txt**?<br>
**R:** Este comando funciona  como uma forma de reverter a uma versão antiga de um arquivo individual.

34. Qual a diferença entre os comandos **git reset HEAD a.txt** e **git checkout -- a.txt**?<br>
**R:** O comando git checkout --a.txt afeta somente as alteracoes referente ao arquivo, enquanto que o git reset HEAD a.txt reverte mudanças encenadas.

35. Veja como interpretar o resultado de git diff [aqui](https://medium.com/therobinkim/how-to-read-a-git-diff-6c87a9dc47c5). Execute, em um dos seus projetos, o comando **git diff HEAD~1 HEAD** e certifique-se de que entende o resultado apresentado.<br>
**R:** Este comando tem o objetivo de mostra a diferença entre o primeiro e o segundo commit apresentado.