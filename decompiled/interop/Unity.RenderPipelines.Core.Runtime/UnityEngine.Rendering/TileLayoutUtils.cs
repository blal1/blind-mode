using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering;

public static class TileLayoutUtils : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_TryLayoutByTiles_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_byref_RectInt_byref_RectInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryLayoutByRow_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryLayoutByCol_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0;

	static TileLayoutUtils()
	{
		Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TileLayoutUtils");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr);
		NativeMethodInfoPtr_TryLayoutByTiles_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_byref_RectInt_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr, 100666835);
		NativeMethodInfoPtr_TryLayoutByRow_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr, 100666836);
		NativeMethodInfoPtr_TryLayoutByCol_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileLayoutUtils>.NativeClassPtr, 100666837);
	}

	[CallerCount(0)]
	public unsafe static bool TryLayoutByTiles(RectInt src, uint tileSize, out RectInt main, out RectInt topRow, out RectInt rightCol, out RectInt topRight)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&src);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileSize;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref main);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref topRow);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref rightCol);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref topRight);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLayoutByTiles_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_byref_RectInt_byref_RectInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool TryLayoutByRow(RectInt src, uint tileSize, out RectInt main, out RectInt other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&src);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileSize;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref main);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLayoutByRow_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static bool TryLayoutByCol(RectInt src, uint tileSize, out RectInt main, out RectInt other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&src);
		*(uint**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileSize;
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref main);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryLayoutByCol_Public_Static_Boolean_RectInt_UInt32_byref_RectInt_byref_RectInt_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public TileLayoutUtils(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
