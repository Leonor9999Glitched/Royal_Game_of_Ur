# Relatório de Linguagens de Programação I

Autoria:
- Leonor Figueiredo nº21902968
- André Cosme nº21802129
- Eduardo Azevedo nº22003276

Link para o git: https://github.com/Leonor9999Glitched/Royal_Game_of_Ur

# Quem fez o que

Leonor Figueiredo - Começou por fazer a Classe das Regras, a Classe da Board, a Classe Do Game. Adicionou elementos à Classe Dice.

André Cosme - Completou a Classe Game, a Classe Board e crior a Classe Menu.

# Descrição da solução

O programa começa na Classe Program. Nessa classe, a Classe Menu será instanciada e o metodo MainMenu() será chamado.

Após isto, o jogador terá a hipotese de escolher o que deseja fazer. Pode sair da aplicação, ver as regras através do metodo ShowRules() que ven da Classe Rules ou, jogar o jogo que irá ser chamado através do metodo Play() que pertence à Classe Game.

Na Classe Game, a Classe Board, a Classe Dices serão fundamentais para dar forma ao jogo. 

Porém, estas classes, excepto a Classe Programa, foram substituidas pelas Classes Controller, GameUI, IViwer - que neste caso, é uma interface - e Player. A intenção era tentar optimizar o programar porém, não correu como era esperado.

# Diagrama UML do projecto
!["Diagrama UML"](https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/2fb39435-99ff-49ad-9246-42032eeea416/dejmf6a-4eafd6da-64aa-424f-ae70-ea446a9a978a.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzJmYjM5NDM1LTk5ZmYtNDlhZC05MjQ2LTQyMDMyZWVlYTQxNlwvZGVqbWY2YS00ZWFmZDZkYS02NGFhLTQyNGYtYWU3MC1lYTQ0NmE5YTk3OGEucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.dho7VeTA-ZbVrRA4yihjG-gcKAjY4p8oAEUgmbDRWW0 "Diagrama UML").

# Referências

As ajudas que tivemos vieram da Internet e das aulas do professor Nuno Fachada.