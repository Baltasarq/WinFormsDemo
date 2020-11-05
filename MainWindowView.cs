// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
	using Draw = System.Drawing;
	using WForms = System.Windows.Forms;
	
	public class MainWindowView: WForms.Form {
		public MainWindowView()
		{
			this.Build();
		}

		private void BuildMenu()
		{
			this.Menu = new WForms.MainMenu();

			// Quit
			this.OpQuit = new WForms.MenuItem("&Quit")
			{
				Shortcut = WForms.Shortcut.CtrlQ
			};

			// View default panel
			this.OpSimplePanel = new WForms.MenuItem("&Simple panel")
			{
				Shortcut = WForms.Shortcut.CtrlF5
			};

			// View table panel
			this.OpTablePanel = new WForms.MenuItem("&Table panel")
			{
				Shortcut = WForms.Shortcut.CtrlF6
			};

			// View dynamic panel
			this.OpDynamicPanel = new WForms.MenuItem("&Dynamic panel")
			{
				Shortcut = WForms.Shortcut.CtrlF7
			};

			// View dialog
			this.OpDialog = new WForms.MenuItem("&Dialog")
			{
				Shortcut = WForms.Shortcut.CtrlF8
			};

			// View chart demo
			this.OpChartDemo = new WForms.MenuItem("&Chart demo")
			{
				Shortcut = WForms.Shortcut.CtrlF11
			};

			// Main menus
			var mFile = new WForms.MenuItem("&File");
			var mView = new WForms.MenuItem("&View");

			// Add options to menus
			mFile.MenuItems.Add(this.OpQuit);

			mView.MenuItems.AddRange( new[]{
				this.OpSimplePanel,
				this.OpTablePanel,
				this.OpDynamicPanel,
				this.OpChartDemo,
				this.OpDialog
			});

			this.Menu.MenuItems.AddRange( new []{ mFile, mView } );
		}

		private void Build()
		{
			var pnlTable = new WForms.TableLayoutPanel();

			pnlTable.SuspendLayout();
			pnlTable.Dock = WForms.DockStyle.Fill;

            this.BtFirst = new WForms.Button {
                Text = "First",
                Dock = WForms.DockStyle.Top
            };

            this.BtSecond = new WForms.Button {
                Text = "Second",
                Dock = WForms.DockStyle.Top
            };
            
            this.BtThird = new WForms.Button {
                Text = "Third",
                Dock = WForms.DockStyle.Top
            };
            
            this.BtFourth = new WForms.Button {
	            Text = "Fourth",
	            Dock = WForms.DockStyle.Top
            };

            this.BtFith = new WForms.Button {
				Text = "Fifth",
				Dock = WForms.DockStyle.Top
            };
            
			pnlTable.Controls.Add( this.BtFirst );
			pnlTable.Controls.Add( this.BtSecond );
            pnlTable.Controls.Add( this.BtThird );
            pnlTable.Controls.Add( this.BtFourth );
            pnlTable.Controls.Add( this.BtFith );

			pnlTable.ResumeLayout( false );
			this.Controls.Add( pnlTable );

            this.BuildMenu();
			this.MinimumSize = new Draw.Size( 320, 240 );
            this.Text = "WinFormsDemo";
		}

		public WForms.Button BtFirst {
			get; private set;
		}
		
		public WForms.Button BtSecond {
			get; private set;
		}
		
		public WForms.Button BtThird {
			get; private set;
		}
		
		public WForms.Button BtFourth {
			get; private set;
		}
		
		public WForms.Button BtFith {
			get; private set;
		}

		public WForms.MenuItem OpQuit {
			get; private set;
		}
		
		public WForms.MenuItem OpSimplePanel {
			get; private set;
		}
		
		public WForms.MenuItem OpTablePanel {
			get; private set;
		}
		
		public WForms.MenuItem OpChartDemo {
			get; private set;
		}
		
		public WForms.MenuItem OpDynamicPanel {
			get; private set;
		}
		
		public WForms.MenuItem OpDialog {
			get; private set;
		}
	}
}
