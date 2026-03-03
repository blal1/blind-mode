using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct PreUpdate
{
	[StructLayout(LayoutKind.Explicit)]
	public struct PhysicsUpdate
	{
		static PhysicsUpdate()
		{
			Il2CppClassPointerStore<PhysicsUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct Physics2DUpdate
	{
		static Physics2DUpdate()
		{
			Il2CppClassPointerStore<Physics2DUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "Physics2DUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2DUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Physics2DUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PhysicsClothUpdate
	{
		static PhysicsClothUpdate()
		{
			Il2CppClassPointerStore<PhysicsClothUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "PhysicsClothUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsClothUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsClothUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct CheckTexFieldInput
	{
		static CheckTexFieldInput()
		{
			Il2CppClassPointerStore<CheckTexFieldInput>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "CheckTexFieldInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckTexFieldInput>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CheckTexFieldInput>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct IMGUISendQueuedEvents
	{
		static IMGUISendQueuedEvents()
		{
			Il2CppClassPointerStore<IMGUISendQueuedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "IMGUISendQueuedEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IMGUISendQueuedEvents>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IMGUISendQueuedEvents>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct SendMouseEvents
	{
		static SendMouseEvents()
		{
			Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "SendMouseEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendMouseEvents>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AIUpdate
	{
		static AIUpdate()
		{
			Il2CppClassPointerStore<AIUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "AIUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AIUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct WindUpdate
	{
		static WindUpdate()
		{
			Il2CppClassPointerStore<WindUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "WindUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateVideo
	{
		static UpdateVideo()
		{
			Il2CppClassPointerStore<UpdateVideo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "UpdateVideo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateVideo>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateVideo>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct NewInputUpdate
	{
		static NewInputUpdate()
		{
			Il2CppClassPointerStore<NewInputUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "NewInputUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewInputUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NewInputUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct InputForUIUpdate
	{
		static InputForUIUpdate()
		{
			Il2CppClassPointerStore<InputForUIUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, "InputForUIUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputForUIUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InputForUIUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	static PreUpdate()
	{
		Il2CppClassPointerStore<PreUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
