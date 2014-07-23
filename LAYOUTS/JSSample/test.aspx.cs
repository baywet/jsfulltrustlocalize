using System;
using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace JSLocalizeSample.LAYOUTS.JSSample
{
    public partial class test : LayoutsPageBase
    {
        protected override void OnPreRender(EventArgs e)
        {
            //SPRibbon currentRibbon = SPRibbon.GetCurrent(this.Page);
            //if (currentRibbon != null)
            //{
                ScriptLink.RegisterScriptAfterUI(this.Page, "SP.Core.js", false, true);
                ScriptLink.RegisterScriptAfterUI(this.Page, "CUI.js", false, true);
                ScriptLink.RegisterScriptAfterUI(this.Page, "core.js", true, false);
                ScriptLink.RegisterScriptAfterUI(this.Page, "SP.Ribbon.js", false, true);
                ScriptLink.RegisterScriptAfterUI(this.Page, "SP.Runtime.js", false, true);
                ScriptLink.RegisterScriptAfterUI(this.Page, "SP.js", false, true);

                ScriptLink.RegisterScriptAfterUI(this.Page, "JSample/Scripts/jquery.min.js", false, true);
                ScriptLink.RegisterScriptAfterUI(this.Page, "JSample/Scripts/sample.js", false, true);
            //}
            base.OnPreRender(e);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}
