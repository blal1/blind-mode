using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.U2D.Animation;

public class SpriteLibrarySourceAsset : ScriptableObject
{
	private static readonly IntPtr NativeFieldInfoPtr_defaultName;

	private static readonly IntPtr NativeFieldInfoPtr_extension;

	private static readonly IntPtr NativeFieldInfoPtr_m_Library;

	private static readonly IntPtr NativeFieldInfoPtr_m_PrimaryLibraryGUID;

	private static readonly IntPtr NativeFieldInfoPtr_m_ModificationHash;

	private static readonly IntPtr NativeFieldInfoPtr_m_Version;

	private static readonly IntPtr NativeMethodInfoPtr_get_library_Public_get_IReadOnlyList_1_SpriteLibCategoryOverride_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_primaryLibraryGUID_Public_get_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_modificationHash_Public_get_Int64_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_get_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_InitializeWithAsset_Public_Void_SpriteLibrarySourceAsset_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLibrary_Public_Void_IList_1_SpriteLibCategoryOverride_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPrimaryLibraryGUID_Public_Void_String_0;

	private static readonly IntPtr NativeMethodInfoPtr_AddCategory_Public_Void_SpriteLibCategoryOverride_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveCategory_Public_Void_SpriteLibCategoryOverride_0;

	private static readonly IntPtr NativeMethodInfoPtr_ClearCategories_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_RemoveCategory_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateModificationHash_Private_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static string defaultName
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_defaultName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_defaultName, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string extension
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_extension, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_extension, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe List<SpriteLibCategoryOverride> m_Library
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Library);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<List<SpriteLibCategoryOverride>>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Library)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string m_PrimaryLibraryGUID
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrimaryLibraryGUID);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_PrimaryLibraryGUID)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe long m_ModificationHash
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ModificationHash);
			return *(long*)num;
		}
		set
		{
			*(long*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ModificationHash)) = value;
		}
	}

	public unsafe int m_Version
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Version)) = value;
		}
	}

	public unsafe IReadOnlyList<SpriteLibCategoryOverride> library
	{
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 25665, RefRangeEnd = 25677, XrefRangeStart = 25665, XrefRangeEnd = 25677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_library_Public_get_IReadOnlyList_1_SpriteLibCategoryOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<IReadOnlyList<SpriteLibCategoryOverride>>(intPtr2) : null;
		}
	}

	public unsafe string primaryLibraryGUID
	{
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 32112, RefRangeEnd = 32148, XrefRangeStart = 32112, XrefRangeEnd = 32148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_primaryLibraryGUID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe long modificationHash
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42604, RefRangeEnd = 42610, XrefRangeStart = 42604, XrefRangeEnd = 42610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_modificationHash_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(long*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int version
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66330, RefRangeEnd = 66331, XrefRangeStart = 66330, XrefRangeEnd = 66331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static SpriteLibrarySourceAsset()
	{
		Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.2D.Animation.Runtime.dll", "UnityEngine.U2D.Animation", "SpriteLibrarySourceAsset");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr);
		NativeFieldInfoPtr_defaultName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, "defaultName");
		NativeFieldInfoPtr_extension = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, "extension");
		NativeFieldInfoPtr_m_Library = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, "m_Library");
		NativeFieldInfoPtr_m_PrimaryLibraryGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, "m_PrimaryLibraryGUID");
		NativeFieldInfoPtr_m_ModificationHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, "m_ModificationHash");
		NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, "m_Version");
		NativeMethodInfoPtr_get_library_Public_get_IReadOnlyList_1_SpriteLibCategoryOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663600);
		NativeMethodInfoPtr_get_primaryLibraryGUID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663601);
		NativeMethodInfoPtr_get_modificationHash_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663602);
		NativeMethodInfoPtr_get_version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663603);
		NativeMethodInfoPtr_InitializeWithAsset_Public_Void_SpriteLibrarySourceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663604);
		NativeMethodInfoPtr_SetLibrary_Public_Void_IList_1_SpriteLibCategoryOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663605);
		NativeMethodInfoPtr_SetPrimaryLibraryGUID_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663606);
		NativeMethodInfoPtr_AddCategory_Public_Void_SpriteLibCategoryOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663607);
		NativeMethodInfoPtr_RemoveCategory_Public_Void_SpriteLibCategoryOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663608);
		NativeMethodInfoPtr_ClearCategories_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663609);
		NativeMethodInfoPtr_RemoveCategory_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663610);
		NativeMethodInfoPtr_UpdateModificationHash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663611);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr, 100663612);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956798, XrefRangeEnd = 956806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeWithAsset(SpriteLibrarySourceAsset source)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)source);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_InitializeWithAsset_Public_Void_SpriteLibrarySourceAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956806, XrefRangeEnd = 956814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLibrary(IList<SpriteLibCategoryOverride> newLibrary)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newLibrary);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLibrary_Public_Void_IList_1_SpriteLibCategoryOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956814, XrefRangeEnd = 956817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPrimaryLibraryGUID(string newPrimaryLibraryGUID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(newPrimaryLibraryGUID);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPrimaryLibraryGUID_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956817, XrefRangeEnd = 956826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddCategory(SpriteLibCategoryOverride newCategory)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)newCategory);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddCategory_Public_Void_SpriteLibCategoryOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956826, XrefRangeEnd = 956833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCategory(SpriteLibCategoryOverride categoryToRemove)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)categoryToRemove);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCategory_Public_Void_SpriteLibCategoryOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956833, XrefRangeEnd = 956835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearCategories()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ClearCategories_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956835, XrefRangeEnd = 956840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveCategory(int indexToRemove)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&indexToRemove);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RemoveCategory_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 956848, RefRangeEnd = 956853, XrefRangeStart = 956840, XrefRangeEnd = 956848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateModificationHash()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateModificationHash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 956853, XrefRangeEnd = 956861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpriteLibrarySourceAsset()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteLibrarySourceAsset>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public SpriteLibrarySourceAsset(IntPtr pointer)
		: base(pointer)
	{
	}
}
