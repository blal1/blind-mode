using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface;

public class ValidationResult : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_trusted;

	private static readonly System.IntPtr NativeFieldInfoPtr_user_denied;

	private static readonly System.IntPtr NativeFieldInfoPtr_error_code;

	private static readonly System.IntPtr NativeFieldInfoPtr_policy_errors;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0;

	public unsafe bool trusted
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trusted);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_trusted)) = value;
		}
	}

	public unsafe bool user_denied
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_user_denied);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_user_denied)) = value;
		}
	}

	public unsafe int error_code
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error_code);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_error_code)) = value;
		}
	}

	public unsafe Il2CppSystem.Nullable<MonoSslPolicyErrors> policy_errors
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_policy_errors);
			return new Il2CppSystem.Nullable<MonoSslPolicyErrors>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<MonoSslPolicyErrors>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_policy_errors), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<MonoSslPolicyErrors>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool Trusted
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool UserDenied
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static ValidationResult()
	{
		Il2CppClassPointerStore<ValidationResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "ValidationResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr);
		NativeFieldInfoPtr_trusted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "trusted");
		NativeFieldInfoPtr_user_denied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "user_denied");
		NativeFieldInfoPtr_error_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "error_code");
		NativeFieldInfoPtr_policy_errors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, "policy_errors");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663620);
		NativeMethodInfoPtr_get_Trusted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663621);
		NativeMethodInfoPtr_get_UserDenied_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr, 100663622);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 693561, RefRangeEnd = 693563, XrefRangeStart = 693560, XrefRangeEnd = 693561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ValidationResult(bool trusted, bool user_denied, int error_code, Il2CppSystem.Nullable<MonoSslPolicyErrors> policy_errors)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidationResult>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&trusted);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &user_denied;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &error_code;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)policy_errors));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Int32_Nullable_1_MonoSslPolicyErrors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ValidationResult(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
