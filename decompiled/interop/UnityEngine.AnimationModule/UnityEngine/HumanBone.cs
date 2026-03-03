using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public sealed class HumanBone : Il2CppSystem.ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneName;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HumanName;

	private static readonly System.IntPtr NativeFieldInfoPtr_limit;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_boneName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_boneName_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_humanName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_humanName_Public_set_Void_String_0;

	public unsafe string m_BoneName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BoneName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_HumanName
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HumanName);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HumanName)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe HumanLimit limit
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limit);
			return *(HumanLimit*)num;
		}
		set
		{
			*(HumanLimit*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_limit)) = value;
		}
	}

	public unsafe string boneName
	{
		[CallerCount(255)]
		[CachedScanResults(RefRangeStart = 761723, RefRangeEnd = 761978, XrefRangeStart = 761723, XrefRangeEnd = 761978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_boneName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 110106, RefRangeEnd = 110111, XrefRangeStart = 110106, XrefRangeEnd = 110111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_boneName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string humanName
	{
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 765815, RefRangeEnd = 765844, XrefRangeStart = 765815, XrefRangeEnd = 765844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_humanName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_humanName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static HumanBone()
	{
		Il2CppClassPointerStore<HumanBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine", "HumanBone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HumanBone>.NativeClassPtr);
		NativeFieldInfoPtr_m_BoneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_BoneName");
		NativeFieldInfoPtr_m_HumanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "m_HumanName");
		NativeFieldInfoPtr_limit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, "limit");
		NativeMethodInfoPtr_get_boneName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, 100664095);
		NativeMethodInfoPtr_set_boneName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, 100664096);
		NativeMethodInfoPtr_get_humanName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, 100664097);
		NativeMethodInfoPtr_set_humanName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HumanBone>.NativeClassPtr, 100664098);
	}

	public HumanBone(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public HumanBone()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HumanBone>.NativeClassPtr))
	{
	}
}
