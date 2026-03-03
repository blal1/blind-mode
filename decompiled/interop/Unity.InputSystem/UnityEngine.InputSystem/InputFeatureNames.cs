using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.InputSystem;

public static class InputFeatureNames : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_kRunPlayerUpdatesInEditMode;

	private static readonly System.IntPtr NativeFieldInfoPtr_kDisableUnityRemoteSupport;

	private static readonly System.IntPtr NativeFieldInfoPtr_kUseOptimizedControls;

	private static readonly System.IntPtr NativeFieldInfoPtr_kUseReadValueCaching;

	private static readonly System.IntPtr NativeFieldInfoPtr_kParanoidReadValueCachingChecks;

	private static readonly System.IntPtr NativeFieldInfoPtr_kUseIMGUIEditorForAssets;

	public unsafe static string kRunPlayerUpdatesInEditMode
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kRunPlayerUpdatesInEditMode, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kRunPlayerUpdatesInEditMode, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kDisableUnityRemoteSupport
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kDisableUnityRemoteSupport, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kDisableUnityRemoteSupport, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kUseOptimizedControls
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kUseOptimizedControls, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kUseOptimizedControls, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kUseReadValueCaching
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kUseReadValueCaching, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kUseReadValueCaching, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kParanoidReadValueCachingChecks
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kParanoidReadValueCachingChecks, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kParanoidReadValueCachingChecks, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string kUseIMGUIEditorForAssets
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_kUseIMGUIEditorForAssets, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_kUseIMGUIEditorForAssets, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static InputFeatureNames()
	{
		Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.InputSystem.dll", "UnityEngine.InputSystem", "InputFeatureNames");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr);
		NativeFieldInfoPtr_kRunPlayerUpdatesInEditMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr, "kRunPlayerUpdatesInEditMode");
		NativeFieldInfoPtr_kDisableUnityRemoteSupport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr, "kDisableUnityRemoteSupport");
		NativeFieldInfoPtr_kUseOptimizedControls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr, "kUseOptimizedControls");
		NativeFieldInfoPtr_kUseReadValueCaching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr, "kUseReadValueCaching");
		NativeFieldInfoPtr_kParanoidReadValueCachingChecks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr, "kParanoidReadValueCachingChecks");
		NativeFieldInfoPtr_kUseIMGUIEditorForAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureNames>.NativeClassPtr, "kUseIMGUIEditorForAssets");
	}

	public InputFeatureNames(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
