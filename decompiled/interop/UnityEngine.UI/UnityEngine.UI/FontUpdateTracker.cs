using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI;

public static class FontUpdateTracker : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Tracked;

	private static readonly System.IntPtr NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0;

	public unsafe static Dictionary<Font, HashSet<Text>> m_Tracked
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_Tracked, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Font, HashSet<Text>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_Tracked, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static FontUpdateTracker()
	{
		Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "FontUpdateTracker");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr);
		NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, "m_Tracked");
		NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663519);
		NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663520);
		NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663521);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1288052, RefRangeEnd = 1288054, XrefRangeStart = 1288010, XrefRangeEnd = 1288052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TrackText(Text t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1288054, XrefRangeEnd = 1288076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RebuildForFont(Font f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)f);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1288111, RefRangeEnd = 1288113, XrefRangeStart = 1288076, XrefRangeEnd = 1288111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UntrackText(Text t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public FontUpdateTracker(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
