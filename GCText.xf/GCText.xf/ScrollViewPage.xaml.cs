using System.Diagnostics;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GCText.xf
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScrollViewPage : ContentPage
    {
        public ScrollViewPage()
        {
            Debug.WriteLine("ScrollViewPage");
            InitializeComponent();
        }

        ~ScrollViewPage() => Debug.WriteLine("~ScrollViewPage");
    }
}