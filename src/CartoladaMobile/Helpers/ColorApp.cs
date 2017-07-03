using System;
using Xamarin.Forms;

namespace CartoladaMobile.Helpers
{
    public static class ColorApp
    {
        public static Color GetColor(string key)
        {
			var converter = new ColorTypeConverter();
			Color color = (Color)Application.Current.Resources[key];
			return color;
        }
    }
}
