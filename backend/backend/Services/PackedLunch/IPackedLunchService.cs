using backend.Models;

namespace backend.Services.PackedLunch
{
    public interface IPackedLunchService
    {
        IEnumerable<PackedLunchEntity> GetPackedLunchs();
    }
}
