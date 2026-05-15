# Prova

Voce irá simular uma batalha entre uma Guilda e um Boss. Para isso precisaremos ter:
- O Tanque (100 de hp, 15 de dano)
- O Guerreiro (60 de hp, 30 de dano)
- O Mago (40 de hp, 60 de dano)
- O Boss (800 de hp, dano aleatório entre 0-30)
- O Boss Furioso (800 de hp, dano é 0 ou 60)

#### Guilda
Crie uma classe 'Guilda' que contém uma lista de aqueles que serão nossos aventureiros.
Para definirmos nossos aventureiros devemos passar uma string e com isso ela irá
criar a devida entidade corretamente
ex:
```cs
var guilda = new Guilda()
guilda.Add("guerreiro")
guilda.Add("guerreiro")
guilda.Add("mago")
guilda.Add("tanque")
```

Método 'Attack', que faz com que todos os membros da Guilda ataquem um inimigo.
A Guida deve Observar o Boss durante a batalha, e sempre que ele atacar ela irá conferir
se algum dos seus aliados foi morto e remove-lo da lista.
O Boss não pode possuir uma referência direta para a classe Guilda. Ele deve apenas 
"anunciar" que atacou, e quem estiver interessado que reaja a isso.


---
#### Boss
Quando o Boss encontrar com um 'mago' ele vai alterar seu modo para furioso, mantendo o Hp atual, e alterando seu dano para 60

-> Achei preconceituoso com os maguinhos lixeira...


Na program:
Faça um Loop para manter ambos batalhando até que um seja morto (Logs manuais sáo permitidos);


(Garanta que eu seja simples e fácil adicionar novos aventureiros que possuem comportamentos novos)
