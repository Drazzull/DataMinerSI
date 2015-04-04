namespace DataMinerSI
{
    partial class PrincipalFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.pgrProcessamento = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnProcessar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSelecionarArquivo = new DevExpress.XtraEditors.SimpleButton();
            this.txtArquivoSelecionado = new DevExpress.XtraEditors.TextEdit();
            this.mainLayoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pnliArquivoSelecionado = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnliSelecionarArquivo = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnliProcessar = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnliProcessamento = new DevExpress.XtraLayout.LayoutControlItem();
            this.pnlsInferior = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pnlsSuperior = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pnlsDireita = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgrProcessamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivoSelecionado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControlGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliArquivoSelecionado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliSelecionarArquivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliProcessar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliProcessamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsInferior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsSuperior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsDireita)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.pgrProcessamento);
            this.layoutControl.Controls.Add(this.btnProcessar);
            this.layoutControl.Controls.Add(this.btnSelecionarArquivo);
            this.layoutControl.Controls.Add(this.txtArquivoSelecionado);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(381, 222, 250, 350);
            this.layoutControl.Root = this.mainLayoutControlGroup;
            this.layoutControl.Size = new System.Drawing.Size(981, 90);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // pgrProcessamento
            // 
            this.pgrProcessamento.Location = new System.Drawing.Point(8, 38);
            this.pgrProcessamento.Name = "pgrProcessamento";
            this.pgrProcessamento.Size = new System.Drawing.Size(760, 18);
            this.pgrProcessamento.StyleController = this.layoutControl;
            this.pgrProcessamento.TabIndex = 8;
            this.pgrProcessamento.Visible = false;
            // 
            // btnProcessar
            // 
            this.btnProcessar.Location = new System.Drawing.Point(772, 39);
            this.btnProcessar.Name = "btnProcessar";
            this.btnProcessar.Size = new System.Drawing.Size(197, 23);
            this.btnProcessar.StyleController = this.layoutControl;
            this.btnProcessar.TabIndex = 7;
            this.btnProcessar.Text = "Processar";
            this.btnProcessar.Click += new System.EventHandler(this.btnProcessar_Click);
            // 
            // btnSelecionarArquivo
            // 
            this.btnSelecionarArquivo.Location = new System.Drawing.Point(772, 12);
            this.btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            this.btnSelecionarArquivo.Size = new System.Drawing.Size(197, 23);
            this.btnSelecionarArquivo.StyleController = this.layoutControl;
            this.btnSelecionarArquivo.TabIndex = 5;
            this.btnSelecionarArquivo.Text = "Selecionar";
            this.btnSelecionarArquivo.Click += new System.EventHandler(this.btnSelecionarArquivo_Click);
            // 
            // txtArquivoSelecionado
            // 
            this.txtArquivoSelecionado.Location = new System.Drawing.Point(132, 12);
            this.txtArquivoSelecionado.Name = "txtArquivoSelecionado";
            this.txtArquivoSelecionado.Properties.ReadOnly = true;
            this.txtArquivoSelecionado.Size = new System.Drawing.Size(636, 22);
            this.txtArquivoSelecionado.StyleController = this.layoutControl;
            this.txtArquivoSelecionado.TabIndex = 4;
            this.txtArquivoSelecionado.TabStop = false;
            // 
            // mainLayoutControlGroup
            // 
            this.mainLayoutControlGroup.CustomizationFormText = "Root";
            this.mainLayoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.mainLayoutControlGroup.GroupBordersVisible = false;
            this.mainLayoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.pnliArquivoSelecionado,
            this.pnliSelecionarArquivo,
            this.pnliProcessar,
            this.pnliProcessamento,
            this.pnlsInferior,
            this.pnlsSuperior,
            this.pnlsDireita});
            this.mainLayoutControlGroup.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControlGroup.Name = "Root";
            this.mainLayoutControlGroup.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 0, 0, 0);
            this.mainLayoutControlGroup.Size = new System.Drawing.Size(981, 90);
            this.mainLayoutControlGroup.Text = "Root";
            this.mainLayoutControlGroup.TextVisible = false;
            // 
            // pnliArquivoSelecionado
            // 
            this.pnliArquivoSelecionado.Control = this.txtArquivoSelecionado;
            this.pnliArquivoSelecionado.CustomizationFormText = "Arquivo Selecionado";
            this.pnliArquivoSelecionado.Location = new System.Drawing.Point(0, 10);
            this.pnliArquivoSelecionado.Name = "pnliArquivoSelecionado";
            this.pnliArquivoSelecionado.Size = new System.Drawing.Size(764, 26);
            this.pnliArquivoSelecionado.Text = "Arquivo Selecionado:";
            this.pnliArquivoSelecionado.TextSize = new System.Drawing.Size(121, 16);
            // 
            // pnliSelecionarArquivo
            // 
            this.pnliSelecionarArquivo.Control = this.btnSelecionarArquivo;
            this.pnliSelecionarArquivo.CustomizationFormText = "Selecionar Arquivo";
            this.pnliSelecionarArquivo.Location = new System.Drawing.Point(764, 10);
            this.pnliSelecionarArquivo.Name = "pnliSelecionarArquivo";
            this.pnliSelecionarArquivo.Size = new System.Drawing.Size(201, 27);
            this.pnliSelecionarArquivo.Text = "Selecionar Arquivo:";
            this.pnliSelecionarArquivo.TextSize = new System.Drawing.Size(0, 0);
            this.pnliSelecionarArquivo.TextToControlDistance = 0;
            this.pnliSelecionarArquivo.TextVisible = false;
            // 
            // pnliProcessar
            // 
            this.pnliProcessar.Control = this.btnProcessar;
            this.pnliProcessar.CustomizationFormText = "Processar Arquivo";
            this.pnliProcessar.Location = new System.Drawing.Point(764, 37);
            this.pnliProcessar.Name = "pnliProcessar";
            this.pnliProcessar.Size = new System.Drawing.Size(201, 27);
            this.pnliProcessar.Text = "Processar Arquivo:";
            this.pnliProcessar.TextSize = new System.Drawing.Size(0, 0);
            this.pnliProcessar.TextToControlDistance = 0;
            this.pnliProcessar.TextVisible = false;
            // 
            // pnliProcessamento
            // 
            this.pnliProcessamento.Control = this.pgrProcessamento;
            this.pnliProcessamento.CustomizationFormText = "Progresso do Processamento";
            this.pnliProcessamento.Location = new System.Drawing.Point(0, 36);
            this.pnliProcessamento.Name = "pnliProcessamento";
            this.pnliProcessamento.Size = new System.Drawing.Size(764, 28);
            this.pnliProcessamento.Text = " ";
            this.pnliProcessamento.TextSize = new System.Drawing.Size(0, 0);
            this.pnliProcessamento.TextToControlDistance = 0;
            this.pnliProcessamento.TextVisible = false;
            this.pnliProcessamento.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.OnlyInCustomization;
            // 
            // pnlsInferior
            // 
            this.pnlsInferior.AllowHotTrack = false;
            this.pnlsInferior.CustomizationFormText = "Espaço Inferior";
            this.pnlsInferior.Location = new System.Drawing.Point(0, 64);
            this.pnlsInferior.Name = "pnlsInferior";
            this.pnlsInferior.Size = new System.Drawing.Size(965, 26);
            this.pnlsInferior.Text = " ";
            this.pnlsInferior.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pnlsSuperior
            // 
            this.pnlsSuperior.AllowHotTrack = false;
            this.pnlsSuperior.CustomizationFormText = "Espaço Superior";
            this.pnlsSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlsSuperior.Name = "pnlsSuperior";
            this.pnlsSuperior.Size = new System.Drawing.Size(965, 10);
            this.pnlsSuperior.Text = " ";
            this.pnlsSuperior.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pnlsDireita
            // 
            this.pnlsDireita.AllowHotTrack = false;
            this.pnlsDireita.CustomizationFormText = "Espaço Direita";
            this.pnlsDireita.Location = new System.Drawing.Point(965, 0);
            this.pnlsDireita.Name = "pnlsDireita";
            this.pnlsDireita.Size = new System.Drawing.Size(10, 90);
            this.pnlsDireita.Text = "Espaço Direita";
            this.pnlsDireita.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 90);
            this.Controls.Add(this.layoutControl);
            this.LookAndFeel.SkinName = "Black";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "PrincipalFrm";
            this.Text = "Dataminer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PrincipalFrm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pgrProcessamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtArquivoSelecionado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControlGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliArquivoSelecionado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliSelecionarArquivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliProcessar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnliProcessamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsInferior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsSuperior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlsDireita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup mainLayoutControlGroup;
        private DevExpress.XtraEditors.ProgressBarControl pgrProcessamento;
        private DevExpress.XtraEditors.SimpleButton btnProcessar;
        private DevExpress.XtraEditors.SimpleButton btnSelecionarArquivo;
        private DevExpress.XtraEditors.TextEdit txtArquivoSelecionado;
        private DevExpress.XtraLayout.LayoutControlItem pnliArquivoSelecionado;
        private DevExpress.XtraLayout.LayoutControlItem pnliSelecionarArquivo;
        private DevExpress.XtraLayout.LayoutControlItem pnliProcessar;
        private DevExpress.XtraLayout.LayoutControlItem pnliProcessamento;
        private DevExpress.XtraLayout.EmptySpaceItem pnlsInferior;
        private DevExpress.XtraLayout.EmptySpaceItem pnlsSuperior;
        private DevExpress.XtraLayout.EmptySpaceItem pnlsDireita;

    }
}
