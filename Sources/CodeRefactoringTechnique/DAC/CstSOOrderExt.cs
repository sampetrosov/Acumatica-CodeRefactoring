using PX.Data;
using PX.Data.BQL;
using PX.Objects.SO;

namespace CodeRefactoringTechnique.DAC
{
    public sealed class CstSOOrderExt : PXCacheExtension<SOOrder>
    {
        public static bool IsActive()
        {
            return SOSetupSlot.Values[0];
        }

        #region CstSomeField
        [PXDBString(30,IsUnicode = true)]
        [PXUIField(DisplayName = "Some Field")]
        [PXUIVisible(typeof(Where<Current<SOSetup.autoReleaseIN>,Equal<True>>))]
        public string UsrSomeField { get; set; }
        public abstract class usrSomeField : BqlType<IBqlString, string>.Field<usrSomeField> { }
        #endregion
    }
}
