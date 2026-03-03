using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class IPropertyPreview : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Abstract_Virtual_New_Void_PlayableDirector_IPropertyCollector_0;

	static IPropertyPreview()
	{
		Il2CppClassPointerStore<IPropertyPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IPropertyPreview");
		NativeMethodInfoPtr_GatherProperties_Public_Abstract_Virtual_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyPreview>.NativeClassPtr, 100664147);
	}

	[CallerCount(0)]
	public unsafe virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)director);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)driver);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_GatherProperties_Public_Abstract_Virtual_New_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IPropertyPreview(IntPtr pointer)
		: base(pointer)
	{
	}
}
