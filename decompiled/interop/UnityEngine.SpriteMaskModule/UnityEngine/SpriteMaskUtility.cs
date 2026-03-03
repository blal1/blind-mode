using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine;

public static class SpriteMaskUtility
{
	private delegate bool HasSpriteMaskInLayerRange_InjectedDelegate([In] IntPtr range);

	private static readonly HasSpriteMaskInLayerRange_InjectedDelegate HasSpriteMaskInLayerRange_InjectedDelegateField = IL2CPP.ResolveICall<HasSpriteMaskInLayerRange_InjectedDelegate>("UnityEngine.SpriteMaskUtility::HasSpriteMaskInLayerRange_Injected");

	public static bool HasSpriteMaskInLayerRange(SortingLayerRange range)
	{
		return HasSpriteMaskInLayerRange_Injected(ref range);
	}

	public unsafe static bool HasSpriteMaskInLayerRange_Injected([In] ref SortingLayerRange range)
	{
		return HasSpriteMaskInLayerRange_InjectedDelegateField((nint)Unsafe.AsPointer(ref range));
	}
}
