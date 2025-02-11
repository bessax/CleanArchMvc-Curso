# Projeto de Curso: [Clean Architecture Essencial - ASP .NET Core com C#](https://www.udemy.com/course/clean-architecture-essencial-asp-net-core-com-c/)

## 📌 Sobre o Projeto
Este projeto faz parte do curso de Clean Architecture Essencial - ASP .NET Core com C#. O objetivo é demonstrar a implementação de uma arquitetura limpa em um sistema, aplicando boas práticas de design de software para garantir modularidade, testabilidade e facilidade de manutenção.

## 🎯 Objetivos do Curso
- Compreender os princípios da Clean Architecture.
- Aplicar separação de responsabilidades (SRP, ISP, DIP).
- Implementar camadas independentes e modulares.
- Criar uma API RESTful robusta utilizando ASP.NET.
- Utilizar Entity Framework Core para persistência de dados.
- Implementar testes unitários.

## 🏗️ Estrutura do Projeto
O projeto segue a estrutura recomendada pela Clean Architecture:

```
📂 src/
   ├── 📂 API/      
   ├── 📂 Application/           
   ├── 📂 Domain/
   ├── 📂 Domain.Tests/    
   ├── 📂 Infra.Data/
   ├── 📂 Infra.IOC/    
   ├── 📂 WebUI/            
```

## 🔧 Tecnologias Utilizadas
- C#
- ASP.NET Core
- Entity Framework Core
- MediatR (para manipulação de casos de uso)
- AutoMapper (para mapeamento de objetos)
- xUnit / NUnit (para testes automatizados)

## 🚀 Como Executar o Projeto
1. Clone o repositório:
   ```sh
   git clone https://github.com/bessax/CleanArchMvc-Curso.git
   ```
2. Acesse a pasta do projeto:
   ```sh
   cd CleanArchMvc-Curso
   ```
3. Restaure as dependências:
   ```sh
   dotnet restore
   ```
4. Configure o banco de dados:
   ```sh
   dotnet ef database update
   ```
5. Execute a API:
   ```sh
   dotnet run --project src/API
   ```
6. Acesse a documentação da API via Swagger:
   ```
   http://localhost:XXXXX/swagger
   ```

## 📝 Licença
Este projeto está licenciado sob a licença MIT. Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.


## ✒️ Implementado por:
- **André Bessa da Silva** - _Desenvolvedor_  - [bessax](https://github.com/bessax)

---
📌 **Observação:** Este é um projeto educacional desenvolvido para fins didáticos.🎉

