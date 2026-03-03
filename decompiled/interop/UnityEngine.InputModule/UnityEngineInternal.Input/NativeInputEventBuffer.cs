using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal.Input;

[StructLayout(LayoutKind.Explicit)]
public struct NativeInputEventBuffer
{
	private static readonly System.IntPtr NativeFieldInfoPtr_eventBuffer;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventCount;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_capacityInBytes;

	[FieldOffset(0)]
	public System.IntPtr eventBuffer;

	[FieldOffset(8)]
	public int eventCount;

	[FieldOffset(12)]
	public int sizeInBytes;

	[FieldOffset(16)]
	public int capacityInBytes;

	public const int structSize = 20;

	static NativeInputEventBuffer()
	{
		Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeInputEventBuffer");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr);
		NativeFieldInfoPtr_eventBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "eventBuffer");
		NativeFieldInfoPtr_eventCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "eventCount");
		NativeFieldInfoPtr_sizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "sizeInBytes");
		NativeFieldInfoPtr_capacityInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, "capacityInBytes");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeInputEventBuffer>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
