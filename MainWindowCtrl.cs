// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    public class MainWindowCtrl {
        public MainWindowCtrl()
        {
            this.View = new MainWindowView();
            
            this.View.OpQuit.Click += (o, args) => this.OnQuit();
            this.View.OpSimplePanel.Click += (o, args) => this.ViewSimplePanel();
            this.View.OpChartDemo.Click += (o, args) => this.ViewDemoChart();
            this.View.OpTablePanel.Click += (o, args) => this.ViewTablePanel();
            this.View.OpDynamicPanel.Click += (o, args) => this.ViewDynamicPanel();
            this.View.BtFirst.Click += (o, args) => this.ViewSimplePanel();
            this.View.BtSecond.Click += (o, args) => this.ViewTablePanel();
            this.View.BtThird.Click += (o, args) => this.ViewDynamicPanel();
            this.View.BtFourth.Click += (o, args) => this.ViewDemoChart();
        }
        
        void OnQuit()
        {
            this.View.Hide();
            this.View.Close();
        }
        
        void ViewSimplePanel()
        {
            new SimplePanelView().Show();
        }
        
        void ViewTablePanel()
        {
            new TablePanelView().Show();
        }
        
        void ViewDemoChart()
        {
            new DemoChartCtrl().View.Show();
        }

        void ViewDynamicPanel()
        {
            new DynamicPanelCtrl().View.Show();
        }

        public MainWindowView View {
            get;
        }
    }
}
