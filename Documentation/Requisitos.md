# Requisitos Funcionais e Não Funcionais

---

### Histórico de Revisões

| Versão | Data | Autor | Descrição |
|---------|---------|---------|---------|
| 1.0 | 11/06/26 | Pedro Henrique | Criação do documento |
| 1.1 | 01/07/26 | Pedro Henrique | Inclusão de novos requisitos funcionais e não funcionais |

---

### 1. Introdução

O presente documento tem como objetivo listar e registrar todos os requisitos funcionais e não funcionais necessários para o pleno funcionamento do projeto, assim como garantir que todos sejam implementados durante a fase de desenvolvimento.

### 2. Requisitos
Neste tópico estão todos os requisitos funcionais e não funcionais propostos para o projeto. Os requisitos estão descritos seguindo o padrão: nome, descrição e nível de prioridade, sendo aceito apenas os níveis **essencial**, **importante** e **desejável**. Além disso, a ordem dos requisitos segue a data da inclusão no documento.

### 2.1 Requisitos Funcionais
Os requisitos funcionais descrevem as funcionalidades e os serviços que o sistema deve oferecer aos seus usuários. Eles definem os comportamentos esperados da aplicação, especificando as ações que poderão ser realizadas, as informações que poderão ser manipuladas e as respostas que o sistema deverá fornecer em diferentes situações. Os requisitos funcionais apresentados a seguir representam as principais funcionalidades necessárias para atender aos objetivos do projeto.

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF01]</th>
        <th style="width: 600px;">Criação de formulários</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que os usuários cadastrados criem formulários personalizados que atendam às suas necessidades.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
    
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF02]</th>
        <th style="width: 600px;">Criação de perguntas</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que os usuários criem perguntas personalizadas em seus formulários.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF03]</th>
        <th style="width: 600px;">Criação de alternativas</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que os usuários criem alternativas personalizadas para as perguntas dos seus formulários do tipo seleção.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF04]</th>
        <th style="width: 600px;">Envio das respostas</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que os usuários enviem respostas aos formulários preenchidos. O criador do formulário poderá configurar a quantidade máxima de respostas permitidas por usuário.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF05]</th>
        <th style="width: 600px;">Cadastro de usuários</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que novos usuários sejam criados de forma independente, sem necessidade de contato prévio com administradores.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF06]</th>
        <th style="width: 600px;">Visualização dos formulários</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que os usuários visualizem uma lista contendo todos os formulários criados por eles.        
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF07]</th>
        <th style="width: 600px;">Edição de formulários</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve permitir que os usuários realizem modificações em seus formulários. A realização das alterações deverá ser possível em todos os componentes do formulário, incluindo título, descrição, perguntas e alternativas.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF08]</th>
        <th style="width: 600px;">Área de preenchimento</th>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Descrição
        </td>
        <td style="overflow-wrap: break-word;">
            O sistema deve possuir uma página alternativa para o preenchimento dos formulários. Nesta página não será possível realizar alterações no formulário, sendo apenas destinada ao preenchimento do mesmo.
        </td>
    </tr>
    <tr>
        <td style="overflow-wrap: break-word;">
            Prioridade
        </td>
        <td style="overflow-wrap: break-word;">
            Essencial
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF09]</th>
        <th style="width: 600px;">Exclusão de formulários</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que os usuários removam formulários criados por eles.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Essencial</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF10]</th>
        <th style="width: 600px;">Visualização de respostas</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que os criadores dos formulários visualizem todas as respostas recebidas.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Essencial</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF11]</th>
        <th style="width: 600px;">Encerramento de formulários</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que o criador do formulário encerre o recebimento de respostas a qualquer momento.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Importante</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF12]</th>
        <th style="width: 600px;">Tipos de perguntas</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir a criação de diferentes tipos de perguntas, como resposta curta, texto longo, múltipla escolha e caixa de seleção.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Importante</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF13]</th>
        <th style="width: 600px;">Perguntas obrigatórias</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que o criador do formulário defina perguntas como obrigatórias para o envio das respostas.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Importante</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF14]</th>
        <th style="width: 600px;">Compartilhamento de formulários</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve gerar um link único para compartilhamento dos formulários criados.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Essencial</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF15]</th>
        <th style="width: 600px;">Exclusão de perguntas</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que os usuários removam perguntas existentes de seus formulários.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Importante</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF16]</th>
        <th style="width: 600px;">Exclusão de alternativas</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que os usuários removam alternativas existentes das perguntas de seus formulários.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Importante</td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RF17]</th>
        <th style="width: 600px;">Autenticação de usuários</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permitir que usuários cadastrados realizem login para acessar suas funcionalidades.
        </td>
    </tr>
    <tr>
        <td>Prioridade</td>
        <td>Essencial</td>
    </tr>
</table>

### 2.2 Requisitos Não Funcionais
Os requisitos não funcionais definem as características de qualidade e as restrições que devem ser atendidas pelo sistema durante sua operação. Diferentemente dos requisitos funcionais, eles não descrevem funcionalidades específicas, mas estabelecem critérios relacionados a desempenho, segurança, disponibilidade, usabilidade, compatibilidade e outros aspectos que influenciam a qualidade da solução. Os requisitos não funcionais apresentados a seguir têm como objetivo garantir que o sistema ofereça uma experiência adequada aos usuários e atenda aos padrões mínimos de qualidade esperados para o projeto.

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RNF01]</th>
        <th style="width: 600px;">Disponibilidade</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve permanecer disponível continuamente, exceto durante períodos programados de manutenção.
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RNF02]</th>
        <th style="width: 600px;">Desempenho</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O tempo médio de resposta das operações do sistema não deve ultrapassar três segundos em condições normais de utilização.
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RNF03]</th>
        <th style="width: 600px;">Segurança das credenciais</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            As senhas dos usuários devem ser armazenadas utilizando algoritmos de hash seguros.
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RNF04]</th>
        <th style="width: 600px;">Compatibilidade</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            O sistema deve funcionar corretamente nos navegadores Google Chrome, Microsoft Edge e Mozilla Firefox em suas versões mais recentes.
        </td>
    </tr>
</table>

---

<table style="width: 800px; table-layout: fixed;">
    <tr>
        <th style="width: 100px;">[RNF05]</th>
        <th style="width: 600px;">Responsividade</th>
    </tr>
    <tr>
        <td>Descrição</td>
        <td>
            A interface do sistema deve adaptar-se adequadamente a diferentes tamanhos de tela, incluindo computadores, tablets e smartphones.
        </td>
    </tr>
</table>