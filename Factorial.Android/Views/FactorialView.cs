using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Factorial.Core.ViewModel;
using MvvmCross.Platforms.Android.Views;

namespace Factorial.Android.Views
{
    [Activity(Label = "@string/app_name")]
    class FactorialView : MvxActivity<FactorialViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.FactorialPage);
        }
    }
}