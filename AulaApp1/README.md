
# Exercício: Componentes Reutilizáveis em Blazor

O FormProduto não adiciona diretamente os produtos à lista porque sua responsabilidade é apenas coletar e validar os dados.
Quem realiza o cadastro é a página Produtos.razor, que mantém e controla a lista.
Quando o formulário recebe dados válidos, ele utiliza um EventCallback<Produto> para enviar o objeto à página.
A página recebe esse evento pelo método ReceberProduto e adiciona o produto à lista.


## Captura de tela do projeto

Abaixo está a tela de cadastro e listagem de produtos:

![Tela de Produtos](imagens/produtos/produtos.png)
![Tela de Produtos](imagens/produtos/produtos2.png)
