namespace MauiApp1;

public partial class Planner : ContentPage
{
	public Planner()
	{
		InitializeComponent();
       

        PopulateCalendar(2023, 12);
    }
    private void PopulateCalendar(int year, int month)
    {
        // Clear previous calendar content
        calendarGrid.Children.Clear();

        // Add days of the week headers
        for (int i = 0; i < 7; i++)
        {
            var label = new Label { Text = ((DayOfWeek)i).ToString().Substring(0, 3), HorizontalOptions = LayoutOptions.Center };
            Grid.SetColumn(label, i);
            Grid.SetRow(label, 0);
            calendarGrid.Children.Add(label);
        }

        // Get the first day of the month
        DateTime firstDayOfMonth = new DateTime(year, month, 1);
        int daysInMonth = DateTime.DaysInMonth(year, month);

        // Find the first day's position in the grid
        int startColumn = (int)firstDayOfMonth.DayOfWeek;
        int row = 1;
        int column = startColumn;

        // Populate the calendar with day numbers and black outlines
        for (int day = 1; day <= daysInMonth; day++)
        {
            // Create a Frame with a black outline around the Label
            var frame = new Frame
            {
                BorderColor = Color.FromRgb(0, 0, 0), // Black color using RGB values
                CornerRadius = 5,
                Padding = new Thickness(5), // Adjust padding as needed
                Content = new Label { Text = day.ToString(), HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center }
            };

            // Set the Frame position in the grid
            Grid.SetColumn(frame, column);
            Grid.SetRow(frame, row);
            calendarGrid.Children.Add(frame);

            // Move to the next column
            column++;

            // Move to the next row if the column exceeds 6 (Saturday)
            if (column > 6)
            {
                column = 0;
                row++;
            }
        }
    }





    
}
