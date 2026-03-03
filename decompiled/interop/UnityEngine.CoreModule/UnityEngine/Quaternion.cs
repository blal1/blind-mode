using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Quaternion
{
	private delegate void FromToRotation_InjectedDelegate([In] System.IntPtr fromDirection, [In] System.IntPtr toDirection, [Out] System.IntPtr ret);

	private delegate void LerpUnclamped_InjectedDelegate([In] System.IntPtr a, [In] System.IntPtr b, float t, [Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeFieldInfoPtr_x;

	private static readonly System.IntPtr NativeFieldInfoPtr_y;

	private static readonly System.IntPtr NativeFieldInfoPtr_z;

	private static readonly System.IntPtr NativeFieldInfoPtr_w;

	private static readonly System.IntPtr NativeFieldInfoPtr_identityQuaternion;

	private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilon;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0;

	[FieldOffset(0)]
	public float x;

	[FieldOffset(4)]
	public float y;

	[FieldOffset(8)]
	public float z;

	[FieldOffset(12)]
	public float w;

	private static readonly FromToRotation_InjectedDelegate FromToRotation_InjectedDelegateField;

	private static readonly LerpUnclamped_InjectedDelegate LerpUnclamped_InjectedDelegateField;

	public unsafe static Quaternion identityQuaternion
	{
		get
		{
			Unsafe.SkipInit(out Quaternion result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_identityQuaternion, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_identityQuaternion, (void*)(&value));
		}
	}

	public unsafe static float kEpsilon
	{
		get
		{
			Unsafe.SkipInit(out float result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kEpsilon, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kEpsilon, (void*)(&value));
		}
	}

	public unsafe static Quaternion identity
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183914, XrefRangeEnd = 1183916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Vector3 eulerAngles
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183993, XrefRangeEnd = 1183998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		set
		{
			this = Internal_FromEulerRad(value * (MathF.PI / 180f));
		}
	}

	public float this[int index]
	{
		get
		{
			return index switch
			{
				0 => x, 
				1 => y, 
				2 => z, 
				3 => w, 
				_ => throw new Il2CppSystem.IndexOutOfRangeException("Invalid Quaternion index!"), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				x = value;
				break;
			case 1:
				y = value;
				break;
			case 2:
				z = value;
				break;
			case 3:
				w = value;
				break;
			default:
				throw new Il2CppSystem.IndexOutOfRangeException("Invalid Quaternion index!");
			}
		}
	}

	public Quaternion normalized => Normalize(this);

	static Quaternion()
	{
		Il2CppClassPointerStore<Quaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Quaternion");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Quaternion>.NativeClassPtr);
		NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "x");
		NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "y");
		NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "z");
		NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "w");
		NativeFieldInfoPtr_identityQuaternion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "identityQuaternion");
		NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, "kEpsilon");
		NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665751);
		NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665752);
		NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665753);
		NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665754);
		NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665755);
		NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665756);
		NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665757);
		NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665758);
		NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665759);
		NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665760);
		NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665761);
		NativeMethodInfoPtr_get_identity_Public_Static_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665762);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665763);
		NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665764);
		NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665765);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665766);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665767);
		NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665768);
		NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665769);
		NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665770);
		NativeMethodInfoPtr_get_eulerAngles_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665771);
		NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665772);
		NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665773);
		NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665774);
		NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665775);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665776);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665777);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665778);
		NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665779);
		NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665780);
		NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665782);
		NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665783);
		NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665784);
		NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665785);
		NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665786);
		NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665787);
		NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665788);
		NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665789);
		NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, 100665790);
		FromToRotation_InjectedDelegateField = IL2CPP.ResolveICall<FromToRotation_InjectedDelegate>("UnityEngine.Quaternion::FromToRotation_Injected");
		LerpUnclamped_InjectedDelegateField = IL2CPP.ResolveICall<LerpUnclamped_InjectedDelegate>("UnityEngine.Quaternion::LerpUnclamped_Injected");
	}

	[CallerCount(16)]
	[CachedScanResults(RefRangeStart = 1183676, RefRangeEnd = 1183692, XrefRangeStart = 1183674, XrefRangeEnd = 1183676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Inverse(Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inverse_Public_Static_Quaternion_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1183694, RefRangeEnd = 1183703, XrefRangeStart = 1183692, XrefRangeEnd = 1183694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Slerp(Quaternion a, Quaternion b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Slerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1183705, RefRangeEnd = 1183707, XrefRangeStart = 1183703, XrefRangeEnd = 1183705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlerpUnclamped_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 1183709, RefRangeEnd = 1183723, XrefRangeStart = 1183707, XrefRangeEnd = 1183709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Lerp(Quaternion a, Quaternion b, float t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&a);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lerp_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(116)]
	[CachedScanResults(RefRangeStart = 1183725, RefRangeEnd = 1183841, XrefRangeStart = 1183723, XrefRangeEnd = 1183725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Internal_FromEulerRad(Vector3 euler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&euler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_FromEulerRad_Private_Static_Quaternion_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 1183843, RefRangeEnd = 1183876, XrefRangeStart = 1183841, XrefRangeEnd = 1183843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Internal_ToEulerRad(Quaternion rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&rotation);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ToEulerRad_Private_Static_Vector3_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1183878, RefRangeEnd = 1183879, XrefRangeStart = 1183876, XrefRangeEnd = 1183878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&q);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref axis);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref angle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ToAxisAngleRad_Private_Static_Void_Quaternion_byref_Vector3_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 1183881, RefRangeEnd = 1183888, XrefRangeStart = 1183879, XrefRangeEnd = 1183881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion AngleAxis(float angle, Vector3 axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&angle);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &axis;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleAxis_Public_Static_Quaternion_Single_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 1183890, RefRangeEnd = 1183899, XrefRangeStart = 1183888, XrefRangeEnd = 1183890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion LookRotation(Vector3 forward, Vector3 upwards)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&forward);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &upwards;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 1183903, RefRangeEnd = 1183914, XrefRangeStart = 1183899, XrefRangeEnd = 1183903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion LookRotation(Vector3 forward)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&forward);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookRotation_Public_Static_Quaternion_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 1023627, RefRangeEnd = 1023632, XrefRangeStart = 1023627, XrefRangeEnd = 1023632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Quaternion(float x, float y, float z, float w)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &w;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static Quaternion operator *(Quaternion lhs, Quaternion rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Quaternion_Quaternion_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(39)]
	[CachedScanResults(RefRangeStart = 1183916, RefRangeEnd = 1183955, XrefRangeStart = 1183916, XrefRangeEnd = 1183916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 operator *(Quaternion rotation, Vector3 point)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&rotation);
		*(Vector3**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &point;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3_Quaternion_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool IsEqualUsingDot(float dot)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&dot);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsEqualUsingDot_Private_Static_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool operator ==(Quaternion lhs, Quaternion rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Quaternion_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1183955, RefRangeEnd = 1183957, XrefRangeStart = 1183955, XrefRangeEnd = 1183955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(Quaternion lhs, Quaternion rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Quaternion_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Dot(Quaternion a, Quaternion b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dot_Public_Static_Single_Quaternion_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static float Angle(Quaternion a, Quaternion b)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&a);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &b;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Angle_Public_Static_Single_Quaternion_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(33)]
	[CachedScanResults(RefRangeStart = 1183960, RefRangeEnd = 1183993, XrefRangeStart = 1183957, XrefRangeEnd = 1183960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector3 Internal_MakePositive(Vector3 euler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&euler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_MakePositive_Private_Static_Vector3_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector3*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1183998, XrefRangeEnd = 1184000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Euler(float x, float y, float z)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&x);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &z;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184000, XrefRangeEnd = 1184002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion Euler(Vector3 euler)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&euler);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Euler_Public_Static_Quaternion_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184002, XrefRangeEnd = 1184004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToAngleAxis(out float angle, out Vector3 axis)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref angle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref axis);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToAngleAxis_Public_Void_byref_Single_byref_Vector3_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184004, XrefRangeEnd = 1184008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&from);
		*(Quaternion**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &to;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxDegreesDelta;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RotateTowards_Public_Static_Quaternion_Quaternion_Quaternion_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Quaternion*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 1184012, RefRangeEnd = 1184020, XrefRangeStart = 1184008, XrefRangeEnd = 1184012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184020, XrefRangeEnd = 1184027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(Quaternion other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Quaternion_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184027, XrefRangeEnd = 1184030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184030, XrefRangeEnd = 1184065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)formatProvider);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184065, XrefRangeEnd = 1184067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Inverse_Injected([In] ref Quaternion rotation, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref rotation);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Inverse_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184067, XrefRangeEnd = 1184069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Slerp_Injected([In] ref Quaternion a, [In] ref Quaternion b, float t, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref b);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Slerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184069, XrefRangeEnd = 1184071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SlerpUnclamped_Injected([In] ref Quaternion a, [In] ref Quaternion b, float t, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref b);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SlerpUnclamped_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184071, XrefRangeEnd = 1184073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Lerp_Injected([In] ref Quaternion a, [In] ref Quaternion b, float t, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)Unsafe.AsPointer(ref a);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref b);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &t;
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Lerp_Injected_Private_Static_Void_byref_Quaternion_byref_Quaternion_Single_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184073, XrefRangeEnd = 1184075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_FromEulerRad_Injected([In] ref Vector3 euler, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref euler);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_FromEulerRad_Injected_Private_Static_Void_byref_Vector3_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184075, XrefRangeEnd = 1184077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ToEulerRad_Injected([In] ref Quaternion rotation, out Vector3 ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref rotation);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ToEulerRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184077, XrefRangeEnd = 1184079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Internal_ToAxisAngleRad_Injected([In] ref Quaternion q, out Vector3 axis, out float angle)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref q);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref axis);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref angle);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Internal_ToAxisAngleRad_Injected_Private_Static_Void_byref_Quaternion_byref_Vector3_byref_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184079, XrefRangeEnd = 1184081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AngleAxis_Injected(float angle, [In] ref Vector3 axis, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&angle);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref axis);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AngleAxis_Injected_Private_Static_Void_Single_byref_Vector3_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1184081, XrefRangeEnd = 1184083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void LookRotation_Injected([In] ref Vector3 forward, [In] ref Vector3 upwards, out Quaternion ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)Unsafe.AsPointer(ref forward);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref upwards);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LookRotation_Injected_Private_Static_Void_byref_Vector3_byref_Vector3_byref_Quaternion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Quaternion>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
	{
		FromToRotation_Injected(ref fromDirection, ref toDirection, out var ret);
		return ret;
	}

	public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
	{
		LerpUnclamped_Injected(ref a, ref b, t, out var ret);
		return ret;
	}

	public void Set(float newX, float newY, float newZ, float newW)
	{
		x = newX;
		y = newY;
		z = newZ;
		w = newW;
	}

	public void SetLookRotation(Vector3 view)
	{
		Vector3 up = Vector3.up;
		SetLookRotation(view, up);
	}

	public void SetLookRotation(Vector3 view, Vector3 up)
	{
		this = LookRotation(view, up);
	}

	public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
	{
		this = FromToRotation(fromDirection, toDirection);
	}

	public static Quaternion Normalize(Quaternion q)
	{
		float num = Mathf.Sqrt(Dot(q, q));
		if (num < Mathf.Epsilon)
		{
			return identity;
		}
		return new Quaternion(q.x / num, q.y / num, q.z / num, q.w / num);
	}

	public void Normalize()
	{
		this = Normalize(this);
	}

	public string ToString(string format)
	{
		return ToString(format, null);
	}

	public static Quaternion EulerRotation(float x, float y, float z)
	{
		return Internal_FromEulerRad(new Vector3(x, y, z));
	}

	public static Quaternion EulerRotation(Vector3 euler)
	{
		return Internal_FromEulerRad(euler);
	}

	public void SetEulerRotation(float x, float y, float z)
	{
		this = Internal_FromEulerRad(new Vector3(x, y, z));
	}

	public void SetEulerRotation(Vector3 euler)
	{
		this = Internal_FromEulerRad(euler);
	}

	public Vector3 ToEuler()
	{
		return Internal_ToEulerRad(this);
	}

	public static Quaternion EulerAngles(float x, float y, float z)
	{
		return Internal_FromEulerRad(new Vector3(x, y, z));
	}

	public static Quaternion EulerAngles(Vector3 euler)
	{
		return Internal_FromEulerRad(euler);
	}

	public void ToAxisAngle(out Vector3 axis, out float angle)
	{
		Internal_ToAxisAngleRad(this, out axis, out angle);
	}

	public void SetEulerAngles(float x, float y, float z)
	{
		SetEulerRotation(new Vector3(x, y, z));
	}

	public void SetEulerAngles(Vector3 euler)
	{
		this = EulerRotation(euler);
	}

	public static Vector3 ToEulerAngles(Quaternion rotation)
	{
		return Internal_ToEulerRad(rotation);
	}

	public Vector3 ToEulerAngles()
	{
		return Internal_ToEulerRad(this);
	}

	public void SetAxisAngle(Vector3 axis, float angle)
	{
		this = AxisAngle(axis, angle);
	}

	public static Quaternion AxisAngle(Vector3 axis, float angle)
	{
		return AngleAxis(57.29578f * angle, axis);
	}

	public unsafe static void FromToRotation_Injected([In] ref Vector3 fromDirection, [In] ref Vector3 toDirection, out Quaternion ret)
	{
		FromToRotation_InjectedDelegateField((nint)Unsafe.AsPointer(ref fromDirection), (nint)Unsafe.AsPointer(ref toDirection), (nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void LerpUnclamped_Injected([In] ref Quaternion a, [In] ref Quaternion b, float t, out Quaternion ret)
	{
		LerpUnclamped_InjectedDelegateField((nint)Unsafe.AsPointer(ref a), (nint)Unsafe.AsPointer(ref b), t, (nint)Unsafe.AsPointer(ref ret));
	}
}
