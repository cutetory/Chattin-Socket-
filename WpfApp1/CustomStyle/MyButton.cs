using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1.CustomStyle
{
	public class MyButton : Button
	{
		public Brush MouseOverColor
		{
			get { return (Brush)GetValue(MouseOverColorProperty); }
			set { SetValue(MouseOverColorProperty, value); }
		}

		public static readonly DependencyProperty MouseOverColorProperty = 
			DependencyProperty.Register("MouseOverColor", typeof(Brush), typeof(MyButton),
			new PropertyMetadata(new SolidColorBrush(Colors.Red)));


	}
}
