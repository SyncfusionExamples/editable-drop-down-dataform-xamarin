# How to make editable drop down in Xamarin.Forms DataForm (SfDataForm)

You can make the editable drop down in Xamarin.Forms SfDataForm by using custom editor.

You can create and add custom editor to SfDataForm by overriding the DataFormEditor class, where the CustomDropDownEditor is inherited using the DataFormDropDownEditor .

Refer to the online user guide documentation for creating new custom editor in DataForm.

**C#**

DropDownEditor modified by customizing DataFormDropDownEditor.

``` c#
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
```
Refer to the following code example for binding DataObject and register the editor using RegisterEditor as CustomDropDownEditor to make data form items as custom editor in DataForm.

**C#**

DropDown editor registered to DataForm.
``` c#
namespace DataFormDropDown
{
    public class DataFormBehavior : Behavior<ContentPage>
    {
        SfDataForm dataForm;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            dataForm = bindable.FindByName<SfDataForm>("dataForm");
            dataForm.DataObject = new Address();
            dataForm.RegisterEditor("DropDown", new CustomDropDownEditor(dataForm));
            dataForm.RegisterEditor("Country", "DropDown");
        }
    }
}
```
**Output**

![EditableDropDown](https://github.com/SyncfusionExamples/editable-drop-down-dataform-xamarin/blob/master/ScreenShots/EditableDropDown.png)
