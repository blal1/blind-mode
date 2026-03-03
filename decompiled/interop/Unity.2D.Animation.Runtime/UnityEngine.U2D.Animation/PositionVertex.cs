using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D.Animation;

[StructLayout(LayoutKind.Explicit)]
public struct PositionVertex
{
	private static readonly System.IntPtr NativeFieldInfoPtr_position;

	[FieldOffset(0)]
	public Vector3 position;

	static PositionVertex()
	{
		Il2CppClassPointerStore<PositionVertex>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "PositionVertex");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionVertex>.NativeClassPtr);
		NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionVertex>.NativeClassPtr, "position");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PositionVertex>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
