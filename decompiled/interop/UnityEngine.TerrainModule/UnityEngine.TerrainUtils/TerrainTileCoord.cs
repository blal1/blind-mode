using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TerrainUtils;

[StructLayout(LayoutKind.Explicit)]
public struct TerrainTileCoord
{
	private static readonly System.IntPtr NativeFieldInfoPtr_tileX;

	private static readonly System.IntPtr NativeFieldInfoPtr_tileZ;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	[FieldOffset(0)]
	public readonly int tileX;

	[FieldOffset(4)]
	public readonly int tileZ;

	static TerrainTileCoord()
	{
		Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TerrainModule.dll", "UnityEngine.TerrainUtils", "TerrainTileCoord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr);
		NativeFieldInfoPtr_tileX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, "tileX");
		NativeFieldInfoPtr_tileZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, "tileZ");
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, 100663327);
	}

	[CallerCount(230)]
	[CachedScanResults(RefRangeStart = 409470, RefRangeEnd = 409700, XrefRangeStart = 409470, XrefRangeEnd = 409700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe TerrainTileCoord(int tileX, int tileZ)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&tileX);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &tileZ;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerrainTileCoord>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
