# ConsumerCatFactApi

Aplicação console em **C# (.NET 8)** que consome a API pública de fatos aleatórios sobre gatos:

- Endpoint: `https://catfact.ninja/fact`

Disciplina: Desenvolvimento Web — Usabilidade, Dev. Web, Mobile e Jogos
Professor: Daniel Henrique Matos de Paiva

## Estrutura do projeto

```
ConsumerCatFactApi/
├── ConsumerCatFactApi.csproj
├── Program.cs      # Ponto de entrada: faz a requisição HTTP e imprime o resultado
├── CatFact.cs       # Modelo (DTO) que representa o JSON retornado pela API
└── README.md
```

## Como executar

Pré-requisito: [.NET 8 SDK](https://dotnet.microsoft.com/download) instalado.

```bash
# Dentro da pasta do projeto
dotnet run
```

Saída esperada (o texto muda a cada execução, pois o fato é aleatório):

```
Fato sobre Gatos:

Many cats cannot properly digest cow's milk. Milk and milk products give them diarrhea.
```

## Como funciona

1. `HttpClient` faz uma requisição `GET` para `https://catfact.ninja/fact`.
2. A resposta JSON é desserializada para a classe `CatFact`, usando `System.Text.Json`.
3. O valor da propriedade `Fact` é impresso no console.

## Publicando no GitHub

Nome sugerido do repositório (conforme o exercício): **consumer-catfact-api-net-console**

```bash
git init
git add .
git commit -m "Consumer console app for catfact.ninja API"
git branch -M main
git remote add origin https://github.com/SEU_USUARIO/consumer-catfact-api-net-console.git
git push -u origin main
```
