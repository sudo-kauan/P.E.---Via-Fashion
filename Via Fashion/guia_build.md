# Guia de build — Via Fashion D0

## Objetivo

Abrir e compilar a solução mínima C# Windows Forms para demonstrar a base do projeto e exibir uma janela `Hello World`, mantendo as camadas `UI`, `Domain` e `Data` separadas.

## Pré-requisitos

- Windows 10/11.
- Visual Studio 2022 compatível com .NET 8.
- Carga de trabalho **Desenvolvimento para desktop com .NET**.
- SDK do .NET 8 instalado.

Confirme a instalação pelo Prompt de Comando/PowerShell:

```powershell
dotnet --list-sdks
```

A lista deve conter uma versão `8.0.xxx`.

## Abrir e executar no Visual Studio

1. Extraia a pasta do projeto do ZIP.
2. Abra `ViaFashion.sln` no Visual Studio usando **Arquivo > Abrir > Projeto/Solução**.
3. Aguarde a carga da solução e a restauração automática de pacotes. Esta solução D0 não usa pacotes NuGet externos.
4. No Gerenciador de Soluções, clique com o botão direito em `ViaFashion.UI`.
5. Selecione **Definir como Projeto de Inicialização**. O projeto deve aparecer em negrito.
6. Selecione `Debug` e `Any CPU` na barra superior.
7. Escolha **Compilar > Compilar Solução** (atalho comum: `Ctrl+Shift+B`).
8. Confira a janela **Lista de Erros**: corrija qualquer erro antes de avançar.
9. Pressione `F5`. A janela “Via Fashion - Base do Projeto D0” deve abrir com o texto Hello World.

## Estrutura em camadas

- `ViaFashion.UI`: aplicação Windows Forms. Contém `Program.cs` e `Form1.cs`.
- `ViaFashion.Domain`: projeto de biblioteca de classes vazio, reservado às entidades e regras de domínio dos próximos marcos.
- `ViaFashion.Data`: projeto de biblioteca de classes vazio, reservado ao acesso aos dados dos próximos marcos.

As camadas `Domain` e `Data` estão propositalmente vazias nesta entrega, conforme o critério de aceitação D0. Não configurar MySQL nem adicionar código de conexão neste marco.

## Evidências reais para o professor

Salvar em uma pasta `Evidencias_D0`:

1. Captura do Gerenciador de Soluções mostrando os três projetos.
2. Captura da mensagem **Compilação bem-sucedida** ou da janela de build sem erros.
3. Captura da janela Windows Forms com o texto Hello World.
4. PDF de requisitos e PDF do DER/dicionário de dados.
5. Link do repositório remoto, caso o docente exija. O ZIP, sozinho, não cria um repositório remoto.

Não forjar ou simular as capturas. Elas devem ser tiradas após a execução no computador do grupo.

## Git local (opcional como preparação para o remoto)

Executar no terminal aberto na pasta raiz do projeto:

```powershell
git init
git add .
git commit -m "Entrega D0 - base do projeto Via Fashion"
```

Depois, para publicar no GitHub, crie um repositório remoto vazio e utilize a URL e os comandos indicados pelo próprio GitHub. Não inclua senhas ou credenciais nos arquivos versionados.
