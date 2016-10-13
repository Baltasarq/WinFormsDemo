using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms {
	public class DemoPanel: Form {
		public DemoPanel()
		{
			this.BuildGui();
		}

		private void BuildGui()
		{
			var pnlRegular = new Panel();

			pnlRegular.SuspendLayout();
			pnlRegular.Dock = DockStyle.Fill;

			var btTop = new Button();
			var btBottom = new Button();
			var btLeft = new Button();
			var btRight = new Button();
			var btCenter = new Button();

			btTop.Text = "Top";
			btTop.Dock = DockStyle.Top;

			btBottom.Text = "Bottom";
			btBottom.Dock = DockStyle.Bottom;

			btLeft.Text = "Left";
			btLeft.Dock = DockStyle.Left;

			btRight.Text = "Right";
			btRight.Dock = DockStyle.Right;

			btCenter.Text = "Center";
			btCenter.Dock = DockStyle.Fill;

			pnlRegular.Controls.Add( btTop );
			pnlRegular.Controls.Add( btBottom );
			pnlRegular.Controls.Add( btLeft );
			pnlRegular.Controls.Add( btRight );
			pnlRegular.Controls.Add( btCenter );

			pnlRegular.ResumeLayout( false );
			this.Controls.Add( pnlRegular );

			this.MinimumSize = new Size( 320, 240 );
		}
	}
}

