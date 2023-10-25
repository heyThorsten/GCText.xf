using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GCText.xf
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContainerPage : ContentPage
    {
        public ContainerPage(View view)
        {
            InitializeComponent();
            Content = view;
            Title = view.GetType().Name;
            Debug.WriteLine($"{Title} Page");
        }

        ~ContainerPage() => Debug.WriteLine($"~{Title} Page");
    }
}