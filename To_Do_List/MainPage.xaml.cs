namespace To_Do_List
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        //кнопка перехода на инфо страницу
        public async void InfoButtonClick(object sender, EventArgs e)
        {
            //ловим запуск окна
            try
            {                
                var info = new InfoPage();             
                await Navigation.PushAsync(info);
              
            }
            catch (Exception ex)
            {             
                await DisplayAlert("Извините, произошла ошибка при открытии", ex.Message, "OK");                
            }
        }

    }
}
