# Cifra de César

Programa desenvolvido em **C# com Windows Forms** para criptografar e descriptografar arquivos de texto utilizando a Cifra de César.

O programa permite selecionar um arquivo `.txt`, informar uma chave numérica e escolher entre criptografar ou descriptografar. Os arquivos são lidos e salvos utilizando a codificação UTF-8.

## Como baixar e executar

1. Clique no botão verde **Code**.
2. Clique em **Download ZIP**.
3. Extraia o arquivo ZIP em uma pasta do computador.
4. Abra a pasta extraída.
5. Abra o arquivo `CifraDeCesar.csproj` no Visual Studio.
6. Pressione `F5` ou clique no botão **Iniciar** para executar.

É necessário utilizar o Windows e ter o **Visual Studio 2022** com a opção **Desenvolvimento para desktop com .NET** instalada.

## Como utilizar

1. Clique em **Selecionar Arquivo**.
2. Escolha um arquivo de texto no formato `.txt`.
3. Marque **Criptografar** ou **Descriptografar**.
4. Informe uma chave numérica.
5. Clique em **Processar**.
6. O caminho do arquivo gerado será mostrado no campo **Arquivo de Saída**.

A chave representa quantas posições cada letra será deslocada no alfabeto. Por exemplo, com a chave `3`, a letra `A` se transforma em `D`, a letra `B` em `E` e a letra `C` em `F`.

Exemplo:

```text
Texto original:      Ola Mundo! ABC xyz 123.
Texto criptografado: Rod Pxqgr! DEF abc 123.
```

Para descriptografar, selecione o arquivo criptografado e utilize a mesma chave usada na criptografia.

Ao criptografar `teste.txt`, o programa cria `testecript.txt`. Na descriptografia, o programa adiciona o sufixo `descript`.

Espaços, números, pontuação e caracteres acentuados são preservados. O arquivo original não é alterado.
