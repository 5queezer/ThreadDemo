using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ThreadDemo
{
	public partial class Form1 : Form
	{
		public delegate void DelegateSetTextValue( string strVal );
		public delegate void DelegateSetProgBarValue( int nVal );
		public delegate void DelegateAddListBoxValue( string strVal );
		public delegate void DelegateResetTextValue();
		public delegate void DelegateResetProgBar();
		public delegate void DelegateResetListBox();

		private Thread m_thrWorker = null;
		private Byte m_bytState = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load( object sender, EventArgs e )
		{
			this.pgbState.Minimum = 0;
			this.pgbState.Maximum = 100;
		}

		private void btnStart_Click( object sender, EventArgs e )
		{
			if( this.m_thrWorker != null )
				return;

			this.m_thrWorker = new Thread( new ParameterizedThreadStart( WorkingInBackground ) );
			Thread.VolatileWrite( ref m_bytState, 1 );
			this.m_thrWorker.Start( this );
		}

		private void btnCancel_Click( object sender, EventArgs e )
		{
			this.CloseThread();
		}

		private void btnClose_Click( object sender, EventArgs e )
		{
			this.Close();
		}

		private void Form1_FormClosing( object sender, FormClosingEventArgs e )
		{
			this.CloseThread();
		}

		private void CloseThread()
		{
			if( this.m_thrWorker != null )
			{
				Thread.VolatileWrite( ref m_bytState, 0 );
				int nCount = 0;
				while( this.m_thrWorker.IsAlive == true && nCount++ < 50 )
					Thread.Sleep( 100 );

				if( this.m_thrWorker.IsAlive == true )
					this.m_thrWorker.Abort();
				this.m_thrWorker = null;
			}
		}

		public void WorkingInBackground( object obj )
		{
			Form1 frm = (Form1)obj;
			int nCount = 1;
			while( Thread.VolatileRead( ref m_bytState ) == 1 )
			{
				frm.SetTextValue( "Durchlauf: " + nCount.ToString() );
				frm.SetProgBarValue( nCount );
				frm.AddListBoxValue( nCount.ToString() );

				if( nCount++ == 100 )
				{
					Thread.Sleep( 3000 );
					frm.ResetTextValue();
					frm.ResetProgBar();
					frm.ResetListBox();
					nCount = 1;
				}
				Thread.Sleep( 50 );

			}
		}

		public void SetTextValue( string strVal )
		{
			if( this.txtMessage.InvokeRequired )
				this.txtMessage.Invoke( new DelegateSetTextValue( SetTextValue ), new object[] { strVal } );
			else
				this.txtMessage.Text = strVal;
		}

		public void SetProgBarValue( int nVal )
		{
			if( this.pgbState.InvokeRequired )
				this.pgbState.Invoke( new DelegateSetProgBarValue( SetProgBarValue ), new object[] { nVal } );
			else
				this.pgbState.Value = nVal;
		}

		public void AddListBoxValue( string strVal )
		{
			if( this.lbData.InvokeRequired )
				this.lbData.Invoke( new DelegateAddListBoxValue( AddListBoxValue ), new object[] { strVal } );
			else
				this.lbData.Items.Add( strVal );
		}

		public void ResetTextValue()
		{
			if( this.txtMessage.InvokeRequired )
				this.txtMessage.Invoke( new DelegateResetTextValue( ResetTextValue ) );
			else
				this.txtMessage.Text = "";
		}

		public void ResetProgBar()
		{
			if( this.pgbState.InvokeRequired )
				this.pgbState.Invoke( new DelegateResetProgBar( ResetProgBar ) );
			else
				this.pgbState.Value = 0;
		}

		public void ResetListBox()
		{
			if( this.lbData.InvokeRequired )
				this.lbData.Invoke( new DelegateResetListBox( ResetListBox ) );
			else
				this.lbData.Items.Clear();
		}

	}
}
