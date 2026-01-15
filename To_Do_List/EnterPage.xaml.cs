namespace To_Do_List;

public partial class EnterPage : ContentPage
{
    private int itemCounter = 1;
    private VerticalStackLayout dynamicPanelsContainer;

    //создание и отображение самой страницы
    public EnterPage()
    {
        InitializeComponent();
        NavigationPage.SetHasNavigationBar(this, false);

        dynamicPanelsContainer = FindByName("DynamicPanelsContainer") as VerticalStackLayout;
    }

    //создание шаблона самой панели которая будет отображаться
    private Frame CreateInputPanel(string placeholder = "")
    {
        Frame panelFrame = new Frame
        {
            BackgroundColor = Colors.Transparent,
            BorderColor = Colors.Transparent,
            CornerRadius = 8,
            Padding = 12,
            HasShadow = false
        };

        HorizontalStackLayout innerLayout = new HorizontalStackLayout
        {
            Spacing = 10,
            VerticalOptions = LayoutOptions.Center
        };

        Entry inputField = new Entry
        {
            Placeholder = placeholder,
            TextColor = Colors.White,
            BackgroundColor = Colors.Transparent,
            PlaceholderColor = Color.FromArgb("#AAAAAA"),
            FontSize = 16,
            HorizontalOptions = LayoutOptions.FillAndExpand
        };

        Button deleteButton = new Button
        {
            Text = "×",
            TextColor = Colors.White,
            BackgroundColor = Colors.Transparent,
            FontSize = 20,
            FontAttributes = FontAttributes.Bold,
            WidthRequest = 20,
            HeightRequest = 20,
            CornerRadius = 10
        };

        deleteButton.Clicked += (s, args) => RemovePanel(panelFrame);

        innerLayout.Children.Add(inputField);
        innerLayout.Children.Add(deleteButton);
        panelFrame.Content = innerLayout;

        return panelFrame;
    }

    // метод удаления по кнопке создаваемой у панели
    private async void RemovePanel(Frame panelToRemove)
    {
        await panelToRemove.FadeTo(0, 200);
        await panelToRemove.TranslateTo(50, 0, 200, Easing.CubicIn);

        if (dynamicPanelsContainer != null)
        {
            dynamicPanelsContainer.Children.Remove(panelToRemove);
        }
    }

    //список продуктов для генерации случайного в списке
    private readonly string[] _productList = new[]
    {
        "Молоко", "Хлеб", "Яйца", "Сыр", "Масло", "Кофе", "Чай",
        "Сахар", "Соль", "Мясо", "Рыба", "Овощи", "Фрукты",
        "Йогурт", "Сок", "Вода", "Печенье", "Шоколад", "Макароны",
        "Рис", "Гречка", "Лук", "Чеснок", "Зелень", "Сметана"
    };


    private Random _random = new Random();

    // метод для получения случайного продукта из списка
    private string GetRandomProduct()
    {
        int index = _random.Next(_productList.Length);
        return _productList[index];
    }

    //Метод нажатия на кнопку добавления
    private void OnAddItemClicked(object sender, EventArgs e)
    {
        if (dynamicPanelsContainer == null)
        {
            DisplayAlert("Ошибка", "Не найден контейнер для панелей", "OK");
            return;
        }

        string randomProduct = GetRandomProduct();
        Frame newPanel = CreateInputPanel(randomProduct);
        dynamicPanelsContainer.Children.Add(newPanel);
        itemCounter++;
    }
}