using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.U2D.Animation;

public static class IconUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_IconPath;

	public unsafe static string IconPath
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_IconPath, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_IconPath, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static IconUtility()
	{
		Il2CppClassPointerStore<IconUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "IconUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconUtility>.NativeClassPtr);
		NativeFieldInfoPtr_IconPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconUtility>.NativeClassPtr, "IconPath");
	}

	public IconUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
