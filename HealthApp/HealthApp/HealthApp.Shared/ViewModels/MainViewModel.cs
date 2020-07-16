using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp.Shared.ViewModels
{
    public class MainViewModel
    {
        public HistoryItemViewModel[] Items { get; } = new HistoryItemViewModel[]
        {
            new HistoryItemViewModel("Steps", "7,810", "steps", "2:12 PM"),
            new HistoryItemViewModel("Walking", "3.5", "km", "1:06 PM"),
            new HistoryItemViewModel("Cardio", "250", "kcal", "11:24 AM"),            
        };
    }
}
