using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct VertexGradient
{
	private static readonly System.IntPtr NativeFieldInfoPtr_topLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_topRight;

	private static readonly System.IntPtr NativeFieldInfoPtr_bottomLeft;

	private static readonly System.IntPtr NativeFieldInfoPtr_bottomRight;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0;

	[FieldOffset(0)]
	public Color topLeft;

	[FieldOffset(16)]
	public Color topRight;

	[FieldOffset(32)]
	public Color bottomLeft;

	[FieldOffset(48)]
	public Color bottomRight;

	static VertexGradient()
	{
		Il2CppClassPointerStore<VertexGradient>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "VertexGradient");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr);
		NativeFieldInfoPtr_topLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "topLeft");
		NativeFieldInfoPtr_topRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "topRight");
		NativeFieldInfoPtr_bottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "bottomLeft");
		NativeFieldInfoPtr_bottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, "bottomRight");
		NativeMethodInfoPtr__ctor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, 100663612);
		NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, 100663613);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1119848, RefRangeEnd = 1119849, XrefRangeStart = 1119848, XrefRangeEnd = 1119848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VertexGradient(Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&color);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe VertexGradient(Color color0, Color color1, Color color2, Color color3)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&color0);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color1;
		*(Color**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &color2;
		*(Color**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &color3;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Color_Color_Color_Color_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexGradient>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
