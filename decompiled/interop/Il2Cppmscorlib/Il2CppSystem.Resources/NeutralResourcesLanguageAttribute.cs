using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Resources;

public sealed class NeutralResourcesLanguageAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__CultureName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Location_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CultureName_Public_get_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0;

	public unsafe string _CultureName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CultureName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CultureName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe UltimateResourceFallbackLocation _Location_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Location_k__BackingField);
			return *(UltimateResourceFallbackLocation*)num;
		}
		set
		{
			*(UltimateResourceFallbackLocation*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Location_k__BackingField)) = value;
		}
	}

	public unsafe string CultureName
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CultureName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	public unsafe UltimateResourceFallbackLocation Location
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(UltimateResourceFallbackLocation*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static NeutralResourcesLanguageAttribute()
	{
		Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Resources", "NeutralResourcesLanguageAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__CultureName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "<CultureName>k__BackingField");
		NativeFieldInfoPtr__Location_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, "<Location>k__BackingField");
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100671562);
		NativeMethodInfoPtr_get_CultureName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100671563);
		NativeMethodInfoPtr_get_Location_Public_get_UltimateResourceFallbackLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr, 100671564);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 807495, XrefRangeEnd = 807497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NeutralResourcesLanguageAttribute(string cultureName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeutralResourcesLanguageAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(cultureName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NeutralResourcesLanguageAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
