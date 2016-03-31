using System;
using System.Runtime.InteropServices;

namespace Aimp4.Api
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("61756943-6865-636B-6564-436F6D626F00")]
    [ComImport]
    public interface IAIMPUiCheckComboBox
    {
        // IAIMPPropertyList
        void BeginUpdate();
        void EndUpdate();
        void Reset();
        // Read
        double GetValueAsFloat(AIMPUiCheckComboBoxPropId propertyId);
        int GetValueAsInt32(AIMPUiCheckComboBoxPropId propertyId);
        long GetValueAsInt64(AIMPUiCheckComboBoxPropId propertyId);

        [return: MarshalAs(UnmanagedType.IUnknown)]
        object GetValueAsObject(AIMPUiCheckComboBoxPropId propertyId, ref Guid iid);

        // Write
        void SetValueAsFloat(AIMPUiCheckComboBoxPropId propertyId, double value);
        void SetValueAsInt32(AIMPUiCheckComboBoxPropId propertyId, int value);
        void SetValueAsInt64(AIMPUiCheckComboBoxPropId propertyId, long value);
        void SetValueAsObject(AIMPUiCheckComboBoxPropId propertyId, [MarshalAs(UnmanagedType.IUnknown)] object value);

        // IAIMPUIControl
        void GetPlacement(IntPtr placement); // AIMPUiControlPlacement**
        void GetPlacementConstraints(IntPtr constraints); // AIMPUiControlPlacementConstraints**
        void SetPlacement(ref AIMPUiControlPlacement placement);
        void SetPlacementConstraints(ref AIMPUiControlPlacementConstraints constraints);

        // Coords Translation
        void ClientToScreen(ref POINT point);
        void ScreenToClient(ref POINT point);

        // Drawing
        void PaintTo(IntPtr hDc, int x, int y);
        void Invalidate();

        // IAIMPUIWinControl
        [return: MarshalAs(UnmanagedType.IUnknown)]
        object GetControl(int index, ref Guid iid);

        [PreserveSig]
        int GetControlCount();

        [PreserveSig]
        IntPtr GetHandle();

        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool HasHandle();

        void SetFocus();

        // IAIMPUIBaseEdit
        void CopyToClipboard();
        void CutToClipboard();
        void PasteFromClipboard();
        void SelectAll();
        void SelectNone();

        // IAIMPUIBaseButtonnedEdit
        IAIMPUiEditButton AddButton([MarshalAs(UnmanagedType.IUnknown)] object eventsHandler);
        void DeleteButton(int index);
        void DeleteButton2(IAIMPUiEditButton button);
        IAIMPUiEditButton GetButton(int index);

        [PreserveSig]
        int GetButtonCount();

        // IAIMPUiBaseComboBox
        void Add([MarshalAs(UnmanagedType.IUnknown)] object obj, int extraData);
        void Add2(IAIMPObjectList list);
        void Clear();
        void Delete(int index);

        [return: MarshalAs(UnmanagedType.IUnknown)]
        object GetItem(int index, ref Guid iid);

        int GetItemCount();
        void SetItem(int index, [MarshalAs(UnmanagedType.IUnknown)] object obj);

        // IAIMPUiBaseComboBox
        [PreserveSig]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool GetChecked(int index);

        void SetChecked(int index, [MarshalAs(UnmanagedType.Bool)] bool value);
    }
}