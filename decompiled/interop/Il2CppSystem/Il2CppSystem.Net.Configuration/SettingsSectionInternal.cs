using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Net.Sockets;

namespace Il2CppSystem.Net.Configuration;

public sealed class SettingsSectionInternal : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instance;

	private static readonly System.IntPtr NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl;

	private static readonly System.IntPtr NativeFieldInfoPtr_IPProtectionLevel;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static SettingsSectionInternal instance
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_instance, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_instance, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool HttpListenerUnescapeRequestUrl
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl)) = value;
		}
	}

	public unsafe IPProtectionLevel IPProtectionLevel
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IPProtectionLevel);
			return *(IPProtectionLevel*)num;
		}
		set
		{
			*(IPProtectionLevel*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IPProtectionLevel)) = value;
		}
	}

	public unsafe static SettingsSectionInternal Section
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897398, XrefRangeEnd = 897402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SettingsSectionInternal>(intPtr2) : null;
		}
	}

	public unsafe bool Ipv6Enabled
	{
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 61071, RefRangeEnd = 61098, XrefRangeStart = 61071, XrefRangeEnd = 61098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SettingsSectionInternal()
	{
		Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Configuration", "SettingsSectionInternal");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr);
		NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "instance");
		NativeFieldInfoPtr_HttpListenerUnescapeRequestUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "HttpListenerUnescapeRequestUrl");
		NativeFieldInfoPtr_IPProtectionLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, "IPProtectionLevel");
		NativeMethodInfoPtr_get_Section_Internal_Static_get_SettingsSectionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100667152);
		NativeMethodInfoPtr_get_Ipv6Enabled_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100667153);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr, 100667154);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897402, XrefRangeEnd = 897403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SettingsSectionInternal()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSectionInternal>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SettingsSectionInternal(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
