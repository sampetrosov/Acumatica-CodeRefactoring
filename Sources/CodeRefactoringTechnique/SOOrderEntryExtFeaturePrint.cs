using PX.Data;
using PX.Objects.SO;
using System.Collections;

namespace CodeRefactoringTechnique
{
    public class SOOrderEntryExtFeaturePrint : PXGraphExtension<SOOrderEntry>
    {
        public static bool IsActive()
        { 
            return SOSetupSlot.IsPrintFeatureEnabled;
        }

        public PXAction<SOOrder> printOrder;
        [PXButton(CommitChanges = true)]
        [PXUIField(DisplayName = "Print Order")]
        protected virtual IEnumerable PrintOrder(PXAdapter adapter)
        {
            throw new PXException(Messages.PrintMsg);
            //return adapter.Get();
        }
    }
}