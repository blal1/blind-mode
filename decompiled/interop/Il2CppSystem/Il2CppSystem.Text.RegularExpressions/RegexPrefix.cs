using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class RegexPrefix : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__CaseInsensitive_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Empty_k__BackingField;

	private static readonly System.IntPtr NativeFieldInfoPtr__Prefix_k__BackingField;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Prefix_Internal_get_String_0;

	public unsafe bool _CaseInsensitive_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CaseInsensitive_k__BackingField);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__CaseInsensitive_k__BackingField)) = value;
		}
	}

	public unsafe static RegexPrefix _Empty_k__BackingField
	{
		get
		{
			System.IntPtr intPtr = (nint)stackalloc byte[(int)(uint)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, ref *(uint*)null)];
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr__Empty_k__BackingField, (void*)intPtr);
			return new RegexPrefix(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, intPtr));
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr__Empty_k__BackingField, (void*)IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)value)));
		}
	}

	public unsafe string _Prefix_k__BackingField
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Prefix_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__Prefix_k__BackingField)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe bool CaseInsensitive
	{
		[CallerCount(90)]
		[CachedScanResults(RefRangeStart = 720416, RefRangeEnd = 720506, XrefRangeStart = 720416, XrefRangeEnd = 720506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe static RegexPrefix Empty
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 876611, XrefRangeEnd = 876615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RegexPrefix(pointer);
		}
	}

	public unsafe string Prefix
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Prefix_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static RegexPrefix()
	{
		Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexPrefix");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr);
		NativeFieldInfoPtr__CaseInsensitive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "<CaseInsensitive>k__BackingField");
		NativeFieldInfoPtr__Empty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "<Empty>k__BackingField");
		NativeFieldInfoPtr__Prefix_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, "<Prefix>k__BackingField");
		NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664789);
		NativeMethodInfoPtr_get_CaseInsensitive_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664790);
		NativeMethodInfoPtr_get_Empty_Internal_Static_get_RegexPrefix_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664791);
		NativeMethodInfoPtr_get_Prefix_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr, 100664792);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 876609, RefRangeEnd = 876611, XrefRangeStart = 876608, XrefRangeEnd = 876609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexPrefix(string prefix, bool ci)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &ci;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RegexPrefix(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RegexPrefix()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexPrefix>.NativeClassPtr))
	{
	}
}
