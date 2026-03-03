using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization;

[System.Serializable]
public class FixupHolder : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_id;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fixupInfo;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_fixupType;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0;

	public unsafe long m_id
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_id);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_id)) = value;
		}
	}

	public unsafe Object m_fixupInfo
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fixupInfo);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fixupInfo)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe int m_fixupType
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fixupType);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_fixupType)) = value;
		}
	}

	static FixupHolder()
	{
		Il2CppClassPointerStore<FixupHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "FixupHolder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr);
		NativeFieldInfoPtr_m_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_id");
		NativeFieldInfoPtr_m_fixupInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupInfo");
		NativeFieldInfoPtr_m_fixupType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, "m_fixupType");
		NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr, 100670715);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 798820, RefRangeEnd = 798821, XrefRangeStart = 798818, XrefRangeEnd = 798820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FixupHolder(long id, Object fixupInfo, int fixupType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FixupHolder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&id);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fixupInfo);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &fixupType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int64_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FixupHolder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
