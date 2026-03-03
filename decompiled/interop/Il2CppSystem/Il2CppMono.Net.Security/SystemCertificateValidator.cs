using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppMono.Security.Interface;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Net.Security;

public static class SystemCertificateValidator : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_is_macosx;

	private static readonly System.IntPtr NativeFieldInfoPtr_s_flags;

	private static readonly System.IntPtr NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0;

	public unsafe static bool is_macosx
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_is_macosx, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_is_macosx, (void*)(&value));
		}
	}

	public unsafe static X509KeyUsageFlags s_flags
	{
		get
		{
			Unsafe.SkipInit(out X509KeyUsageFlags result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_s_flags, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_s_flags, (void*)(&value));
		}
	}

	static SystemCertificateValidator()
	{
		Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Net.Security", "SystemCertificateValidator");
		NativeFieldInfoPtr_is_macosx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, "is_macosx");
		NativeFieldInfoPtr_s_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, "s_flags");
		NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SystemCertificateValidator>.NativeClassPtr, 100663666);
	}

	[CallerCount(143)]
	[CachedScanResults(RefRangeStart = 9, RefRangeEnd = 152, XrefRangeStart = 9, XrefRangeEnd = 152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NeedsChain(MonoTlsSettings settings)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)settings);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NeedsChain_Internal_Static_Boolean_MonoTlsSettings_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public SystemCertificateValidator(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
