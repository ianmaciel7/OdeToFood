# OdeToFood
Repositório das atividades realizadas no curso ASP.NET Core fundamentals na Pluralsight

## Atividade do modulo 2

☑️ Criar entidades e razor Page

☑️ Exibir mensagem na razor page com texto contido no *appsetings.json*

☑️ Aplicar injeção de dependência

☑️ Imprimir os dados dos restaurantes em uma tabela no *Restaurants/List*

## Atividade do modulo 3

☑️ Criar form de filtragem na tabela *Restaurants/List* com atributo usando *[BindProperty]*

☑️ Possibilatar a exibição dos detalhes de cada restaurante ao clicar no respectivo link dentro das linhas da tabela *Restaurants/List*

☑️ Customizar rota do *restaurants/Detail* para que possa processar */restaurants/Detail/{id}*

☑️ Elaborar uma pagina como *NotFound* para caso *id* na url *restaurants/Detail/{id}* seja Inválida 

## Atividade do modulo 4

☑️ Possibilatar a edição dos restaurantes em um formulario que deve conter campo *Cuisine* como *select* e restante sendo *inputs*. A pagina deve permitir a rota */restaurants/Edit/{id}* e caso não encontre o restaurante com a *id* passada, o usuario deve ser redirecionada para pagina *Restaurants/NotFound*

☑️ Gerar as opções tag *select* */restaurants/Edit/* pelo *PageModel* da pagina

☑️ Criar validação nos campos dos restaurantes

☑️ Aplicar o padrão PGR (Post/Redirect/Get) na edição dos restaurantes

☑️ Possibilitar a criação de um novo restaurante reutilizando pagina */restaurants/Edit/* e sua lógica

☑️ Alterar */restaurants/Edit/* caso TempData["Message"] não seja nulo imprima sua mensagem dentro de alert informando que o restaurante foi salvo com sucesso
