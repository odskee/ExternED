// Manages reading from the journal and notifying other components
using System.Threading.Tasks;

namespace ExternED.Services
{
    public interface IJournal
    {
        Task<bool> IsDocked();
    }




    public class Journal : IJournal
    {
        public async Task<bool> IsDocked()
        {
            return true;
        }
    }
}
