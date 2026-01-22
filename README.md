# StockVision - Plataforma de Análise Financeira com IA

![StockVision](https://img.shields.io/badge/Status-Em%20Desenvolvimento-blue)
![Angular](https://img.shields.io/badge/Angular-17-DD0031?logo=angular)
![.NET](https://img.shields.io/badge/.NET-8-512BD4?logo=dotnet)
![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-4.x-38B2AC?logo=tailwind-css)

## 📊 Sobre o Projeto

**StockVision** é uma plataforma web moderna e profissional de análise financeira baseada em dados e inteligência artificial.  
O sistema permite que investidores, analistas financeiros e entusiastas do mercado visualizem dados históricos e intraday de ativos, acompanhem previsões de preços geradas por modelos de séries temporais e analisem automaticamente o sentimento de notícias relacionadas aos ativos.

Este projeto foi desenvolvido como **portfólio profissional**, com foco em **arquitetura de software, boas práticas, testes e UX orientada a dados**, demonstrando competências em:

- Desenvolvimento Frontend com **Angular**
- Desenvolvimento Backend com **.NET Web API**
- Arquitetura limpa e componentização
- Visualização de dados financeiros
- Integração com APIs externas
- Aplicação de IA em problemas reais de mercado

---

## 🎯 Principais Funcionalidades

### 1️⃣ **Dashboard Principal**
- Visão geral dos principais indicadores financeiros
- Cards com preço atual, volume, máxima/mínima e variação percentual
- Gráficos de histórico de preços (30, 90 dias, 1 ano)
- Gráfico intraday com dados quase em tempo real
- Indicadores rápidos para tomada de decisão

### 2️⃣ **Visualização Histórica**
- Gráfico de preços com múltiplos períodos (1M, 3M, 6M, 1Y, 5Y)
- Gráfico de volume de negociação
- Resumo estatístico do ativo
- Estrutura preparada para exportação de dados

### 3️⃣ **Visualização Intraday**
- Monitoramento da sessão atual do mercado
- Indicadores de abertura, máxima, mínima e variação
- Atualização periódica (ex.: a cada 5 minutos)
- Análise rápida do comportamento do ativo

### 4️⃣ **Previsão de Preços com IA**
- Modelos de séries temporais (ARIMA + LSTM)
- Previsões para 7, 14 e 30 dias
- Visualização de intervalo de confiança
- Identificação automática de tendência (alta, baixa ou neutra)
- Insights gerados a partir do modelo

### 5️⃣ **Análise de Sentimento de Notícias**
- Processamento automático de notícias financeiras
- Score agregado de sentimento
- Distribuição visual (positivo, neutro, negativo)
- Lista de manchetes analisadas
- Tendência de sentimento ao longo do tempo

### 6️⃣ **Sistema de Alertas**
- Criação de alertas personalizados
- Alertas de preço (acima/abaixo de determinado valor)
- Alertas baseados em sentimento
- Gestão completa de alertas (ativar, desativar, remover)

---

## 🛠️ Stack Tecnológica

### Frontend
- **Angular** — Framework para construção de SPAs escaláveis
- **TypeScript** — Tipagem estática e maior segurança
- **Tailwind CSS v4** — Estilização moderna e responsiva
- **Chart Libraries (ex.: ngx-charts / chart.js)** — Visualização de dados
- **RxJS** — Programação reativa
- **Angular Router** — Navegação entre módulos

### Backend
- **.NET 8 Web API** — Backend robusto e escalável
- **Entity Framework Core** — ORM para acesso a dados
- **SQL Server** — Banco de dados relacional
- **Arquitetura Limpa (Clean Architecture)**

### Integrações Externas
- **Alpha Vantage API** — Dados financeiros históricos e intraday
- Serviços de notícias financeiras (para análise de sentimento)

### Inteligência Artificial (Planejado)
- **Python** — Modelos de Machine Learning
- **ARIMA + LSTM** — Previsão de séries temporais
- **NLP** — Análise de sentimento de notícias
- Integração via API com o backend .NET

---

## 🎨 Design System

### Paleta de Cores
- **Background**: `#0B1120`
- **Cards**: `#151B2B`
- **Primária**: `#3B82F6`
- **Positivo**: `#10B981`
- **Negativo**: `#EF4444`
- **Neutro**: `#64748B`

### Componentes Principais
- **Sidebar** — Navegação lateral fixa
- **Header** — Busca de ativos e informações do usuário
- **Cards** — Métricas e indicadores
- **Charts** — Gráficos financeiros interativos
- **Buttons & Inputs** — Estados visuais bem definidos

---
## 📂 Estrutura do Projeto

```
stockvision/
├── frontend/
│ ├── src/
│ │ ├── app/
│ │ │ ├── core/
│ │ │ ├── shared/
│ │ │ ├── features/
│ │ │ │ ├── dashboard/
│ │ │ │ ├── historical/
│ │ │ │ ├── intraday/
│ │ │ │ ├── prediction/
│ │ │ │ ├── sentiment/
│ │ │ │ └── alerts/
│ │ ├── assets/
│ │ └── environments/
│ └── angular.json
│
├── backend/
│ ├── StockVision.Api/
│ ├── StockVision.Application/
│ ├── StockVision.Domain/
│ ├── StockVision.Infrastructure/
│ └── StockVision.Tests/
│
├── docs/
│ ├── requirements.md
│ ├── architecture.md
│ ├── diagrams/
│ └── testing-strategy.md
│
└── README.md
```
---
## 🚀 Como Executar

### Pré-requisitos
- Node.js 18+
- Angular CLI
- .NET 8 SDK
- SQL Server (ou SQL Server Express)

### Frontend
```bash
cd frontend
npm install
ng serve
```

### Backend

```bash
cd backend
dotnet restore
dotnet run --project StockVision.Api
```

## Roadmap

* Integração completa com Alpha Vantage
* Implementação dos modelos de IA
* Autenticação com JWT
* Sistema de notificações
* Testes automatizados (Unitários, Integração e E2E)
* CI/CD com GitHub Actions
* Deploy em ambiente cloud (Azure / AWS)

## 👤 Autor 

Anabelly Montibeller

* Linkedin: https://www.linkedin.com/in/anabelly-sthephany-paiva-montibeller-/

## 📄 Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.


