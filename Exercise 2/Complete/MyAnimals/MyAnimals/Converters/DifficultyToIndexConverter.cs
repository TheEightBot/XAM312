using System;
using Xamarin.Forms;
using System.Globalization;

namespace MyAnimals
{
	public class DifficultyToIndexConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			Difficulty difficulty = (Difficulty)value;
			if (targetType != typeof(int))
				throw new Exception("DifficultyConverter.Convert expected integer targetType");
			return (int)difficulty;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			int index = (int)value;
			if (targetType != typeof(Difficulty))
				throw new Exception("DifficultyConverter.ConvertBack expected Gender targetType");
			return (Difficulty)index;
		}
	}
}