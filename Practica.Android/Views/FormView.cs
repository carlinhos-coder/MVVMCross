using Android.OS;
using Android.App;
using MvvmCross.Platforms.Android.Views;
using Practica.Core.ViewModels;

namespace Practica.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class FormView : MvxActivity<FormViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FormPage);
        }
    }
}