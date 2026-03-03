using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.IO;

public class EnumerationOptions : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Compatible_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CompatibleRecursive_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Default_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__RecurseSubdirectories_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IgnoreInaccessible_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__BufferSize_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__AttributesToSkip_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MatchType_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__MatchCasing_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__ReturnSpecialDirectories_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Compatible_Internal_Static_get_EnumerationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CompatibleRecursive_Private_Static_get_EnumerationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Internal_Static_get_EnumerationOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FromSearchOption_Internal_Static_EnumerationOptions_SearchOption_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_RecurseSubdirectories_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_RecurseSubdirectories_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_IgnoreInaccessible_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IgnoreInaccessible_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_BufferSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_AttributesToSkip_Public_get_FileAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_AttributesToSkip_Public_set_Void_FileAttributes_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MatchType_Public_get_MatchType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_MatchType_Public_set_Void_MatchType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MatchCasing_Public_get_MatchCasing_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_ReturnSpecialDirectories_Public_get_Boolean_0;

	public unsafe static EnumerationOptions _Compatible_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Compatible_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Compatible_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EnumerationOptions _CompatibleRecursive_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__CompatibleRecursive_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__CompatibleRecursive_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static EnumerationOptions _Default_k__BackingField
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Default_k__BackingField, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Default_k__BackingField, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe bool _RecurseSubdirectories_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RecurseSubdirectories_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__RecurseSubdirectories_k__BackingField)) = value;
		}
	}

	public unsafe bool _IgnoreInaccessible_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IgnoreInaccessible_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IgnoreInaccessible_k__BackingField)) = value;
		}
	}

	public unsafe int _BufferSize_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BufferSize_k__BackingField);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__BufferSize_k__BackingField)) = value;
		}
	}

	public unsafe FileAttributes _AttributesToSkip_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttributesToSkip_k__BackingField);
			return *(FileAttributes*)num;
		}
		set
		{
			*(FileAttributes*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__AttributesToSkip_k__BackingField)) = value;
		}
	}

	public unsafe MatchType _MatchType_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MatchType_k__BackingField);
			return *(MatchType*)num;
		}
		set
		{
			*(MatchType*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MatchType_k__BackingField)) = value;
		}
	}

	public unsafe MatchCasing _MatchCasing_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MatchCasing_k__BackingField);
			return *(MatchCasing*)num;
		}
		set
		{
			*(MatchCasing*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__MatchCasing_k__BackingField)) = value;
		}
	}

	public unsafe bool _ReturnSpecialDirectories_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReturnSpecialDirectories_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__ReturnSpecialDirectories_k__BackingField)) = value;
		}
	}

	public unsafe static EnumerationOptions Compatible
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836088, XrefRangeEnd = 836092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Compatible_Internal_Static_get_EnumerationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
		}
	}

	public unsafe static EnumerationOptions CompatibleRecursive
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836092, XrefRangeEnd = 836096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CompatibleRecursive_Private_Static_get_EnumerationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
		}
	}

	public unsafe static EnumerationOptions Default
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836096, XrefRangeEnd = 836100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Default_Internal_Static_get_EnumerationOptions_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
		}
	}

	public unsafe bool RecurseSubdirectories
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_RecurseSubdirectories_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 86557, RefRangeEnd = 86558, XrefRangeStart = 86557, XrefRangeEnd = 86558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_RecurseSubdirectories_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe bool IgnoreInaccessible
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_IgnoreInaccessible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IgnoreInaccessible_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe int BufferSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_BufferSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe FileAttributes AttributesToSkip
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_AttributesToSkip_Public_get_FileAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(FileAttributes*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155401, RefRangeEnd = 155404, XrefRangeStart = 155401, XrefRangeEnd = 155404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_AttributesToSkip_Public_set_Void_FileAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MatchType MatchType
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MatchType_Public_get_MatchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MatchType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_MatchType_Public_set_Void_MatchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe MatchCasing MatchCasing
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 63233, RefRangeEnd = 63234, XrefRangeStart = 63233, XrefRangeEnd = 63234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MatchCasing_Public_get_MatchCasing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(MatchCasing*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool ReturnSpecialDirectories
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_ReturnSpecialDirectories_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static EnumerationOptions()
	{
		Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "EnumerationOptions");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr);
		NativeFieldInfoPtr__Compatible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<Compatible>k__BackingField");
		NativeFieldInfoPtr__CompatibleRecursive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<CompatibleRecursive>k__BackingField");
		NativeFieldInfoPtr__Default_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<Default>k__BackingField");
		NativeFieldInfoPtr__RecurseSubdirectories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<RecurseSubdirectories>k__BackingField");
		NativeFieldInfoPtr__IgnoreInaccessible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<IgnoreInaccessible>k__BackingField");
		NativeFieldInfoPtr__BufferSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<BufferSize>k__BackingField");
		NativeFieldInfoPtr__AttributesToSkip_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<AttributesToSkip>k__BackingField");
		NativeFieldInfoPtr__MatchType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<MatchType>k__BackingField");
		NativeFieldInfoPtr__MatchCasing_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<MatchCasing>k__BackingField");
		NativeFieldInfoPtr__ReturnSpecialDirectories_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, "<ReturnSpecialDirectories>k__BackingField");
		NativeMethodInfoPtr_get_Compatible_Internal_Static_get_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674722);
		NativeMethodInfoPtr_get_CompatibleRecursive_Private_Static_get_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674723);
		NativeMethodInfoPtr_get_Default_Internal_Static_get_EnumerationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674724);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674725);
		NativeMethodInfoPtr_FromSearchOption_Internal_Static_EnumerationOptions_SearchOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674726);
		NativeMethodInfoPtr_get_RecurseSubdirectories_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674727);
		NativeMethodInfoPtr_set_RecurseSubdirectories_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674728);
		NativeMethodInfoPtr_get_IgnoreInaccessible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674729);
		NativeMethodInfoPtr_set_IgnoreInaccessible_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674730);
		NativeMethodInfoPtr_get_BufferSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674731);
		NativeMethodInfoPtr_get_AttributesToSkip_Public_get_FileAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674732);
		NativeMethodInfoPtr_set_AttributesToSkip_Public_set_Void_FileAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674733);
		NativeMethodInfoPtr_get_MatchType_Public_get_MatchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674734);
		NativeMethodInfoPtr_set_MatchType_Public_set_Void_MatchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674735);
		NativeMethodInfoPtr_get_MatchCasing_Public_get_MatchCasing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674736);
		NativeMethodInfoPtr_get_ReturnSpecialDirectories_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr, 100674737);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 836100, XrefRangeEnd = 836101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe EnumerationOptions()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumerationOptions>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 836108, RefRangeEnd = 836110, XrefRangeStart = 836101, XrefRangeEnd = 836108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static EnumerationOptions FromSearchOption(SearchOption searchOption)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&searchOption);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FromSearchOption_Internal_Static_EnumerationOptions_SearchOption_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<EnumerationOptions>(intPtr2) : null;
	}

	public EnumerationOptions(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
