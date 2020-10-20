// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>Demoes the use of a table panel.</summary>
	public class TablePanelView: Form {
		public TablePanelView()
		{
			this.Build();
		}

		private void Build()
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

            this.Text = this.GetType().Name;
			this.MinimumSize = new Size( 320, 240 );
		}
	}
}

