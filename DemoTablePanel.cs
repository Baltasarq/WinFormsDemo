using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms {
	public class DemoTablePanel: Form {
		public DemoTablePanel()
		{
			this.BuildGui();
		}

		private void BuildGui()
		{
			var pnlTable = new TableLayoutPanel();

			pnlTable.SuspendLayout();
			pnlTable.Dock = DockStyle.Fill;

			var btFirst = new Button();
			var btSecond = new Button();
			var btThird = new Button();
			var btFourth = new Button();
			var btFifth = new Button();

			btFirst.Text = "First";
			btFirst.Dock = DockStyle.Top;
			btSecond.Text = "Second";
			btThird.Text = "Third";
			btFourth.Text = "Fourth";
			btFifth.Text = "Fifth";
			btFifth.Dock = DockStyle.Top;

			pnlTable.Controls.Add( btFirst );
			pnlTable.Controls.Add( btSecond );
			pnlTable.Controls.Add( btThird );
			pnlTable.Controls.Add( btFourth );
			pnlTable.Controls.Add( btFifth );

			pnlTable.ResumeLayout( false );
			this.Controls.Add( pnlTable );

			this.MinimumSize = new Size( 320, 240 );
		}
	}
}

