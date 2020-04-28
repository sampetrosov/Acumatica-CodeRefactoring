using PX.Data;
using PX.Objects.SO;
using System.Collections;

namespace CodeRefactoringTechnique
{
    public class CstSOOrderEntryExtFeatureRedirect : PXGraphExtension<SOOrderEntry>
    {
        public static bool IsActive()
        {
            return SOSetupSlot.IsRedirectFeatureEnabled;
        }
        public PXAction<SOOrder> redirectToRecord;
        [PXButton(CommitChanges = true)]
        [PXUIField(DisplayName ="Redirect To Record")]
        protected virtual IEnumerable RedirectToRecord(PXAdapter adapter)
        {
            throw new PXException(Messages.RedirectToMsg);
            //return adapter.Get();
        }
    }
}