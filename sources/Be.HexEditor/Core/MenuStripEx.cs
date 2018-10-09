using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Be.HexEditor.Core
{
    public class MenuStripEx : MenuStrip
    {        
        Form _form;
        float _dpiOld = 96F;

        public MenuStripEx()
        {
        }

        protected override void ScaleControl(System.Drawing.SizeF factor, BoundsSpecified specified)
        {
            //base.ScaleControl(factor, specified);
            //CoreUtil.AdjustImages(this, ref _dpiOld, this._form.DeviceDpi);
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            CoreUtil.ScaleFont(this);
            CoreUtil.AdjustImages(this);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            EnableFormEvents();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            EnableFormEvents();
        }

        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            EnableFormEvents();
        }

        void EnableFormEvents()
        {
            _form = CoreUtil.GetParent<Form>(this);

            if (_form != null)
            {
                CoreUtil.AdjustImages(this);
            }
        }
    }
}
