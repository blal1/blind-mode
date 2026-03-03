using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSpine;

public class BoundingBoxAttachment : VertexAttachment
{
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_BoundingBoxAttachment_0;

	private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Virtual_Attachment_0;

	static BoundingBoxAttachment()
	{
		Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-csharp.dll", "Spine", "BoundingBoxAttachment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr, 100663657);
		NativeMethodInfoPtr__ctor_Protected_Void_BoundingBoxAttachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr, 100663658);
		NativeMethodInfoPtr_Copy_Public_Virtual_Attachment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr, 100663659);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 842662, RefRangeEnd = 842663, XrefRangeStart = 842658, XrefRangeEnd = 842662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoundingBoxAttachment(string name)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842663, XrefRangeEnd = 842667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BoundingBoxAttachment(BoundingBoxAttachment other)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoundingBoxAttachment>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)other);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Protected_Void_BoundingBoxAttachment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 842667, XrefRangeEnd = 842674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Attachment Copy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_Copy_Public_Virtual_Attachment_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Attachment>(intPtr2) : null;
	}

	public BoundingBoxAttachment(IntPtr pointer)
		: base(pointer)
	{
	}
}
