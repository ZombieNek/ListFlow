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

        //переход на сеттингс страницу
        public async void SettingsButtonClick(object sender, EventArgs e)
        {            
            try
            {
                var info = new SettingsPage();
                await Navigation.PushAsync(info);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Извините, произошла ошибка при открытии", ex.Message, "OK");
            }
        }

        //переход на страничку аккаунта
        public async void AccountButtonClick(object sender, EventArgs e)
        {           
            try
            {
                var info = new AccountPage();
                await Navigation.PushAsync(info);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Извините, произошла ошибка при открытии", ex.Message, "OK");
            }
        }

        //кнопка добавления записи
        public async void EnterButtonClick(object sender, EventArgs e)
        {
            try
            {
                var info = new EnterPage();
                await Navigation.PushAsync(info);

            }
            catch (Exception ex)
            {
                await DisplayAlert("Извините, произошла ошибка при открытии", ex.Message, "OK");
            }
        }

    }
}
