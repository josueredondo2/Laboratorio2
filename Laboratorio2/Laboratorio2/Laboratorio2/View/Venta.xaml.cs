﻿using Laboratorio2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio2.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Venta : ContentPage
	{
		public Venta ()
		{
			InitializeComponent ();

            BindingContext = PersonaViewModel.GetInstance();
        }
	}
}