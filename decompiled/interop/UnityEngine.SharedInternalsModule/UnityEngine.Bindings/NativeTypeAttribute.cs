using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Bindings;

public class NativeTypeAttribute : Il2CppSystem.Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__Header_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__CodegenOptions_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0;

	public unsafe string _Header_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Header_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Header_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string _IntermediateScriptingStructName_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe CodegenOptions _CodegenOptions_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CodegenOptions_k__BackingField);
			return *(CodegenOptions*)num;
		}
		set
		{
			*(CodegenOptions*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CodegenOptions_k__BackingField)) = value;
		}
	}

	public unsafe string Header
	{
		get
		{
			return _Header_k__BackingField;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42532, RefRangeEnd = 42533, XrefRangeStart = 42532, XrefRangeEnd = 42533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe string IntermediateScriptingStructName
	{
		get
		{
			return _IntermediateScriptingStructName_k__BackingField;
		}
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 86477, RefRangeEnd = 86487, XrefRangeStart = 86477, XrefRangeEnd = 86487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CodegenOptions CodegenOptions
	{
		get
		{
			return _CodegenOptions_k__BackingField;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 102244, RefRangeEnd = 102245, XrefRangeStart = 102244, XrefRangeEnd = 102245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static NativeTypeAttribute()
	{
		Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SharedInternalsModule.dll", "UnityEngine.Bindings", "NativeTypeAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__Header_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<Header>k__BackingField");
		NativeFieldInfoPtr__IntermediateScriptingStructName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<IntermediateScriptingStructName>k__BackingField");
		NativeFieldInfoPtr__CodegenOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, "<CodegenOptions>k__BackingField");
		NativeMethodInfoPtr_set_Header_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663332);
		NativeMethodInfoPtr_set_IntermediateScriptingStructName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663333);
		NativeMethodInfoPtr_set_CodegenOptions_Public_Virtual_Final_New_set_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663334);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663335);
		NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663336);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663337);
		NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr, 100663338);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271578, XrefRangeEnd = 1271579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeTypeAttribute()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271579, XrefRangeEnd = 1271580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeTypeAttribute(CodegenOptions codegenOptions)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&codegenOptions);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271580, XrefRangeEnd = 1271598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeTypeAttribute(string header)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1271598, XrefRangeEnd = 1271600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NativeTypeAttribute(CodegenOptions codegenOptions, string intermediateStructName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeTypeAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&codegenOptions);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(intermediateStructName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_CodegenOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public NativeTypeAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
