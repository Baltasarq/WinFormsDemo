// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    public class DemoChartCtrl {
        public DemoChartCtrl()
        {
            this.View = new DemoChartView();
            
            this.View.Chart.LegendY = "Sells (in thousands)";
            this.View.Chart.LegendX = "Months";
            this.View.Chart.Values = new []{ 10, 20, 30, 40, 25, 21, 11, 2, 28, 33, 18, 45 };
            this.View.Chart.Draw();
        }

        public DemoChartView View {
            get;
        }
    }
}
