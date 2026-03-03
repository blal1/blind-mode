using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine;

public class AttachmentLoader : Il2CppObjectBase
{
	private static readonly IntPtr NativeMethodInfoPtr_NewRegionAttachment_Public_Abstract_Virtual_New_RegionAttachment_Skin_String_String_Sequence_0;

	private static readonly IntPtr NativeMethodInfoPtr_NewMeshAttachment_Public_Abstract_Virtual_New_MeshAttachment_Skin_String_String_Sequence_0;

	private static readonly IntPtr NativeMethodInfoPtr_NewBoundingBoxAttachment_Public_Abstract_Virtual_New_BoundingBoxAttachment_Skin_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_NewPathAttachment_Public_Abstract_Virtual_New_PathAttachment_Skin_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_NewPointAttachment_Public_Abstract_Virtual_New_PointAttachment_Skin_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_NewClippingAttachment_Public_Abstract_Virtual_New_ClippingAttachment_Skin_String_0;

	static AttachmentLoader()
	{
		Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "AttachmentLoader");
		NativeMethodInfoPtr_NewRegionAttachment_Public_Abstract_Virtual_New_RegionAttachment_Skin_String_String_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr, 100663651);
		NativeMethodInfoPtr_NewMeshAttachment_Public_Abstract_Virtual_New_MeshAttachment_Skin_String_String_Sequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr, 100663652);
		NativeMethodInfoPtr_NewBoundingBoxAttachment_Public_Abstract_Virtual_New_BoundingBoxAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr, 100663653);
		NativeMethodInfoPtr_NewPathAttachment_Public_Abstract_Virtual_New_PathAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr, 100663654);
		NativeMethodInfoPtr_NewPointAttachment_Public_Abstract_Virtual_New_PointAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr, 100663655);
		NativeMethodInfoPtr_NewClippingAttachment_Public_Abstract_Virtual_New_ClippingAttachment_Skin_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentLoader>.NativeClassPtr, 100663656);
	}

	[CallerCount(0)]
	public unsafe virtual RegionAttachment NewRegionAttachment(Skin skin, string name, string path, Sequence sequence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sequence);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NewRegionAttachment_Public_Abstract_Virtual_New_RegionAttachment_Skin_String_String_Sequence_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<RegionAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual MeshAttachment NewMeshAttachment(Skin skin, string name, string path, Sequence sequence)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(path);
		*(IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sequence);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NewMeshAttachment_Public_Abstract_Virtual_New_MeshAttachment_Skin_String_String_Sequence_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<MeshAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NewBoundingBoxAttachment_Public_Abstract_Virtual_New_BoundingBoxAttachment_Skin_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<BoundingBoxAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual PathAttachment NewPathAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NewPathAttachment_Public_Abstract_Virtual_New_PathAttachment_Skin_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PathAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual PointAttachment NewPointAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NewPointAttachment_Public_Abstract_Virtual_New_PointAttachment_Skin_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<PointAttachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe virtual ClippingAttachment NewClippingAttachment(Skin skin, string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skin);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NewClippingAttachment_Public_Abstract_Virtual_New_ClippingAttachment_Skin_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ClippingAttachment>(intPtr2) : null;
	}

	public AttachmentLoader(IntPtr pointer)
		: base(pointer)
	{
	}
}
