using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Protocol.Ntlm;

public static class NtlmSettings : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_defaultAuthLevel;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0;

	public unsafe static NtlmAuthLevel defaultAuthLevel
	{
		get
		{
			Unsafe.SkipInit(out NtlmAuthLevel result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultAuthLevel, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultAuthLevel, (void*)(&value));
		}
	}

	public unsafe static NtlmAuthLevel DefaultAuthLevel
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693317, XrefRangeEnd = 693321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(NtlmAuthLevel*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static NtlmSettings()
	{
		Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Protocol.Ntlm", "NtlmSettings");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr);
		NativeFieldInfoPtr_defaultAuthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr, "defaultAuthLevel");
		NativeMethodInfoPtr_get_DefaultAuthLevel_Public_Static_get_NtlmAuthLevel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NtlmSettings>.NativeClassPtr, 100663592);
	}

	public NtlmSettings(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
