using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace Il2Cpp;

public class PlayableDirectorEx : PlayableDirector
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	static PlayableDirectorEx()
	{
		Il2CppClassPointerStore<PlayableDirectorEx>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "PlayableDirectorEx");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableDirectorEx>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableDirectorEx>.NativeClassPtr, 100664112);
	}

	[CallerCount(103)]
	[CachedScanResults(RefRangeStart = 22793, RefRangeEnd = 22896, XrefRangeStart = 22793, XrefRangeEnd = 22896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayableDirectorEx()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableDirectorEx>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public PlayableDirectorEx(IntPtr pointer)
		: base(pointer)
	{
	}
}
