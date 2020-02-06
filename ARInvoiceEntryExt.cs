using PX.Data;
using PX.Objects.AR;

namespace Cegid.Erp
{
    public class ARInvoiceEntryExt : PXGraphExtension<ARInvoiceEntry>
    {
        [PXMergeAttributes(Method = MergeMethod.Merge)]
        [ARTranInventoryItem(Filterable = true)]
        protected virtual void ARTran_InventoryID_CacheAttached(PXCache sender)
        {
        }
    }
}
