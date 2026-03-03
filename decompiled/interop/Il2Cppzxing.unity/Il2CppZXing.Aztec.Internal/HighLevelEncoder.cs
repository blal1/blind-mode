using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppZXing.Common;

namespace Il2CppZXing.Aztec.Internal;

public sealed class HighLevelEncoder : Il2CppSystem.Object
{
	private static readonly System.IntPtr NativeFieldInfoPtr_MODE_NAMES;

	private static readonly System.IntPtr NativeFieldInfoPtr_LATCH_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_CHAR_MAP;

	private static readonly System.IntPtr NativeFieldInfoPtr_SHIFT_TABLE;

	private static readonly System.IntPtr NativeFieldInfoPtr_text;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_encode_Public_BitArray_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateStateListForChar_Private_ICollection_1_State_IEnumerable_1_State_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateStateForChar_Private_Void_State_Int32_ICollection_1_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateStateListForPair_Private_Static_ICollection_1_State_IEnumerable_1_State_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_updateStateForPair_Private_Static_Void_State_Int32_Int32_ICollection_1_State_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_simplifyStates_Private_Static_ICollection_1_State_IEnumerable_1_State_0;

	public unsafe static Il2CppStringArray MODE_NAMES
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_MODE_NAMES, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_MODE_NAMES, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> LATCH_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_LATCH_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_LATCH_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> CHAR_MAP
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_CHAR_MAP, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_CHAR_MAP, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Il2CppReferenceArray<Il2CppStructArray<int>> SHIFT_TABLE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SHIFT_TABLE, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppStructArray<int>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SHIFT_TABLE, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Il2CppStructArray<byte> text
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_text)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static HighLevelEncoder()
	{
		Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("zxing.unity.dll", "ZXing.Aztec.Internal", "HighLevelEncoder");
		NativeFieldInfoPtr_MODE_NAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, "MODE_NAMES");
		NativeFieldInfoPtr_LATCH_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, "LATCH_TABLE");
		NativeFieldInfoPtr_CHAR_MAP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, "CHAR_MAP");
		NativeFieldInfoPtr_SHIFT_TABLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, "SHIFT_TABLE");
		NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, "text");
		NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664916);
		NativeMethodInfoPtr_encode_Public_BitArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664917);
		NativeMethodInfoPtr_updateStateListForChar_Private_ICollection_1_State_IEnumerable_1_State_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664918);
		NativeMethodInfoPtr_updateStateForChar_Private_Void_State_Int32_ICollection_1_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664919);
		NativeMethodInfoPtr_updateStateListForPair_Private_Static_ICollection_1_State_IEnumerable_1_State_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664920);
		NativeMethodInfoPtr_updateStateForPair_Private_Static_Void_State_Int32_Int32_ICollection_1_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664921);
		NativeMethodInfoPtr_simplifyStates_Private_Static_ICollection_1_State_IEnumerable_1_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr, 100664922);
	}

	[CallerCount(215)]
	[CachedScanResults(RefRangeStart = 79185, RefRangeEnd = 79400, XrefRangeStart = 79185, XrefRangeEnd = 79400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HighLevelEncoder(Il2CppStructArray<byte> text)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HighLevelEncoder>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)text);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430823, RefRangeEnd = 1430824, XrefRangeStart = 1430780, XrefRangeEnd = 1430823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe BitArray encode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_encode_Public_BitArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<BitArray>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430852, RefRangeEnd = 1430853, XrefRangeStart = 1430824, XrefRangeEnd = 1430852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ICollection<State> updateStateListForChar(IEnumerable<State> states, int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)states);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateStateListForChar_Private_ICollection_1_State_IEnumerable_1_State_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<State>>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430877, RefRangeEnd = 1430878, XrefRangeStart = 1430853, XrefRangeEnd = 1430877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void updateStateForChar(State state, int index, ICollection<State> result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateStateForChar_Private_Void_State_Int32_ICollection_1_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1430923, RefRangeEnd = 1430924, XrefRangeStart = 1430878, XrefRangeEnd = 1430923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ICollection<State> updateStateListForPair(IEnumerable<State> states, int index, int pairCode)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)states);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pairCode;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateStateListForPair_Private_Static_ICollection_1_State_IEnumerable_1_State_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<State>>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1430924, XrefRangeEnd = 1430940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void updateStateForPair(State state, int index, int pairCode, ICollection<State> result)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[4];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)state);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &index;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &pairCode;
		*(System.IntPtr*)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)result);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_updateStateForPair_Private_Static_Void_State_Int32_Int32_ICollection_1_State_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 1431012, RefRangeEnd = 1431014, XrefRangeStart = 1430940, XrefRangeEnd = 1431012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static ICollection<State> simplifyStates(IEnumerable<State> states)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)states);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_simplifyStates_Private_Static_ICollection_1_State_IEnumerable_1_State_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<ICollection<State>>(intPtr2) : null;
	}

	public HighLevelEncoder(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
