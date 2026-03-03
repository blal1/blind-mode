using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Btls;

public class MonoBtlsX509StoreCtx : MonoBtlsObject
{
	public class BoringX509StoreCtxHandle : MonoBtlsHandle
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_dontFree;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

		private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		public unsafe bool dontFree
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontFree);
				return *(bool*)num;
			}
			set
			{
				*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_dontFree)) = value;
			}
		}

		static BoringX509StoreCtxHandle()
		{
			Il2CppClassPointerStore<BoringX509StoreCtxHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, "BoringX509StoreCtxHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoringX509StoreCtxHandle>.NativeClassPtr);
			NativeFieldInfoPtr_dontFree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoringX509StoreCtxHandle>.NativeClassPtr, "dontFree");
			NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509StoreCtxHandle>.NativeClassPtr, 100664052);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509StoreCtxHandle>.NativeClassPtr, 100664053);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoringX509StoreCtxHandle(System.IntPtr handle, bool ownsHandle = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoringX509StoreCtxHandle>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&handle);
			*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ownsHandle;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867732, XrefRangeEnd = 867734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BoringX509StoreCtxHandle(System.IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_verifyResult;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreCtxHandle_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_new_Private_Static_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_from_ptr_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_error_Private_Static_MonoBtlsX509Error_IntPtr_byref_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_chain_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_init_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_set_param_Private_Static_Int32_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_verify_cert_Private_Static_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_untrusted_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_up_ref_Private_Static_IntPtr_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_mono_btls_x509_store_ctx_free_Private_Static_Void_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreCtxHandle_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_IntPtr_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509StoreCtxHandle_Nullable_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetError_Public_MonoBtlsX509Error_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetChain_Public_MonoBtlsX509Chain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetUntrusted_Public_MonoBtlsX509Chain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MonoBtlsX509Store_MonoBtlsX509Chain_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_VerifyResult_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Verify_Public_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Copy_Public_MonoBtlsX509StoreCtx_0;

	public unsafe Il2CppSystem.Nullable<int> verifyResult
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verifyResult);
			return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_verifyResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public new unsafe BoringX509StoreCtxHandle Handle
	{
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 867737, RefRangeEnd = 867747, XrefRangeStart = 867734, XrefRangeEnd = 867737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreCtxHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoringX509StoreCtxHandle>(intPtr2) : null;
		}
	}

	public unsafe int VerifyResult
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867846, XrefRangeEnd = 867855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_VerifyResult_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MonoBtlsX509StoreCtx()
	{
		Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509StoreCtx");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr);
		NativeFieldInfoPtr_verifyResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, "verifyResult");
		NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509StoreCtxHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664029);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664030);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_from_ptr_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664031);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_error_Private_Static_MonoBtlsX509Error_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664032);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_chain_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664033);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_init_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664034);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_set_param_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664035);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_verify_cert_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664036);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_untrusted_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664037);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr_mono_btls_x509_store_ctx_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664039);
		NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664040);
		NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreCtxHandle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664041);
		NativeMethodInfoPtr__ctor_Internal_Void_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664042);
		NativeMethodInfoPtr__ctor_Internal_Void_BoringX509StoreCtxHandle_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664043);
		NativeMethodInfoPtr_GetError_Public_MonoBtlsX509Error_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664044);
		NativeMethodInfoPtr_GetChain_Public_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664045);
		NativeMethodInfoPtr_GetUntrusted_Public_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664046);
		NativeMethodInfoPtr_Initialize_Public_Void_MonoBtlsX509Store_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664047);
		NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664048);
		NativeMethodInfoPtr_get_VerifyResult_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664049);
		NativeMethodInfoPtr_Verify_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664050);
		NativeMethodInfoPtr_Copy_Public_MonoBtlsX509StoreCtx_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr, 100664051);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867747, XrefRangeEnd = 867749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr mono_btls_x509_store_ctx_new()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_new_Private_Static_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867749, XrefRangeEnd = 867751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr mono_btls_x509_store_ctx_from_ptr(System.IntPtr ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_from_ptr_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867751, XrefRangeEnd = 867753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(System.IntPtr handle, out System.IntPtr error_string)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref error_string);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_error_Private_Static_MonoBtlsX509Error_IntPtr_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MonoBtlsX509Error*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867753, XrefRangeEnd = 867755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr mono_btls_x509_store_ctx_get_chain(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_chain_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867755, XrefRangeEnd = 867757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_store_ctx_init(System.IntPtr handle, System.IntPtr store, System.IntPtr chain)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&handle);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &store;
		*(System.IntPtr**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &chain;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_init_Private_Static_Int32_IntPtr_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867757, XrefRangeEnd = 867759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_store_ctx_set_param(System.IntPtr handle, System.IntPtr param)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&handle);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &param;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_set_param_Private_Static_Int32_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867759, XrefRangeEnd = 867761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_store_ctx_verify_cert(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_verify_cert_Private_Static_Int32_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867761, XrefRangeEnd = 867763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr mono_btls_x509_store_ctx_get_untrusted(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_get_untrusted_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867763, XrefRangeEnd = 867765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static System.IntPtr mono_btls_x509_store_ctx_up_ref(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_up_ref_Private_Static_IntPtr_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(System.IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867765, XrefRangeEnd = 867767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_x509_store_ctx_free(System.IntPtr handle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_store_ctx_free_Private_Static_Void_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867774, RefRangeEnd = 867776, XrefRangeStart = 867767, XrefRangeEnd = 867774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509StoreCtx()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867776, XrefRangeEnd = 867782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static BoringX509StoreCtxHandle Create_internal(System.IntPtr store_ctx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&store_ctx);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Create_internal_Private_Static_BoringX509StoreCtxHandle_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoringX509StoreCtxHandle>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867782, XrefRangeEnd = 867792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509StoreCtx(int preverify_ok, System.IntPtr store_ctx)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&preverify_ok);
		*(System.IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &store_ctx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_Int32_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867792, XrefRangeEnd = 867793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509StoreCtx(BoringX509StoreCtxHandle ptr, Il2CppSystem.Nullable<int> verifyResult)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509StoreCtx>.NativeClassPtr))
	{
		System.IntPtr* ptr2 = stackalloc System.IntPtr[2];
		*ptr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)ptr);
		*(System.IntPtr*)((byte*)ptr2 + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)verifyResult));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BoringX509StoreCtxHandle_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr2, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867796, RefRangeEnd = 867797, XrefRangeStart = 867793, XrefRangeEnd = 867796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Error GetError()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetError_Public_MonoBtlsX509Error_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(MonoBtlsX509Error*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867797, XrefRangeEnd = 867811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Chain GetChain()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetChain_Public_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867811, XrefRangeEnd = 867825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Chain GetUntrusted()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetUntrusted_Public_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr2) : null;
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867834, RefRangeEnd = 867836, XrefRangeStart = 867825, XrefRangeEnd = 867834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)store);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)chain);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initialize_Public_Void_MonoBtlsX509Store_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867844, RefRangeEnd = 867846, XrefRangeStart = 867836, XrefRangeEnd = 867844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVerifyParam(MonoBtlsX509VerifyParam param)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)param);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetVerifyParam_Public_Void_MonoBtlsX509VerifyParam_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867864, RefRangeEnd = 867866, XrefRangeStart = 867855, XrefRangeEnd = 867864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int Verify()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Verify_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867866, XrefRangeEnd = 867880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509StoreCtx Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Public_MonoBtlsX509StoreCtx_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509StoreCtx>(intPtr2) : null;
	}

	public MonoBtlsX509StoreCtx(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
