using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct SHCoefficients
{
	private static readonly System.IntPtr NativeFieldInfoPtr_SHAr;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHAg;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHAb;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHBr;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHBg;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHBb;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHC;

	private static readonly System.IntPtr NativeFieldInfoPtr_ProbesOcclusion;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_Vector4_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSHA_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSHB_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetSHC_Private_Static_Vector4_SphericalHarmonicsL2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SHCoefficients_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0;

	[FieldOffset(0)]
	public Vector4 SHAr;

	[FieldOffset(16)]
	public Vector4 SHAg;

	[FieldOffset(32)]
	public Vector4 SHAb;

	[FieldOffset(48)]
	public Vector4 SHBr;

	[FieldOffset(64)]
	public Vector4 SHBg;

	[FieldOffset(80)]
	public Vector4 SHBb;

	[FieldOffset(96)]
	public Vector4 SHC;

	[FieldOffset(112)]
	public Vector4 ProbesOcclusion;

	static SHCoefficients()
	{
		Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SHCoefficients");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr);
		NativeFieldInfoPtr_SHAr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHAr");
		NativeFieldInfoPtr_SHAg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHAg");
		NativeFieldInfoPtr_SHAb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHAb");
		NativeFieldInfoPtr_SHBr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHBr");
		NativeFieldInfoPtr_SHBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHBg");
		NativeFieldInfoPtr_SHBb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHBb");
		NativeFieldInfoPtr_SHC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "SHC");
		NativeFieldInfoPtr_ProbesOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, "ProbesOcclusion");
		NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666349);
		NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666350);
		NativeMethodInfoPtr_GetSHA_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666351);
		NativeMethodInfoPtr_GetSHB_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666352);
		NativeMethodInfoPtr_GetSHC_Private_Static_Vector4_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666353);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SHCoefficients_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666354);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666355);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666356);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666357);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, 100666358);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1049965, RefRangeEnd = 1049967, XrefRangeStart = 1049933, XrefRangeEnd = 1049965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SHCoefficients(SphericalHarmonicsL2 sh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sh);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049967, XrefRangeEnd = 1049968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SHCoefficients(SphericalHarmonicsL2 sh, Vector4 probesOcclusion)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sh);
		*(Vector4**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &probesOcclusion;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_SphericalHarmonicsL2_Vector4_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049968, XrefRangeEnd = 1049973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetSHA(SphericalHarmonicsL2 sh, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSHA_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049973, XrefRangeEnd = 1049977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetSHB(SphericalHarmonicsL2 sh, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&sh);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSHB_Private_Static_Vector4_SphericalHarmonicsL2_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049977, XrefRangeEnd = 1049980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetSHC(SphericalHarmonicsL2 sh)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&sh);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetSHC_Private_Static_Vector4_SphericalHarmonicsL2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1049980, RefRangeEnd = 1049984, XrefRangeStart = 1049980, XrefRangeEnd = 1049980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(SHCoefficients other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SHCoefficients_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049984, XrefRangeEnd = 1049988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049988, XrefRangeEnd = 1049994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049994, XrefRangeEnd = 1049995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(SHCoefficients left, SHCoefficients right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(SHCoefficients**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049995, XrefRangeEnd = 1049996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(SHCoefficients left, SHCoefficients right)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&left);
		*(SHCoefficients**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &right;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SHCoefficients_SHCoefficients_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SHCoefficients>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
