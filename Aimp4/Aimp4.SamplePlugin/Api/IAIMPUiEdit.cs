using System;
using System.Runtime.InteropServices;

namespace Aimp4.Api
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("61756945-6469-7400-0000-000000000000")]
    [ComImport]
    public interface IAIMPUiEdit
    {
        // IAIMPPropertyList
        void BeginUpdate();
        void EndUpdate();
        void Reset();
        // Read
        double GetValueAsFloat(AIMPUiEditPropId propertyId);
        int GetValueAsInt32(AIMPUiEditPropId propertyId);
        long GetValueAsInt64(AIMPUiEditPropId propertyId);

        [return: MarshalAs(UnmanagedType.IUnknown)]
        object GetValueAsObject(AIMPUiEditPropId propertyId, ref Guid iid);

        // Write
        void SetValueAsFloat(AIMPUiEditPropId propertyId, double value);
        void SetValueAsInt32(AIMPUiEditPropId propertyId, int value);
        void SetValueAsInt64(AIMPUiEditPropId propertyId, long value);
        void SetValueAsObject(AIMPUiEditPropId propertyId, [MarshalAs(UnmanagedType.IUnknown)] object value);

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
    }
}