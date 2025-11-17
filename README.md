# Sistema de Reserva de Hotel em C#

>  Projeto Concluído 

Projeto de Console Application em C# que simula um sistema de reserva de hotel. O objetivo foi aplicar na prática os conceitos fundamentais da Programação Orientada a Objetos (POO), gerenciando o cadastro de hóspedes e a reserva de uma suíte, com regras de negócio e validações.

---

## Funcionalidades

* **Cadastro de Hóspedes:** Permite o cadastro de múltiplos hóspedes para uma mesma reserva.
* **Escolha de Suíte:** O usuário pode escolher entre diferentes tipos de suítes (Premium, Confort, etc.), cada uma com sua própria capacidade e valor de diária.
* **Validação de Capacidade:** O sistema não permite que uma reserva seja feita se o número de hóspedes exceder a capacidade da suíte escolhida.
* **Cálculo do Valor Total:** O sistema calcula o valor total da estadia com base nos dias reservados e no valor da diária.
* **Regra de Negócio (Desconto):** Aplica um desconto de **10%** no valor total para estadias de 10 dias ou mais.

---

## Conceitos Aplicados

Este projeto foi uma oportunidade para praticar pilares essenciais do C# e da POO:

* **Programação Orientada a Objetos (POO):**
    * **Classes:** Criação das classes `Reserva`, `Pessoa` e `Suite` para modelar o domínio do problema.
    * **Propriedades:** Uso de `get; set;` para encapsular os dados.
    * **Construtores:** Utilização de construtores para garantir que os objetos sejam criados em um estado válido (ex: `Reserva` exigindo `diasReservados` e inicializando a lista).
* **Coleções:** Uso de `List<Pessoa>` para armazenar múltiplos hóspedes em uma reserva.
* **Validação de Entrada de Dados (Input Handling):**
    * Uso de `int.TryParse` para converter a entrada do console para números de forma segura, evitando que o programa quebre.
    * Uso de `string.IsNullOrWhiteSpace` para garantir que nomes e sobrenomes não sejam nulos ou vazios.
* **Estruturas de Controle:**
    * Uso de loops `while(true)` para criar menus de validação que só terminam quando a entrada do usuário é válida.
    * Uso de loops `for` para cadastrar o número exato de hóspedes.
* **Programação Defensiva:**
    * Implementação de "Null Checks" (ex: `if (Suite == null)` no método `calcularValorTotal`) para evitar `NullReferenceException`.

---

## Tecnologias Utilizadas

* **C#**
* **.NET**
* **Console Application**

---

## Como Usar

1.  Clone o repositório:
    ```bash
    git clone [https://github.com/CalebeXimenes07/SEU-REPOSITORIO.git](https://github.com/CalebeXimenes07/SEU-REPOSITORIO.git)
    ```
2.  Abra o projeto no Visual Studio ou VS Code.
3.  Execute o programa (pressionando F5 no Visual Studio ou usando `dotnet run` no terminal).
