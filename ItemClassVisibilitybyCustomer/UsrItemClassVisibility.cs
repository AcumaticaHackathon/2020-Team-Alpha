using System;
using PX.Data;

namespace ItemClassVisibilitybyCustomer
{
  [Serializable]
  [PXCacheName("UsrItemClassVisibility")]
  public class UsrItemClassVisibility : IBqlTable
  {
    #region BAccountID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "BAccount ID")]
    public virtual int? BAccountID { get; set; }
    public abstract class bAccountID : PX.Data.BQL.BqlInt.Field<bAccountID> { }
    #endregion

    #region ItemClassID
    [PXDBInt(IsKey = true)]
    [PXUIField(DisplayName = "Item Class ID")]
    public virtual int? ItemClassID { get; set; }
    public abstract class itemClassID : PX.Data.BQL.BqlInt.Field<itemClassID> { }
    #endregion

    #region CreatedByID
    [PXDBCreatedByID()]
    public virtual Guid? CreatedByID { get; set; }
    public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID> { }
    #endregion

    #region CreatedDateTime
    [PXDBCreatedDateTime()]
    public virtual DateTime? CreatedDateTime { get; set; }
    public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }
    #endregion

    #region LastModifiedByID
    [PXDBLastModifiedByID()]
    public virtual Guid? LastModifiedByID { get; set; }
    public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID> { }
    #endregion

    #region LastModifiedDateTime
    [PXDBLastModifiedDateTime()]
    public virtual DateTime? LastModifiedDateTime { get; set; }
    public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
    #endregion
  }
}