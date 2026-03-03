using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls;

public class MonoBtlsX509Chain : MonoBtlsObject
{
	public class BoringX509ChainHandle : MonoBtlsHandle
	{
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0;

		static BoringX509ChainHandle()
		{
			Il2CppClassPointerStore<BoringX509ChainHandle>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, "BoringX509ChainHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoringX509ChainHandle>.NativeClassPtr);
			NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoringX509ChainHandle>.NativeClassPtr, 100663960);
		}

		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867144, XrefRangeEnd = 867146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReleaseHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_ReleaseHandle_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		public BoringX509ChainHandle(IntPtr pointer)
			: base(pointer)
		{
		}
	}

	private static readonly IntPtr NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509ChainHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_new_Private_Static_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_get_count_Private_Static_Int32_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_get_cert_Private_Static_IntPtr_IntPtr_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_add_cert_Private_Static_Int32_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_up_ref_Private_Static_IntPtr_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_x509_chain_free_Private_Static_Void_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BoringX509ChainHandle_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0;

	private static readonly IntPtr NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509Chain_0;

	public new unsafe BoringX509ChainHandle Handle
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 867149, RefRangeEnd = 867155, XrefRangeStart = 867146, XrefRangeEnd = 867149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509ChainHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoringX509ChainHandle>(intPtr2) : null;
		}
	}

	public unsafe int Count
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 867178, RefRangeEnd = 867181, XrefRangeStart = 867175, XrefRangeEnd = 867178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static MonoBtlsX509Chain()
	{
		Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsX509Chain");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr);
		NativeMethodInfoPtr_get_Handle_Internal_get_BoringX509ChainHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663946);
		NativeMethodInfoPtr_mono_btls_x509_chain_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663947);
		NativeMethodInfoPtr_mono_btls_x509_chain_get_count_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663948);
		NativeMethodInfoPtr_mono_btls_x509_chain_get_cert_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663949);
		NativeMethodInfoPtr_mono_btls_x509_chain_add_cert_Private_Static_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663950);
		NativeMethodInfoPtr_mono_btls_x509_chain_up_ref_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663951);
		NativeMethodInfoPtr_mono_btls_x509_chain_free_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663952);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663953);
		NativeMethodInfoPtr__ctor_Internal_Void_BoringX509ChainHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663954);
		NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663955);
		NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663956);
		NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663957);
		NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr, 100663958);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867155, XrefRangeEnd = 867157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_chain_new()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_chain_new_Private_Static_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867157, XrefRangeEnd = 867159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_chain_get_count(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_chain_get_count_Private_Static_Int32_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867159, XrefRangeEnd = 867161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&Handle);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &index;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_chain_get_cert_Private_Static_IntPtr_IntPtr_Int32_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867161, XrefRangeEnd = 867163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&chain);
		*(IntPtr**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &x509;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_chain_add_cert_Private_Static_Int32_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867163, XrefRangeEnd = 867165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_x509_chain_up_ref(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_chain_up_ref_Private_Static_IntPtr_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867165, XrefRangeEnd = 867167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void mono_btls_x509_chain_free(IntPtr handle)
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_x509_chain_free_Private_Static_Void_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 867174, RefRangeEnd = 867175, XrefRangeStart = 867167, XrefRangeEnd = 867174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Chain()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 628864, RefRangeEnd = 628865, XrefRangeStart = 628864, XrefRangeEnd = 628865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Chain(BoringX509ChainHandle handle)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsX509Chain>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)handle);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_BoringX509ChainHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 867196, RefRangeEnd = 867198, XrefRangeStart = 867181, XrefRangeEnd = 867196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509 GetCertificate(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&index);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCertificate_Public_MonoBtlsX509_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 867202, RefRangeEnd = 867205, XrefRangeStart = 867198, XrefRangeEnd = 867202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCertificate(MonoBtlsX509 x509)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)x509);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCertificate_Public_Void_MonoBtlsX509_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 867205, XrefRangeEnd = 867219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsX509Chain Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Copy_Internal_MonoBtlsX509Chain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MonoBtlsX509Chain>(intPtr2) : null;
	}

	public MonoBtlsX509Chain(IntPtr pointer)
		: base(pointer)
	{
	}
}
