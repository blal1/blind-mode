using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SphericalHarmonicsL2
{
	private delegate void SetZeroDelegate(System.IntPtr @this);

	private delegate void AddAmbientLight_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr color);

	private delegate void AddDirectionalLightInternal_InjectedDelegate(System.IntPtr sh, [In] System.IntPtr direction, [In] System.IntPtr color);

	private delegate void EvaluateInternal_InjectedDelegate(System.IntPtr sh, System.IntPtr directions, [Out] System.IntPtr results);

	private static readonly System.IntPtr NativeFieldInfoPtr_shr0;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr1;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr2;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr3;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr4;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr5;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr6;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr7;

	private static readonly System.IntPtr NativeFieldInfoPtr_shr8;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg0;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg1;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg2;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg3;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg4;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg5;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg6;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg7;

	private static readonly System.IntPtr NativeFieldInfoPtr_shg8;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb0;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb1;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb2;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb3;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb4;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb5;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb6;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb7;

	private static readonly System.IntPtr NativeFieldInfoPtr_shb8;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0;

	[FieldOffset(0)]
	public float shr0;

	[FieldOffset(4)]
	public float shr1;

	[FieldOffset(8)]
	public float shr2;

	[FieldOffset(12)]
	public float shr3;

	[FieldOffset(16)]
	public float shr4;

	[FieldOffset(20)]
	public float shr5;

	[FieldOffset(24)]
	public float shr6;

	[FieldOffset(28)]
	public float shr7;

	[FieldOffset(32)]
	public float shr8;

	[FieldOffset(36)]
	public float shg0;

	[FieldOffset(40)]
	public float shg1;

	[FieldOffset(44)]
	public float shg2;

	[FieldOffset(48)]
	public float shg3;

	[FieldOffset(52)]
	public float shg4;

	[FieldOffset(56)]
	public float shg5;

	[FieldOffset(60)]
	public float shg6;

	[FieldOffset(64)]
	public float shg7;

	[FieldOffset(68)]
	public float shg8;

	[FieldOffset(72)]
	public float shb0;

	[FieldOffset(76)]
	public float shb1;

	[FieldOffset(80)]
	public float shb2;

	[FieldOffset(84)]
	public float shb3;

	[FieldOffset(88)]
	public float shb4;

	[FieldOffset(92)]
	public float shb5;

	[FieldOffset(96)]
	public float shb6;

	[FieldOffset(100)]
	public float shb7;

	[FieldOffset(104)]
	public float shb8;

	private static readonly SetZeroDelegate SetZeroDelegateField;

	private static readonly AddAmbientLight_InjectedDelegate AddAmbientLight_InjectedDelegateField;

	private static readonly AddDirectionalLightInternal_InjectedDelegate AddDirectionalLightInternal_InjectedDelegateField;

	private static readonly EvaluateInternal_InjectedDelegate EvaluateInternal_InjectedDelegateField;

	public unsafe float this[int rgb, int coefficient]
	{
		[CallerCount(72)]
		[CachedScanResults(RefRangeStart = 1237217, RefRangeEnd = 1237289, XrefRangeStart = 1237217, XrefRangeEnd = 1237217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[2];
			*ptr = (nint)(&rgb);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coefficient;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 1237289, RefRangeEnd = 1237313, XrefRangeStart = 1237289, XrefRangeEnd = 1237289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[3];
			*ptr = (nint)(&rgb);
			*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &coefficient;
			*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &value;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static SphericalHarmonicsL2()
	{
		Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "SphericalHarmonicsL2");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr);
		NativeFieldInfoPtr_shr0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr0");
		NativeFieldInfoPtr_shr1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr1");
		NativeFieldInfoPtr_shr2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr2");
		NativeFieldInfoPtr_shr3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr3");
		NativeFieldInfoPtr_shr4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr4");
		NativeFieldInfoPtr_shr5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr5");
		NativeFieldInfoPtr_shr6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr6");
		NativeFieldInfoPtr_shr7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr7");
		NativeFieldInfoPtr_shr8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shr8");
		NativeFieldInfoPtr_shg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg0");
		NativeFieldInfoPtr_shg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg1");
		NativeFieldInfoPtr_shg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg2");
		NativeFieldInfoPtr_shg3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg3");
		NativeFieldInfoPtr_shg4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg4");
		NativeFieldInfoPtr_shg5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg5");
		NativeFieldInfoPtr_shg6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg6");
		NativeFieldInfoPtr_shg7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg7");
		NativeFieldInfoPtr_shg8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shg8");
		NativeFieldInfoPtr_shb0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb0");
		NativeFieldInfoPtr_shb1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb1");
		NativeFieldInfoPtr_shb2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb2");
		NativeFieldInfoPtr_shb3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb3");
		NativeFieldInfoPtr_shb4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb4");
		NativeFieldInfoPtr_shb5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb5");
		NativeFieldInfoPtr_shb6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb6");
		NativeFieldInfoPtr_shb7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb7");
		NativeFieldInfoPtr_shb8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, "shb8");
		NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668291);
		NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668292);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668293);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668294);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668295);
		NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668296);
		NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100668297);
		SetZeroDelegateField = IL2CPP.ResolveICall<SetZeroDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::SetZero");
		AddAmbientLight_InjectedDelegateField = IL2CPP.ResolveICall<AddAmbientLight_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddAmbientLight_Injected");
		AddDirectionalLightInternal_InjectedDelegateField = IL2CPP.ResolveICall<AddDirectionalLightInternal_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddDirectionalLightInternal_Injected");
		EvaluateInternal_InjectedDelegateField = IL2CPP.ResolveICall<EvaluateInternal_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::EvaluateInternal_Injected");
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237313, XrefRangeEnd = 1237340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237340, XrefRangeEnd = 1237344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1237344, XrefRangeEnd = 1237345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool Equals(SphericalHarmonicsL2 other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1237345, RefRangeEnd = 1237348, XrefRangeStart = 1237345, XrefRangeEnd = 1237345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(SphericalHarmonicsL2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1237349, RefRangeEnd = 1237350, XrefRangeStart = 1237348, XrefRangeEnd = 1237349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&lhs);
		*(SphericalHarmonicsL2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rhs;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void Clear()
	{
		SetZero();
	}

	public unsafe void SetZero()
	{
		//IL_000b: Expected O, but got Ref
		SetZeroDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)Unsafe.AsPointer(ref this)));
	}

	public void AddAmbientLight(Color color)
	{
		AddAmbientLight_Injected(ref this, ref color);
	}

	public void AddDirectionalLight(Vector3 direction, Color color, float intensity)
	{
		Color color2 = color * (2f * intensity);
		AddDirectionalLightInternal(ref this, direction, color2);
	}

	public static void AddDirectionalLightInternal(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color)
	{
		AddDirectionalLightInternal_Injected(ref sh, ref direction, ref color);
	}

	public void Evaluate(Il2CppStructArray<Vector3> directions, Il2CppStructArray<Color> results)
	{
		if (directions == null)
		{
			throw new Il2CppSystem.ArgumentNullException("directions");
		}
		if (results == null)
		{
			throw new Il2CppSystem.ArgumentNullException("results");
		}
		if (((Il2CppArrayBase)directions).Length != 0)
		{
			if (((Il2CppArrayBase)directions).Length != ((Il2CppArrayBase)results).Length)
			{
				throw new Il2CppSystem.ArgumentException("Length of the directions array and the results array must match.");
			}
			EvaluateInternal(ref this, directions, results);
		}
	}

	public static void EvaluateInternal(ref SphericalHarmonicsL2 sh, Il2CppStructArray<Vector3> directions, [Out] Il2CppStructArray<Color> results)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public static SphericalHarmonicsL2 operator *(SphericalHarmonicsL2 lhs, float rhs)
	{
		SphericalHarmonicsL2 result = default(SphericalHarmonicsL2);
		result.shr0 = lhs.shr0 * rhs;
		result.shr1 = lhs.shr1 * rhs;
		result.shr2 = lhs.shr2 * rhs;
		result.shr3 = lhs.shr3 * rhs;
		result.shr4 = lhs.shr4 * rhs;
		result.shr5 = lhs.shr5 * rhs;
		result.shr6 = lhs.shr6 * rhs;
		result.shr7 = lhs.shr7 * rhs;
		result.shr8 = lhs.shr8 * rhs;
		result.shg0 = lhs.shg0 * rhs;
		result.shg1 = lhs.shg1 * rhs;
		result.shg2 = lhs.shg2 * rhs;
		result.shg3 = lhs.shg3 * rhs;
		result.shg4 = lhs.shg4 * rhs;
		result.shg5 = lhs.shg5 * rhs;
		result.shg6 = lhs.shg6 * rhs;
		result.shg7 = lhs.shg7 * rhs;
		result.shg8 = lhs.shg8 * rhs;
		result.shb0 = lhs.shb0 * rhs;
		result.shb1 = lhs.shb1 * rhs;
		result.shb2 = lhs.shb2 * rhs;
		result.shb3 = lhs.shb3 * rhs;
		result.shb4 = lhs.shb4 * rhs;
		result.shb5 = lhs.shb5 * rhs;
		result.shb6 = lhs.shb6 * rhs;
		result.shb7 = lhs.shb7 * rhs;
		result.shb8 = lhs.shb8 * rhs;
		return result;
	}

	public static SphericalHarmonicsL2 operator *(float lhs, SphericalHarmonicsL2 rhs)
	{
		SphericalHarmonicsL2 result = default(SphericalHarmonicsL2);
		result.shr0 = rhs.shr0 * lhs;
		result.shr1 = rhs.shr1 * lhs;
		result.shr2 = rhs.shr2 * lhs;
		result.shr3 = rhs.shr3 * lhs;
		result.shr4 = rhs.shr4 * lhs;
		result.shr5 = rhs.shr5 * lhs;
		result.shr6 = rhs.shr6 * lhs;
		result.shr7 = rhs.shr7 * lhs;
		result.shr8 = rhs.shr8 * lhs;
		result.shg0 = rhs.shg0 * lhs;
		result.shg1 = rhs.shg1 * lhs;
		result.shg2 = rhs.shg2 * lhs;
		result.shg3 = rhs.shg3 * lhs;
		result.shg4 = rhs.shg4 * lhs;
		result.shg5 = rhs.shg5 * lhs;
		result.shg6 = rhs.shg6 * lhs;
		result.shg7 = rhs.shg7 * lhs;
		result.shg8 = rhs.shg8 * lhs;
		result.shb0 = rhs.shb0 * lhs;
		result.shb1 = rhs.shb1 * lhs;
		result.shb2 = rhs.shb2 * lhs;
		result.shb3 = rhs.shb3 * lhs;
		result.shb4 = rhs.shb4 * lhs;
		result.shb5 = rhs.shb5 * lhs;
		result.shb6 = rhs.shb6 * lhs;
		result.shb7 = rhs.shb7 * lhs;
		result.shb8 = rhs.shb8 * lhs;
		return result;
	}

	public static SphericalHarmonicsL2 operator +(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
	{
		SphericalHarmonicsL2 result = default(SphericalHarmonicsL2);
		result.shr0 = lhs.shr0 + rhs.shr0;
		result.shr1 = lhs.shr1 + rhs.shr1;
		result.shr2 = lhs.shr2 + rhs.shr2;
		result.shr3 = lhs.shr3 + rhs.shr3;
		result.shr4 = lhs.shr4 + rhs.shr4;
		result.shr5 = lhs.shr5 + rhs.shr5;
		result.shr6 = lhs.shr6 + rhs.shr6;
		result.shr7 = lhs.shr7 + rhs.shr7;
		result.shr8 = lhs.shr8 + rhs.shr8;
		result.shg0 = lhs.shg0 + rhs.shg0;
		result.shg1 = lhs.shg1 + rhs.shg1;
		result.shg2 = lhs.shg2 + rhs.shg2;
		result.shg3 = lhs.shg3 + rhs.shg3;
		result.shg4 = lhs.shg4 + rhs.shg4;
		result.shg5 = lhs.shg5 + rhs.shg5;
		result.shg6 = lhs.shg6 + rhs.shg6;
		result.shg7 = lhs.shg7 + rhs.shg7;
		result.shg8 = lhs.shg8 + rhs.shg8;
		result.shb0 = lhs.shb0 + rhs.shb0;
		result.shb1 = lhs.shb1 + rhs.shb1;
		result.shb2 = lhs.shb2 + rhs.shb2;
		result.shb3 = lhs.shb3 + rhs.shb3;
		result.shb4 = lhs.shb4 + rhs.shb4;
		result.shb5 = lhs.shb5 + rhs.shb5;
		result.shb6 = lhs.shb6 + rhs.shb6;
		result.shb7 = lhs.shb7 + rhs.shb7;
		result.shb8 = lhs.shb8 + rhs.shb8;
		return result;
	}

	public unsafe static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, [In] ref Color color)
	{
		AddAmbientLight_InjectedDelegateField((nint)Unsafe.AsPointer(ref _unity_self), (nint)Unsafe.AsPointer(ref color));
	}

	public unsafe static void AddDirectionalLightInternal_Injected(ref SphericalHarmonicsL2 sh, [In] ref Vector3 direction, [In] ref Color color)
	{
		AddDirectionalLightInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sh), (nint)Unsafe.AsPointer(ref direction), (nint)Unsafe.AsPointer(ref color));
	}

	public unsafe static void EvaluateInternal_Injected(ref SphericalHarmonicsL2 sh, ref ManagedSpanWrapper directions, out BlittableArrayWrapper results)
	{
		EvaluateInternal_InjectedDelegateField((nint)Unsafe.AsPointer(ref sh), (nint)Unsafe.AsPointer(ref directions), (nint)Unsafe.AsPointer(ref results));
	}
}
