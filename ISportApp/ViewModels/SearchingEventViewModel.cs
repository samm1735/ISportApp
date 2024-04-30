using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ISportApp.Models;
using ISportApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISportApp.ViewModels
{
    //public partial class SearchingEventViewModel : ObservableObject
    //{

    //    [ObservableProperty]
    //    public String searchTerm1 = new("");

    //    [ObservableProperty]
    //    public String searchTerm2 = new("");

    //    [ObservableProperty]
    //    public String errorMessage = new("");

    //    [ObservableProperty]
    //    public string eventFullString = new("");

    //    [ObservableProperty]
    //    public List<Event> eventList = new();

    //    [ObservableProperty]
    //    public ObservableCollection<Event> modelViewEvents = new();


    //    public bool IsErrorVisible => !string.IsNullOrEmpty(ErrorMessage);




    //    [RelayCommand]
    //    private async Task Search()
    //    {
    //        //string searchTerm = SearchTerm;
    //        //searchTerm = FormatName(searchTerm1,searchTerm2);  Make sure the team names are well formatted as Team_1_VS_Team_2

    //        // Perform search based on searchTerm
    //        EventFullString = "Real_Madrid_vs_Manchester_City";
    //        //await GetEvents();
    //        await GetData();
    //    }

    //    public async Task GetData()
    //    {
    //        //TO-DO : ...
    //        //List<Event> temp = await _personneService.LoadPersonnes();

    //        SearchedEvents searchedEvents = await SearchingEventService.getSearchedEvents(EventFullString);

    //        if (ModelViewEvents.Count > 0)
    //            ModelViewEvents.Clear();

    //        foreach (Event _event in searchedEvents._event)
    //        {
    //            ModelViewEvents.Add(_event);
    //        }
    //        OnPropertyChanged(nameof(ModelViewEvents));

    //    }



    //    public async Task GetEvents()
    //    {
    //        try
    //        {
    //            SearchedEvents searchedEvents = await SearchingEventService.getSearchedEvents(EventFullString);

    //            if (searchedEvents._event != null && searchedEvents._event.Length > 0)
    //            {
    //                foreach(Event e in searchedEvents._event)
    //                {
    //                    EventList.Add(e);
    //                }

    //            }
    //            else
    //            {
    //                // No Event instance found, set error message
    //                ErrorMessage = "No player found for the entered search term.";
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            ErrorMessage = $"An error occurred: {ex.Message}";
    //        }
    //    }


    //}


    // ViewModel

    public partial class SearchingEventViewModel : ObservableObject
    {
        public string SearchTerm1 { get; set; }
        public string SearchTerm2 { get; set; }
        public string ErrorMessage { get; set; }
        public ObservableCollection<Event> ModelViewEvents { get; set; }

        public SearchingEventViewModel()
        {
            ModelViewEvents = new ObservableCollection<Event>();
        }

        [RelayCommand]
        private async Task Search()
        {
            try
            {
                string eventFullString = $"{FormatName(SearchTerm1)}_vs_{FormatName(SearchTerm2)}";
                //eventFullString = "Real_Madrid_vs_Manchester_city";
                ModelViewEvents.Clear();
                await GetData(eventFullString);
            }
            catch (Exception ex)
            {
                ErrorMessage = $"An error occurred: {ex.Message}";
            }
        }

        private async Task GetData(string eventFullString)
        {
            SearchedEvents searchedEvents = await SearchingEventService.getSearchedEvents(eventFullString);
            var a = searchedEvents;
            foreach (Event _event in searchedEvents.@event)
            {
                ModelViewEvents.Add(_event);
            }

            OnPropertyChanged(nameof(ModelViewEvents));
        }


        public string FormatName(string name)
        {
            // Split the name into individual words
            string[] words = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Initialize a StringBuilder to store the formatted name
            StringBuilder formattedName = new StringBuilder();

            // Iterate through each word in the name
            for (int i = 0; i < words.Length; i++)
            {

                // Convert the first word to lowercase and append it directly
                if (i == 0)
                {
                    formattedName.Append(words[i]);
                }
                else
                {
                    // Convert subsequent words to lowercase and append them with an underscore
                    formattedName.Append("_").Append(words[i].ToLower());
                }
            }

            // Return the formatted name
            return formattedName.ToString();
        }

    }

}
