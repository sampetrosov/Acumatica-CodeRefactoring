using System.Collections.Generic;
using PX.Data;
using PX.Objects.SO;

namespace CodeRefactoringTechnique
{
    public class SOSetupSlot : IPrefetchable
    {
        protected List<bool> values = new List<bool>();
        public static List<bool> Values
        {
            get
            {
                //Get the values from the slot dynamically. 
                //By providing table name, you inform system when it should reset the slot.
                return PXDatabase.GetSlot<SOSetupSlot>("CstSOSetupSlot", typeof(SOSetup)).values;
            }
        }

        public void Prefetch()
        {
            //read database here
            foreach (PXDataRecord rec in PXDatabase.SelectMulti<SOSetup>(
                new PXDataField<SOSetup.autoReleaseIN>(), // definition for fields that system should select
                new PXDataField<SOSetup.useShippedNotInvoiced>()
              ))
            {
                //populate your collection from the database here
                values.Add(rec.GetBoolean(0) == true); // 0 - SOSetup.autoReleaseIN
                values.Add(rec.GetBoolean(1) == true); // 1 - SOSetup.useShippedNotInvoiced
            }
        }
    }   
}