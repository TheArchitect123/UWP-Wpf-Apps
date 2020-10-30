using System.Threading.Tasks;

namespace IMDBConsumer.Uwp.PlatformServices.Interfaces
{
    public interface IFlyoutNavigationMngrExtensions
    {
        Task OpenFlyoutForViewModelAsync<T>(T viewmodel);
        Task OpenFlyoutForViewModalAsync<T>(T viewmodel);
    }
}
