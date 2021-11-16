using Litium.Runtime.DependencyInjection;

namespace LitiumItemTemplate
{
    [Service(ServiceType = typeof(I$safeitemname$), Lifetime = DependencyLifetime.Transient)]
    public class LitiumService : I$safeitemname$
    {
        public LitiumService()
        {
        }
    }
}
