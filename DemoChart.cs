namespace WinForms {
    using System.Drawing;
    using System.Windows.Forms;
    
    /// <summary>Demoes painting a chart.</summary>
	public class DemoChart: Form {
        public const int ChartCanvasSize = 512;
    
        /// <summary>
        /// Initializes a new <see cref="T:WinForms.DemoChart"/>.
        /// </summary>
		public DemoChart()
		{
			this.Build();
            
            this.Chart.LegendY = "Sells (in thousands)";
            this.Chart.LegendX = "Months";
            this.Chart.Values = new []{ 10, 20, 30, 40, 25, 21, 11, 2, 28, 33, 18, 45 };
            this.Chart.Draw();
		}

		private void Build()
		{
            this.Chart = new Chart( width: ChartCanvasSize,
                                    height: ChartCanvasSize)
            {
                Dock = DockStyle.Fill,
            };
            
            this.Controls.Add( this.Chart );
			this.MinimumSize = new Size( ChartCanvasSize, ChartCanvasSize );
            this.Text = this.GetType().Name;
		}
        
        /// <summary>
        /// Gets the <see cref="Chart"/>.
        /// </summary>
        /// <value>The chart.</value>
        public Chart Chart {
            get; private set;
        }
	}
}
