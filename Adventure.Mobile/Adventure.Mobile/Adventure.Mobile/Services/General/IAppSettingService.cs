using System.Threading.Tasks;

namespace Adventure.Mobile.Services.General
{
    public interface IAppSettingService
    {
        Task<string> ReadAsStringAsync(string filename);
    }
}
