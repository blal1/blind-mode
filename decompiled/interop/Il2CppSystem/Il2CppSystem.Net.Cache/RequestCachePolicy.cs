using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.Cache;

public class RequestCachePolicy : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Level;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RequestCacheLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	public unsafe RequestCacheLevel m_Level
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Level);
			return *(RequestCacheLevel*)num;
		}
		set
		{
			*(RequestCacheLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Level)) = value;
		}
	}

	public unsafe RequestCacheLevel Level
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(RequestCacheLevel*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static RequestCachePolicy()
	{
		Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Cache", "RequestCachePolicy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr);
		NativeFieldInfoPtr_m_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, "m_Level");
		NativeMethodInfoPtr__ctor_Public_Void_RequestCacheLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100667160);
		NativeMethodInfoPtr_get_Level_Public_get_RequestCacheLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100667161);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr, 100667162);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897419, XrefRangeEnd = 897420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RequestCachePolicy(RequestCacheLevel level)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequestCachePolicy>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&level);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_RequestCacheLevel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897420, XrefRangeEnd = 897426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	public RequestCachePolicy(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
