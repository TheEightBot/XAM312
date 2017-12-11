using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyAnimals
{
    public class Animal : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        string name;

        public string Description
        {
            get { return description; }
            set { SetProperty(ref description, value); }
        }
        string description;


        public string ImageUrl { get; set; }

        public bool IsFavorite
        {
            get { return isFavorite; }
            set { SetProperty(ref isFavorite, value); }
        }
        bool isFavorite;

        public Difficulty Difficulty { get; set; }

        bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (!object.Equals(field, value))
            {
                field = value;
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Name}: {Description}";
        }
    }
}