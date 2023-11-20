MyFirstAPI.ASPNET
Este projeto é uma API simples desenvolvida em ASP.NET Core, criada como parte de uma introdução ao desenvolvimento de APIs.

Descrição
A MyFirstAPI.ASPNET é uma API básica que fornece endpoints para operações CRUD (Create, Read, Update, Delete) em uma entidade de exemplo. A API é um projeto inicial para aqueles que estão começando a explorar o desenvolvimento de APIs em ASP.NET Core.

Funcionalidades
Operações CRUD: 
A API oferece endpoints para criar, recuperar, atualizar e excluir dados da entidade de exemplo.

Utilização de Rotas e Controladores: 
Demonstração do uso de rotas e controladores para gerenciar requisições HTTP.

Endpoints Disponíveis
GET /api/sample: Retorna todos os registros da entidade de exemplo.
GET /api/sample/{id}: Retorna um registro específico com base no ID fornecido.
POST /api/sample: Cria um novo registro.
PUT /api/sample/{id}: Atualiza um registro existente com base no ID fornecido.
DELETE /api/sample/{id}: Remove um registro com base no ID fornecido.

Instalação e Uso

Clonar o Repositório:
git clone https://github.com/Luizhnrs/MyFirstAPI.ASPNET.git

Configuração do Ambiente:
Verifique se possui o .NET Core SDK instalado.

Executando o Projeto:
cd MyFirstAPI.ASPNET
dotnet run

Testando a API:
Utilize uma ferramenta como Postman ou cURL para enviar requisições HTTP aos endpoints listados acima.

