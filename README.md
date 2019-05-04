## Awesome Timeline in Xamarin.Forms

![](Timeline/screenshots/tweet.png)

### Lioncoding article Link

[Awesome Timeline in Xamarin.Forms](https://lioncoding.com/2019/04/08/2019-04-08-ui-concevoir-un-timeline-dans-xamarin-forms/)

### Create your project(I'm using VS2019)

![](Timeline/screenshots/create_project.PNG)



![](Timeline/screenshots/select_type.PNG)



![](Timeline/screenshots/project_location.PNG)

![](Timeline/screenshots/project_model.PNG)

### Add the following NuGet packages to your solution

- [Xamarin.FFImageLoading.Forms 2.4.4.859](https://www.nuget.org/packages/)
- [Xamarin.FFImageLoading.Transformations 2.4.4.859](https://www.nuget.org/packages/)
- [Xamarin.Forms 3.4.0.1009999](https://www.nuget.org/packages/)

### Initialization

##### Android project

- MainActivity.cs

```csharp
protected override void OnCreate(Bundle savedInstanceState)
{
	TabLayoutResource = Resource.Layout.Tabbar;
	ToolbarResource = Resource.Layout.Toolbar;

	base.OnCreate(savedInstanceState);
    // Init FFImageLoading plugin
	CachedImageRenderer.Init(false);
	global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
	LoadApplication(new App());
}
```

##### IOSproject

- AppDelegate.cs

```csharp
public override bool FinishedLaunching(UIApplication app, NSDictionary options)
{
	// Init FFImageLoading plugin
	FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
    
	global::Xamarin.Forms.Forms.Init();
	LoadApplication(new App());
	return base.FinishedLaunching(app, options);
}
```



### UI

```xaml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage
    x:Class="Timeline.Views.TimelineView"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:template="clr-namespace:Timeline.Views.Templates"
    xmlns:viewModel="clr-namespace:Timeline.ViewModels"
    Title="{Binding Title}"
    BackgroundImage="bg.jpg">

    <ContentPage.BindingContext>
        <viewModel:TimelineViewModel />
    </ContentPage.BindingContext>

    <ContentPage.Content>
        <StackLayout>
            <ListView
                CachingStrategy="RecycleElement"
                HasUnevenRows="False"
                ItemsSource="{Binding TimelineEvents}"
                RowHeight="107"
                SelectionMode="None"
                SeparatorColor="Gray"
                SeparatorVisibility="None">
                <ListView.ItemTemplate>
                    <DataTemplate>
                        <ViewCell>
                            <template:TimelineWithImage />
                        </ViewCell>
                    </DataTemplate>
                </ListView.ItemTemplate>
            </ListView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```

### ViewCell Template

```xaml
<?xml version="1.0" encoding="UTF-8" ?>
<ContentView
    x:Class="Timeline.Views.Templates.TimelineWithImage"
    xmlns="http://xamarin.com/schemas/2014/forms"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:ff="clr-namespace:FFImageLoading.Forms;assembly=FFImageLoading.Forms"
    xmlns:ffTransformations="clr-namespace:FFImageLoading.Transformations;assembly=FFImageLoading.Transformations">

    <StackLayout
        Margin="20,0,0,0"
        Orientation="Horizontal"
        VerticalOptions="Center">

        <!--  VERTICAL LINE WITH IMAGE  -->
        <StackLayout
            x:Name="firstStackLayout"
            Margin="0,0,0,-6"
            HorizontalOptions="Center"
            Orientation="Vertical"
            VerticalOptions="Center">
            <!--  FIRST CENTER VERTICAL LINE  -->
            <BoxView
                Grid.Row="0"
                Grid.Column="0"
                Margin="0,0,0,-6"
                HeightRequest="30"
                HorizontalOptions="Center"
                WidthRequest="3"
                Color="Accent" />
            <!--  IMAGE  -->
            <ff:CachedImage
                Grid.Row="1"
                Grid.Column="0"
                Margin="0,0,0,0"
                HeightRequest="55"
                Source="{Binding AuthorImage}"
                WidthRequest="55">
                <ff:CachedImage.Transformations>
                    <ffTransformations:RoundedTransformation
                        BorderHexColor="#FF4081"
                        BorderSize="20"
                        Radius="240" />
                </ff:CachedImage.Transformations>
            </ff:CachedImage>
            <!--  LAST CENTER VERTICAL LINE  -->
            <BoxView
                Grid.Row="2"
                Grid.Column="0"
                Margin="0,-6,0,0"
                HeightRequest="30"
                HorizontalOptions="Center"
                WidthRequest="3"
                Color="Accent" />
        </StackLayout>

        <!--  MESSAGE  -->
        <StackLayout
            Margin="5,0,0,0"
            HorizontalOptions="FillAndExpand"
            Orientation="Horizontal"
            VerticalOptions="Center">
            <StackLayout
                Margin="0,0,5,0"
                HorizontalOptions="Start"
                Orientation="Vertical"
                VerticalOptions="Center">
                <Label
                    FontAttributes="Bold"
                    FontSize="15"
                    HorizontalOptions="Start"
                    Text="{Binding Title}"
                    TextColor="Accent"
                    XAlign="Start" />
                <StackLayout
                    Margin="0,0,5,0"
                    Orientation="Horizontal"
                    VerticalOptions="EndAndExpand">
                    <Label
                        FontSize="14"
                        Text="{Binding Detail}"
                        TextColor="#4e5156" />
                </StackLayout>
                <StackLayout Orientation="Horizontal" VerticalOptions="EndAndExpand">
                    <Label
                        FontAttributes="Bold"
                        FontSize="12"
                        Text="{Binding DateToString}"
                        TextColor="#3b0999" />
                </StackLayout>
            </StackLayout>
        </StackLayout>
    </StackLayout>
</ContentView>
```

