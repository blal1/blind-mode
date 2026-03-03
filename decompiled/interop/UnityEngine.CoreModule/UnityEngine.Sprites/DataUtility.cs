using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Sprites;

public sealed class DataUtility : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0;

	static DataUtility()
	{
		Il2CppClassPointerStore<DataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Sprites", "DataUtility");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataUtility>.NativeClassPtr);
		NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100668991);
		NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100668992);
		NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100668993);
		NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100668994);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241371, RefRangeEnd = 1241373, XrefRangeStart = 1241370, XrefRangeEnd = 1241371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetInnerUV(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1241374, RefRangeEnd = 1241378, XrefRangeStart = 1241373, XrefRangeEnd = 1241374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetOuterUV(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1241379, RefRangeEnd = 1241381, XrefRangeStart = 1241378, XrefRangeEnd = 1241379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector4 GetPadding(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector4*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1241381, XrefRangeEnd = 1241385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Vector2 GetMinSize(Sprite sprite)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Vector2*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public DataUtility(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
