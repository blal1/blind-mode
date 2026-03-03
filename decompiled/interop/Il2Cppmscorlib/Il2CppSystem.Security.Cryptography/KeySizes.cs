using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Security.Cryptography;

public sealed class KeySizes : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_minSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_maxSize;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_skipSize;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0;

	public unsafe int m_minSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_minSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_minSize)) = value;
		}
	}

	public unsafe int m_maxSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_maxSize)) = value;
		}
	}

	public unsafe int m_skipSize
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_skipSize);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_skipSize)) = value;
		}
	}

	public unsafe int MinSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 50668, RefRangeEnd = 50669, XrefRangeStart = 50668, XrefRangeEnd = 50669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int MaxSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82717, RefRangeEnd = 82718, XrefRangeStart = 82717, XrefRangeEnd = 82718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int SkipSize
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 54510, RefRangeEnd = 54511, XrefRangeStart = 54510, XrefRangeEnd = 54511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static KeySizes()
	{
		Il2CppClassPointerStore<KeySizes>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "KeySizes");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeySizes>.NativeClassPtr);
		NativeFieldInfoPtr_m_minSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_minSize");
		NativeFieldInfoPtr_m_maxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_maxSize");
		NativeFieldInfoPtr_m_skipSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, "m_skipSize");
		NativeMethodInfoPtr_get_MinSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669235);
		NativeMethodInfoPtr_get_MaxSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669236);
		NativeMethodInfoPtr_get_SkipSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669237);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669238);
		NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669239);
		NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySizes>.NativeClassPtr, 100669240);
	}

	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 583836, RefRangeEnd = 583844, XrefRangeStart = 583836, XrefRangeEnd = 583844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KeySizes(int minSize, int maxSize, int skipSize)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySizes>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&minSize);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &maxSize;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &skipSize;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 784955, XrefRangeEnd = 784956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsLegal(int keySize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&keySize);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLegal_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 784958, RefRangeEnd = 784959, XrefRangeStart = 784956, XrefRangeEnd = 784958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsLegalKeySize(Il2CppReferenceArray<KeySizes> legalKeys, int size)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)legalKeys);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IsLegalKeySize_Internal_Static_Boolean_Il2CppReferenceArray_1_KeySizes_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public KeySizes(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
