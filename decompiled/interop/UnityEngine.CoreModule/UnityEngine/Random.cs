using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

public static class Random : Il2CppSystem.Object
{
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct State
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_s0;

		private static readonly System.IntPtr NativeFieldInfoPtr_s1;

		private static readonly System.IntPtr NativeFieldInfoPtr_s2;

		private static readonly System.IntPtr NativeFieldInfoPtr_s3;

		[FieldOffset(0)]
		public int s0;

		[FieldOffset(4)]
		public int s1;

		[FieldOffset(8)]
		public int s2;

		[FieldOffset(12)]
		public int s3;

		static State()
		{
			Il2CppClassPointerStore<State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Random>.NativeClassPtr, "State");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<State>.NativeClassPtr);
			NativeFieldInfoPtr_s0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "s0");
			NativeFieldInfoPtr_s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "s1");
			NativeFieldInfoPtr_s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "s2");
			NativeFieldInfoPtr_s3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<State>.NativeClassPtr, "s3");
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<State>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	private delegate void GetRandomUnitCircleDelegate([Out] System.IntPtr output);

	private delegate int get_seedDelegate();

	private delegate void set_seedDelegate(int value);

	private delegate void get_insideUnitSphere_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_onUnitSphere_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_rotation_InjectedDelegate([Out] System.IntPtr ret);

	private delegate void get_rotationUniform_InjectedDelegate([Out] System.IntPtr ret);

	private static readonly System.IntPtr NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Public_Static_get_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_Static_get_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0;

	private static readonly GetRandomUnitCircleDelegate GetRandomUnitCircleDelegateField;

	private static readonly get_seedDelegate get_seedDelegateField;

	private static readonly set_seedDelegate set_seedDelegateField;

	private static readonly get_insideUnitSphere_InjectedDelegate get_insideUnitSphere_InjectedDelegateField;

	private static readonly get_onUnitSphere_InjectedDelegate get_onUnitSphere_InjectedDelegateField;

	private static readonly get_rotation_InjectedDelegate get_rotation_InjectedDelegateField;

	private static readonly get_rotationUniform_InjectedDelegate get_rotationUniform_InjectedDelegateField;

	public unsafe static State state
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1185358, RefRangeEnd = 1185360, XrefRangeStart = 1185356, XrefRangeEnd = 1185358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Public_Static_get_State_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(State*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1185362, RefRangeEnd = 1185364, XrefRangeStart = 1185360, XrefRangeEnd = 1185362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe static float value
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1185427, RefRangeEnd = 1185434, XrefRangeStart = 1185425, XrefRangeEnd = 1185427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_value_Public_Static_get_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public static Vector3 insideUnitSphere
	{
		get
		{
			get_insideUnitSphere_Injected(out var ret);
			return ret;
		}
	}

	public static Vector2 insideUnitCircle
	{
		get
		{
			GetRandomUnitCircle(out var output);
			return output;
		}
	}

	public static Vector3 onUnitSphere
	{
		get
		{
			get_onUnitSphere_Injected(out var ret);
			return ret;
		}
	}

	public static Quaternion rotation
	{
		get
		{
			get_rotation_Injected(out var ret);
			return ret;
		}
	}

	public static Quaternion rotationUniform
	{
		get
		{
			get_rotationUniform_Injected(out var ret);
			return ret;
		}
	}

	public static int seed
	{
		get
		{
			return get_seedDelegateField();
		}
		set
		{
			set_seedDelegateField(value);
		}
	}

	static Random()
	{
		Il2CppClassPointerStore<Random>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Random");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Random>.NativeClassPtr);
		NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666084);
		NativeMethodInfoPtr_get_state_Public_Static_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666085);
		NativeMethodInfoPtr_set_state_Public_Static_set_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666086);
		NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666087);
		NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666088);
		NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666089);
		NativeMethodInfoPtr_get_value_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666090);
		NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666091);
		NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Random>.NativeClassPtr, 100666092);
		GetRandomUnitCircleDelegateField = IL2CPP.ResolveICall<GetRandomUnitCircleDelegate>("UnityEngine.Random::GetRandomUnitCircle");
		get_seedDelegateField = IL2CPP.ResolveICall<get_seedDelegate>("UnityEngine.Random::get_seed");
		set_seedDelegateField = IL2CPP.ResolveICall<set_seedDelegate>("UnityEngine.Random::set_seed");
		get_insideUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<get_insideUnitSphere_InjectedDelegate>("UnityEngine.Random::get_insideUnitSphere_Injected");
		get_onUnitSphere_InjectedDelegateField = IL2CPP.ResolveICall<get_onUnitSphere_InjectedDelegate>("UnityEngine.Random::get_onUnitSphere_Injected");
		get_rotation_InjectedDelegateField = IL2CPP.ResolveICall<get_rotation_InjectedDelegate>("UnityEngine.Random::get_rotation_Injected");
		get_rotationUniform_InjectedDelegateField = IL2CPP.ResolveICall<get_rotationUniform_InjectedDelegate>("UnityEngine.Random::get_rotationUniform_Injected");
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1185354, RefRangeEnd = 1185356, XrefRangeStart = 1185352, XrefRangeEnd = 1185354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitState(int seed)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&seed);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitState_Public_Static_Void_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(25)]
	[CachedScanResults(RefRangeStart = 1185366, RefRangeEnd = 1185391, XrefRangeStart = 1185364, XrefRangeEnd = 1185366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float Range(float minInclusive, float maxInclusive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minInclusive);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxInclusive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Range_Public_Static_Single_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(float*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 1185393, RefRangeEnd = 1185425, XrefRangeStart = 1185391, XrefRangeEnd = 1185393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Range(int minInclusive, int maxExclusive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minInclusive);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxExclusive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Range_Public_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(32)]
	[CachedScanResults(RefRangeStart = 1185393, RefRangeEnd = 1185425, XrefRangeStart = 1185393, XrefRangeEnd = 1185425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int RandomRangeInt(int minInclusive, int maxExclusive)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&minInclusive);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxExclusive;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RandomRangeInt_Private_Static_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185434, XrefRangeEnd = 1185436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void get_state_Injected(out State ret)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref ret);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_state_Injected_Private_Static_Void_byref_State_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1185436, XrefRangeEnd = 1185438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void set_state_Injected([In] ref State value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_state_Injected_Private_Static_Void_byref_State_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Random(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public unsafe static void GetRandomUnitCircle(out Vector2 output)
	{
		GetRandomUnitCircleDelegateField((nint)Unsafe.AsPointer(ref output));
	}

	public static float RandomRange(float min, float max)
	{
		return Range(min, max);
	}

	public static int RandomRange(int min, int max)
	{
		return Range(min, max);
	}

	public static Color ColorHSV()
	{
		return ColorHSV(0f, 1f, 0f, 1f, 0f, 1f, 1f, 1f);
	}

	public static Color ColorHSV(float hueMin, float hueMax)
	{
		return ColorHSV(hueMin, hueMax, 0f, 1f, 0f, 1f, 1f, 1f);
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax)
	{
		return ColorHSV(hueMin, hueMax, saturationMin, saturationMax, 0f, 1f, 1f, 1f);
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax)
	{
		return ColorHSV(hueMin, hueMax, saturationMin, saturationMax, valueMin, valueMax, 1f, 1f);
	}

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax)
	{
		float h = Mathf.Lerp(hueMin, hueMax, value);
		float s = Mathf.Lerp(saturationMin, saturationMax, value);
		float v = Mathf.Lerp(valueMin, valueMax, value);
		Color result = Color.HSVToRGB(h, s, v, hdr: true);
		result.a = Mathf.Lerp(alphaMin, alphaMax, value);
		return result;
	}

	public unsafe static void get_insideUnitSphere_Injected(out Vector3 ret)
	{
		get_insideUnitSphere_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_onUnitSphere_Injected(out Vector3 ret)
	{
		get_onUnitSphere_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_rotation_Injected(out Quaternion ret)
	{
		get_rotation_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}

	public unsafe static void get_rotationUniform_Injected(out Quaternion ret)
	{
		get_rotationUniform_InjectedDelegateField((nint)Unsafe.AsPointer(ref ret));
	}
}
