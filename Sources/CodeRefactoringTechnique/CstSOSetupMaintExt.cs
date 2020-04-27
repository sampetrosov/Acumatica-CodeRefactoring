using PX.Common;
using PX.Data;
using PX.Objects.SO;

namespace CodeRefactoringTechnique
{
    public class CstSOSetupMaintExt : PXGraphExtension<SOSetupMaint>
    {
        public delegate void PersistDelegate();
        [PXOverride]
        public void Persist(PersistDelegate baseMethod)
        {
            baseMethod();
            // We need to reset Slots and Cache after the values may change.
            PXDatabase.ResetSlots();
            PXPageCacheUtils.InvalidateCachedPages();
        }
    }
}
