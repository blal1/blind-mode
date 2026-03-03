using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX;

public sealed class VFXOutputEventArgs : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__nameId_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__eventAttribute_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_nameId_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eventAttribute_Public_get_VFXEventAttribute_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0;

	public unsafe int _nameId_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nameId_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__nameId_k__BackingField)) = value;
		}
	}

	public unsafe VFXEventAttribute _eventAttribute_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventAttribute_k__BackingField);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__eventAttribute_k__BackingField)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int nameId
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_nameId_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe VFXEventAttribute eventAttribute
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eventAttribute_Public_get_VFXEventAttribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
		}
	}

	static VFXOutputEventArgs()
	{
		Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXOutputEventArgs");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr);
		NativeFieldInfoPtr__nameId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, "<nameId>k__BackingField");
		NativeFieldInfoPtr__eventAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, "<eventAttribute>k__BackingField");
		NativeMethodInfoPtr_get_nameId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, 100663428);
		NativeMethodInfoPtr_get_eventAttribute_Public_get_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, 100663429);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr, 100663430);
	}

	[CallerCount(31)]
	[CachedScanResults(RefRangeStart = 506934, RefRangeEnd = 506965, XrefRangeStart = 506934, XrefRangeEnd = 506965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VFXOutputEventArgs(int nameId, VFXEventAttribute eventAttribute)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&nameId);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eventAttribute);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_VFXEventAttribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public VFXOutputEventArgs(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public VFXOutputEventArgs()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXOutputEventArgs>.NativeClassPtr))
	{
	}
}
