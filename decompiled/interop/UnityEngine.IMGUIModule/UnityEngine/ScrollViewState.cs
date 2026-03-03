using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine;

public class ScrollViewState : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static ScrollViewState()
	{
		Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ScrollViewState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr, 100663816);
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ScrollViewState()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollViewState>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public ScrollViewState(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public void ScrollTo(Rect pos)
	{
		ScrollTowards(pos, float.PositiveInfinity);
	}

	public bool ScrollTowards(Rect pos, float maxDelta)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}

	public Vector2 ScrollNeeded(Rect pos)
	{
		throw new System.NotSupportedException("Method unstripping failed");
	}
}
