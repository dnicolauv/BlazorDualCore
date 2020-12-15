namespace BlazorDualCore.Client
{
  using Microsoft.Extensions.Logging;
  using Microsoft.JSInterop;
  using System.Threading.Tasks;

  public class ClientLoader
  {
    private readonly IClientLoaderConfiguration ClientLoaderConfiguration;

    private readonly IJSRuntime JSRuntime;

    private readonly ILogger Logger;

    public ClientLoader
    (
      ILogger<ClientLoader> _Logger,
      IJSRuntime _JSRuntime,
      IClientLoaderConfiguration _ClientLoaderConfiguration
    )
    {
      Logger = _Logger;
      Logger.LogDebug($"{GetType().Name}: constructor");
      JSRuntime = _JSRuntime;
      ClientLoaderConfiguration = _ClientLoaderConfiguration;
    }

    public async Task LoadClient()
    {
      await Task.Delay(ClientLoaderConfiguration.DelayTimeSpan).ConfigureAwait(false);
      const string LoadClientInteropName = "CompositionRoot.BlazorDualMode.LoadClient";
      Logger.LogDebug(LoadClientInteropName);
      await JSRuntime.InvokeAsync<object>(LoadClientInteropName).ConfigureAwait(false);
    }
  }
}
