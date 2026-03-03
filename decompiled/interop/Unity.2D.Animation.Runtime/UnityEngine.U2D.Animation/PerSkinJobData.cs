using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Unity.Mathematics;

namespace UnityEngine.U2D.Animation;

[StructLayout(LayoutKind.Explicit)]
public struct PerSkinJobData
{
	private static readonly System.IntPtr NativeFieldInfoPtr_deformVerticesStartPos;

	private static readonly System.IntPtr NativeFieldInfoPtr_bindPosesIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_verticesIndex;

	[FieldOffset(0)]
	public int deformVerticesStartPos;

	[FieldOffset(4)]
	public int2 bindPosesIndex;

	[FieldOffset(12)]
	public int2 verticesIndex;

	static PerSkinJobData()
	{
		Il2CppClassPointerStore<PerSkinJobData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "PerSkinJobData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PerSkinJobData>.NativeClassPtr);
		NativeFieldInfoPtr_deformVerticesStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerSkinJobData>.NativeClassPtr, "deformVerticesStartPos");
		NativeFieldInfoPtr_bindPosesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerSkinJobData>.NativeClassPtr, "bindPosesIndex");
		NativeFieldInfoPtr_verticesIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PerSkinJobData>.NativeClassPtr, "verticesIndex");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PerSkinJobData>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
