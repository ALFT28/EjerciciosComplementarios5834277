namespace MatchGame583477
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            SetUpGame();
        }



        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()
            {
                "🐕","🐕",
                "🙈","🙈",
                "🐙","🐙",
                "🐘","🐘",
                "🦓","🦓",
                "🦒","🦒",
                "🐠","🐠",
                "🐬","🐬",

            };

            Random random = new Random();

            foreach(Button view in Grid1.Children)
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                view.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }    

            
        }

        Button ultimoButtonClicked;
        bool encontrandoMath = false;


        private void Button_Clicked(object sender, EventArgs e)
        {

            Button button = sender as Button;
            if (encontrandoMath == false) 
            {
                button.IsVisible = false;
                ultimoButtonClicked = button;
                encontrandoMath = true;
            }
            else if (button.Text == ultimoButtonClicked.Text)
            {
                button.IsVisible = false;
                encontrandoMath = false;
            }
            else
            {
                ultimoButtonClicked.IsVisible = true;
                encontrandoMath = false;
            }

        }

       
    }

}
