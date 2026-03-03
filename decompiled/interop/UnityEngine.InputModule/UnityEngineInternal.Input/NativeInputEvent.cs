using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal.Input;

[StructLayout(LayoutKind.Explicit)]
public struct NativeInputEvent
{
	private static readonly System.IntPtr NativeFieldInfoPtr_structSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_type;

	private static readonly System.IntPtr NativeFieldInfoPtr_sizeInBytes;

	private static readonly System.IntPtr NativeFieldInfoPtr_deviceId;

	private static readonly System.IntPtr NativeFieldInfoPtr_time;

	private static readonly System.IntPtr NativeFieldInfoPtr_eventId;

	[FieldOffset(0)]
	public NativeInputEventType type;

	[FieldOffset(4)]
	public ushort sizeInBytes;

	[FieldOffset(6)]
	public ushort deviceId;

	[FieldOffset(8)]
	public double time;

	[FieldOffset(16)]
	public int eventId;

	public unsafe static int structSize
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_structSize, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_structSize, (void*)(&value));
		}
	}

	static NativeInputEvent()
	{
		Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputModule.dll", "UnityEngineInternal.Input", "NativeInputEvent");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr);
		NativeFieldInfoPtr_structSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, "structSize");
		NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, "type");
		NativeFieldInfoPtr_sizeInBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, "sizeInBytes");
		NativeFieldInfoPtr_deviceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, "deviceId");
		NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, "time");
		NativeFieldInfoPtr_eventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, "eventId");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeInputEvent>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
