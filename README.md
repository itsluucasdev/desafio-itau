# Desafio-Itau

## Visão Geral

Esse repositório tem como objetivo apresentar a proposta de solução para o desafio **[Itaú](www.itau.com.br)**: Cotação de moeda estrangeiras com taxas por segmento de cliente. 

A proposta de solução foi desenhada utilizando as tecnologias **[Angular](https://angular.io/)**, **[.NetCore 3.1](https://dotnet.microsoft.com/download/dotnet/3.1)**, e infraestrutura **[AWS](https://aws.amazon.com/)**.

- A arquitetura prevista será essa:

![Arquitetura AWS-CloudFormation](https://github.com/itsluucasdev/desafio-itau/blob/main/Desenho/desenho-arquitetura.png)

- Desenho de funcionamento da API backend

![Desenho API Backend](https://github.com/itsluucasdev/desafio-itau/blob/main/Desenho/desenho-backend.png)

- Desenho Tela Frontend

![Desenho Tela Frontend](https://github.com/itsluucasdev/desafio-itau/blob/main/Desenho/desenho-frontend.png)

**Links para Documentação**
- [AWS CloudFormation](https://docs.aws.amazon.com/cloudformation/index.html)
- [AWS Fargate](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/AWS_Fargate.html)
- [IAM (Identity Access Management)](https://docs.aws.amazon.com/pt_br/IAM/latest/UserGuide/id_roles.html)
- [Docker](https://docs.docker.com/)

O serviço backend de cotação de compra moeda estrangeira por segmento expõem uma API com as seguintes chamadas:

## Cotação Moeda Estrangeira
* URL

apidesafioitau.com.br/cotacao

* MÉTODOS

`GET` | `POST` | `PUT`

* PARAMÊTROS DE URL

    **REQUIRED**
    
    `MoedaEstrangeira=[string]`

    `QtdeValorEstrangeiro=[decimal]`

    `TaxaId=[integer]`

* **Data Params**
    
    Example JSon: 

        {
            "MoedaEstrangeira":"USD",
            "QteValorEstrangeiro":"500"
            "TaxaId"="2"
        }
  
* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `{ ValorEmReais : 2652.25 }`

* **Error Response:**

    * **Code:** 422 UNPROCESSABLE ENTRY <br />
    **Content:** `{ error : "Quantidade Estrangeira Inválida" }`
  
  OR

  * **Code:** 422 UNPROCESSABLE ENTRY <br />
    **Content:** `{ error : "Moeda Estrangeira Inválida" }`
    
* **Sample Call:**

        apidesafioitau.com.br/cotacao?authorization_key=?

## Bibliografia

**[ASP.NET Core Web API CRUD with Angular 11
](https://www.youtube.com/watch?v=S5dzfuh3t8U)**

**[Docker Tutorial for Beginners [FULL COURSE in 3 Hours]
](https://www.youtube.com/watch?v=3c-iBn73dDE)**

## Dica de Leitura 

**[Arquitetura limpa: O guia do artesão para estrutura e design de software](https://www.amazon.com.br/dp/8550804606/ref=cm_sw_r_tw_dp_Y2RZNMRZGF9ZS3GMPP4A)**