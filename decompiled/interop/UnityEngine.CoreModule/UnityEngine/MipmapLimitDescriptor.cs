using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public sealed class MipmapLimitDescriptor : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__useMipmapLimit_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__groupName_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_useMipmapLimit_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_groupName_Public_get_String_0;

	public unsafe bool _useMipmapLimit_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useMipmapLimit_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__useMipmapLimit_k__BackingField)) = value;
		}
	}

	public unsafe string _groupName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groupName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__groupName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool useMipmapLimit
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 720416, RefRangeEnd = 720506, XrefRangeStart = 720416, XrefRangeEnd = 720506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_useMipmapLimit_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe string groupName
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_groupName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static MipmapLimitDescriptor()
	{
		Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MipmapLimitDescriptor");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr);
		NativeFieldInfoPtr__useMipmapLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, "<useMipmapLimit>k__BackingField");
		NativeFieldInfoPtr__groupName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, "<groupName>k__BackingField");
		NativeMethodInfoPtr_get_useMipmapLimit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, 100665504);
		NativeMethodInfoPtr_get_groupName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, 100665505);
	}

	public MipmapLimitDescriptor(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public MipmapLimitDescriptor()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr))
	{
	}
}
