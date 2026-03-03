using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct RectangleLight
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadow;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientation;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_range;

	private static readonly System.IntPtr NativeFieldInfoPtr_width;

	private static readonly System.IntPtr NativeFieldInfoPtr_height;

	private static readonly System.IntPtr NativeFieldInfoPtr_falloff;

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
	public float width;

	[FieldOffset(76)]
	public float height;

	[FieldOffset(80)]
	public FalloffType falloff;

	static RectangleLight()
	{
		Il2CppClassPointerStore<RectangleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "RectangleLight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr);
		NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "instanceID");
		NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "shadow");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "position");
		NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "orientation");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "color");
		NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "indirectColor");
		NativeFieldInfoPtr_range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "range");
		NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "width");
		NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "height");
		NativeFieldInfoPtr_falloff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, "falloff");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectangleLight>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
