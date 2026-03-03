using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine.Unity;

public class RegionlessAttachmentLoader : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_emptyRegion;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_EmptyRegion_Private_Static_get_AtlasRegion_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewRegionAttachment_Public_Virtual_Final_New_RegionAttachment_Skin_String_String_Sequence_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewMeshAttachment_Public_Virtual_Final_New_MeshAttachment_Skin_String_String_Sequence_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewBoundingBoxAttachment_Public_Virtual_Final_New_BoundingBoxAttachment_Skin_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewPathAttachment_Public_Virtual_Final_New_PathAttachment_Skin_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewPointAttachment_Public_Virtual_Final_New_PointAttachment_Skin_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NewClippingAttachment_Public_Virtual_Final_New_ClippingAttachment_Skin_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static AtlasRegion emptyRegion
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_emptyRegion, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_emptyRegion, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static AtlasRegion EmptyRegion
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 850706, RefRangeEnd = 850708, XrefRangeStart = 850662, XrefRangeEnd = 850706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_EmptyRegion_Private_Static_get_AtlasRegion_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<AtlasRegion>(intPtr2) : null;
		}
	}

	static RegionlessAttachmentLoader()
	{
		Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "RegionlessAttachmentLoader");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr);
		NativeFieldInfoPtr_emptyRegion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, "emptyRegion");
		NativeMethodInfoPtr_get_EmptyRegion_Private_Static_get_AtlasRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_NewRegionAttachment_Public_Virtual_Final_New_RegionAttachment_Skin_String_String_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_NewMeshAttachment_Public_Virtual_Final_New_MeshAttachment_Skin_String_String_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr_NewBoundingBoxAttachment_Public_Virtual_Final_New_BoundingBoxAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr_NewPathAttachment_Public_Virtual_Final_New_PathAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663394);
		NativeMethodInfoPtr_NewPointAttachment_Public_Virtual_Final_New_PointAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr_NewClippingAttachment_Public_Virtual_Final_New_ClippingAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr, 100663397);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850708, XrefRangeEnd = 850714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual RegionAttachment NewRegionAttachment(Skin skin, string name, string path, Sequence sequence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sequence);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewRegionAttachment_Public_Virtual_Final_New_RegionAttachment_Skin_String_String_Sequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850714, XrefRangeEnd = 850720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual MeshAttachment NewMeshAttachment(Skin skin, string name, string path, Sequence sequence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sequence);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewMeshAttachment_Public_Virtual_Final_New_MeshAttachment_Skin_String_String_Sequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<MeshAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850720, XrefRangeEnd = 850724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewBoundingBoxAttachment_Public_Virtual_Final_New_BoundingBoxAttachment_Skin_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BoundingBoxAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850724, XrefRangeEnd = 850728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PathAttachment NewPathAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewPathAttachment_Public_Virtual_Final_New_PathAttachment_Skin_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PathAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850728, XrefRangeEnd = 850732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual PointAttachment NewPointAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewPointAttachment_Public_Virtual_Final_New_PointAttachment_Skin_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<PointAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850732, XrefRangeEnd = 850736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual ClippingAttachment NewClippingAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_NewClippingAttachment_Public_Virtual_Final_New_ClippingAttachment_Skin_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ClippingAttachment>(intPtr2) : null;
	}

	[CallerCount(1950)]
	[CachedScanResults(RefRangeStart = 20036, RefRangeEnd = 21986, XrefRangeStart = 20036, XrefRangeEnd = 21986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegionlessAttachmentLoader()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegionlessAttachmentLoader>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RegionlessAttachmentLoader(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
