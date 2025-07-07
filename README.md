# Pokédex API 🐾

Uma API RESTful construída em C# para gerenciar uma Pokédex usando MongoDB.  
Permite CRUD completo de Pokémons, tipos, habilidades, evoluções e estatísticas.

-- não testada por erro de máquina --

---

## 💡 O que o código faz

- Define modelos para Pokémon, Tipo, Habilidade, Evolução e Estatística  
- Implementa CRUD para Pokémons com relacionamentos (N:N e 1:N)  
- Usa MongoDB para armazenamento flexível de dados   
- Suporta inserção, atualização, listagem e remoção de Pokémons completos

---

## 🚀 Tecnologias usadas

- [.NET 7](https://dotnet.microsoft.com/) (ASP.NET Core Web API)  
- [MongoDB](https://www.mongodb.com/) (NoSQL Database)  
- [MongoDB.Driver](https://www.nuget.org/packages/MongoDB.Driver/) (driver oficial Mongo para C#)  
- [Visual Studio Code](https://code.visualstudio.com/) (IDE)

---

## 🛠️ Como rodar o projeto

### Pré-requisitos

- Instalar [.NET SDK](https://dotnet.microsoft.com/en-us/download)  
- Ter uma conta no [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) (ou Mongo local)  
- Ter o [Visual Studio Code](https://code.visualstudio.com/) instalado

### Passos

1. Clone este repositório:

   ```bash
   git clone https://github.com/seuusuario/pokedex-api.git
   cd pokedex-api
