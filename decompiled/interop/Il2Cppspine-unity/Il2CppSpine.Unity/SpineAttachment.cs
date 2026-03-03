using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppSpine.Unity;

public class SpineAttachment : SpineAttributeBase
{
	public sealed class Hierarchy : Il2CppSystem.ValueType
	{
		private static readonly System.IntPtr NativeFieldInfoPtr_skin;

		private static readonly System.IntPtr NativeFieldInfoPtr_slot;

		private static readonly System.IntPtr NativeFieldInfoPtr_name;

		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		public unsafe string skin
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skin);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skin)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string slot
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slot);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slot)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		public unsafe string name
		{
			get
			{
				nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
			}
			set
			{
				System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_name)), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		static Hierarchy()
		{
			Il2CppClassPointerStore<Hierarchy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, "Hierarchy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr);
			NativeFieldInfoPtr_skin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "skin");
			NativeFieldInfoPtr_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "slot");
			NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, "name");
			NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr, 100664132);
		}

		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 857860, RefRangeEnd = 857863, XrefRangeStart = 857838, XrefRangeEnd = 857860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hierarchy(string fullPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}

		public Hierarchy(System.IntPtr pointer)
			: base(pointer)
		{
		}

		public Hierarchy()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hierarchy>.NativeClassPtr))
		{
		}
	}

	private static readonly System.IntPtr NativeFieldInfoPtr_returnAttachmentPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_currentSkinOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_placeholdersOnly;

	private static readonly System.IntPtr NativeFieldInfoPtr_skinField;

	private static readonly System.IntPtr NativeFieldInfoPtr_slotField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_String_String_String_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHierarchy_Public_Static_Hierarchy_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttachment_Public_Static_Attachment_String_SkeletonData_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetAttachment_Public_Static_Attachment_String_SkeletonDataAsset_0;

	public unsafe bool returnAttachmentPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_returnAttachmentPath);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_returnAttachmentPath)) = value;
		}
	}

	public unsafe bool currentSkinOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSkinOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_currentSkinOnly)) = value;
		}
	}

	public unsafe bool placeholdersOnly
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeholdersOnly);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_placeholdersOnly)) = value;
		}
	}

	public unsafe string skinField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_skinField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string slotField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_slotField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	static SpineAttachment()
	{
		Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr = IL2CPP.GetIl2CppClass("spine-unity.dll", "Spine.Unity", "SpineAttachment");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr);
		NativeFieldInfoPtr_returnAttachmentPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, "returnAttachmentPath");
		NativeFieldInfoPtr_currentSkinOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, "currentSkinOnly");
		NativeFieldInfoPtr_placeholdersOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, "placeholdersOnly");
		NativeFieldInfoPtr_skinField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, "skinField");
		NativeFieldInfoPtr_slotField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, "slotField");
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_String_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, 100664128);
		NativeMethodInfoPtr_GetHierarchy_Public_Static_Hierarchy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, 100664129);
		NativeMethodInfoPtr_GetAttachment_Public_Static_Attachment_String_SkeletonData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, 100664130);
		NativeMethodInfoPtr_GetAttachment_Public_Static_Attachment_String_SkeletonDataAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr, 100664131);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857863, XrefRangeEnd = 857881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpineAttachment(bool currentSkinOnly = true, bool returnAttachmentPath = false, bool placeholdersOnly = false, string slotField = "", string dataField = "", string skinField = "", bool includeNone = true, bool fallbackToTextField = false)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpineAttachment>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[8];
		*ptr = (nint)(&currentSkinOnly);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &returnAttachmentPath;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &placeholdersOnly;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(slotField);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(dataField);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(skinField);
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &includeNone;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &fallbackToTextField;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Boolean_Boolean_String_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857881, XrefRangeEnd = 857882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Hierarchy GetHierarchy(string fullPath)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPath);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHierarchy_Public_Static_Hierarchy_String_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Hierarchy(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857882, XrefRangeEnd = 857887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Attachment GetAttachment(string attachmentPath, SkeletonData skeletonData)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(attachmentPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonData);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttachment_Public_Static_Attachment_String_SkeletonData_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Attachment>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857887, XrefRangeEnd = 857893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Attachment GetAttachment(string attachmentPath, SkeletonDataAsset skeletonDataAsset)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(attachmentPath);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)skeletonDataAsset);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetAttachment_Public_Static_Attachment_String_SkeletonDataAsset_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Attachment>(intPtr2) : null;
	}

	public SpineAttachment(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
