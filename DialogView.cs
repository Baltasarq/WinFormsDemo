// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    using Draw = System.Drawing;
    using WForms = System.Windows.Forms;
    
    public class DialogView: WForms.Form {
        public DialogView()
        {
            this.Build();
        }

        void Build()
        {
            var panel = new WForms.Panel { Dock = WForms.DockStyle.Fill };
            var lblConfirm = new WForms.Label { Dock = WForms.DockStyle.Fill, Text = "Confirm?" };

            panel.Controls.Add( this.BuildButtons() );
            panel.Controls.Add( lblConfirm );
            this.Controls.Add( panel );
        }

        WForms.Panel BuildButtons()
        {
            var btOk = new WForms.Button {
                Text = "Ok",
                DialogResult = WForms.DialogResult.OK,
                Dock = WForms.DockStyle.Right
            };
            
            var btCancel = new WForms.Button {
                Text = "Cancel",
                DialogResult = WForms.DialogResult.Cancel,
                Dock = WForms.DockStyle.Left
            };

            var pnlButtons = new WForms.Panel {
                Dock = WForms.DockStyle.Bottom
            };
            
            pnlButtons.Controls.Add( btOk );
            pnlButtons.Controls.Add( btCancel );
            pnlButtons.MaximumSize = new Draw.Size( int.MaxValue, btOk.Height ); 
            return pnlButtons;
        }
    }
}
