using Microsoft.JSInterop;

namespace LearnBlazor.Helper{

  public static class IJSRuntimeExtension
  {
    public static async Task ToastrSuccess(this IJSRuntime jSRuntime, string message) {
      await jSRuntime.InvokeVoidAsync("showToaster", "success", message);
    }  

    public static async Task ToastrError(this IJSRuntime jSRuntime, string message) {
      await jSRuntime.InvokeVoidAsync("showToaster", "error", message);
    }  }
}