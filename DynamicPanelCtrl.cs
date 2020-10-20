// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    public class DynamicPanelCtrl {
        public DynamicPanelCtrl()
        {
            this.View = new DynamicPanelView();
        }

        public DynamicPanelView View {
            get;
        }
    }
}