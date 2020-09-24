namespace ChatClient.App
{
    partial class frmChat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChat));
            this.txtChat = new System.Windows.Forms.TextBox();
            this.statusMsg = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnviarMsgAll = new System.Windows.Forms.Button();
            this.btnEnviarMsg = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNovaSala = new System.Windows.Forms.TextBox();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listSalas = new System.Windows.Forms.ListBox();
            this.listPessoas = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            resources.ApplyResources(this.txtChat, "txtChat");
            this.txtChat.Name = "txtChat";
            // 
            // statusMsg
            // 
            this.statusMsg.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.statusMsg, "statusMsg");
            this.statusMsg.Name = "statusMsg";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApelido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEntrar);
            this.groupBox1.Controls.Add(this.txtPorta);
            this.groupBox1.Controls.Add(this.txtIP);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtApelido
            // 
            resources.ApplyResources(this.txtApelido, "txtApelido");
            this.txtApelido.Name = "txtApelido";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnEntrar
            // 
            resources.ApplyResources(this.btnEntrar, "btnEntrar");
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPorta
            // 
            resources.ApplyResources(this.txtPorta, "txtPorta");
            this.txtPorta.Name = "txtPorta";
            // 
            // txtIP
            // 
            resources.ApplyResources(this.txtIP, "txtIP");
            this.txtIP.Name = "txtIP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnviarMsgAll);
            this.groupBox2.Controls.Add(this.btnEnviarMsg);
            this.groupBox2.Controls.Add(this.txtMensagem);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnEnviarMsgAll
            // 
            resources.ApplyResources(this.btnEnviarMsgAll, "btnEnviarMsgAll");
            this.btnEnviarMsgAll.Name = "btnEnviarMsgAll";
            this.btnEnviarMsgAll.UseVisualStyleBackColor = true;
            this.btnEnviarMsgAll.Click += new System.EventHandler(this.btnEnviarMsgAll_Click);
            // 
            // btnEnviarMsg
            // 
            resources.ApplyResources(this.btnEnviarMsg, "btnEnviarMsg");
            this.btnEnviarMsg.Name = "btnEnviarMsg";
            this.btnEnviarMsg.UseVisualStyleBackColor = true;
            this.btnEnviarMsg.Click += new System.EventHandler(this.btnEnviarMsg_Click);
            // 
            // txtMensagem
            // 
            resources.ApplyResources(this.txtMensagem, "txtMensagem");
            this.txtMensagem.Name = "txtMensagem";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNovaSala);
            this.groupBox3.Controls.Add(this.btnCriarSala);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtNovaSala
            // 
            resources.ApplyResources(this.txtNovaSala, "txtNovaSala");
            this.txtNovaSala.Name = "txtNovaSala";
            // 
            // btnCriarSala
            // 
            resources.ApplyResources(this.btnCriarSala, "btnCriarSala");
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listSalas);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // listSalas
            // 
            this.listSalas.FormattingEnabled = true;
            resources.ApplyResources(this.listSalas, "listSalas");
            this.listSalas.Items.AddRange(new object[] {
            resources.GetString("listSalas.Items"),
            resources.GetString("listSalas.Items1"),
            resources.GetString("listSalas.Items2"),
            resources.GetString("listSalas.Items3")});
            this.listSalas.Name = "listSalas";
            // 
            // listPessoas
            // 
            this.listPessoas.FormattingEnabled = true;
            resources.ApplyResources(this.listPessoas, "listPessoas");
            this.listPessoas.Items.AddRange(new object[] {
            resources.GetString("listPessoas.Items"),
            resources.GetString("listPessoas.Items1"),
            resources.GetString("listPessoas.Items2"),
            resources.GetString("listPessoas.Items3"),
            resources.GetString("listPessoas.Items4"),
            resources.GetString("listPessoas.Items5"),
            resources.GetString("listPessoas.Items6")});
            this.listPessoas.Name = "listPessoas";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listPessoas);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // frmChat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusMsg);
            this.Controls.Add(this.txtChat);
            this.Name = "frmChat";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.StatusStrip statusMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnviarMsgAll;
        private System.Windows.Forms.Button btnEnviarMsg;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNovaSala;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listSalas;
        private System.Windows.Forms.ListBox listPessoas;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

