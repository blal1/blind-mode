using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppSpine.Unity.AttachmentTools;

public static class AttachmentRegionExtensions : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_Sprite_Material_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_Sprite_AtlasPage_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRegionAttachmentPMAClone_Public_Static_RegionAttachment_Sprite_Shader_TextureFormat_Boolean_Material_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRegionAttachmentPMAClone_Public_Static_RegionAttachment_Sprite_Material_TextureFormat_Boolean_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_AtlasRegion_String_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Public_Static_Void_RegionAttachment_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetScale_Public_Static_Void_RegionAttachment_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionOffset_Public_Static_Void_RegionAttachment_Vector2_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPositionOffset_Public_Static_Void_RegionAttachment_Single_Single_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetRotation_Public_Static_Void_RegionAttachment_Single_0;

	static AttachmentRegionExtensions()
	{
		Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity.AttachmentTools", "AttachmentRegionExtensions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr);
		NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_Sprite_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664255);
		NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_Sprite_AtlasPage_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664256);
		NativeMethodInfoPtr_ToRegionAttachmentPMAClone_Public_Static_RegionAttachment_Sprite_Shader_TextureFormat_Boolean_Material_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664257);
		NativeMethodInfoPtr_ToRegionAttachmentPMAClone_Public_Static_RegionAttachment_Sprite_Material_TextureFormat_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664258);
		NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_AtlasRegion_String_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664259);
		NativeMethodInfoPtr_SetScale_Public_Static_Void_RegionAttachment_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664260);
		NativeMethodInfoPtr_SetScale_Public_Static_Void_RegionAttachment_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664261);
		NativeMethodInfoPtr_SetPositionOffset_Public_Static_Void_RegionAttachment_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664262);
		NativeMethodInfoPtr_SetPositionOffset_Public_Static_Void_RegionAttachment_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664263);
		NativeMethodInfoPtr_SetRotation_Public_Static_Void_RegionAttachment_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentRegionExtensions>.NativeClassPtr, 100664264);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859055, XrefRangeEnd = 859060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegionAttachment ToRegionAttachment(this Sprite sprite, Material material, float rotation = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)material);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_Sprite_Material_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 859075, RefRangeEnd = 859076, XrefRangeStart = 859060, XrefRangeEnd = 859075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegionAttachment ToRegionAttachment(this Sprite sprite, AtlasPage page, float rotation = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)page);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_Sprite_AtlasPage_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859076, XrefRangeEnd = 859103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegionAttachment ToRegionAttachmentPMAClone(this Sprite sprite, Shader shader, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, Material materialPropertySource = null, float rotation = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)shader);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(float**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRegionAttachmentPMAClone_Public_Static_RegionAttachment_Sprite_Shader_TextureFormat_Boolean_Material_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 859103, XrefRangeEnd = 859118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegionAttachment ToRegionAttachmentPMAClone(this Sprite sprite, Material materialPropertySource, TextureFormat textureFormat = TextureFormat.RGBA32, bool mipmaps = false, float rotation = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sprite);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)materialPropertySource);
		*(TextureFormat**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &textureFormat;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &mipmaps;
		*(float**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRegionAttachmentPMAClone_Public_Static_RegionAttachment_Sprite_Material_TextureFormat_Boolean_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 859129, RefRangeEnd = 859132, XrefRangeStart = 859118, XrefRangeEnd = 859129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegionAttachment ToRegionAttachment(this AtlasRegion region, string attachmentName, float scale = 0.01f, float rotation = 0f)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)region);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(attachmentName);
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		*(float**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ToRegionAttachment_Public_Static_RegionAttachment_AtlasRegion_String_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static void SetScale(this RegionAttachment regionAttachment, Vector2 scale)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionAttachment);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &scale;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScale_Public_Static_Void_RegionAttachment_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetScale(this RegionAttachment regionAttachment, float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionAttachment);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetScale_Public_Static_Void_RegionAttachment_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetPositionOffset(this RegionAttachment regionAttachment, Vector2 offset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionAttachment);
		*(Vector2**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &offset;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionOffset_Public_Static_Void_RegionAttachment_Vector2_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetPositionOffset(this RegionAttachment regionAttachment, float x, float y)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionAttachment);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &x;
		*(float**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &y;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionOffset_Public_Static_Void_RegionAttachment_Single_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe static void SetRotation(this RegionAttachment regionAttachment, float rotation)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)regionAttachment);
		*(float**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &rotation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetRotation_Public_Static_Void_RegionAttachment_Single_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public AttachmentRegionExtensions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
