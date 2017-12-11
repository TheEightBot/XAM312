using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAnimals
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnimalDetails : ContentPage
	{
		public AnimalDetails (Animal animal)
		{
            BindingContext = animal;
			InitializeComponent ();
		}
	}
}