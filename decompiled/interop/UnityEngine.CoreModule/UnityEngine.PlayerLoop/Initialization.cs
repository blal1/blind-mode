using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct Initialization
{
	[StructLayout(LayoutKind.Explicit)]
	public struct ProfilerStartFrame
	{
		static ProfilerStartFrame()
		{
			Il2CppClassPointerStore<ProfilerStartFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "ProfilerStartFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerStartFrame>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerStartFrame>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateCameraMotionVectors
	{
		static UpdateCameraMotionVectors()
		{
			Il2CppClassPointerStore<UpdateCameraMotionVectors>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "UpdateCameraMotionVectors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateCameraMotionVectors>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateCameraMotionVectors>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DirectorSampleTime
	{
		static DirectorSampleTime()
		{
			Il2CppClassPointerStore<DirectorSampleTime>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "DirectorSampleTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorSampleTime>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectorSampleTime>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AsyncUploadTimeSlicedUpdate
	{
		static AsyncUploadTimeSlicedUpdate()
		{
			Il2CppClassPointerStore<AsyncUploadTimeSlicedUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "AsyncUploadTimeSlicedUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncUploadTimeSlicedUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUploadTimeSlicedUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SynchronizeState
	{
		static SynchronizeState()
		{
			Il2CppClassPointerStore<SynchronizeState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "SynchronizeState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizeState>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SynchronizeState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SynchronizeInputs
	{
		static SynchronizeInputs()
		{
			Il2CppClassPointerStore<SynchronizeInputs>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "SynchronizeInputs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizeInputs>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SynchronizeInputs>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct XREarlyUpdate
	{
		static XREarlyUpdate()
		{
			Il2CppClassPointerStore<XREarlyUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Initialization>.NativeClassPtr, "XREarlyUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XREarlyUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XREarlyUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	public struct PlayerUpdateTime
	{
	}

	static Initialization()
	{
		Il2CppClassPointerStore<Initialization>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "Initialization");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Initialization>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Initialization>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
