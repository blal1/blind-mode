using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security;

public static class ASN1Convert : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0;

	static ASN1Convert()
	{
		Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security", "ASN1Convert");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr);
		NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663316);
		NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663317);
		NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663318);
		NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663319);
		NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663320);
		NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ASN1Convert>.NativeClassPtr, 100663321);
	}

	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 688675, RefRangeEnd = 688681, XrefRangeStart = 688636, XrefRangeEnd = 688675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ASN1 FromInt32(int value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromInt32_Public_Static_ASN1_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 688689, RefRangeEnd = 688697, XrefRangeStart = 688681, XrefRangeEnd = 688689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ASN1 FromOid(string oid)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromOid_Public_Static_ASN1_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 688706, RefRangeEnd = 688716, XrefRangeStart = 688697, XrefRangeEnd = 688706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ASN1 FromUnsignedBigInteger(Il2CppStructArray<byte> big)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)big);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromUnsignedBigInteger_Public_Static_ASN1_Il2CppStructArray_1_Byte_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 688722, RefRangeEnd = 688726, XrefRangeStart = 688716, XrefRangeEnd = 688722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int ToInt32(ASN1 asn1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asn1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToInt32_Public_Static_Int32_ASN1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(22)]
	[CachedScanResults(RefRangeStart = 688751, RefRangeEnd = 688773, XrefRangeStart = 688726, XrefRangeEnd = 688751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string ToOid(ASN1 asn1)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)asn1);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToOid_Public_Static_String_ASN1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 688792, RefRangeEnd = 688799, XrefRangeStart = 688773, XrefRangeEnd = 688792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppSystem.DateTime ToDateTime(ASN1 time)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)time);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_ASN1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Il2CppSystem.DateTime*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public ASN1Convert(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
