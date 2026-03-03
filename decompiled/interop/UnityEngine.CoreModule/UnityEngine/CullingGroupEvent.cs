using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CullingGroupEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevState;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ThisState;

	[FieldOffset(0)]
	public int m_Index;

	[FieldOffset(4)]
	public byte m_PrevState;

	[FieldOffset(5)]
	public byte m_ThisState;

	public const byte kIsVisibleMask = 128;

	public const byte kDistanceMask = 127;

	public int index => m_Index;

	public bool isVisible => (m_ThisState & 0x80) != 0;

	public bool wasVisible => (m_PrevState & 0x80) != 0;

	public bool hasBecomeVisible => isVisible && !wasVisible;

	public bool hasBecomeInvisible => !isVisible && wasVisible;

	public int currentDistance => m_ThisState & 0x7F;

	public int previousDistance => m_PrevState & 0x7F;

	static CullingGroupEvent()
	{
		Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "CullingGroupEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr);
		NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_Index");
		NativeFieldInfoPtr_m_PrevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_PrevState");
		NativeFieldInfoPtr_m_ThisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, "m_ThisState");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
