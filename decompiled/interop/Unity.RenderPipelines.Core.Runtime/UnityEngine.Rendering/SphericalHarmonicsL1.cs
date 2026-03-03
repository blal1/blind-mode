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
public struct SphericalHarmonicsL1
{
	private static readonly System.IntPtr NativeFieldInfoPtr_shAr;

	private static readonly System.IntPtr NativeFieldInfoPtr_shAg;

	private static readonly System.IntPtr NativeFieldInfoPtr_shAb;

	private static readonly System.IntPtr NativeFieldInfoPtr_zero;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public Vector4 shAr;

	[FieldOffset(16)]
	public Vector4 shAg;

	[FieldOffset(32)]
	public Vector4 shAb;

	public unsafe static SphericalHarmonicsL1 zero
	{
		get
		{
			Unsafe.SkipInit(out SphericalHarmonicsL1 result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_zero, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_zero, (void*)(&value));
		}
	}

	static SphericalHarmonicsL1()
	{
		Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SphericalHarmonicsL1");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr);
		NativeFieldInfoPtr_shAr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "shAr");
		NativeFieldInfoPtr_shAg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "shAg");
		NativeFieldInfoPtr_shAb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "shAb");
		NativeFieldInfoPtr_zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, "zero");
		NativeMethodInfoPtr_op_Addition_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665895);
		NativeMethodInfoPtr_op_Subtraction_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665896);
		NativeMethodInfoPtr_op_Multiply_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665897);
		NativeMethodInfoPtr_op_Division_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665898);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665899);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665900);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665901);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, 100665902);
	}

	[CallerCount(0)]
	public unsafe static SphericalHarmonicsL1 operator +(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(SphericalHarmonicsL1**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Addition_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SphericalHarmonicsL1*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static SphericalHarmonicsL1 operator -(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(SphericalHarmonicsL1**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Subtraction_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_SphericalHarmonicsL1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SphericalHarmonicsL1*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static SphericalHarmonicsL1 operator *(SphericalHarmonicsL1 lhs, float rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SphericalHarmonicsL1*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static SphericalHarmonicsL1 operator /(SphericalHarmonicsL1 lhs, float rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Division_Public_Static_SphericalHarmonicsL1_SphericalHarmonicsL1_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(SphericalHarmonicsL1*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1045542, RefRangeEnd = 1045544, XrefRangeStart = 1045542, XrefRangeEnd = 1045542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(SphericalHarmonicsL1**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045544, XrefRangeEnd = 1045548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(SphericalHarmonicsL1 lhs, SphericalHarmonicsL1 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(SphericalHarmonicsL1**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL1_SphericalHarmonicsL1_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045548, XrefRangeEnd = 1045554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1045554, XrefRangeEnd = 1045566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphericalHarmonicsL1>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
