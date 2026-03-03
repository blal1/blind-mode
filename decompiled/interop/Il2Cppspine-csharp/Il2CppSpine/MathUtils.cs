using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine;

public static class MathUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_random;

	private static readonly System.IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SinDeg_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CosDeg_Public_Static_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Atan2Deg_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

	public unsafe static Il2CppSystem.Random random
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_random, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Random>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_random, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static MathUtils()
	{
		Il2CppClassPointerStore<MathUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "MathUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathUtils>.NativeClassPtr);
		NativeFieldInfoPtr_random = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, "random");
		NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663885);
		NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663886);
		NativeMethodInfoPtr_SinDeg_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663887);
		NativeMethodInfoPtr_CosDeg_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663888);
		NativeMethodInfoPtr_Atan2Deg_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663889);
		NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663890);
		NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100663891);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 843635, RefRangeEnd = 843642, XrefRangeStart = 843631, XrefRangeEnd = 843635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Sin(float radians)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&radians);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 843646, RefRangeEnd = 843653, XrefRangeStart = 843642, XrefRangeEnd = 843646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Cos(float radians)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&radians);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 843657, RefRangeEnd = 843670, XrefRangeStart = 843653, XrefRangeEnd = 843657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float SinDeg(float degrees)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&degrees);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SinDeg_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 843674, RefRangeEnd = 843687, XrefRangeStart = 843670, XrefRangeEnd = 843674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float CosDeg(float degrees)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&degrees);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CosDeg_Public_Static_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 843691, RefRangeEnd = 843698, XrefRangeStart = 843687, XrefRangeEnd = 843691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Atan2Deg(float y, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&y);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan2Deg_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 843702, RefRangeEnd = 843719, XrefRangeStart = 843698, XrefRangeEnd = 843702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Atan2(float y, float x)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&y);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Atan2_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 843719, RefRangeEnd = 843726, XrefRangeStart = 843719, XrefRangeEnd = 843719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Clamp(float value, float min, float max)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&value);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &min;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &max;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public MathUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
