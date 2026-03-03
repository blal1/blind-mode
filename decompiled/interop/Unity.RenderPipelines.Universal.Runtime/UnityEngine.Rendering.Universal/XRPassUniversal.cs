using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.Universal;

public class XRPassUniversal : XRPass
{
	private static readonly IntPtr NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__canMarkLateLatch_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField;

	private static readonly IntPtr NativeFieldInfoPtr__canFoveateIntermediatePasses_k__BackingField;

	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XRPass_XRPassCreateInfo_0;

	private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_isLateLatchEnabled_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_isLateLatchEnabled_Internal_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_canMarkLateLatch_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_canMarkLateLatch_Internal_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_hasMarkedLateLatch_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_hasMarkedLateLatch_Internal_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_canFoveateIntermediatePasses_Internal_get_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_set_canFoveateIntermediatePasses_Internal_set_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe bool _isLateLatchEnabled_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField)) = value;
		}
	}

	public unsafe bool _canMarkLateLatch_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canMarkLateLatch_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canMarkLateLatch_k__BackingField)) = value;
		}
	}

	public unsafe bool _hasMarkedLateLatch_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField)) = value;
		}
	}

	public unsafe bool _canFoveateIntermediatePasses_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canFoveateIntermediatePasses_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__canFoveateIntermediatePasses_k__BackingField)) = value;
		}
	}

	public unsafe bool isLateLatchEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isLateLatchEnabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_isLateLatchEnabled_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool canMarkLateLatch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canMarkLateLatch_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_canMarkLateLatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool hasMarkedLateLatch
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasMarkedLateLatch_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasMarkedLateLatch_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool canFoveateIntermediatePasses
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_canFoveateIntermediatePasses_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = stackalloc IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_canFoveateIntermediatePasses_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static XRPassUniversal()
	{
		Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "XRPassUniversal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr);
		NativeFieldInfoPtr__isLateLatchEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<isLateLatchEnabled>k__BackingField");
		NativeFieldInfoPtr__canMarkLateLatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<canMarkLateLatch>k__BackingField");
		NativeFieldInfoPtr__hasMarkedLateLatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<hasMarkedLateLatch>k__BackingField");
		NativeFieldInfoPtr__canFoveateIntermediatePasses_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, "<canFoveateIntermediatePasses>k__BackingField");
		NativeMethodInfoPtr_Create_Public_Static_XRPass_XRPassCreateInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666129);
		NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666130);
		NativeMethodInfoPtr_get_isLateLatchEnabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666131);
		NativeMethodInfoPtr_set_isLateLatchEnabled_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666132);
		NativeMethodInfoPtr_get_canMarkLateLatch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666133);
		NativeMethodInfoPtr_set_canMarkLateLatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666134);
		NativeMethodInfoPtr_get_hasMarkedLateLatch_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666135);
		NativeMethodInfoPtr_set_hasMarkedLateLatch_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666136);
		NativeMethodInfoPtr_get_canFoveateIntermediatePasses_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666137);
		NativeMethodInfoPtr_set_canFoveateIntermediatePasses_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666138);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr, 100666139);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108229, XrefRangeEnd = 1108237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static XRPass Create(XRPassCreateInfo createInfo)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)createInfo));
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_Public_Static_XRPass_XRPassCreateInfo_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<XRPass>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108237, XrefRangeEnd = 1108243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Release()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1108243, XrefRangeEnd = 1108244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe XRPassUniversal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRPassUniversal>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public XRPassUniversal(IntPtr pointer)
		: base(pointer)
	{
	}
}
