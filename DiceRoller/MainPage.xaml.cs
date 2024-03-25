namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }


        void UpperBoundRandoms(object sender, EventArgs e)
        {
            var seed = 0;
            var upper = 10;
            Random randObj = new Random(seed);
            randObj.Next(upper);

        }


    }

}
