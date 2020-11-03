// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    using System;

    public class DynamicPanelCtrl {
        public DynamicPanelCtrl()
        {
            this.View = new DynamicPanelView();
            this.View.ChangeTo( DynamicPanelView.FormView.Passenger );
            this.View.CmbSelector.SelectedIndexChanged +=
                        (obj, evt) => this.OnSelectorChanged();
        }

        void OnSelectorChanged()
        {
            int index = Math.Max( 0, this.View.CmbSelector.SelectedIndex );

            this.View.ChangeTo( (DynamicPanelView.FormView) index );
        }

        public DynamicPanelView View {
            get;
        }
    }
}