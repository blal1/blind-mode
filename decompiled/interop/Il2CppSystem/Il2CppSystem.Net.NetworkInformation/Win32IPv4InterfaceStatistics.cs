using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Net.NetworkInformation;

public class Win32IPv4InterfaceStatistics : IPv4InterfaceStatistics
{
	private static readonly System.IntPtr NativeFieldInfoPtr_info;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Win32_MIB_IFROW_0;

	public unsafe Win32_MIB_IFROW info
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info);
			return new Win32_MIB_IFROW(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_info), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Win32_MIB_IFROW>.NativeClassPtr, ref *(uint*)null));
		}
	}

	static Win32IPv4InterfaceStatistics()
	{
		Il2CppClassPointerStore<Win32IPv4InterfaceStatistics>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.NetworkInformation", "Win32IPv4InterfaceStatistics");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Win32IPv4InterfaceStatistics>.NativeClassPtr);
		NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Win32IPv4InterfaceStatistics>.NativeClassPtr, "info");
		NativeMethodInfoPtr__ctor_Public_Void_Win32_MIB_IFROW_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Win32IPv4InterfaceStatistics>.NativeClassPtr, 100667131);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 897221, XrefRangeEnd = 897223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Win32IPv4InterfaceStatistics(Win32_MIB_IFROW info)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Win32IPv4InterfaceStatistics>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)info));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Win32_MIB_IFROW_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Win32IPv4InterfaceStatistics(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
