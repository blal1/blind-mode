using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net;

public class SystemNetworkCredential : NetworkCredential
{
	private static readonly System.IntPtr NativeFieldInfoPtr_defaultCredential;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

	public unsafe static SystemNetworkCredential defaultCredential
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultCredential, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<SystemNetworkCredential>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultCredential, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static SystemNetworkCredential()
	{
		Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "SystemNetworkCredential");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr);
		NativeFieldInfoPtr_defaultCredential = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, "defaultCredential");
		NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr, 100666119);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 887623, XrefRangeEnd = 887631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SystemNetworkCredential()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SystemNetworkCredential>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SystemNetworkCredential(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
