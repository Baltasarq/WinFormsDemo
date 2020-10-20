// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    using WForms = System.Windows.Forms;

	public class Ppal {

		[System.STAThread]
		public static void Main()
		{
			var form = new MainWindowCtrl().View;

			try {
				form.Show( );
				WForms.Application.Run( form );
			} catch(System.Exception exc)
			{
				WForms.MessageBox.Show( "Unexpected: " + exc.Message, "Demo",
				                 WForms.MessageBoxButtons.OK,
				                 WForms.MessageBoxIcon.Error );
			}
		}
	}
}
