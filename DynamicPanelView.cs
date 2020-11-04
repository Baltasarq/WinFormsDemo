// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


using System;

namespace WinFormsDemo {
    using WForms = System.Windows.Forms;
    
    
    public class DynamicPanelView: WForms.Form {
        public enum FormView {
            Passenger,
            Good
        }
        
        public DynamicPanelView()
        {
            this.Build();
        }

        public void ChangeTo(FormView view)
        {
            var panels = new WForms.Panel[] { this.pnlPassenger, this.pnlGood };
            WForms.Panel panel = panels[ (int) view ];

            Array.ForEach( panels, (p) => p.Hide()  );
            panel.Show();
        }

        void Build()
        {
            var mainPanel = this.BuildMainPanel();
            
            this.pnlGood = this.BuildPanelGood();
            this.pnlPassenger = this.BuildPanelPassenger();
            
            this.pnlContainer.Controls.Add( this.pnlPassenger );
            this.pnlContainer.Controls.Add( this.pnlGood );
            
            this.Controls.Add( mainPanel );
        }

        WForms.Control BuildMainPanel()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Fill  
            };
            
            this.CmbSelector = new WForms.ComboBox {
                Dock = WForms.DockStyle.Top,
                DropDownStyle = WForms.ComboBoxStyle.DropDownList
            };
            
            this.CmbSelector.Items.AddRange(
                Array.ConvertAll(
                    (FormView[]) Enum.GetValues( typeof( FormView ) ),
                    (x) => x.ToString() )
            );

            this.CmbSelector.SelectedIndex = 0;

            this.pnlContainer = new WForms.Panel { Dock = WForms.DockStyle.Fill };
            toret.Controls.Add( this.pnlContainer );
            toret.Controls.Add( this.CmbSelector );
            return toret;
        }

        WForms.Panel BuildPanelPassenger()
        {
            var toret = new WForms.TableLayoutPanel {
                Dock = WForms.DockStyle.Fill,
                Visible = false
            };

            var lblName = new WForms.Label {
                Dock = WForms.DockStyle.Left,
                Text = "Name"
            };

            this.EdName = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill
            };
            
            var lblAge = new WForms.Label {
                Dock = WForms.DockStyle.Left,
                Text = "Age"
            };
            
            this.EdAge = new WForms.NumericUpDown {
                Dock = WForms.DockStyle.Fill
            };

            var pnlName = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };

            pnlName.Controls.Add( this.EdName );
            pnlName.Controls.Add( lblName );
            
            var pnlAge = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            
            pnlAge.Controls.Add( this.EdAge );
            pnlAge.Controls.Add( lblAge );

            toret.Controls.Add( pnlName );
            toret.Controls.Add( pnlAge );
            return toret;
        }
        
        WForms.Panel BuildPanelGood()
        {
            var toret = new WForms.TableLayoutPanel() {
                Dock = WForms.DockStyle.Fill,
                Visible = false
            };

            var lblVolume = new WForms.Label {
                Dock = WForms.DockStyle.Left,
                Text = "Volume"
            };

            this.EdVolume = new WForms.NumericUpDown {
                Dock = WForms.DockStyle.Fill
            };
            
            var lblWeight = new WForms.Label {
                Dock = WForms.DockStyle.Left,
                Text = "Weight"
            };
            
            this.EdWeight = new WForms.NumericUpDown {
                Dock = WForms.DockStyle.Fill
            };

            var pnlVolume = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            pnlVolume.Controls.Add( this.EdVolume );
            pnlVolume.Controls.Add( lblVolume );

            var pnlWeight = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            
            pnlWeight.Controls.Add( this.EdWeight );
            pnlWeight.Controls.Add( lblWeight );
            
            toret.Controls.Add( pnlVolume );
            toret.Controls.Add( pnlWeight );
            return toret;
        }

        public WForms.TextBox EdName {
            get; private set;
        }
        
        public WForms.NumericUpDown EdAge {
            get; private set;
        }
        
        public WForms.NumericUpDown EdVolume {
            get; private set;
        }
        
        public WForms.NumericUpDown EdWeight {
            get; private set;
        }

        public WForms.ComboBox CmbSelector {
            get; private set;
        }

        WForms.Panel pnlPassenger;
        WForms.Panel pnlGood;
        WForms.Panel pnlContainer;
    }
}
