namespace WinForms {
    using System;
    using System.Windows.Forms;

	public class Ppal {

		[STAThread]
		public static void Main()
		{
			var form = new MainWindow( );

			try {
				form.Show( );
				Application.Run( form );
			} catch(Exception exc)
			{
				MessageBox.Show( "Unexpected: " + exc.Message, "Demo",
				                 MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}
	}
}
