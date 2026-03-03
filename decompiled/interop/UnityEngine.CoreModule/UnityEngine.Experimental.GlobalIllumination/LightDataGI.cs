using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct LightDataGI
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookieID;

	private static readonly System.IntPtr NativeFieldInfoPtr_cookieScale;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientation;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeFieldInfoPtr_coneAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_innerConeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_shape0;

	private static readonly System.IntPtr NativeFieldInfoPtr_shape1;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadow;

	private static readonly System.IntPtr NativeFieldInfoPtr_falloff;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0;

	[FieldOffset(0)]
	public int instanceID;

	[FieldOffset(4)]
	public int cookieID;

	[FieldOffset(8)]
	public float cookieScale;

	[FieldOffset(12)]
	public LinearColor color;

	[FieldOffset(28)]
	public LinearColor indirectColor;

	[FieldOffset(44)]
	public Quaternion orientation;

	[FieldOffset(60)]
	public Vector3 position;

	[FieldOffset(72)]
	public float range;

	[FieldOffset(76)]
	public float coneAngle;

	[FieldOffset(80)]
	public float innerConeAngle;

	[FieldOffset(84)]
	public float shape0;

	[FieldOffset(88)]
	public float shape1;

	[FieldOffset(92)]
	public LightType type;

	[FieldOffset(93)]
	public LightMode mode;

	[FieldOffset(94)]
	public byte shadow;

	[FieldOffset(95)]
	public FalloffType falloff;

	static LightDataGI()
	{
		Il2CppClassPointerStore<LightDataGI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "LightDataGI");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr);
		NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "instanceID");
		NativeFieldInfoPtr_cookieID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieID");
		NativeFieldInfoPtr_cookieScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "cookieScale");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "color");
		NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "indirectColor");
		NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "orientation");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "position");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "range");
		NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "coneAngle");
		NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "innerConeAngle");
		NativeFieldInfoPtr_shape0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape0");
		NativeFieldInfoPtr_shape1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shape1");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "type");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "shadow");
		NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, "falloff");
		NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668901);
		NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668902);
		NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668903);
		NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668904);
		NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668905);
		NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668906);
		NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668907);
		NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668908);
		NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, 100668909);
	}

	[CallerCount(0)]
	public unsafe void Init(ref DirectionalLight light, ref Cookie cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_byref_Cookie_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Init(ref PointLight light, ref Cookie cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_byref_Cookie_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Init(ref SpotLight light, ref Cookie cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_byref_Cookie_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Init(ref RectangleLight light, ref Cookie cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_RectangleLight_byref_Cookie_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void Init(ref DiscLight light, ref Cookie cookie)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref cookie);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_DiscLight_byref_Cookie_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240788, RefRangeEnd = 1240789, XrefRangeStart = 1240788, XrefRangeEnd = 1240788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(ref DirectionalLight light)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_DirectionalLight_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240789, RefRangeEnd = 1240790, XrefRangeStart = 1240789, XrefRangeEnd = 1240789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(ref PointLight light)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_PointLight_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1240790, RefRangeEnd = 1240791, XrefRangeStart = 1240790, XrefRangeEnd = 1240790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init(ref SpotLight light)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)Unsafe.AsPointer(ref light);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Init_Public_Void_byref_SpotLight_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1240791, RefRangeEnd = 1240793, XrefRangeStart = 1240791, XrefRangeEnd = 1240791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitNoBake(int lightInstanceID)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&lightInstanceID);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitNoBake_Public_Void_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LightDataGI>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public void Init(ref RectangleLight light)
	{
		Cookie cookie = Cookie.Defaults();
		Init(ref light, ref cookie);
	}

	public void Init(ref DiscLight light)
	{
		Cookie cookie = Cookie.Defaults();
		Init(ref light, ref cookie);
	}
}
