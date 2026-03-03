using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering;

public static class SinglepassKeywords : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_STEREO_MULTIVIEW_ON;

	private static readonly System.IntPtr NativeFieldInfoPtr_STEREO_INSTANCING_ON;

	public unsafe static GlobalKeyword STEREO_MULTIVIEW_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEREO_MULTIVIEW_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEREO_MULTIVIEW_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe static GlobalKeyword STEREO_INSTANCING_ON
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_STEREO_INSTANCING_ON, (void*)intPtr);
			return new GlobalKeyword(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalKeyword>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_STEREO_INSTANCING_ON, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	static SinglepassKeywords()
	{
		Il2CppClassPointerStore<SinglepassKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "SinglepassKeywords");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SinglepassKeywords>.NativeClassPtr);
		NativeFieldInfoPtr_STEREO_MULTIVIEW_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglepassKeywords>.NativeClassPtr, "STEREO_MULTIVIEW_ON");
		NativeFieldInfoPtr_STEREO_INSTANCING_ON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinglepassKeywords>.NativeClassPtr, "STEREO_INSTANCING_ON");
	}

	public SinglepassKeywords(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
