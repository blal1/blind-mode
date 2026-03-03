using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMS.Internal.Xml.XPath;

namespace Il2CppSystem.Xml.Schema;

public class DoubleLinkAxis : Axis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_next;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Next_Internal_get_Axis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0;

	public unsafe Axis next
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Axis>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_next)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Axis Next
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Next_Internal_get_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Axis>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static DoubleLinkAxis()
	{
		Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "DoubleLinkAxis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr);
		NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, "next");
		NativeMethodInfoPtr_get_Next_Internal_get_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100665871);
		NativeMethodInfoPtr_set_Next_Internal_set_Void_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100665872);
		NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100665873);
		NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr, 100665874);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 920048, XrefRangeEnd = 920052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DoubleLinkAxis(Axis axis, DoubleLinkAxis inputaxis)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoubleLinkAxis>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axis);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)inputaxis);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Axis_DoubleLinkAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 920062, RefRangeEnd = 920066, XrefRangeStart = 920052, XrefRangeEnd = 920062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DoubleLinkAxis ConvertTree(Axis axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)axis);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ConvertTree_Internal_Static_DoubleLinkAxis_Axis_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<DoubleLinkAxis>(intPtr2) : null;
	}

	public DoubleLinkAxis(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
