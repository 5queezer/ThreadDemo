namespace ThreadDemo
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.pgbState = new System.Windows.Forms.ProgressBar();
			this.lbData = new System.Windows.Forms.ListBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point( 12, 12 );
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size( 254, 20 );
			this.txtMessage.TabIndex = 0;
			// 
			// pgbState
			// 
			this.pgbState.Location = new System.Drawing.Point( 12, 38 );
			this.pgbState.Name = "pgbState";
			this.pgbState.Size = new System.Drawing.Size( 254, 23 );
			this.pgbState.TabIndex = 1;
			// 
			// lbData
			// 
			this.lbData.FormattingEnabled = true;
			this.lbData.Location = new System.Drawing.Point( 12, 82 );
			this.lbData.Name = "lbData";
			this.lbData.Size = new System.Drawing.Size( 254, 186 );
			this.lbData.TabIndex = 2;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point( 191, 301 );
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size( 75, 23 );
			this.btnStart.TabIndex = 3;
			this.btnStart.Text = "Starten";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler( this.btnStart_Click );
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point( 12, 301 );
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size( 75, 23 );
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Schließen";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler( this.btnClose_Click );
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point( 110, 301 );
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Abbrechen";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler( this.btnCancel_Click );
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 278, 336 );
			this.Controls.Add( this.btnCancel );
			this.Controls.Add( this.btnClose );
			this.Controls.Add( this.btnStart );
			this.Controls.Add( this.lbData );
			this.Controls.Add( this.pgbState );
			this.Controls.Add( this.txtMessage );
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler( this.Form1_Load );
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.Form1_FormClosing );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.ProgressBar pgbState;
		private System.Windows.Forms.ListBox lbData;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnCancel;
	}
}

