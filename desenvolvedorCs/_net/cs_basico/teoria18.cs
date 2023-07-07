Modificadores de acesso

Antes de continuarmos, é necessário entender os modificadores de acesso.

Basicamente, o que os modificadores de acesso fazem é dizer ao compilador a forma como um membro de uma classe pode ser acessado externamente quando ela é instanciada. Podemos utilizar os modificadores de acesso em qualquer membro da classe. Já o utilizamos tópico da definição da classe Carro, onde todos os membros da classe foram definidos como públicos (public):

class Carro
{
      public string Cor = "";
      public string Modelo = "";
      public string Motor = "";
      public string Status = "";

      public void Ligar()
      {
            Status = "Ligando o carro.";
      }

      public void Desligar()
      {
            Status = "Desligando o carro.";
      }

      public void Acelerar()
      {
            Status = "Acelerando o carro.";
      }

      public void Brecar()
      {
            Status = "Brecando o carro.";
      }

      public void MudarMarcha()
      {
            Status = "Mudando de Marcha.";
      }
}



Mas não existe apenas esse modificador! Veja na tabela a seguir os modificadores possíveis e seus significados:

Modificador
	

Tipo de acesso

public
	

Membro visível externamente à classe, assim como das suas classes derivadas via herança

protected
	

Somente os membros da classe, bem como suas classes derivadas via herança, têm acesso ao membro

internal
	

Acesso limitado ao assembly (DLL) que contém a classe

Protected internal
	

Acesso limitado ao assembly (DLL) que contém a classe ou aos tipos derivados da classe

private
	

Acesso limitado aos membros da classe, não sendo acessível por classes externas e nem pelas classes derivadas via herança
Dica

Por hora, entenda como assembly o seu próprio projeto. Na verdade, um assembly é um artefato (geralmente uma DLL) gerada ao final do processo de compilação do nosso projeto. Um projeto pode se ligar a vários outros assemblies.

Quando o modificador de acesso não é especificado, o compilador assume o modificador default “private” para propriedades e variáveis. Para classes, o valor default assumido é “internal”.


Exemplo:

class PrimeiraClasse
{
      public int idade;
      // O modificador default private é assumido neste caso
      string nome;
}
Na propriedade idade foi utilizado o modificador public; já na propriedade nome não foi utilizado nenhum modificador, então o compilador interpretará como private. Ao longo dos exemplos entenderemos melhor os modificadores. 