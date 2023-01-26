<div>
  <img src="https://www.farmarcas.com.br/wp-content/themes/farmarcas/img/logo-fixo.png">
  <img src="https://user-images.githubusercontent.com/90655270/161388302-145d58d6-723a-4dc1-97e7-80133dfa4c3a.png" width="100px">
</div>

<h1> PROJETO RADAR - API </h1>
O projeto consiste em desenvolver uma API REST em AspNet core API C#, para que possamos ter o controle interno sobre as informações de nosso sistema Radar.<br>
<br>- <a href="#Configurar">Configurar</a>
<br>- <a href="#Features">Features</a>
<br>- <a href="#Metodos">Métodos</a>
<br>- <a href="#Endpoints">Endpoints</a>
<br>- <a href="#Modelo">Modelo ER</a>
<br>- <a href="#Tecnologias">Tecnologias utilizadas ER</a>

<hr>
<h3> <a href="https://projetoradar.vercel.app/login">Acesse a página:</a> </h3>

       login: adm@radar.com
       senha: 123456

<hr>
<h3> <a href="https://github.com/Radar-Dotnet/Front-end">Repositório Front-End</a> </h3>
<hr>

<div id="Configurar">
<h2> 🖥️ Como executar: </h2>

#### Conexão Banco de Dados
Adicione sua string de conexão em uma variável de ambiente com o nome "DATABASE_CF_URL" ou no arquivo ***appsettings.json***, na linha 10.

  `Server=127.0.0.1;Database=dbradar;Uid=<USUÁRIO>;Password=<SENHA>;`

### Build do projeto:

      $ dotnet build

### Build do Banco de Dados:

      $ dotnet ef database update


### Comando para desenvolvimento (conexão com o banco local)

      $ dotnet watch run
</div>

<hr>

<h2 id="Features"> 💾Features </h2>

- [x] Gerenciamento de dados das entidades (CRUD);
- [x] Persistência de dados com SQL (MySql);
- [x] Login do usuário e autenticação para uso de rotas(🔓 - JWT);
- [x] Deploy da aplicação e Banco de Dados pelo railway;

<hr>

<div id="Metodos">
<h2> 🔍Métodos: </h2>

Requisições para a API devem seguir os padrões (HTTP):
| Método | Descrição                                     |
|--------|-----------------------------------------------|
| POST   | Cadastrar informações de um registro.         |
| GET    | Retornar informações de um ou mais registros. |
| PUT    | Atualizar informações de um registro.         |
| DELETE | Deletar informações de um registro.           |

</div>
<hr>

<div id="Endpoints">
<h2>🔚Endpoints:</h2>

## <a href="https://dbradar.up.railway.app/swagger/index.html">Documentação das requisições feitas pela API. 📝</a>
![image](https://user-images.githubusercontent.com/95944401/214368113-647578d8-fbc2-435b-ad78-f4c9180fb1a3.png)
</div>
<hr>

<div id="Modelo">
<h2>📄Modelo:</h2>

![image](https://user-images.githubusercontent.com/95944401/214358950-40e998d8-30d6-4904-bcc1-b300906f9e5b.png)
</div>
<hr>
  
   <h2 id="Tecnologias">💻 Tecnologias utilizadas no projeto: <h2>
  <table  align= "center">
   <tr>
   <a  href="https://skillicons.dev">
    <img src="https://skillicons.dev/icons?i=git,github,dotnet,c#,mysql" />    
  </a>
 </tr>
  </table>   

<h2>:computer: Desenvolvedores:</h2>
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/99arielsr">
        <img src="https://avatars.githubusercontent.com/u/95944401?v=4" width="100px;"/><br>
        <sub>
          <b>Ariel Rodrigues</b>
        </sub>
      </a>
    </td>
     <td align="center">
      <a href="https://github.com/DanihBritt0">
        <img src="https://avatars.githubusercontent.com/u/117491473?v=4)" width="100px;"/><br>
        <sub>
          <b>Daniele Britto</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/MotionLeo">
        <img src="https://avatars.githubusercontent.com/u/73909249?v=4" width="100px;"/><br>
        <sub>
          <b>Leonardo Daniel</b>
        </sub>
      </a>
    </td>
     <td align="center">
      <a href="https://github.com/moysesth">
        <img src="https://avatars.githubusercontent.com/u/20120282?v=4" width="100px;"/><br>
        <sub>
          <b>Moyses Thomaz</b>
        </sub>
      </a>
    </td>
     <td align="center">
      <a href="https://github.com/Sungjuno">
        <img src="https://avatars.githubusercontent.com/u/61665463?v=4" width="100px;"/><br>
        <sub>
          <b>Sung Ju</b>
        </sub>
      </a>
    </td>
     <td align="center">
      <a href="https://github.com/Williamalmeida27">
        <img src="https://avatars.githubusercontent.com/u/101687916?v=4" width="100px;"/><br>
        <sub>
          <b>William Almeida</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

<div id="greetings">
<h2> 🤝 Agradecimentos </h2>
<p> Agradecemos à Febrafar/Farmarcas pela oportunidade de participarmos desta bela iniciativa que é o programa de treinamento Código do Futuro, que proporciona a ampliação de conhecimentos e de qualificação na área de desenvolvimento Full Stack - Frontend e Backend (Angular, C#/DotNet). </p>
</div>
