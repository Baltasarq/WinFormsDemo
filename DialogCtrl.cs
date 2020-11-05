// WinFormsDemo (c) Baltasar 2017/20 MIT License <jbgarcia@uvigo.es>


namespace WinFormsDemo {
    public class DialogCtrl {
        public DialogCtrl()
        {
            this.View = new DialogView();
        }

        public DialogView View {
            get;
        }
    }
}
