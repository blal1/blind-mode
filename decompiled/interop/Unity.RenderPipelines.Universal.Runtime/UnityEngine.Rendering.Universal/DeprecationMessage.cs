using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal;

[StructLayout(LayoutKind.Explicit)]
public struct DeprecationMessage
{
	private static readonly System.IntPtr NativeFieldInfoPtr_CompatibilityScriptingAPIObsolete;

	private static readonly System.IntPtr NativeFieldInfoPtr_CompatibilityScriptingAPIConsoleWarning;

	public unsafe static string CompatibilityScriptingAPIObsolete
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CompatibilityScriptingAPIObsolete, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CompatibilityScriptingAPIObsolete, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string CompatibilityScriptingAPIConsoleWarning
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CompatibilityScriptingAPIConsoleWarning, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CompatibilityScriptingAPIConsoleWarning, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static DeprecationMessage()
	{
		Il2CppClassPointerStore<DeprecationMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DeprecationMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeprecationMessage>.NativeClassPtr);
		NativeFieldInfoPtr_CompatibilityScriptingAPIObsolete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecationMessage>.NativeClassPtr, "CompatibilityScriptingAPIObsolete");
		NativeFieldInfoPtr_CompatibilityScriptingAPIConsoleWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecationMessage>.NativeClassPtr, "CompatibilityScriptingAPIConsoleWarning");
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeprecationMessage>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
