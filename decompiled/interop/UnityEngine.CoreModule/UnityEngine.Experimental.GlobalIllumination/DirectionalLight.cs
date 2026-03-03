using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Experimental.GlobalIllumination;

[StructLayout(LayoutKind.Explicit)]
public struct DirectionalLight
{
	private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;

	private static readonly System.IntPtr NativeFieldInfoPtr_shadow;

	private static readonly System.IntPtr NativeFieldInfoPtr_mode;

	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_orientation;

	private static readonly System.IntPtr NativeFieldInfoPtr_color;

	private static readonly System.IntPtr NativeFieldInfoPtr_indirectColor;

	private static readonly System.IntPtr NativeFieldInfoPtr_penumbraWidthRadian;

	private static readonly System.IntPtr NativeFieldInfoPtr_direction;

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
	public float penumbraWidthRadian;

	[FieldOffset(72)]
	public Vector3 direction;

	static DirectionalLight()
	{
		Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.GlobalIllumination", "DirectionalLight");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr);
		NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "instanceID");
		NativeFieldInfoPtr_shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "shadow");
		NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "mode");
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "position");
		NativeFieldInfoPtr_orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "orientation");
		NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "color");
		NativeFieldInfoPtr_indirectColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "indirectColor");
		NativeFieldInfoPtr_penumbraWidthRadian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "penumbraWidthRadian");
		NativeFieldInfoPtr_direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, "direction");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectionalLight>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
