using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.InteropServices;

public sealed class DllImportAttribute : Attribute
{
	private static readonly System.IntPtr NativeFieldInfoPtr__val;

	private static readonly System.IntPtr NativeFieldInfoPtr_EntryPoint;

	private static readonly System.IntPtr NativeFieldInfoPtr_CharSet;

	private static readonly System.IntPtr NativeFieldInfoPtr_SetLastError;

	private static readonly System.IntPtr NativeFieldInfoPtr_ExactSpelling;

	private static readonly System.IntPtr NativeFieldInfoPtr_PreserveSig;

	private static readonly System.IntPtr NativeFieldInfoPtr_CallingConvention;

	private static readonly System.IntPtr NativeFieldInfoPtr_BestFitMapping;

	private static readonly System.IntPtr NativeFieldInfoPtr_ThrowOnUnmappableChar;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

	public unsafe string _val
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__val);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__val)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string EntryPoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EntryPoint);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_EntryPoint)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe CharSet CharSet
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharSet);
			return *(CharSet*)num;
		}
		set
		{
			*(CharSet*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CharSet)) = value;
		}
	}

	public unsafe bool SetLastError
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetLastError);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_SetLastError)) = value;
		}
	}

	public unsafe bool ExactSpelling
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExactSpelling);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ExactSpelling)) = value;
		}
	}

	public unsafe bool PreserveSig
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreserveSig);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_PreserveSig)) = value;
		}
	}

	public unsafe CallingConvention CallingConvention
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CallingConvention);
			return *(CallingConvention*)num;
		}
		set
		{
			*(CallingConvention*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_CallingConvention)) = value;
		}
	}

	public unsafe bool BestFitMapping
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BestFitMapping);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BestFitMapping)) = value;
		}
	}

	public unsafe bool ThrowOnUnmappableChar
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThrowOnUnmappableChar);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_ThrowOnUnmappableChar)) = value;
		}
	}

	public unsafe string Value
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 50644, RefRangeEnd = 50653, XrefRangeStart = 50644, XrefRangeEnd = 50653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}
	}

	static DllImportAttribute()
	{
		Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "DllImportAttribute");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr);
		NativeFieldInfoPtr__val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "_val");
		NativeFieldInfoPtr_EntryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "EntryPoint");
		NativeFieldInfoPtr_CharSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CharSet");
		NativeFieldInfoPtr_SetLastError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "SetLastError");
		NativeFieldInfoPtr_ExactSpelling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ExactSpelling");
		NativeFieldInfoPtr_PreserveSig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "PreserveSig");
		NativeFieldInfoPtr_CallingConvention = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "CallingConvention");
		NativeFieldInfoPtr_BestFitMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "BestFitMapping");
		NativeFieldInfoPtr_ThrowOnUnmappableChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, "ThrowOnUnmappableChar");
		NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671233);
		NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671234);
		NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671235);
		NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671236);
		NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr, 100671237);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 804047, RefRangeEnd = 804048, XrefRangeStart = 804034, XrefRangeEnd = 804047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Attribute GetCustomAttribute(RuntimeMethodInfo method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCustomAttribute_Internal_Static_Attribute_RuntimeMethodInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Attribute>(intPtr2) : null;
	}

	[CallerCount(0)]
	public unsafe static bool IsDefined(RuntimeMethodInfo method)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)method);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsDefined_Internal_Static_Boolean_RuntimeMethodInfo_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 804048, XrefRangeEnd = 804051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DllImportAttribute(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[9];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(entryPoint);
		*(CharSet**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &charSet;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &exactSpelling;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &setLastError;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &preserveSig;
		*(CallingConvention**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &callingConvention;
		*(bool**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &bestFitMapping;
		*(bool**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &throwOnUnmappableChar;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Internal_Void_String_String_CharSet_Boolean_Boolean_Boolean_CallingConvention_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 684810, RefRangeEnd = 684814, XrefRangeStart = 684810, XrefRangeEnd = 684814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DllImportAttribute(string dllName)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DllImportAttribute>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(dllName);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DllImportAttribute(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
