using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppSpine.Unity.AttachmentTools;

public static class AttachmentCloneExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_GetRemappedClone_Public_Static_Attachment_Attachment_Sprite_Material_Boolean_Boolean_Boolean_Boolean_Boolean_TextureFormat_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetRemappedClone_Public_Static_Attachment_Attachment_AtlasRegion_Boolean_Boolean_Single_0;

	static AttachmentCloneExtensions()
	{
		Il2CppClassPointerStore<AttachmentCloneExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity.AttachmentTools", "AttachmentCloneExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentCloneExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_GetRemappedClone_Public_Static_Attachment_Attachment_Sprite_Material_Boolean_Boolean_Boolean_Boolean_Boolean_TextureFormat_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentCloneExtensions>.NativeClassPtr, 100664253);
		NativeMethodInfoPtr_GetRemappedClone_Public_Static_Attachment_Attachment_AtlasRegion_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentCloneExtensions>.NativeClassPtr, 100664254);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859018, XrefRangeEnd = 859048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Attachment GetRemappedClone(this Attachment o, Sprite sprite, Material sourceMaterial, bool premultiplyAlpha = true, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, bool pivotShiftsMeshUVCoords = true, bool useOriginalRegionScale = false, TextureFormat pmaCloneTextureFormat = TextureFormat.RGBA32, bool pmaCloneMipmaps = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[10];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sourceMaterial);
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &premultiplyAlpha;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &cloneMeshAsLinked;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalRegionSize;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &pivotShiftsMeshUVCoords;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalRegionScale;
		*(TextureFormat**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &pmaCloneTextureFormat;
		*(bool**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &pmaCloneMipmaps;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRemappedClone_Public_Static_Attachment_Attachment_Sprite_Material_Boolean_Boolean_Boolean_Boolean_Boolean_TextureFormat_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Attachment>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859054, RefRangeEnd = 859055, XrefRangeStart = 859048, XrefRangeEnd = 859054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Attachment GetRemappedClone(this Attachment o, AtlasRegion atlasRegion, bool cloneMeshAsLinked = true, bool useOriginalRegionSize = false, float scale = 0.01f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)o);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)atlasRegion);
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &cloneMeshAsLinked;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &useOriginalRegionSize;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetRemappedClone_Public_Static_Attachment_Attachment_AtlasRegion_Boolean_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Attachment>(intPtr2) : null;
	}

	public AttachmentCloneExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
