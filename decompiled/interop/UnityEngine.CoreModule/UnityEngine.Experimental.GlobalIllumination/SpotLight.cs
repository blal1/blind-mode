using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct SpotLight
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadow;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientation;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeFieldInfoPtr_sphereRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_coneAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_innerConeAngle;

	private static readonly System.IntPtr NativeFieldInfoPtr_falloff;

	private static readonly System.IntPtr NativeFieldInfoPtr_angularFalloff;

	[FieldOffset(0)]
	public int instanceID;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.U1)]
	public bool shadow;

	[FieldOffset(5)]
	public LightMode mode;

	[FieldOffset(8)]
	public Vector3 position;

	[FieldOffset(20)]
	public Quaternion orientation;

	[FieldOffset(36)]
	public LinearColor color;

	[FieldOffset(52)]
	public LinearColor indirectColor;

	[FieldOffset(68)]
	public float range;

	[FieldOffset(72)]
	public float sphereRadius;

	[FieldOffset(76)]
	public float coneAngle;

	[FieldOffset(80)]
	public float innerConeAngle;

	[FieldOffset(84)]
	public FalloffType falloff;

	[FieldOffset(85)]
	public AngularFalloffType angularFalloff;

	static SpotLight()
	{
		Il2CppClassPointerStore<SpotLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "SpotLight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpotLight>.NativeClassPtr);
		NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "instanceID");
		NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "shadow");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "position");
		NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "orientation");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "color");
		NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "indirectColor");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "range");
		NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "sphereRadius");
		NativeFieldInfoPtr_coneAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "coneAngle");
		NativeFieldInfoPtr_innerConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "innerConeAngle");
		NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "falloff");
		NativeFieldInfoPtr_angularFalloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, "angularFalloff");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpotLight>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
