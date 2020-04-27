using PX.Data;
using PX.Data.BQL;
using PX.Objects.SO;

namespace CodeRefactoringTechnique.DAC
{
    public sealed class CstSOOrderExt2 : PXCacheExtension<SOOrder>
    {
        public static bool IsActive()
        {
            return SOSetupSlot.Values[1];
        }

        #region CstSomeField
        [PXDBString(30, IsUnicode = true)]
        [PXUIField(DisplayName = "Some Field 2")]
        [PXUIVisible(typeof(Where<Current<SOSetup.useShippedNotInvoiced>, Equal<True>>))]
        public string UsrSomeField2 { get; set; }
        public abstract class usrSomeField2 : BqlType<IBqlString, string>.Field<usrSomeField2> { }
        #endregion
    }
}
