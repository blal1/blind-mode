using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Profiling;

public sealed class ProfilerRecorderDebugView : Il2CppSystem.Object
{
	public Il2CppStructArray<ProfilerRecorderSample> Items
	{
		get
		{
			throw new System.NotSupportedException("Method unstripping failed");
		}
	}

	static ProfilerRecorderDebugView()
	{
		Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", "ProfilerRecorderDebugView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDebugView>.NativeClassPtr);
	}

	public ProfilerRecorderDebugView(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
