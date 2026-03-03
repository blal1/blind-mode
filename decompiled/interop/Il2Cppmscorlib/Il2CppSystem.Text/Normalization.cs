using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text;

public class Normalization : Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_props;

	private static readonly System.IntPtr NativeFieldInfoPtr_mappedChars;

	private static readonly System.IntPtr NativeFieldInfoPtr_charMapIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_helperIndex;

	private static readonly System.IntPtr NativeFieldInfoPtr_mapIdxToComposite;

	private static readonly System.IntPtr NativeFieldInfoPtr_combiningClass;

	private static readonly System.IntPtr NativeFieldInfoPtr_forLock;

	private static readonly System.IntPtr NativeFieldInfoPtr_isReady;

	private static readonly System.IntPtr NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0;

	public unsafe static byte* props
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_props, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_props, (void*)value);
		}
	}

	public unsafe static int* mappedChars
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mappedChars, (void*)(&intPtr));
			return *(int**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mappedChars, (void*)value);
		}
	}

	public unsafe static short* charMapIndex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_charMapIndex, (void*)(&intPtr));
			return *(short**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_charMapIndex, (void*)value);
		}
	}

	public unsafe static short* helperIndex
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_helperIndex, (void*)(&intPtr));
			return *(short**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_helperIndex, (void*)value);
		}
	}

	public unsafe static ushort* mapIdxToComposite
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_mapIdxToComposite, (void*)(&intPtr));
			return *(ushort**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_mapIdxToComposite, (void*)value);
		}
	}

	public unsafe static byte* combiningClass
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_combiningClass, (void*)(&intPtr));
			return *(byte**)intPtr;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_combiningClass, (void*)value);
		}
	}

	public unsafe static Object forLock
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_forLock, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_forLock, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool isReady
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isReady, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isReady, (void*)(&value));
		}
	}

	static Normalization()
	{
		Il2CppClassPointerStore<Normalization>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "Normalization");
		NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "props");
		NativeFieldInfoPtr_mappedChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mappedChars");
		NativeFieldInfoPtr_charMapIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "charMapIndex");
		NativeFieldInfoPtr_helperIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "helperIndex");
		NativeFieldInfoPtr_mapIdxToComposite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "mapIdxToComposite");
		NativeFieldInfoPtr_combiningClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "combiningClass");
		NativeFieldInfoPtr_forLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "forLock");
		NativeFieldInfoPtr_isReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Normalization>.NativeClassPtr, "isReady");
		NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669031);
		NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669032);
		NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669033);
		NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669034);
		NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669035);
		NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669036);
		NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669037);
		NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669038);
		NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669039);
		NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669040);
		NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669041);
		NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669042);
		NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669043);
		NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669044);
		NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669045);
		NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669046);
		NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669047);
		NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669048);
		NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669049);
		NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669050);
		NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669051);
		NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Normalization>.NativeClassPtr, 100669052);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 782783, RefRangeEnd = 782785, XrefRangeStart = 782775, XrefRangeEnd = 782783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint PropValue(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PropValue_Private_Static_UInt32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(uint*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782785, XrefRangeEnd = 782793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CharMapIdx(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CharMapIdx_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 782802, RefRangeEnd = 782812, XrefRangeStart = 782793, XrefRangeEnd = 782802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static byte GetCombiningClass(int c)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&c);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCombiningClass_Private_Static_Byte_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 782821, RefRangeEnd = 782822, XrefRangeStart = 782812, XrefRangeEnd = 782821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrimaryCompositeFromMapIndex(int src)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&src);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimaryCompositeFromMapIndex_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782822, XrefRangeEnd = 782831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPrimaryCompositeHelperIndex(int cp)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&cp);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetPrimaryCompositeHelperIndex_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 782854, RefRangeEnd = 782855, XrefRangeStart = 782831, XrefRangeEnd = 782854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Compose(string source, int checkType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Compose_Private_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782855, XrefRangeEnd = 782869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static StringBuilder Combine(string source, int start, int checkType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Static_StringBuilder_String_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 782894, RefRangeEnd = 782897, XrefRangeStart = 782869, XrefRangeEnd = 782894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Combine(StringBuilder sb, int i, int checkType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Combine_Private_Static_Void_StringBuilder_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782897, XrefRangeEnd = 782916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int CombineHangul(StringBuilder sb, string s, int current)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &current;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CombineHangul_Private_Static_Int32_StringBuilder_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782916, XrefRangeEnd = 782917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Fetch(StringBuilder sb, string s, int i)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Fetch_Private_Static_Int32_StringBuilder_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 782930, RefRangeEnd = 782931, XrefRangeStart = 782917, XrefRangeEnd = 782930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryComposeWithPreviousStarter(StringBuilder sb, string s, int current)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &current;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryComposeWithPreviousStarter_Private_Static_Int32_StringBuilder_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 782931, XrefRangeEnd = 782947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int TryCompose(int i, int starter, int candidate)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&i);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &starter;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &candidate;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TryCompose_Private_Static_Int32_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783013, RefRangeEnd = 783014, XrefRangeStart = 782947, XrefRangeEnd = 783013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Decompose(string source, int checkType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decompose_Private_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783044, RefRangeEnd = 783045, XrefRangeStart = 783014, XrefRangeEnd = 783044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Decompose(string source, ref StringBuilder sb, int checkType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Decompose_Private_Static_Void_String_byref_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		sb = ((intPtr4 == (System.IntPtr)0) ? null : new StringBuilder(intPtr4));
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 783079, RefRangeEnd = 783081, XrefRangeStart = 783045, XrefRangeEnd = 783079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ReorderCanonical(string src, ref StringBuilder sb, int start)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(src);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*(System.IntPtr**)num = &intPtr;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &start;
		Unsafe.SkipInit(out System.IntPtr intPtr2);
		System.IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ReorderCanonical_Private_Static_Void_String_byref_StringBuilder_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		System.IntPtr intPtr4 = intPtr;
		sb = ((intPtr4 == (System.IntPtr)0) ? null : new StringBuilder(intPtr4));
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783081, XrefRangeEnd = 783099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DecomposeChar(ref StringBuilder sb, ref Il2CppStructArray<int> buf, string s, int i, int checkType, ref int start)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)sb);
		*ptr = (nint)(&intPtr);
		byte* num = (byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)));
		System.IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(System.IntPtr**)num = &intPtr2;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.ManagedStringToIl2Cpp(s);
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &i;
		*(int**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref start);
		Unsafe.SkipInit(out System.IntPtr intPtr3);
		System.IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_DecomposeChar_Private_Static_Void_byref_StringBuilder_byref_Il2CppStructArray_1_Int32_String_Int32_Int32_byref_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		System.IntPtr intPtr5 = intPtr;
		sb = ((intPtr5 == (System.IntPtr)0) ? null : new StringBuilder(intPtr5));
		System.IntPtr intPtr6 = intPtr2;
		buf = ((intPtr6 == (System.IntPtr)0) ? null : new Il2CppStructArray<int>(intPtr6));
	}

	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 783103, RefRangeEnd = 783108, XrefRangeStart = 783099, XrefRangeEnd = 783103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static NormalizationCheck QuickCheck(char c, int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&c);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_QuickCheck_Public_Static_NormalizationCheck_Char_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(NormalizationCheck*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int GetCanonicalHangul(int s, Il2CppStructArray<int> buf, int bufIdx)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&s);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufIdx;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanonicalHangul_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 783111, RefRangeEnd = 783114, XrefRangeStart = 783108, XrefRangeEnd = 783111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetCanonical(int c, Il2CppStructArray<int> buf, int bufIdx, int checkType)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = (nint)(&c);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)buf);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &bufIdx;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &checkType;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCanonical_Private_Static_Int32_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783127, RefRangeEnd = 783128, XrefRangeStart = 783114, XrefRangeEnd = 783127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Normalize(string source, NormalizationForm normalizationForm)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		*(NormalizationForm**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &normalizationForm;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalize_Public_Static_String_String_NormalizationForm_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 783135, RefRangeEnd = 783136, XrefRangeStart = 783128, XrefRangeEnd = 783135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Normalize(string source, int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(source);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Normalize_Public_Static_String_String_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return IL2CPP.Il2CppStringToManaged(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 783136, XrefRangeEnd = 783137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void load_normalization_resource(out System.IntPtr props, out System.IntPtr mappedChars, out System.IntPtr charMapIndex, out System.IntPtr helperIndex, out System.IntPtr mapIdxToComposite, out System.IntPtr combiningClass)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)Unsafe.AsPointer(ref props);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mappedChars);
		*(void**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref charMapIndex);
		*(void**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref helperIndex);
		*(void**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref mapIdxToComposite);
		*(void**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = Unsafe.AsPointer(ref combiningClass);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_load_normalization_resource_Private_Static_Void_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_byref_IntPtr_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public Normalization(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
