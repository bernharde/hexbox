using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Be.Windows.Forms
{
    public class StatusStripEx : StatusStrip
    {
        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            var form = Util.GetParent<Form>(this);
            this.Font = form.Font;
        }
    }
}
