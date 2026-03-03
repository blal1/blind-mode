using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
public class SerializableEnum : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnumValueAsString;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_EnumTypeAsString;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Enum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Enum_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

	public unsafe string m_EnumValueAsString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnumValueAsString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnumValueAsString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_EnumTypeAsString
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnumTypeAsString);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EnumTypeAsString)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Il2CppSystem.Enum value
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030157, XrefRangeEnd = 1030169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_get_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Enum>(intPtr2) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030169, XrefRangeEnd = 1030171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_value_Public_set_Void_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static SerializableEnum()
	{
		Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SerializableEnum");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr);
		NativeFieldInfoPtr_m_EnumValueAsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, "m_EnumValueAsString");
		NativeFieldInfoPtr_m_EnumTypeAsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, "m_EnumTypeAsString");
		NativeMethodInfoPtr_get_value_Public_get_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, 100664547);
		NativeMethodInfoPtr_set_value_Public_set_Void_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, 100664548);
		NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr, 100664549);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1030171, XrefRangeEnd = 1030179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SerializableEnum(Il2CppSystem.Type enumType)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableEnum>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)enumType);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SerializableEnum(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
