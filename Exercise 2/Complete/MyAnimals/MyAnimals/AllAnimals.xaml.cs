using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;

namespace MyAnimals
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AllAnimals : ContentPage
	{
        bool isEditing;

        public AllAnimals ()
		{
			InitializeComponent ();

            BindingContext = AnimalRepository.Animals;
        }

        void OnEdit(object sender, EventArgs e)
        {
            isEditing = !isEditing;
            ((ToolbarItem)sender).Text = isEditing ? "End Edit" : "Edit";
        }

        async void OnDelete(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;
            var animal = (Animal)item.BindingContext;
            await DeleteAnimalAsync(animal);
        }

        async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (!isEditing)
            {
                var animalSelected = (Animal)e.Item;
                await this.Navigation.PushAsync(new AnimalDetails(animalSelected));
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (isEditing)
            {
                var animal = (Animal)e.SelectedItem;
                if (await DeleteAnimalAsync(animal))
                {
                    OnEdit(editButton, EventArgs.Empty);
                }
            }
        }

        async Task<bool> DeleteAnimalAsync(Animal animal)
        {
            if (animal != null)
            {
                if (await this.DisplayAlert("Confirm", $"Are you sure you want to delete {animal.Name}?", "Yes", "No") == true)
                {
                    AnimalRepository.Animals.Remove(animal);
                    return true;
                }
            }
            return false;
        }
    }
}