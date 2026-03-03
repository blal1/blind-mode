using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PlayerLoop;

[StructLayout(LayoutKind.Explicit)]
public struct PreLateUpdate
{
	[StructLayout(LayoutKind.Explicit)]
	public struct Physics2DLateUpdate
	{
		static Physics2DLateUpdate()
		{
			Il2CppClassPointerStore<Physics2DLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "Physics2DLateUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Physics2DLateUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Physics2DLateUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct PhysicsLateUpdate
	{
		static PhysicsLateUpdate()
		{
			Il2CppClassPointerStore<PhysicsLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "PhysicsLateUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsLateUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsLateUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AIUpdatePostScript
	{
		static AIUpdatePostScript()
		{
			Il2CppClassPointerStore<AIUpdatePostScript>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "AIUpdatePostScript");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AIUpdatePostScript>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AIUpdatePostScript>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DirectorUpdateAnimationBegin
	{
		static DirectorUpdateAnimationBegin()
		{
			Il2CppClassPointerStore<DirectorUpdateAnimationBegin>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationBegin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorUpdateAnimationBegin>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectorUpdateAnimationBegin>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct LegacyAnimationUpdate
	{
		static LegacyAnimationUpdate()
		{
			Il2CppClassPointerStore<LegacyAnimationUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "LegacyAnimationUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyAnimationUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LegacyAnimationUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DirectorUpdateAnimationEnd
	{
		static DirectorUpdateAnimationEnd()
		{
			Il2CppClassPointerStore<DirectorUpdateAnimationEnd>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorUpdateAnimationEnd");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorUpdateAnimationEnd>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectorUpdateAnimationEnd>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct DirectorDeferredEvaluate
	{
		static DirectorDeferredEvaluate()
		{
			Il2CppClassPointerStore<DirectorDeferredEvaluate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "DirectorDeferredEvaluate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectorDeferredEvaluate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DirectorDeferredEvaluate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct AccessibilityUpdate
	{
		static AccessibilityUpdate()
		{
			Il2CppClassPointerStore<AccessibilityUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "AccessibilityUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessibilityUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AccessibilityUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UIElementsUpdatePanels
	{
		static UIElementsUpdatePanels()
		{
			Il2CppClassPointerStore<UIElementsUpdatePanels>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UIElementsUpdatePanels");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementsUpdatePanels>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UIElementsUpdatePanels>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateNetworkManager
	{
		static UpdateNetworkManager()
		{
			Il2CppClassPointerStore<UpdateNetworkManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateNetworkManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateNetworkManager>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateNetworkManager>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct UpdateMasterServerInterface
	{
		static UpdateMasterServerInterface()
		{
			Il2CppClassPointerStore<UpdateMasterServerInterface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "UpdateMasterServerInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateMasterServerInterface>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateMasterServerInterface>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct EndGraphicsJobsAfterScriptUpdate
	{
		static EndGraphicsJobsAfterScriptUpdate()
		{
			Il2CppClassPointerStore<EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "EndGraphicsJobsAfterScriptUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndGraphicsJobsAfterScriptUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ParticleSystemBeginUpdateAll
	{
		static ParticleSystemBeginUpdateAll()
		{
			Il2CppClassPointerStore<ParticleSystemBeginUpdateAll>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ParticleSystemBeginUpdateAll");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticleSystemBeginUpdateAll>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ParticleSystemBeginUpdateAll>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ScriptRunBehaviourLateUpdate
	{
		static ScriptRunBehaviourLateUpdate()
		{
			Il2CppClassPointerStore<ScriptRunBehaviourLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ScriptRunBehaviourLateUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptRunBehaviourLateUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptRunBehaviourLateUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct ConstraintManagerUpdate
	{
		static ConstraintManagerUpdate()
		{
			Il2CppClassPointerStore<ConstraintManagerUpdate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, "ConstraintManagerUpdate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintManagerUpdate>.NativeClassPtr);
		}

		public unsafe Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConstraintManagerUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
		}
	}

	static PreLateUpdate()
	{
		Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.PlayerLoop", "PreLateUpdate");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PreLateUpdate>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
