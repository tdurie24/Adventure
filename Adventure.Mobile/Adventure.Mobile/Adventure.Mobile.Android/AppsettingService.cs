using System.IO;
using System.Threading.Tasks;
using Adventure.Mobile.Services.General;
using Android.App;
using Android.Content;

namespace Adventure.Mobile.Droid
{
    public class AppSettingService: IAppSettingService
    {
        private readonly Context context = Application.Context;

        public async Task<string> ReadAsStringAsync(string filename)
        {
            using (var asset = this.context.Assets.Open(filename))
            using (var streamReader = new StreamReader(asset))
            {
                return await streamReader.ReadToEndAsync();
            }
        }
    }
}