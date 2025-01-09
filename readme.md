Project Car Catalog- Projeto Catálogo de Carros - By Paulo Fiuza -  01/09/2025 - 09/01/2025

Car Catalog Application

Introduction

This report provides a detailed overview of a desktop application designed to catalog vintage and iconic car models. It is structured to guide individuals without a technical background through the concepts and workings of the application. Developed using the C# programming language and the Windows Forms framework, the application enables users to browse cars by brand and view corresponding models and images.

Conceptualization

The application is a graphical interface that facilitates car catalog exploration. Its primary objectives are:

Allowing users to select car brands from a dropdown menu.

Displaying models corresponding to the selected brand.

Showing an image of the selected car model.

Key components include:

ComboBox: Dropdown menus for car brands and models.

PictureBox: Displays images of the selected car models.

Development of Topics

Main Functionalities

1. Brand and Model Selection

Users interact with two dropdown menus:

The first dropdown allows the selection of car brands such as Ford, Chevrolet, and Ferrari.

Upon selecting a brand, the second dropdown is populated with models specific to that brand.

2. Image Display

When a car model is selected, the application searches for an image file that matches the model’s name. If found, the image is displayed in the application.

3. File Organization

The application relies on a predefined directory structure where images of car models are stored. The image files must be named in a specific format matching the model names.

Technical Implementation

Code Overview

Form1.cs: Handles user interactions, such as brand and model selection, and dynamically updates the dropdown menus and image display.

The comboBox1_SelectedIndexChanged method updates the second dropdown based on the selected brand.

The comboBox3_SelectedIndexChanged method loads the corresponding car image.

Program.cs: Defines the entry point for the application, initializing and running the main form (Form1).

File Dependencies

Form1.cs: Contains the logic for updating UI components and loading images.

Program.cs: Sets up the application’s runtime environment.

Image directory: Holds images of car models, structured in a specific path.

Conclusion

The Car Catalog Application offers a user-friendly interface for exploring iconic cars. By integrating dropdown menus for seamless navigation and an image display for visual representation, it provides an engaging experience. While the application is simple, it demonstrates foundational programming concepts such as event handling, UI design, and file management.

_______________________________________________________________________________________________________________________________________________

Aplicativo de Catálogo de Carros

Introdução

Este relatório fornece uma visão detalhada de um aplicativo de desktop projetado para catalogar modelos de carros clássicos e icônicos. Ele é estruturado para guiar indivíduos sem experiência técnica pelos conceitos e funcionamento do aplicativo. Desenvolvido em linguagem C# com o framework Windows Forms, o aplicativo permite que usuários naveguem por marcas de carros e visualizem modelos e imagens correspondentes.

Conceituação

O aplicativo é uma interface gráfica que facilita a exploração de catálogos de carros. Seus objetivos principais são:

Permitir que usuários selecionem marcas de carros em um menu suspenso.

Exibir modelos correspondentes à marca selecionada.

Mostrar uma imagem do modelo de carro selecionado.

Os componentes principais incluem:

ComboBox: Menus suspensos para marcas e modelos de carros.

PictureBox: Exibe imagens dos modelos de carro selecionados.

Desenvolvimento dos Tópicos

Funcionalidades Principais

1. Seleção de Marca e Modelo

Os usuários interagem com dois menus suspensos:

O primeiro menu permite a seleção de marcas como Ford, Chevrolet e Ferrari.

Ao selecionar uma marca, o segundo menu é preenchido com modelos específicos daquela marca.

2. Exibição de Imagem

Quando um modelo de carro é selecionado, o aplicativo procura um arquivo de imagem que corresponda ao nome do modelo. Caso encontrado, a imagem é exibida no aplicativo.

3. Organização de Arquivos

O aplicativo depende de uma estrutura de diretórios predefinida, onde as imagens dos modelos de carros são armazenadas. Os arquivos de imagem devem ser nomeados em um formato específico que corresponda aos nomes dos modelos.

Implementação Técnica

Visão Geral do Código

Form1.cs: Gerencia as interações do usuário, como seleção de marcas e modelos, e atualiza dinamicamente os menus e a exibição de imagens.

O método comboBox1_SelectedIndexChanged atualiza o segundo menu com base na marca selecionada.

O método comboBox3_SelectedIndexChanged carrega a imagem correspondente ao modelo de carro.

Program.cs: Define o ponto de entrada do aplicativo, inicializando e executando o formulário principal (Form1).

Dependências de Arquivos

Form1.cs: Contém a lógica para atualização de componentes da interface e carregamento de imagens.

Program.cs: Configura o ambiente de execução do aplicativo.

Diretório de imagens: Contém as imagens dos modelos de carros, estruturado em um caminho específico.

Conclusão

O Aplicativo de Catálogo de Carros oferece uma interface amigável para explorar carros icônicos. Ao integrar menus suspensos para navegação e exibição de imagens para representação visual, ele proporciona uma experiência envolvente. Embora simples, o aplicativo demonstra conceitos fundamentais de programação, como manipulação de eventos, design de interface e gerenciamento de arquivos.

