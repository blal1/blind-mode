using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CullingSplit
{
	private static readonly System.IntPtr NativeFieldInfoPtr_sphereCenter;

	private static readonly System.IntPtr NativeFieldInfoPtr_sphereRadius;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlaneOffset;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingPlaneCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_cascadeBlendCullingFactor;

	private static readonly System.IntPtr NativeFieldInfoPtr_nearPlane;

	private static readonly System.IntPtr NativeFieldInfoPtr_cullingMatrix;

	[FieldOffset(0)]
	public Vector3 sphereCenter;

	[FieldOffset(12)]
	public float sphereRadius;

	[FieldOffset(16)]
	public int cullingPlaneOffset;

	[FieldOffset(20)]
	public int cullingPlaneCount;

	[FieldOffset(24)]
	public float cascadeBlendCullingFactor;

	[FieldOffset(28)]
	public float nearPlane;

	[FieldOffset(32)]
	public Matrix4x4 cullingMatrix;

	static CullingSplit()
	{
		Il2CppClassPointerStore<CullingSplit>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "CullingSplit");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr);
		NativeFieldInfoPtr_sphereCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "sphereCenter");
		NativeFieldInfoPtr_sphereRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "sphereRadius");
		NativeFieldInfoPtr_cullingPlaneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingPlaneOffset");
		NativeFieldInfoPtr_cullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingPlaneCount");
		NativeFieldInfoPtr_cascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cascadeBlendCullingFactor");
		NativeFieldInfoPtr_nearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "nearPlane");
		NativeFieldInfoPtr_cullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, "cullingMatrix");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingSplit>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
