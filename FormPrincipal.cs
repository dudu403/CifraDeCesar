using System.Text;

namespace CifraDeCesar;

public partial class FormPrincipal : Form
{
    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void botaoSelecionarArquivo_Click(object sender, EventArgs e)
    {
        SelecionarArquivo();
    }

    private void botaoProcessar_Click(object sender, EventArgs e)
    {
        ProcessarArquivo();
    }

    private void botaoLimpar_Click(object sender, EventArgs e)
    {
        LimparCampos();
    }

    private void botaoSair_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void operacao_CheckedChanged(object sender, EventArgs e)
    {
        AtualizarNomeArquivoSaida();
    }

    private void SelecionarArquivo()
    {
        if (dialogoAbrirArquivo.ShowDialog() == DialogResult.OK)
        {
            caixaCaminhoEntrada.Text = dialogoAbrirArquivo.FileName;
            AtualizarNomeArquivoSaida();
            AdicionarLog("Arquivo selecionado: " + dialogoAbrirArquivo.FileName);
        }
    }

    private string CriptografarTexto(string texto, int chave)
    {
        return AplicarCifraDeCesar(texto, chave);
    }

    private string DescriptografarTexto(string texto, int chave)
    {
        return AplicarCifraDeCesar(texto, -chave);
    }

    private string AplicarCifraDeCesar(string texto, int deslocamento)
    {
        StringBuilder resultado = new StringBuilder();
        deslocamento = ((deslocamento % 26) + 26) % 26;

        foreach (char caractere in texto)
        {
            if (caractere >= 'A' && caractere <= 'Z')
            {
                char letra = (char)('A' + (caractere - 'A' + deslocamento) % 26);
                resultado.Append(letra);
            }
            else if (caractere >= 'a' && caractere <= 'z')
            {
                char letra = (char)('a' + (caractere - 'a' + deslocamento) % 26);
                resultado.Append(letra);
            }
            else
            {
                resultado.Append(caractere);
            }
        }

        return resultado.ToString();
    }

    private void ProcessarArquivo()
    {
        string caminhoEntrada = caixaCaminhoEntrada.Text;

        if (string.IsNullOrWhiteSpace(caminhoEntrada) || !File.Exists(caminhoEntrada))
        {
            MessageBox.Show("Selecione um arquivo de texto válido.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            int chave = (int)seletorChave.Value;
            string textoOriginal = File.ReadAllText(caminhoEntrada, Encoding.UTF8);
            string textoProcessado;

            if (radioCriptografar.Checked)
            {
                textoProcessado = CriptografarTexto(textoOriginal, chave);
            }
            else
            {
                textoProcessado = DescriptografarTexto(textoOriginal, chave);
            }

            string caminhoSaida = GerarNomeArquivoSaida(caminhoEntrada);
            File.WriteAllText(caminhoSaida, textoProcessado, new UTF8Encoding(false));
            caixaCaminhoSaida.Text = caminhoSaida;

            string operacao = radioCriptografar.Checked ? "Criptografia" : "Descriptografia";
            AdicionarLog(operacao + " concluída com sucesso.");
            AdicionarLog("Arquivo gerado: " + caminhoSaida);

            MessageBox.Show("Arquivo processado com sucesso!", "Concluído",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception erro)
        {
            AdicionarLog("Erro: " + erro.Message);
            MessageBox.Show("Não foi possível processar o arquivo.\n\n" + erro.Message,
                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private string GerarNomeArquivoSaida(string caminhoEntrada)
    {
        string pasta = Path.GetDirectoryName(caminhoEntrada) ?? "";
        string nomeSemExtensao = Path.GetFileNameWithoutExtension(caminhoEntrada);
        string extensao = Path.GetExtension(caminhoEntrada);
        string sufixo = radioCriptografar.Checked ? "cript" : "descript";

        return Path.Combine(pasta, nomeSemExtensao + sufixo + extensao);
    }

    private void AtualizarNomeArquivoSaida()
    {
        if (!string.IsNullOrWhiteSpace(caixaCaminhoEntrada.Text))
        {
            caixaCaminhoSaida.Text = GerarNomeArquivoSaida(caixaCaminhoEntrada.Text);
        }
    }

    private void AdicionarLog(string mensagem)
    {
        caixaLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + " - " + mensagem
            + Environment.NewLine);
    }

    private void LimparCampos()
    {
        caixaCaminhoEntrada.Clear();
        caixaCaminhoSaida.Clear();
        caixaLog.Clear();
        radioCriptografar.Checked = true;
        seletorChave.Value = 3;
    }

    private void rotuloSubtitulo_Click(object sender, EventArgs e)
    {

    }

    private void grupoLog_Enter(object sender, EventArgs e)
    {

    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {

    }

    private void seletorChave_ValueChanged(object sender, EventArgs e)
    {

    }
}
