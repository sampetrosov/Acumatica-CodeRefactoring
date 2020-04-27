using PX.Data;
using PX.Objects.SO;
using System.Collections;

namespace CodeRefactoringTechnique
{
    public class CstSOOrderEntryExtCust1 : PXGraphExtension<SOOrderEntry>
    {
        public static bool IsActive()
        { 
            return SOSetupSlot.Values[0];// 0 - SOSetup.autoReleaseIN
        }

        public PXAction<SOOrder> someAction;
        [PXButton(CommitChanges = true)]
        [PXUIField(DisplayName = "GRAPH 1 ACTION")]
        protected virtual IEnumerable SomeAction(PXAdapter adapter)
        {
            throw new PXException(Messages.FirstActionMsg);
            //return adapter.Get();
        }
    }
}