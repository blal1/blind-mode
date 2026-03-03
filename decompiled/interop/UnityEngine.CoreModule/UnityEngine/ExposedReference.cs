using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
public sealed class ExposedReference<T> : Il2CppSystem.ValueType where T : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_exposedName;

	private static readonly System.IntPtr NativeFieldInfoPtr_defaultValue;

	private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0;

	public unsafe PropertyName exposedName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposedName);
			return *(PropertyName*)num;
		}
		set
		{
			*(PropertyName*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_exposedName)) = value;
		}
	}

	public unsafe Object defaultValue
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultValue);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_defaultValue)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static ExposedReference()
	{
		Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExposedReference`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1] { Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr);
		NativeFieldInfoPtr_exposedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, "exposedName");
		NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, "defaultValue");
		NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, 100664093);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1170579, RefRangeEnd = 1170584, XrefRangeStart = 1170573, XrefRangeEnd = 1170579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe T Resolve(IExposedPropertyTable resolver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)resolver);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
	}

	public ExposedReference(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public ExposedReference()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr))
	{
	}
}
