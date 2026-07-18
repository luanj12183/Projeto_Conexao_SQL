#Projeto de Conexão SQL + Azure (Cloud)

📦 Gerenciador de Produtos **(.NET Core + Azure SQL)**
Este projeto é uma aplicação web em ASP.NET Core MVC desenvolvida para o gerenciamento completo de produtos (CRUD), com armazenamento e persistência de dados em tempo real na nuvem utilizando o Azure SQL Database.

🚀 Destaques da Integração com o Azure
Banco de Dados em Nuvem: Migração completa da infraestrutura local para a nuvem da Microsoft através do Entity Framework Core, que gerencia de forma segura as conexões de rede com o Azure.

Arquitetura Serverless: Configuração na camada de consumo inteligente do Azure, reduzindo custos ao pausar o processamento automaticamente quando o sistema fica inativo.

Segurança por Firewall: Bloqueio de acessos externos e liberação restrita do tráfego criptografado apenas para IPs autorizados no painel de controle da nuvem.

Tratamento de Timeouts: Ajuste de resiliência na aplicação para lidar com o tempo de inicialização (cold start) do servidor do Azure quando ele sai do modo de suspensão.

⚙️ Funcionalidades e Funcionalidades Técnicas
CRUD Completo: Controle de produtos através das rotas Index (listagem), Cadastrar (criação), Visualizar (detalhes) e Excluir (remoção definitiva com confirmação em JavaScript).

Localização Monetária (pt-BR): Correção da cultura nativa do servidor do Azure (que opera em padrão americano) para forçar a exibição correta dos valores no formato de Real brasileiro (R$) usando CultureInfo.

Interface Responsiva: Telas limpas estruturadas com Bootstrap 5 e motor de renderização Razor, incluindo alertas para tabelas vazias e cartões organizados para visualização técnica de dados.
