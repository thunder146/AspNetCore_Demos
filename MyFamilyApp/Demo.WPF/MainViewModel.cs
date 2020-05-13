using MyFamilyApp.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Demo.WPF
{
    public class MainViewModel
    {
        public string Title { get; set; } = "My WPF Demo";

        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();

        private readonly IFamilyService _familyService;

        public MainViewModel()
        {
            _familyService = new FamilyService();

            LoadPeople();
        }

        private void LoadPeople()
        {
            var people = _familyService.GetPeople();
            foreach (var person in people)
                People.Add(person);
        }
    }
}
