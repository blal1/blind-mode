using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppTMPro;

[StructLayout(LayoutKind.Explicit)]
public struct GlyphPairKey
{
	private static readonly System.IntPtr NativeFieldInfoPtr_firstGlyphIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_secondGlyphIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_key;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0;

	[FieldOffset(0)]
	public uint firstGlyphIndex;

	[FieldOffset(4)]
	public uint secondGlyphIndex;

	[FieldOffset(8)]
	public uint key;

	static GlyphPairKey()
	{
		Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "GlyphPairKey");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr);
		NativeFieldInfoPtr_firstGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "firstGlyphIndex");
		NativeFieldInfoPtr_secondGlyphIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "secondGlyphIndex");
		NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, "key");
		NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, 100664038);
		NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, 100664039);
	}

	[CallerCount(0)]
	public unsafe GlyphPairKey(uint firstGlyphIndex, uint secondGlyphIndex)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&firstGlyphIndex);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &secondGlyphIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe GlyphPairKey(TMP_GlyphPairAdjustmentRecord record)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)record);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_TMP_GlyphPairAdjustmentRecord_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphPairKey>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
