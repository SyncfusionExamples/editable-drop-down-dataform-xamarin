using Syncfusion.XForms.ComboBox;
using Syncfusion.XForms.DataForm;
using Syncfusion.XForms.DataForm.Editors;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class CustomDropDownEditor : DataFormDropDownEditor
    {
        public CustomDropDownEditor(SfDataForm dataForm) : base(dataForm)
        {
        }
        protected override void OnInitializeView(DataFormItem dataFormItem, SfComboBox view)
        {
            base.OnInitializeView(dataFormItem, view);
            view.IsEditableMode = true;
        }
    }
}
