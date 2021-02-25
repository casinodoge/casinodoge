### OI =) 👋

Seja bem vindos a página do GITHUB do CasinoDoge.org, aqui vamos tentar explicar como o nosso sistema é seguro, justo e leal com os nossos usuários! Então vamos lá =)

### PROVABLY FAIR

O sistema PROVABLY FAIR é utilizado em na maioria dos grandes casinos online em todo o mundo!

O sistema é o seguinte, fazemos um calculo com DUAS HASHS uma é do cliente e uma do servidor.

A HASH(semente) do cliente é sempre aberta e divulgada a todos!

A HASH(semente) do servidor é divulgada, porém ela é protegida em SHA256!

Portanto, se ANTES de você rolar os dados, você anotar as duas sementes, após rolar os dados, iremos abrir para você a HASH(semente) do servidor sem o SHA256!

Apos abrirmos para você, basta você comparar se o SHA256 bate com a semente aberta, isso quer dizer que utilizamos a mesma semente que mostramos para você, parece complicado mais é bem simples!

O algoritimo pode ser visto aqui na ClassDice.cs, aqui no nosso github!

Temos uma explicação bem completa aqui: https://dicesites.com/provably-fair
Também temos uma explicação legal no wikipedia: https://en.wikipedia.org/wiki/Provably_fair_algorithm
