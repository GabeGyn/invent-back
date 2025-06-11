
# Invent Back-end





[![CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)

[![DotNet](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
)](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
)

[![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=Swagger&logoColor=white
)](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=Swagger&logoColor=white)




## Descrição

Criar o processo de CRUD (Create, Read, Update, Delete) com uma api em C#.

Conexao com banco de dados não é obrigatoria, os dados podem ser salvos em memoria, mas se alguma base de dados for utilizada dê preferencia a bases NoSql.


## Front-end

O repositorio do projeto front-end pode ser acessado pelo link:

[Invent Front-end](https://github.com/GabeGyn/invent-front#)


## Rodando localmente

Clone o projeto

```bash
  git clone https://github.com/GabeGyn/invent-back.git
```

Entre no diretório do projeto

```bash
  cd invent-back
```

Inicie o servidor

```bash
  dotnet run
```

Navegue até a documentação da API Swagger
```bash
http://localhost:5250/swagger
```


## Documentação da API

#### Retorna todos os itens

```http
  GET /api/equipamentoeletronico
```

#### Insere um novo item

```http
  POST /api/equipamentoeletronico
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `nome`      | `string` | **Obrigatório**. Nome do equipamento eletrônico |
| `tipo`      | `string` | **Obrigatório**. Tipo do equipamento eletrônico |
| `qtdeEstoque`      | `integer` | **Obrigatório**. Quantidade do equipamento em estoque |

#### Atualiza um item

```http
  PUT /api/equipamentoeletronico/{:id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `string` | **Obrigatório**. Id do equipamento eletrônico |
| `nome`      | `string` | **Obrigatório**. Nome do equipamento eletrônico |
| `tipo`      | `string` | **Obrigatório**. Tipo do equipamento eletrônico |
| `qtdeEstoque`      | `integer` | **Obrigatório**. Quantidade do equipamento em estoque |

#### Remove um item

```http
  DELETE /api/equipamentoeletronico/{:id}
```