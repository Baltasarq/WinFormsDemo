// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    using System.Drawing;
    using System.Windows.Forms;
    
    /// <summary>Demoes painting a chart.</summary>
	public class DemoChartView: Form {
        public const int ChartCanvasSize = 512;
    
        /// <summary>
        /// Initializes a new <see cref="T:WinForms.DemoChartView"/>.
        /// </summary>
		public DemoChartView()
		{
			this.Build();
		}

		void Build()
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
