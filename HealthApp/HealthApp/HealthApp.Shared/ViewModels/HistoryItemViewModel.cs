namespace HealthApp.Shared.ViewModels
{
    public class HistoryItemViewModel
    {
        public HistoryItemViewModel(string title, string number, string unit, string time)
        {
            Title = title;
            Number = number;
            Unit = unit;
            Time = time;
        }

        public string Title { get; set; }

        public string Number { get; set; }

        public string Unit { get; set; }

        public string Time { get; set; }
    }
}
