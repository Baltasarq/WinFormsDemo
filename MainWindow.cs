using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms {
	public class MainWindow: Form {
		public MainWindow()
		{
			this.BuildGui();
		}

		private void OnQuit()
		{
			this.Hide();
			this.Close();
		}

		private void OnViewDefaultPanel()
		{
			new DemoPanel().Show();
		}

		private void OnViewTablePanel()
		{
			new DemoTablePanel().Show();
		}

		private void BuildMenu()
		{
			this.Menu = new MainMenu();

			var mFile = new MenuItem( "&File" );
			var opQuit = new MenuItem( "&Quit" );
			mFile.MenuItems.Add( opQuit );
			opQuit.Shortcut = Shortcut.CtrlQ;
			opQuit.Click += delegate(object o, EventArgs args) {
				this.OnQuit();
			};

			var mView = new MenuItem( "&View" );
			var opDefaultPanel = new MenuItem( "&Default panel" );
			mView.MenuItems.Add( opDefaultPanel );
			opDefaultPanel.Shortcut = Shortcut.CtrlQ;
			opDefaultPanel.Click += delegate(object o, EventArgs args) {
				this.OnViewDefaultPanel();
			};
			var opTablePanel = new MenuItem( "&Table panel" );
			mView.MenuItems.Add( opTablePanel );
			opTablePanel.Shortcut = Shortcut.CtrlQ;
			opTablePanel.Click += delegate(object o, EventArgs args) {
				this.OnViewTablePanel();
			};


			this.Menu.MenuItems.Add( mFile );
			this.Menu.MenuItems.Add( mView );
		}

		private void BuildGui()
		{
			var pnlTable = new TableLayoutPanel();

			pnlTable.SuspendLayout();
			pnlTable.Dock = DockStyle.Fill;

			var btFirst = new Button();
			var btSecond = new Button();

			btFirst.Text = "First";
			btFirst.Dock = DockStyle.Top;
			btSecond.Text = "Second";
			btSecond.Dock = DockStyle.Top;

			btFirst.Click += delegate(object sender, EventArgs e) {
				var w = new DemoPanel();
				w.Show();
			};

			btSecond.Click += delegate(object sender, EventArgs e) {
				var w = new DemoTablePanel();
				w.Show();
			};

			pnlTable.Controls.Add( btFirst );
			pnlTable.Controls.Add( btSecond );

			pnlTable.ResumeLayout( false );
			this.Controls.Add( pnlTable );

			this.MinimumSize = new Size( 320, 240 );
			this.BuildMenu();
		}
	}
}

