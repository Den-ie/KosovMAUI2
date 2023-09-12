namespace KosovMAUI2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Quest1(object sender, EventArgs e)
    {
        if (!Int32.TryParse(pointA.Text, out int A) | !Int32.TryParse(pointB.Text, out int B) | !Int32.TryParse(pointC.Text, out int C))
        {
            DisplayAlert("Ошибка", "Введите числовые значения точек", "Продолжить");
        }
        else
        {
            if (A < 0 || B < 0 || C < 0) DisplayAlert("Ошибка", "Введите положительные значения точек", "Продолжить");
            else
            {
                if (!(A < B & B < C)) DisplayAlert("Ошибка", "Введите значения точек по возрастанию", "Продолжить");
                else
                {
                    int ac = C - A, bc = C - B;
                    AC.Text = Convert.ToString(ac);
                    BC.Text = Convert.ToString(bc);
                    Summ.Text = Convert.ToString(ac + bc);
                }
            }
        }
    }

    private void Quest2(object sender, EventArgs e)
    {
        if (!int.TryParse(Seconds.Text, out int sec)) DisplayAlert("Ошибка", "Введите корректное значение секунд", "Продолжить");
        else if (sec < 0) DisplayAlert("Ошибка", "Введите положительное значение секунд", "Продолжить");
        else
        {
            int min = 0;

            while (sec >= 3600)
            {
                sec -= 3600;
            }

            for (int i = 0; sec >= 60; i++)
            {
                sec = sec - 60;
                min += 1;
            }

            Minutes.Text = Convert.ToString(min);
        }
    }
}
