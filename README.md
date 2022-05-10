# API FanfarraInvest
api-fanfareInvest esta API consulta investimentos. 💵​📈​

1. Deverá ter endpoints abaixo:
	- Listar investimentos todos
	- Obter investimentos renda fixa
	- Obter investimento renda variável
	- Obter investimento fundos
	- Investir renda fixa = POST
	- Investir renda fundos imobiliário = POST
	
2. Aplicação deverá ter o código em inglês
3. Deverá conter os testes de unidade para as regras
	- Usuário não pode resgatar o investimento em menos de 1 mês (TODOS)
	- Usuário não pode investir em algum título que não esteja adequado ao seu perfil
	- Calculo do resgate
		- Se a data vencimento do titulo for maior que 6 meses, então desconta 20% do rendimento
		- Se a data vencimento do titulo for maior que 12 meses, então desconta 10% do rendimento
		- Se a data vencimento do titulo for igual ao vencimento, então desconta 5% do rendimento
	
	- O usuário não deverá investir menos que o valor mínimo de cada título	
		
4. Essa aplicação deverá ser publicada em um container Docker e criado o Dockerfile e disponibilizada no Github
5. A aplicação deverá ser utilizada as seguintes versões e ferramentas:
	- .NET 6
	- Moq Testes de unidade
	- xUnit Ferramenta para testes de unidade
	- Docker


 1. # Mocks
  	- Tesouro Direto: https://run.mocky.io/v3/52ad684e-30a4-4a45-9c88-3b18169c6137
        - Renda Fixa: https://run.mocky.io/v3/31da374a-18c1-4d19-8d94-3507abb54abb
        - Renda Variável: https://run.mocky.io/v3/4fcc8f18-8ab7-4a36-abc1-f466566e9785
        - Fundos: https://run.mocky.io/v3/7ac36199-db5c-4d21-bc8a-74fe91fa43b1

<hr />

# api-fanfareInvest
api-fanfareInvest this APIs investiment consulting. 💵​📈​


1. Should have enpoints below:
	- List all investiments
	- Get investiments Fixed Income
	- Get invetiments Variable Rent
	- Get invetiments Funds
	- Investing Fixed Income is a POST
	- Investing Funds imobiliário is a POST
	- Rescue invetiments
	
2. The application should have english code
3. Should have unit test for rules below
  - The user cannot  rescue the investiment in less than a month for all
	- The user cannot investing bonds that
	- Usuário não pode investir em investimento that does not fit your profile
	- Rescue calc
		- If the date due date the investiment is than more that six month, so descount twent percent (20%) the yours yield
		- If the date due date the investiment is than more that twelve month, so descount ten percent (10%) the yours yield
		- If the date due date the investiment is equal due date all, so descount five percent (5%) the yours yield
	
4. The user cannot investing less that the minium value each investiment   
5. This application should be publish in Docker container and create the Dockerfile, and available here
6. The application should be the tools versions:
	- Framework .NET 6
	- Moq unit tests
	- Framework xUnit  for unit tests
	- Docker


 1. # Mocks
  	- Tesouro Direto: https://run.mocky.io/v3/52ad684e-30a4-4a45-9c88-3b18169c6137
        - Renda Fixa: https://run.mocky.io/v3/31da374a-18c1-4d19-8d94-3507abb54abb
        - Renda Variável: https://run.mocky.io/v3/4fcc8f18-8ab7-4a36-abc1-f466566e9785
        - Fundos: https://run.mocky.io/v3/7ac36199-db5c-4d21-bc8a-74fe91fa43b1
