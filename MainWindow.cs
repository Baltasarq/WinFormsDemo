using System;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms {
	public class MainWindow: Form {
		public MainWindow()
		{
			this.Build();
		}

		private void OnQuit()
		{
			this.Hide();
			this.Close();
		}
        
        private void ViewDemoPanel()
        {
            new DemoSimplePanel().Show();
        }
        
        private void ViewTablePanel()
        {
            new DemoTablePanel().Show();
        }
        
        private void ViewDemoChart()
        {
            new DemoChart().Show();
        }

		private void BuildMenu()
		{
			this.Menu = new MainMenu();
            
            // Quit
            var opQuit = new MenuItem("&Quit") {
                Shortcut = Shortcut.CtrlQ
            };
            
            opQuit.Click += (sender, args) => {
				this.OnQuit();
			};

            // View default panel
            var opSimplePanel = new MenuItem("&Simple panel") {
                Shortcut = Shortcut.CtrlF5
            };
            
            opSimplePanel.Click += (sender, args) => this.ViewDemoPanel();

            // View table panel
            var opTablePanel = new MenuItem("&Table panel") {
                Shortcut = Shortcut.CtrlF6
            };
            
            opTablePanel.Click += (sender, args) => this.ViewTablePanel();
            
            // View chart demo
            var opChartDemo = new MenuItem("&Chart demo") {
                Shortcut = Shortcut.CtrlF11
            };
            
            opChartDemo.Click += (sender, args) => this.ViewDemoChart();

            // Main menus
            var mFile = new MenuItem( "&File" );
            var mView = new MenuItem( "&View" );

            // Add options to menus
            mFile.MenuItems.Add( opQuit );

            mView.MenuItems.Add( opSimplePanel );
            mView.MenuItems.Add( opTablePanel );
            mView.MenuItems.Add( opChartDemo );
            
			this.Menu.MenuItems.Add( mFile );
			this.Menu.MenuItems.Add( mView );
		}

		private void Build()
		{
			var pnlTable = new TableLayoutPanel();

			pnlTable.SuspendLayout();
			pnlTable.Dock = DockStyle.Fill;

            var btFirst = new Button {
                Text = "First",
                Dock = DockStyle.Top
            };

            var btSecond = new Button {
                Text = "Second",
                Dock = DockStyle.Top
            };
            
            var btThird = new Button {
                Text = "Third",
                Dock = DockStyle.Top
            };

			btFirst.Click += (sender, args) => ViewDemoPanel();
            btSecond.Click += (sender, args) => ViewTablePanel();
			btThird.Click += (sender, args) => ViewDemoChart();

			pnlTable.Controls.Add( btFirst );
			pnlTable.Controls.Add( btSecond );
            pnlTable.Controls.Add( btThird );

			pnlTable.ResumeLayout( false );
			this.Controls.Add( pnlTable );

            this.BuildMenu();
			this.MinimumSize = new Size( 320, 240 );
            this.Text = "WinFormsDemo";
		}
	}
}
