using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Popover;

namespace YourNamespace
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            // Create the Popover content
            var popoverContent = new StackLayout
            {
                Children =
                {
                    new Label { Text = "Option 1" },
                    new Label { Text = "Option 2" },
                    new Label { Text = "Option 3" },
                }
            };

            // Create the Popover and set the content
            var popover = new Popover
            {
                Content = popoverContent
            };

            // Show the Popover
            await this.ShowPopoverAsync(popover, (Button)sender);
        }
    }
}
