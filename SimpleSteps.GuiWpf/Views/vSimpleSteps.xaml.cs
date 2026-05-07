using SimpleSteps.GuiWpf.ViewModels;
using System.Windows;

namespace SimpleSteps.GuiWpf.Views
{
    /// <summary>
    /// Interaction logic for vSimpleSteps.xaml
    /// </summary>
    public partial class vSimpleSteps : Window
    {
        public vSimpleSteps()
        {
            InitializeComponent();

            this.DataContext = new vmSimpleSteps();


        }
    }
}
