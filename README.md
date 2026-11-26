# 🚗 Sistema de Cadastro de Veículos

[![.NET](https://img.shields.io/badge/.NET-10.0--windows-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-12.0-239120?logo=csharp)](https://docs.microsoft.com/dotnet/csharp/)
[![Windows Forms](https://img.shields.io/badge/UI-Windows%20Forms-0078D7?logo=windows)](https://docs.microsoft.com/dotnet/desktop/winforms/)
[![IFRN](https://img.shields.io/badge/IFRN-POO-green)](https://portal.ifrn.edu.br/)

Aplicação desktop desenvolvida em **C# / Windows Forms** para a disciplina de **Programação Orientada a Objetos (POO)** do **Instituto Federal de Educação, Ciência e Tecnologia do Rio Grande do Norte (IFRN)**.

O sistema permite gerenciar cadastros de veículos de forma intuitiva, utilizando uma arquitetura em janelas MDI (*Multiple Document Interface*) e persistência de dados local em formato **JSON**.

---

## 📋 Funcionalidades Implementadas

- [x] **Janela Principal MDI (`FormPrincipal`)**:
  - Funciona como container MDI principal da aplicação.
  - Barra de menus (`MenuStrip`) organizada por categorias:
    - **Cadastro**: *Novo veículo* (`FormCadastro`), *Visualizar cadastros* (`FormListagem`) e *Excluir cadastros* (`FormCadastro`).
    - **Menu**: *Sair* (com confirmação via `MessageBox` e encerramento seguro).
  - Gerenciamento de instâncias MDI filhas via `AbrirFilhoMdi` (evita duplicidade de janelas, trazendo à frente e atualizando a janela já aberta).

- [x] **Cadastro, Busca e Exclusão de Veículos (`FormCadastro`)**:
  - Janela MDI filha para inclusão, consulta por placa e exclusão de veículos.
  - Campos de entrada:
    - **Placa**: Identificador único do veículo.
    - **Marca** e **Modelo**: Especificações do fabricante e modelo.
    - **Ano de Fabricação**: Ano do veículo.
    - **Cor**: Tonalidade do veículo.
    - **Preço**: Valor monetário.
    - **Tipo de Combustível**: Seleção via `ComboBox` (*Gasolina*, *Flex*, *Diesel*, *Elétrico*).
  - **Cadastro com validação**:
    - Verificação de preenchimento obrigatório em todos os campos.
    - Validação de ano numérico válido (`1886` até o ano atual + 1) e preço válido maior que zero (aceitando vírgula ou ponto decimal).
    - Prevenção de cadastro com placa duplicada e tratamento de erros de persistência.
  - **Busca por placa (`Buscar`)**:
    - Localiza o veículo pela placa (sem diferenciar maiúsculas/minúsculas e com suporte a comparação sem hífen) e preenche automaticamente os demais campos da tela.
    - Limpa os detalhes e exibe aviso (`MessageBox`) caso nenhum veículo seja encontrado.
  - **Exclusão (`Excluir veículo`)**:
    - Solicita confirmação ao usuário via `MessageBox` exibindo os dados do veículo encontrado.
    - Remove o registro da lista, atualiza o arquivo `veiculos.json` no disco e limpa todos os campos da tela.
  - **Limpeza e Cancelamento**: Botões para limpar todos os campos (`Limpar formulário`) ou fechar a janela (`Cancelar cadastro`).

- [x] **Listagem e Consulta (`FormListagem`)**:
  - Janela MDI filha para visualização dos registros em formato tabular.
  - **Grid de Dados (`DataGridView`) altamente configurada**:
    - Proteção contra edição acidental (`ReadOnly = true`, `AllowUserToAddRows = false`, `AllowUserToDeleteRows = false`).
    - Seleção por linha completa (`SelectionMode = FullRowSelect`, `MultiSelect = false`).
    - Cabeçalhos estilizados em negrito (`Segoe UI 9.5pt Bold`) e com altura confortável.
    - Alinhamentos específicos: centralizado para *Placa* e *Ano Fab.*, alinhado à direita para *Preço* e à esquerda para os demais campos.
    - Formatação monetária brasileira rigorosa (`pt-BR`, máscara `C2`), exibindo valores formatados como `R$ 0,00`.
  - **Ciclo de Vida e Atualização**:
    - Disparo automático no evento de carregamento do formulário (`FormListagem_Load`) para buscar os dados serializados em disco (`veiculos.json`).
    - Botão de **Atualizar** para forçar sincronização manual a qualquer momento.
    - Botão de **Fechar** para encerramento limpo da janela filha.
    - Feedback dinâmico no rodapé com o total de registros ou aviso amigável quando a lista estiver vazia.

- [x] **Persistência de Dados (`VeiculoRepositorio`)**:
  - Armazenamento dos dados no arquivo `veiculos.json` no diretório de execução.
  - Serialização e desserialização via `System.Text.Json`.
  - Tratamento de arquivos inexistentes ou vazios com retorno seguro de lista vazia.

---

## 🏗️ Arquitetura do Projeto

O projeto adota os princípios de Programação Orientada a Objetos e divisão de responsabilidades em camadas:

```text
cadastro-de-veiculos/
│
├── .gitignore                          # Regras de exclusão do Git
├── README.md                           # Documentação geral do projeto
│
└── cadastro-de-veiculos/               # Diretório da Solution e Projeto
    ├── cadastro-de-veiculos.slnx       # Arquivo de solução .NET
    ├── cadastro-de-veiculos.csproj     # Configuração do projeto (.NET 10.0-windows)
    ├── Program.cs                      # Ponto de entrada (Main) da aplicação
    │
    ├── Models/                         # Camada de Domínio / Entidades
    │   └── Veiculo.cs                  # Classe Veiculo com atributos, construtores e ToString()
    │
    ├── Persistencia/                   # Camada de Acesso a Dados
    │   └── VeiculoRepositorio.cs       # Leitura e escrita serializada em JSON (veiculos.json)
    │
    └── Forms (Interface Gráfica)       # Camada de Apresentação
        ├── FormPrincipal.cs            # Janela MDI Container e Menus de Navegação
        ├── FormCadastro.cs             # Formulário MDI Child para inclusão, busca e exclusão
        └── FormListagem.cs             # Formulário MDI Child com DataGridView para visualização
```

### Detalhes das Classes Principais

#### `Veiculo` (Models)
Representa a entidade de negócio com as propriedades:
- `Placa` (`string`)
- `Marca` (`string`)
- `Modelo` (`string`)
- `AnoFabricacao` (`int`)
- `Cor` (`string`)
- `Preco` (`decimal`)
- `TipoCombustivel` (`string`)

#### `VeiculoRepositorio` (Persistencia)
Fornece operações para:
- `SalvarDados(List<Veiculo> veiculos)`: Serializa a lista com indentação (`WriteIndented = true`) e grava em disco.
- `CarregarDados()`: Lê o arquivo JSON e converte em lista de objetos `Veiculo`, tratando possíveis exceções.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem**: C# (.NET 10.0 SDK)
- **Framework de UI**: Windows Forms (WinForms)
- **Persistência**: `System.Text.Json`
- **Controle de Versão**: Git & GitHub (GitFlow com feature branches)
- **IDE Recomendada**: Visual Studio 2022/2026 ou VS Code com C# Dev Kit

---

## 🚀 Como Executar o Projeto

### Pré-requisitos
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download) ou superior instalado.
- Sistema Operacional: Windows (compatível com Windows Forms).

### Passos:

1. **Clonar o repositório:**
   ```bash
   git clone https://github.com/Zjonathas/cadastro-de-veiculos.git
   cd cadastro-de-veiculos
   ```

2. **Acessar a pasta do projeto:**
   ```bash
   cd cadastro-de-veiculos
   ```

3. **Restaurar e compilar:**
   ```bash
   dotnet build
   ```

4. **Executar a aplicação:**
   ```bash
   dotnet run
   ```

Ou simplesmente abra o arquivo `cadastro-de-veiculos.slnx` no **Visual Studio** e pressione `F5`.

---

## 🌿 Histórico de Branches e Features

O projeto foi construído colaborativamente através de branches temáticas:

| Branch | Objetivo / Responsabilidade |
|---|---|
| `feature/setup-model` | Criação da classe `Veiculo` e estrutura inicial do domínio. |
| `feature/form-mdi` | Implementação do `FormPrincipal` como MDI Container e menus base. |
| `feature/form-cadastro` | Construção do `FormCadastro` com controles de entrada de dados. |
| `feature/persistencia` | Implementação do `VeiculoRepositorio` com `System.Text.Json`. |
| `feature/form-listagem` | Criação do `FormListagem` com `DataGridView` e vínculo MDI ao menu. |
| `fix/ajustes-finais` | Ajustes de acabamento, usabilidade e validações finais. |

---

## 👨‍💻 Autores e Créditos

Projeto desenvolvido para a disciplina de **Programação Orientada a Objetos (POO)** do **IFRN**.

