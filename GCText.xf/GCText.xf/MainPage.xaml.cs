using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace GCText.xf
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Debug.WriteLine("MainPage");
            InitializeComponent();

            InitActions();
            BindableLayout.SetItemsSource(buttons, Actions);

            InitActionsMoreComplex();
            BindableLayout.SetItemsSource(buttonsMoreComplex, ActionsMoreComplex);
        }

        ~MainPage() => Debug.WriteLine("~MainPage");

        public ObservableCollection<ButtonAction> Actions { get; private set; }
        public ObservableCollection<ButtonAction> ActionsMoreComplex { get; private set; }

        private void GCCollect(object sender, EventArgs e)
        {
            GC.Collect();
            Debug.WriteLine("GC.Collect()");
        }

        private void InitActions()
        {
            Actions = new ObservableCollection<ButtonAction>
            {
                new ButtonAction
                {
                    Description = "AbsoluteLayout",
                    Command = new Command(() => OpenContainerPage(() => new AbsoluteLayout()))
                },
                new ButtonAction
                {
                    Description = "FlexLayout",
                    Command = new Command(() => OpenContainerPage(() => new FlexLayout()))
                },
                new ButtonAction
                {
                    Description = "Grid",
                    Command = new Command(() => OpenContainerPage(() => new Grid()))
                },
                new ButtonAction
                {
                    Description = "StackLayout",
                    Command = new Command(() => OpenContainerPage(() => new StackLayout()))
                },
                new ButtonAction
                {
                    Description = "BoxView",
                    Command = new Command(() => OpenContainerPage(() => new BoxView()))
                },
                new ButtonAction
                {
                    Description = "Frame",
                    Command = new Command(() => OpenContainerPage(() => new Frame()))
                },
                new ButtonAction
                {
                    Description = "Image",
                    Command = new Command(() => OpenContainerPage(() => new Image()))
                },
                new ButtonAction
                {
                    Description = "Label",
                    Command = new Command(() => OpenContainerPage(() => new Label()))
                },
                new ButtonAction
                {
                    Description = "ScrollView",
                    Command = new Command(() => OpenContainerPage(() => new ScrollView()))
                },
                new ButtonAction
                {
                    Description = "WebView",
                    Command = new Command(() => OpenContainerPage(() => new WebView()))
                },
                new ButtonAction
                {
                    Description = "Ellipse",
                    Command = new Command(() => OpenContainerPage(() => new Ellipse()))
                },
                new ButtonAction
                {
                    Description = "Line",
                    Command = new Command(() => OpenContainerPage(() => new Line()))
                },
                new ButtonAction
                {
                    Description = "Path",
                    Command = new Command(() => OpenContainerPage(() => new Path()))
                },
                new ButtonAction
                {
                    Description = "Polygon",
                    Command = new Command(() => OpenContainerPage(() => new Polygon()))
                },
                new ButtonAction
                {
                    Description = "Polyline",
                    Command = new Command(() => OpenContainerPage(() => new Polyline()))
                },
                new ButtonAction
                {
                    Description = "Rectangle",
                    Command = new Command(() => OpenContainerPage(() => new Xamarin.Forms.Shapes.Rectangle()))
                },
                new ButtonAction
                {
                    Description = "Button",
                    Command = new Command(() => OpenContainerPage(() => new Button()))
                },
                new ButtonAction
                {
                    Description = "ImageButton",
                    Command = new Command(() => OpenContainerPage(() => new ImageButton()))
                },
                new ButtonAction
                {
                    Description = "RadioButton",
                    Command = new Command(() => OpenContainerPage(() => new RadioButton()))
                },
                new ButtonAction
                {
                    Description = "RefreshView",
                    Command = new Command(() => OpenContainerPage(() => new RefreshView()))
                },
                new ButtonAction
                {
                    Description = "SearchBar",
                    Command = new Command(() => OpenContainerPage(() => new SearchBar()))
                },
                new ButtonAction
                {
                    Description = "SwipeView",
                    Command = new Command(() => OpenContainerPage(() => new SwipeView()))
                },
                new ButtonAction
                {
                    Description = "CheckBox",
                    Command = new Command(() => OpenContainerPage(() => new CheckBox()))
                },
                new ButtonAction
                {
                    Description = "DatePicker",
                    Command = new Command(() => OpenContainerPage(() => new DatePicker()))
                },
                new ButtonAction
                {
                    Description = "Slider",
                    Command = new Command(() => OpenContainerPage(() => new Slider()))
                },
                new ButtonAction
                {
                    Description = "Stepper",
                    Command = new Command(() => OpenContainerPage(() => new Stepper()))
                },
                new ButtonAction
                {
                    Description = "Switch",
                    Command = new Command(() => OpenContainerPage(() => new Xamarin.Forms.Switch()))
                },
                new ButtonAction
                {
                    Description = "TimePicker",
                    Command = new Command(() => OpenContainerPage(() => new TimePicker()))
                },
                new ButtonAction
                {
                    Description = "Editor",
                    Command = new Command(() => OpenContainerPage(() => new Editor()))
                },
                new ButtonAction
                {
                    Description = "Entry",
                    Command = new Command(() => OpenContainerPage(() => new Entry()))
                },
                new ButtonAction
                {
                    Description = "ActivityIndicator",
                    Command = new Command(() => OpenContainerPage(() => new ActivityIndicator()))
                },
                new ButtonAction
                {
                    Description = "ProgressBar",
                    Command = new Command(() => OpenContainerPage(() => new ProgressBar()))
                },
                new ButtonAction
                {
                    Description = "CarouselView",
                    Command = new Command(() => OpenContainerPage(() => new CarouselView()))
                },
                new ButtonAction
                {
                    Description = "CollectionView",
                    Command = new Command(() => OpenContainerPage(() => new CollectionView()))
                },
                new ButtonAction
                {
                    Description = "IndicatorView",
                    Command = new Command(() => OpenContainerPage(() => new IndicatorView()))
                },
                new ButtonAction
                {
                    Description = "ListView",
                    Command = new Command(() => OpenContainerPage(() => new ListView()))
                },
                new ButtonAction
                {
                    Description = "Picker",
                    Command = new Command(() => OpenContainerPage(() => new Picker()))
                },
                new ButtonAction
                {
                    Description = "TableView",
                    Command = new Command(() => OpenContainerPage(() => new TableView()))
                },
                new ButtonAction
                {
                    Description = "ContentView",
                    Command = new Command(() => OpenContainerPage(() => new ContentView()))
                },
            };
        }

        private void InitActionsMoreComplex()
        {
            ActionsMoreComplex = new ObservableCollection<ButtonAction>
            {
                new ButtonAction
                {
                    Description = "AbsoluteLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new AbsoluteLayout();
                        layout.Children.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new ButtonAction
                {
                    Description = "Grid",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new Grid();
                        layout.Children.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new ButtonAction
                {
                    Description = "FlexLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new FlexLayout();
                        layout.Children.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new ButtonAction
                {
                    Description = "StackLayout",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var layout = new StackLayout();
                        layout.Children.Add(new Label() { Text = "test" });
                        return layout;
                    }))
                },
                new ButtonAction
                {
                    Description = "Frame",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var frame = new Frame();
                        frame.Content = new Label() { Text = "test" };
                        return frame;
                    }))
                },
                new ButtonAction
                {
                    Description = "Image",
                    Command = new Command(() => OpenContainerPage(() => new Image() { Source = "dotnet_bot.png" }))
                },
                new ButtonAction
                {
                    Description = "Label",
                    Command = new Command(() => OpenContainerPage(() => new Label() { Text = "test" }))
                },
                new ButtonAction
                {
                    Description = "ScrollView",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var view = new ScrollView();
                        view.Content = new Label() { Text = "test" };
                        return view;
                    }))
                },
                new ButtonAction
                {
                    Description = "WebView",
                    Command = new Command(() => OpenContainerPage(() => new WebView() { Source = "https://google.com" }))
                },
                new ButtonAction
                {
                    Description = "Ellipse",
                    Command = new Command(() => OpenContainerPage(() => new Ellipse() { Stroke = Brush.Red, HeightRequest = 200, WidthRequest = 200 }))
                },
                new ButtonAction
                {
                    Description = "Line",
                    Command = new Command(() => OpenContainerPage(() => new Line() { X1 = 0, X2 = 0, Y1 = 200, Y2 = 200, Stroke = Brush.Red, }))
                },
                new ButtonAction
                {
                    Description = "Rectangle",
                    Command = new Command(() => OpenContainerPage(() => new Xamarin.Forms.Shapes.Rectangle() { Stroke = Brush.Red, WidthRequest = 200, HeightRequest = 200 }))
                },
                new ButtonAction
                {
                    Description = "Button",
                    Command = new Command(() => OpenContainerPage(() => new Button() { Text = "test" }))
                },
                new ButtonAction
                {
                    Description = "ImageButton",
                    Command = new Command(() => OpenContainerPage(() => new ImageButton() { Source = "dotnet_bot.png" }))
                },
                new ButtonAction
                {
                    Description = "RefreshView",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var view = new RefreshView();
                        view.Content = new Label() { Text = "test" };
                        return view;
                    }))
                },
                new ButtonAction
                {
                    Description = "CarouselView",
                    Command = new Command(() => OpenContainerPage(() => new CarouselView()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new ButtonAction
                {
                    Description = "CollectionView",
                    Command = new Command(() => OpenContainerPage(() => new CollectionView()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new ButtonAction
                {
                    Description = "IndicatorView",
                    Command = new Command(() => OpenContainerPage(() => new IndicatorView()))
                },
                new ButtonAction
                {
                    Description = "ListView",
                    Command = new Command(() => OpenContainerPage(() => new ListView()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new ButtonAction
                {
                    Description = "Picker",
                    Command = new Command(() => OpenContainerPage(() => new Picker()
                    { ItemsSource = new List<int>() { 1, 2, 3, 4, 5 } }))
                },
                new ButtonAction
                {
                    Description = "ContentView",
                    Command = new Command(() => OpenContainerPage(() =>
                    {
                        var view = new ContentView();
                        view.Content = new Label() { Text = "test" };
                        return view;
                    }))
                },
            };
        }

        private void OpenContainerPage(Func<View> action)
        {
            Application.Current.MainPage.Navigation.PushAsync(new ContainerPage(action()));
        }

        public class ButtonAction
        {
            public ICommand Command { get; set; }
            public string Description { get; set; }
        }
    }
}