using System;
using System.Collections;
using PX.Common;
using PX.Data;

using PX.Data.BQL;
using PX.Data.EP;
using PX.Objects.AP;
using PX.Objects.AR;
using PX.Objects.CS;
using PX.Objects.CT;
using PX.Objects.SO;
using PX.SM;
using PX.Objects.CR.DAC;
using PX.Objects.CA;
using System.Collections.Generic;
using PX.Objects;
using PX.Objects.CR;
using ItemClassVisibilitybyCustomer;

namespace PX.Objects.CR

{
  public class CustomerMaint_Extension : PXGraphExtension<CustomerMaint>
  {
    public PXSelect<UsrItemClassVisibility, Where<UsrItemClassVisibility.bAccountID, Equal<Current<Customer.bAccountID>>>> CustomerItemList;
  }
}