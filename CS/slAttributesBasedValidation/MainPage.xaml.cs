using System.Windows.Controls;

namespace slAttributesBasedValidation {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = Stuff.GetStuff();
        }
    }
}
