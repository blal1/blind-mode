using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace UnityEngine.Animations;

public class IAnimationWindowPreview : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_StartPreview_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_StopPreview_Public_Abstract_Virtual_New_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdatePreviewGraph_Public_Abstract_Virtual_New_Void_PlayableGraph_0;

	private static readonly IntPtr NativeMethodInfoPtr_BuildPreviewGraph_Public_Abstract_Virtual_New_Playable_PlayableGraph_Playable_0;

	static IAnimationWindowPreview()
	{
		Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AnimationModule.dll", "UnityEngine.Animations", "IAnimationWindowPreview");
		NativeMethodInfoPtr_StartPreview_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr, 100664246);
		NativeMethodInfoPtr_StopPreview_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr, 100664247);
		NativeMethodInfoPtr_UpdatePreviewGraph_Public_Abstract_Virtual_New_Void_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr, 100664248);
		NativeMethodInfoPtr_BuildPreviewGraph_Public_Abstract_Virtual_New_Playable_PlayableGraph_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationWindowPreview>.NativeClassPtr, 100664249);
	}

	[CallerCount(0)]
	public unsafe virtual void StartPreview()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StartPreview_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void StopPreview()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_StopPreview_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual void UpdatePreviewGraph(PlayableGraph graph)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&graph);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_UpdatePreviewGraph_Public_Abstract_Virtual_New_Void_PlayableGraph_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual Playable BuildPreviewGraph(PlayableGraph graph, Playable inputPlayable)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&graph);
		*(Playable**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &inputPlayable;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_BuildPreviewGraph_Public_Abstract_Virtual_New_Playable_PlayableGraph_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Playable*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public IAnimationWindowPreview(IntPtr pointer)
		: base(pointer)
	{
	}
}
