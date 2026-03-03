using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Animations;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

public class AnimationPreviewUpdateCallback : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Output;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Graph;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviewComponents;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FetchPreviewComponents_Private_Void_0;

	public unsafe AnimationPlayableOutput m_Output
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Output);
			return *(AnimationPlayableOutput*)num;
		}
		set
		{
			*(AnimationPlayableOutput*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Output)) = value;
		}
	}

	public unsafe PlayableGraph m_Graph
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Graph);
			return *(PlayableGraph*)num;
		}
		set
		{
			*(PlayableGraph*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Graph)) = value;
		}
	}

	public unsafe List<IAnimationWindowPreview> m_PreviewComponents
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviewComponents);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<IAnimationWindowPreview>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PreviewComponents)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static AnimationPreviewUpdateCallback()
	{
		Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "AnimationPreviewUpdateCallback");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr);
		NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, "m_Output");
		NativeFieldInfoPtr_m_Graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, "m_Graph");
		NativeFieldInfoPtr_m_PreviewComponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, "m_PreviewComponents");
		NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, 100663365);
		NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, 100663366);
		NativeMethodInfoPtr_FetchPreviewComponents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr, 100663367);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135477, XrefRangeEnd = 1135487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnimationPreviewUpdateCallback(AnimationPlayableOutput output)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationPreviewUpdateCallback>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&output);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_AnimationPlayableOutput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135487, XrefRangeEnd = 1135524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Evaluate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135524, XrefRangeEnd = 1135543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FetchPreviewComponents()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FetchPreviewComponents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AnimationPreviewUpdateCallback(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
