using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct Update
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ScriptRunBehaviourUpdate
	{
		static ScriptRunBehaviourUpdate()
		{
			Il2CppClassPointerStore<ScriptRunBehaviourUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunBehaviourUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunBehaviourUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptRunBehaviourUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DirectorUpdate
	{
		static DirectorUpdate()
		{
			Il2CppClassPointerStore<DirectorUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "DirectorUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectorUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ScriptRunDelayedDynamicFrameRate
	{
		static ScriptRunDelayedDynamicFrameRate()
		{
			Il2CppClassPointerStore<ScriptRunDelayedDynamicFrameRate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedDynamicFrameRate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunDelayedDynamicFrameRate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptRunDelayedDynamicFrameRate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ScriptRunDelayedTasks
	{
		static ScriptRunDelayedTasks()
		{
			Il2CppClassPointerStore<ScriptRunDelayedTasks>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Update>.NativeClassPtr, "ScriptRunDelayedTasks");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunDelayedTasks>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptRunDelayedTasks>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	static Update()
	{
		Il2CppClassPointerStore<Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "Update");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Update>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Update>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
