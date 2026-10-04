namespace CifraDeCesar;

partial class FormPrincipal
{
    private System.ComponentModel.IContainer componentes = null;
    private Label rotuloIcone;
    private Label rotuloTitulo;
    private Label rotuloSubtitulo;
    private GroupBox grupoEntrada;
    private TextBox caixaCaminhoEntrada;
    private Button botaoSelecionarArquivo;
    private Label rotuloAjudaEntrada;
    private GroupBox grupoOperacao;
    private RadioButton radioCriptografar;
    private RadioButton radioDescriptografar;
    private GroupBox grupoChave;
    private Label rotuloAjudaChave;
    private NumericUpDown seletorChave;
    private GroupBox grupoSaida;
    private TextBox caixaCaminhoSaida;
    private Label rotuloAjudaSaida;
    private GroupBox grupoLog;
    private TextBox caixaLog;
    private Button botaoProcessar;
    private Button botaoLimpar;
    private Button botaoSair;
    private OpenFileDialog dialogoAbrirArquivo;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (componentes != null))
            componentes.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        rotuloIcone = new Label();
        rotuloTitulo = new Label();
        rotuloSubtitulo = new Label();
        grupoEntrada = new GroupBox();
        caixaCaminhoEntrada = new TextBox();
        botaoSelecionarArquivo = new Button();
        rotuloAjudaEntrada = new Label();
        grupoOperacao = new GroupBox();
        radioCriptografar = new RadioButton();
        radioDescriptografar = new RadioButton();
        grupoChave = new GroupBox();
        rotuloAjudaChave = new Label();
        seletorChave = new NumericUpDown();
        grupoSaida = new GroupBox();
        caixaCaminhoSaida = new TextBox();
        rotuloAjudaSaida = new Label();
        grupoLog = new GroupBox();
        caixaLog = new TextBox();
        botaoProcessar = new Button();
        botaoLimpar = new Button();
        botaoSair = new Button();
        dialogoAbrirArquivo = new OpenFileDialog();
        fileSystemWatcher1 = new FileSystemWatcher();
        grupoEntrada.SuspendLayout();
        grupoOperacao.SuspendLayout();
        grupoChave.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)seletorChave).BeginInit();
        grupoSaida.SuspendLayout();
        grupoLog.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
        SuspendLayout();
        // 
        // rotuloIcone
        // 
        rotuloIcone.BackColor = Color.WhiteSmoke;
        rotuloIcone.BorderStyle = BorderStyle.FixedSingle;
        rotuloIcone.Font = new Font("Segoe UI Symbol", 38F);
        rotuloIcone.Location = new Point(42, 20);
        rotuloIcone.Name = "rotuloIcone";
        rotuloIcone.Size = new Size(94, 90);
        rotuloIcone.TabIndex = 0;
        rotuloIcone.Text = "🔒";
        rotuloIcone.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // rotuloTitulo
        // 
        rotuloTitulo.AutoSize = true;
        rotuloTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        rotuloTitulo.Location = new Point(166, 30);
        rotuloTitulo.Name = "rotuloTitulo";
        rotuloTitulo.Size = new Size(372, 25);
        rotuloTitulo.TabIndex = 1;
        rotuloTitulo.Text = "Cifra de César - Criptografia de Arquivos";
        // 
        // rotuloSubtitulo
        // 
        rotuloSubtitulo.AutoSize = true;
        rotuloSubtitulo.Font = new Font("Segoe UI", 10F);
        rotuloSubtitulo.Location = new Point(166, 72);
        rotuloSubtitulo.Name = "rotuloSubtitulo";
        rotuloSubtitulo.Size = new Size(508, 38);
        rotuloSubtitulo.TabIndex = 2;
        rotuloSubtitulo.Text = "Leia um arquivo de texto, criptografe ou descriptografe utilizando a Cifra de César\r\ne gere um arquivo de saída.";
        rotuloSubtitulo.Click += rotuloSubtitulo_Click;
        // 
        // grupoEntrada
        // 
        grupoEntrada.Controls.Add(caixaCaminhoEntrada);
        grupoEntrada.Controls.Add(botaoSelecionarArquivo);
        grupoEntrada.Controls.Add(rotuloAjudaEntrada);
        grupoEntrada.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grupoEntrada.Location = new Point(22, 127);
        grupoEntrada.Name = "grupoEntrada";
        grupoEntrada.Size = new Size(1018, 94);
        grupoEntrada.TabIndex = 3;
        grupoEntrada.TabStop = false;
        grupoEntrada.Text = "1. Selecionar Arquivo de Entrada";
        // 
        // caixaCaminhoEntrada
        // 
        caixaCaminhoEntrada.Font = new Font("Segoe UI", 9F);
        caixaCaminhoEntrada.Location = new Point(16, 25);
        caixaCaminhoEntrada.Name = "caixaCaminhoEntrada";
        caixaCaminhoEntrada.ReadOnly = true;
        caixaCaminhoEntrada.Size = new Size(770, 23);
        caixaCaminhoEntrada.TabIndex = 0;
        // 
        // botaoSelecionarArquivo
        // 
        botaoSelecionarArquivo.Font = new Font("Segoe UI", 9F);
        botaoSelecionarArquivo.Location = new Point(810, 23);
        botaoSelecionarArquivo.Name = "botaoSelecionarArquivo";
        botaoSelecionarArquivo.Size = new Size(187, 29);
        botaoSelecionarArquivo.TabIndex = 1;
        botaoSelecionarArquivo.Text = "📁  Selecionar Arquivo";
        botaoSelecionarArquivo.UseVisualStyleBackColor = true;
        botaoSelecionarArquivo.Click += botaoSelecionarArquivo_Click;
        // 
        // rotuloAjudaEntrada
        // 
        rotuloAjudaEntrada.AutoSize = true;
        rotuloAjudaEntrada.Font = new Font("Segoe UI", 9F);
        rotuloAjudaEntrada.Location = new Point(16, 58);
        rotuloAjudaEntrada.Name = "rotuloAjudaEntrada";
        rotuloAjudaEntrada.Size = new Size(275, 15);
        rotuloAjudaEntrada.TabIndex = 2;
        rotuloAjudaEntrada.Text = "Apenas arquivos de texto (.txt) - Codificação UTF-8";
        // 
        // grupoOperacao
        // 
        grupoOperacao.Controls.Add(radioCriptografar);
        grupoOperacao.Controls.Add(radioDescriptografar);
        grupoOperacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grupoOperacao.Location = new Point(22, 237);
        grupoOperacao.Name = "grupoOperacao";
        grupoOperacao.Size = new Size(505, 94);
        grupoOperacao.TabIndex = 4;
        grupoOperacao.TabStop = false;
        grupoOperacao.Text = "2. Operação";
        // 
        // radioCriptografar
        // 
        radioCriptografar.AutoSize = true;
        radioCriptografar.Checked = true;
        radioCriptografar.Font = new Font("Segoe UI", 9F);
        radioCriptografar.Location = new Point(17, 28);
        radioCriptografar.Name = "radioCriptografar";
        radioCriptografar.Size = new Size(129, 19);
        radioCriptografar.TabIndex = 0;
        radioCriptografar.TabStop = true;
        radioCriptografar.Text = "Criptografar (Cifrar)";
        radioCriptografar.UseVisualStyleBackColor = true;
        radioCriptografar.CheckedChanged += operacao_CheckedChanged;
        // 
        // radioDescriptografar
        // 
        radioDescriptografar.AutoSize = true;
        radioDescriptografar.Font = new Font("Segoe UI", 9F);
        radioDescriptografar.Location = new Point(17, 59);
        radioDescriptografar.Name = "radioDescriptografar";
        radioDescriptografar.Size = new Size(158, 19);
        radioDescriptografar.TabIndex = 1;
        radioDescriptografar.Text = "Descriptografar (Decifrar)";
        radioDescriptografar.UseVisualStyleBackColor = true;
        radioDescriptografar.CheckedChanged += operacao_CheckedChanged;
        // 
        // grupoChave
        // 
        grupoChave.Controls.Add(rotuloAjudaChave);
        grupoChave.Controls.Add(seletorChave);
        grupoChave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grupoChave.Location = new Point(538, 237);
        grupoChave.Name = "grupoChave";
        grupoChave.Size = new Size(502, 94);
        grupoChave.TabIndex = 5;
        grupoChave.TabStop = false;
        grupoChave.Text = "3. Chave de Criptografia (Cifra de César)";
        // 
        // rotuloAjudaChave
        // 
        rotuloAjudaChave.AutoSize = true;
        rotuloAjudaChave.Font = new Font("Segoe UI", 9F);
        rotuloAjudaChave.Location = new Point(16, 25);
        rotuloAjudaChave.Name = "rotuloAjudaChave";
        rotuloAjudaChave.Size = new Size(189, 15);
        rotuloAjudaChave.TabIndex = 0;
        rotuloAjudaChave.Text = "Informe um número inteiro (ex.: 3)";
        // 
        // seletorChave
        // 
        seletorChave.Font = new Font("Segoe UI", 9F);
        seletorChave.Location = new Point(16, 54);
        seletorChave.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        seletorChave.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        seletorChave.Name = "seletorChave";
        seletorChave.Size = new Size(465, 23);
        seletorChave.TabIndex = 1;
        seletorChave.Value = new decimal(new int[] { 3, 0, 0, 0 });
        seletorChave.ValueChanged += seletorChave_ValueChanged;
        // 
        // grupoSaida
        // 
        grupoSaida.Controls.Add(caixaCaminhoSaida);
        grupoSaida.Controls.Add(rotuloAjudaSaida);
        grupoSaida.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grupoSaida.Location = new Point(22, 347);
        grupoSaida.Name = "grupoSaida";
        grupoSaida.Size = new Size(1018, 88);
        grupoSaida.TabIndex = 6;
        grupoSaida.TabStop = false;
        grupoSaida.Text = "4. Arquivo de Saída";
        // 
        // caixaCaminhoSaida
        // 
        caixaCaminhoSaida.Font = new Font("Segoe UI", 9F);
        caixaCaminhoSaida.Location = new Point(16, 24);
        caixaCaminhoSaida.Name = "caixaCaminhoSaida";
        caixaCaminhoSaida.ReadOnly = true;
        caixaCaminhoSaida.Size = new Size(981, 23);
        caixaCaminhoSaida.TabIndex = 0;
        // 
        // rotuloAjudaSaida
        // 
        rotuloAjudaSaida.AutoSize = true;
        rotuloAjudaSaida.Font = new Font("Segoe UI", 9F);
        rotuloAjudaSaida.Location = new Point(16, 57);
        rotuloAjudaSaida.Name = "rotuloAjudaSaida";
        rotuloAjudaSaida.Size = new Size(559, 15);
        rotuloAjudaSaida.TabIndex = 1;
        rotuloAjudaSaida.Text = "Na criptografia, o arquivo terá o mesmo nome da entrada com o sufixo \"cript\"; na volta, usará \"descript\".";
        // 
        // grupoLog
        // 
        grupoLog.Controls.Add(caixaLog);
        grupoLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        grupoLog.Location = new Point(22, 451);
        grupoLog.Name = "grupoLog";
        grupoLog.Size = new Size(1018, 132);
        grupoLog.TabIndex = 7;
        grupoLog.TabStop = false;
        grupoLog.Text = "5. Log / Status";
        grupoLog.Enter += grupoLog_Enter;
        // 
        // caixaLog
        // 
        caixaLog.BackColor = Color.White;
        caixaLog.Font = new Font("Consolas", 9F);
        caixaLog.Location = new Point(12, 23);
        caixaLog.Multiline = true;
        caixaLog.Name = "caixaLog";
        caixaLog.ReadOnly = true;
        caixaLog.ScrollBars = ScrollBars.Vertical;
        caixaLog.Size = new Size(985, 94);
        caixaLog.TabIndex = 0;
        // 
        // botaoProcessar
        // 
        botaoProcessar.Font = new Font("Segoe UI", 9F);
        botaoProcessar.Location = new Point(608, 600);
        botaoProcessar.Name = "botaoProcessar";
        botaoProcessar.Size = new Size(134, 36);
        botaoProcessar.TabIndex = 8;
        botaoProcessar.Text = "⚙  Processar";
        botaoProcessar.UseVisualStyleBackColor = true;
        botaoProcessar.Click += botaoProcessar_Click;
        // 
        // botaoLimpar
        // 
        botaoLimpar.Font = new Font("Segoe UI", 9F);
        botaoLimpar.Location = new Point(754, 600);
        botaoLimpar.Name = "botaoLimpar";
        botaoLimpar.Size = new Size(134, 36);
        botaoLimpar.TabIndex = 9;
        botaoLimpar.Text = "▣  Limpar";
        botaoLimpar.UseVisualStyleBackColor = true;
        botaoLimpar.Click += botaoLimpar_Click;
        // 
        // botaoSair
        // 
        botaoSair.Font = new Font("Segoe UI", 9F);
        botaoSair.Location = new Point(900, 600);
        botaoSair.Name = "botaoSair";
        botaoSair.Size = new Size(140, 36);
        botaoSair.TabIndex = 10;
        botaoSair.Text = "ⓧ  Sair";
        botaoSair.UseVisualStyleBackColor = true;
        botaoSair.Click += botaoSair_Click;
        // 
        // dialogoAbrirArquivo
        // 
        dialogoAbrirArquivo.Filter = "Arquivos de texto (*.txt)|*.txt";
        dialogoAbrirArquivo.Title = "Selecione um arquivo de texto UTF-8";
        // 
        // fileSystemWatcher1
        // 
        fileSystemWatcher1.EnableRaisingEvents = true;
        fileSystemWatcher1.SynchronizingObject = this;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1077, 654);
        Controls.Add(botaoSair);
        Controls.Add(botaoLimpar);
        Controls.Add(botaoProcessar);
        Controls.Add(grupoLog);
        Controls.Add(grupoSaida);
        Controls.Add(grupoChave);
        Controls.Add(grupoOperacao);
        Controls.Add(grupoEntrada);
        Controls.Add(rotuloSubtitulo);
        Controls.Add(rotuloTitulo);
        Controls.Add(rotuloIcone);
        Font = new Font("Segoe UI", 9F);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "🔒 Cifra de César - Criptografia de Arquivos";
        Load += FormPrincipal_Load;
        grupoEntrada.ResumeLayout(false);
        grupoEntrada.PerformLayout();
        grupoOperacao.ResumeLayout(false);
        grupoOperacao.PerformLayout();
        grupoChave.ResumeLayout(false);
        grupoChave.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)seletorChave).EndInit();
        grupoSaida.ResumeLayout(false);
        grupoSaida.PerformLayout();
        grupoLog.ResumeLayout(false);
        grupoLog.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private FileSystemWatcher fileSystemWatcher1;
}
