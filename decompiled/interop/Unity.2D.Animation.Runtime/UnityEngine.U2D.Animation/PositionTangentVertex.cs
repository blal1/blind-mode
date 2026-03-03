using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D.Animation;

[StructLayout(LayoutKind.Explicit)]
public struct PositionTangentVertex
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	private static readonly System.IntPtr NativeFieldInfoPtr_tangent;

	[FieldOffset(0)]
	public Vector3 position;

	[FieldOffset(12)]
	public Vector4 tangent;

	static PositionTangentVertex()
	{
		Il2CppClassPointerStore<PositionTangentVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "PositionTangentVertex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionTangentVertex>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionTangentVertex>.NativeClassPtr, "position");
		NativeFieldInfoPtr_tangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionTangentVertex>.NativeClassPtr, "tangent");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PositionTangentVertex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
