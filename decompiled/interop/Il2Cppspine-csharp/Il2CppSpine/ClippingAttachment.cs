using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine;

public class ClippingAttachment : VertexAttachment
{
	private static readonly IntPtr NativeFieldInfoPtr_endSlot;

	private static readonly IntPtr NativeMethodInfoPtr_get_EndSlot_Public_get_SlotData_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_EndSlot_Public_set_Void_SlotData_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_ClippingAttachment_0;

	private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Attachment_0;

	public unsafe SlotData endSlot
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endSlot);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SlotData>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_endSlot)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SlotData EndSlot
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EndSlot_Public_get_SlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SlotData>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_EndSlot_Public_set_Void_SlotData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static ClippingAttachment()
	{
		Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "ClippingAttachment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr);
		NativeFieldInfoPtr_endSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr, "endSlot");
		NativeMethodInfoPtr_get_EndSlot_Public_get_SlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr, 100663660);
		NativeMethodInfoPtr_set_EndSlot_Public_set_Void_SlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr, 100663661);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr, 100663662);
		NativeMethodInfoPtr__ctor_Protected_Void_ClippingAttachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr, 100663663);
		NativeMethodInfoPtr_Copy_Public_Virtual_Attachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr, 100663664);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 842678, RefRangeEnd = 842679, XrefRangeStart = 842674, XrefRangeEnd = 842678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClippingAttachment(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842679, XrefRangeEnd = 842685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ClippingAttachment(ClippingAttachment other)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClippingAttachment>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_ClippingAttachment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842685, XrefRangeEnd = 842693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Attachment Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Copy_Public_Virtual_Attachment_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Attachment>(intPtr2) : null;
	}

	public ClippingAttachment(IntPtr pointer)
		: base(pointer)
	{
	}
}
