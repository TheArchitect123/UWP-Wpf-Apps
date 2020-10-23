using Caliburn.Micro;
using System.Threading.Tasks;

namespace CryptoCoin.Uwp.PlatformServices.Interfaces
{
    public interface INavigationServiceExtensions : INavigationService
    {
        Task OpenModalPageByViewModalAsync<T>(T viewmodel);
        Task OpenModalPageWithLoaderByViewModal<T>(T viewmodel);

        Task OpenContentDialogueByViewModelAsync<T>(T viewModel);
        Task OpenContentDialogueWithLoaderByViewModelAsync<T>(T viewModel);
    }
}
