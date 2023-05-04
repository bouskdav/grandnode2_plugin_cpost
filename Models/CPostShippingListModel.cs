using Grand.Infrastructure.ModelBinding;
using Grand.Infrastructure.Models;

namespace Shipping.CPost.Models
{
    public class CPostShippingListModel : BaseModel
    {
        [GrandResourceDisplayName("Plugins.Shipping.CPost.Fields.LimitMethodsToCreated")]
        public bool LimitMethodsToCreated { get; set; }

        [GrandResourceDisplayName("Plugins.Shipping.CPost.Fields.DisplayOrder")]
        public int DisplayOrder { get; set; }
    }
}