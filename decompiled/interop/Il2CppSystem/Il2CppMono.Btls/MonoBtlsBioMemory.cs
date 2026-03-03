using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppMono.Btls;

public class MonoBtlsBioMemory : MonoBtlsBio
{
	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_mem_new_Private_Static_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr_mono_btls_bio_mem_get_data_Private_Static_Int32_IntPtr_byref_IntPtr_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_0;

	static MonoBtlsBioMemory()
	{
		Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Btls", "MonoBtlsBioMemory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr);
		NativeMethodInfoPtr_mono_btls_bio_mem_new_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663688);
		NativeMethodInfoPtr_mono_btls_bio_mem_get_data_Private_Static_Int32_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663689);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663690);
		NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr, 100663691);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864847, XrefRangeEnd = 864849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static IntPtr mono_btls_bio_mem_new()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_bio_mem_new_Private_Static_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(IntPtr*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864849, XrefRangeEnd = 864851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data)
	{
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&handle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_mono_btls_bio_mem_get_data_Private_Static_Int32_IntPtr_byref_IntPtr_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864859, RefRangeEnd = 864860, XrefRangeStart = 864851, XrefRangeEnd = 864859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBtlsBioMemory()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBtlsBioMemory>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 864879, RefRangeEnd = 864880, XrefRangeStart = 864860, XrefRangeEnd = 864879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppStructArray<byte> GetData()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetData_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
	}

	public MonoBtlsBioMemory(IntPtr pointer)
		: base(pointer)
	{
	}
}
