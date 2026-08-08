# 📋 ProjetoForms

O **ProjetoForms** é uma API robusta e moderna desenvolvida em **ASP.NET Core (Web API) com .NET 10**. A aplicação permite que usuários cadastrados criem, editem, compartilhem e gerenciem formulários personalizados com diferentes tipos de perguntas e alternativas, além de coletar e visualizar as respostas de forma segura e controlada.

---

## 🚀 Principais Funcionalidades (Requisitos)

O sistema foi modelado para atender a um conjunto completo de requisitos funcionais e não funcionais:

### 🔹 Gestão de Formulários e Perguntas
* **Criação de Formulários personalizados** com título e descrição ([RF01]).
* **Criação de Perguntas** associadas aos formulários ([RF02]) com suporte a **perguntas obrigatórias** ([RF13]).
* **Múltiplos tipos de perguntas**: Resposta curta, texto longo, múltipla escolha e caixa de seleção ([RF12]).
* **Criação de Alternativas** para perguntas do tipo seleção ([RF03]).
* **Edição completa** de todos os componentes do formulário (perguntas, alternativas, etc.) ([RF07]).
* **Exclusão** de formulários ([RF09]), perguntas ([RF15]) e alternativas ([RF16]).
* **Compartilhamento simplificado** através da geração de um link único por formulário ([RF14]).

### 🔹 Respostas e Preenchimento
* **Área exclusiva de preenchimento** através de uma página pública/alternativa sem permissão de edição ([RF08]).
* **Envio de respostas** com limite máximo de respostas configurável por usuário ([RF04]).
* **Visualização de respostas recebidas** restrita ao criador do formulário ([RF10]).
* **Encerramento de formulários** para parar de receber novas respostas a qualquer momento ([RF11]).

### 🔹 Usuários e Segurança
* **Cadastro independente** de novos usuários ([RF05]).
* **Autenticação segura** via JWT Bearer Token ([RF17]).
* **Segurança de dados**: Senhas criptografadas usando algoritmo de hash seguro **BCrypt** ([RNF03]).
* **Controle de Acesso**: Políticas baseadas em perfis (Administrador vs. Usuário Comum).

---

## 🛠️ Stack Tecnológica

* **Framework Principal:** [ASP.NET Core 10 (Web API)](https://dotnet.microsoft.com/)
* **Linguagem:** C# 14
* **Persistência de Dados & ORM:** [Entity Framework Core 10](https://learn.microsoft.com/ef/core/)
* **Banco de Dados:** [SQL Server](https://www.microsoft.com/sql-server)
* **Segurança & Criptografia:** BCrypt.Net-Next
* **Autenticação:** JWT (JSON Web Tokens)
* **Gerenciamento de Ambientes:** DotNetEnv
* **Documentação de API:** Swagger/OpenAPI (Swashbuckle)
* **Containerização:** Docker

---

## 📁 Estrutura do Projeto

A arquitetura do projeto segue o padrão de **Camadas (Controllers -> Services -> Repositories -> Database)**, promovendo baixo acoplamento e alta testabilidade.

```bash
ProjetoForms/
├── Controllers/         # Portas de entrada da API (Rotas e controle de requisições)
├── Services/            # Camada de Regras de Negócio (Interfaces e Implementações)
├── Repositories/        # Camada de Acesso a Dados (Interfaces e Implementações)
├── Models/              # Entidades representativas do Banco de Dados
├── DTOs/                # Objetos de Transferência de Dados (Data Transfer Objects)
├── Enums/               # Enumeradores (ex: PerfilUsuario)
├── Data/                # Contexto de dados do Entity Framework (FormsDbContext)
├── Middlewares/         # Tratamento global de exceções e interceptação de requisições
├── Migrations/          # Histórico de alterações e migrações do banco de dados
├── Documentation/       # Documentos de requisitos e especificações do sistema
├── Properties/          # Configurações de inicialização do projeto (launchSettings.json)
├── Dockerfile           # Instruções para criação do container da aplicação
├── Program.cs           # Configuração de serviços, middlewares e inicialização da API
└── ProjetoForms.csproj  # Configurações de pacotes NuGet e build do .NET
```

---

## ⚙️ Instalação e Configuração

### Pré-requisitos
Antes de começar, certifique-se de ter instalado em sua máquina:
* [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
* [SQL Server](https://www.microsoft.com/sql-server/sql-server-downloads) (ou LocalDB)
* [Docker](https://www.docker.com/) (opcional, para rodar em container)

---

### Passo a Passo

#### 1. Clonar o Repositório
```bash
git clone https://github.com/seu-usuario/ProjetoForms.git
cd ProjetoForms
```

#### 2. Configurar as Variáveis de Ambiente
Crie um arquivo chamado `.env` na raiz do projeto (mesmo nível do arquivo `Program.cs`) e utilize as configurações contidas em `.env.exemple` como base:

```env
# String de conexão com o SQL Server
ConnectionStrings__Default=Server=SEU_SERVIDOR;Database=ProjetoFormsDb;Trusted_Connection=True;TrustServerCertificate=True;

# Configurações do JWT (Mantenha a JWT_KEY protegida)
JWT_KEY=SuaChaveSecretaSuperSeguraComPeloMenos256Bits
JWT_ISSUER=ProjetoFormsAPI
JWT_AUDIENCE=ProjetoFormsClient
```

#### 3. Executar as Migrações do Banco de Dados
Para criar as tabelas e o banco de dados no SQL Server com base nas migrações do EF Core, execute:

```bash
dotnet ef database update
```
*(Nota: Certifique-se de que a ferramenta `dotnet-ef` está instalada globalmente via `dotnet tool install --global dotnet-ef`.)*

#### 4. Executar a Aplicação
Inicie o servidor de desenvolvimento da API:

```bash
dotnet run
```
Ou no modo de monitoramento automático de código (Watch):
```bash
dotnet watch
```

A API estará disponível por padrão nos endereços configurados em `Properties/launchSettings.json`.
Você pode acessar a documentação Swagger interativa em:
* **Swagger UI:** `http://localhost:5000/swagger` ou `https://localhost:5001/swagger` (ou a porta exibida no seu console).

---

## 🐳 Executando com Docker

Se preferir rodar a aplicação encapsulada em um container Docker, utilize os comandos abaixo:

#### 1. Construir a imagem Docker
```bash
docker build -t projetoforms-api -f Dockerfile .
```

#### 2. Executar o container
```bash
docker run -d -p 8080:8080 --name projetoforms-app --env-file .env projetoforms-api
```

---

## 🛑 Principais Endpoints da API

Abaixo estão listados os principais endpoints expostos pela API. A documentação completa e interativa pode ser vista diretamente pelo Swagger.

### Autenticação (`/api/Auth`)
| Método | Rota | Descrição | Requer Autenticação |
|:---:|:---|:---|:---:|
| **POST** | `/api/Auth` | Realiza o login de um usuário e retorna o Token JWT | Não |

### Usuários (`/api/Usuario`)
| Método | Rota | Descrição | Requer Autenticação |
|:---:|:---|:---|:---:|
| **POST** | `/api/Usuario/create` | Cadastra um novo usuário no sistema | Não |
| **GET** | `/api/Usuario/{id}` | Busca os dados de um usuário pelo ID | Sim (Perfil Comum/Admin) |
| **GET** | `/api/Usuario` | Lista todos os usuários cadastrados | Sim (Apenas Admin) |
| **PUT** | `/api/Usuario/update` | Atualiza os dados cadastrais do usuário | Sim (Perfil Comum/Admin) |
| **DELETE** | `/api/Usuario/delete` | Exclui um usuário do sistema pelo ID | Sim (Apenas Admin) |

### Formulários (`/api/Formulario`)
| Método | Rota | Descrição | Requer Autenticação |
|:---:|:---|:---|:---:|
| **POST** | `/api/Formulario/create` | Cria um novo formulário personalizado | Sim |
| **GET** | `/api/Formulario/{id}` | Obtém os detalhes de um formulário pelo ID | Não |
| **GET** | `/api/Formulario` | Lista todos os formulários ativos | Não |
| **PUT** | `/api/Formulario/update` | Atualiza um formulário existente | Sim |
| **DELETE** | `/api/Formulario/delete` | Remove um formulário pelo ID | Sim |

---

## 🛡️ Segurança e Middlewares

A aplicação conta com um tratamento centralizado de erros e exceções através de um **ExceptionMiddleware** (`Middlewares/ExceptionMiddleware.cs`), garantindo que falhas inesperadas retornem respostas formatadas e amigáveis ao cliente, ocultando detalhes sensíveis do servidor em ambientes de produção.

---

## 👥 Contribuição e Autoria

Projeto idealizado e desenvolvido originalmente por **Pedro Henrique** conforme histórico de requisitos e especificações.

Sinta-se à vontade para abrir pull requests ou sugerir melhorias abrindo uma issue!
