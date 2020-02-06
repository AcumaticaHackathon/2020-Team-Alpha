using PX.Data;
using PX.Objects.AR;
using PX.Objects.IN;

namespace Cegid.Erp
{
    [PXDBInt]
    [PXUIField(DisplayName = "Inventory ID", Visibility = PXUIVisibility.Visible)]
    [PXRestrictor(typeof(Where<
            Current<ARSetup.migrationMode>, Equal<True>,
            Or<InventoryItem.stkItem, NotEqual<True>>>), PX.Objects.AP.Messages.CannotFindInventoryItem)]
    [PXRestrictor(typeof(Where<
            Current<ARSetup.migrationMode>, Equal<True>,
            Or<Current<ARTran.sOOrderNbr>, IsNotNull,
            Or<InventoryItem.stkItem, NotEqual<False>,
            Or<InventoryItem.kitItem, NotEqual<True>>>>>), PX.Objects.SO.Messages.CannotAddNonStockKitDirectly)]
    [PXRestrictor(typeof(Where<
            Current<ARSetup.migrationMode>, Equal<True>,
            Or<InventoryItem.stkItem, NotEqual<False>,
            Or<InventoryItem.kitItem, NotEqual<True>>>>), PX.Objects.IN.Messages.CannotAddNonStockKit)]
    [PXRestrictor(typeof(Where<InventoryItem.itemStatus, NotEqual<InventoryItemStatus.unknown>>), PX.Objects.PM.Messages.ReservedForProject)]
    public class ARTranInventoryItemAttribute : InventoryAttribute
    {
        public ARTranInventoryItemAttribute()
            : base(typeof(Search2<InventoryItem.inventoryID,
                LeftJoin<UsrItemClassVisibility, On<UsrItemClassVisibility.itemClassID, Equal<InventoryItem.itemClassID>, And<UsrItemClassVisibility.bAccountID, Equal<Current<ARInvoice.customerID>>>>>,
                Where2<Match<Current<AccessInfo.userName>>,
                    And<Where<UsrItemClassVisibility.bAccountID, IsNotNull,
                        Or<Not<Exists<Select<UsrItemClassVisibility,
                            Where<UsrItemClassVisibility.bAccountID, Equal<Current<ARInvoice.customerID>>>>>>>>>>>),
                typeof(InventoryItem.inventoryCD),
                typeof(InventoryItem.descr))
        {
        }
    }
}
