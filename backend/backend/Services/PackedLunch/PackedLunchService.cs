using backend.Models;

namespace backend.Services.PackedLunch
{
    public class PackedLunchService : IPackedLunchService
    {
        public IEnumerable<PackedLunchEntity> GetPackedLunchs()
        {
            return new List<PackedLunchEntity>();
        }
    }
}
