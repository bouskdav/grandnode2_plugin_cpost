using Grand.Domain.Configuration;

namespace Shipping.CPost
{
    public class CPostShippingSettings : ISettings
    {
        public bool LimitMethodsToCreated { get; set; }
        public int DisplayOrder { get; set; }

    }
}
