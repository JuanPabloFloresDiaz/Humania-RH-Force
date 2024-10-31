
namespace Humania_RH_Force.Views;
public interface ISplashView
{
    void UpdateProgress(int progress);
    void ShowLogin();
    void ShowFirstUse();
    void ShowNoInternetError();
    void ShowServerError();

    // Cambia las propiedades a `get; set;`
    bool RedirectToLogin { get; set; }
    bool RedirectToFirstUse { get; set; }
    bool RedirectToNoInternet { get; set; }
    bool RedirectToServerError { get; set; }
}
