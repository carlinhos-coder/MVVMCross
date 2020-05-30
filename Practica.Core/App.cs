using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Practica.Core.ViewModels;

namespace Practica.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FormViewModel>();
        }
    }
}
