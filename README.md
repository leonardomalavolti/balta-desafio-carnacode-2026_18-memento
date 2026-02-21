![CO-6](https://github.com/user-attachments/assets/e03073e5-1f5e-4ccf-afe8-2c9c1daddb3a)

## 🥁 CarnaCode 2026 - Desafio 18 - Memento

Oi, eu sou o Leonardo Malavolti e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo [balta.io](https://balta.io). 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

### Sobre este desafio
No desafio **Memento** eu tive que resolver um problema real implementando o **Design Pattern** em questão.
Neste processo eu aprendi:
* ✅ Boas Práticas de Software
* ✅ Código Limpo
* ✅ SOLID
* ✅ Design Patterns (Padrões de Projeto)
* ✅ Desacoplamento de histórico de objeto
* ✅ Undo/Redo eficiente sem expor internals

## Problema
Um editor de imagens precisa permitir desfazer/refazer operações (crop, filtros, rotação).  
O código atual tinha problemas:
* Salvava estado completo da imagem após cada edição → alto consumo de memória
* Métodos públicos expunham todos os atributos internos
* Undo/Redo violava encapsulamento
* Difícil manter integridade e invariantes do editor
* Abordagem delta/diff complexa e frágil

## Solução Implementada
Utilizando o **Memento Pattern**:
* O editor (`ImageEditor`) mantém seu estado interno privado
* O `EditorHistory` gerencia snapshots (Mementos) de forma encapsulada
* Undo e redo são possíveis sem expor arrays internos ou detalhes do estado
* Memória usada de forma eficiente, salvando apenas o necessário
* Código desacoplado, extensível e testável

### Benefícios
* Undo/Redo funcional e seguro
* Estado interno protegido e encapsulado
* Menor consumo de memória comparado a snapshots completos
* Facilidade de salvar/restaurar múltiplos pontos
* Permite futura serialização do estado

## Sobre o CarnaCode 2026
O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais. Durante os 23 desafios desta jornada, os participantes são submetidos ao aprendizado e prática na identificação de códigos não escaláveis e na solução de problemas utilizando padrões de mercado.

### eBook - Fundamentos dos Design Patterns
Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito [Fundamentos dos Design Patterns](https://lp.balta.io/ebook-fundamentos-design-patterns).

### Veja meu progresso no desafio
[Incluir link para o repositório central]
