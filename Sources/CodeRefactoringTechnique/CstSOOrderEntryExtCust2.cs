using PX.Data;
using PX.Objects.SO;
using System.Collections;

namespace CodeRefactoringTechnique
{
    public class CstSOOrderEntryExtCust2 : PXGraphExtension<CstSOOrderEntryExtCust1, SOOrderEntry>
    {
        public static bool IsActive()
        {
            return SOSetupSlot.Values[1];// 1 - SOSetup.useShippedNotInvoiced
        }
        public PXAction<SOOrder> someAction2;
        [PXButton(CommitChanges = true)]
        [PXUIField(DisplayName ="GRAPH 2 ACTION")]
        protected virtual IEnumerable SomeAction2(PXAdapter adapter)
        {
            throw new PXException(Messages.SecondActionMsg);
            //return adapter.Get();
        }
    }
}