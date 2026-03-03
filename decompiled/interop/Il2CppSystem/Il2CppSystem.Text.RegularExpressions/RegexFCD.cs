using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions;

public sealed class RegexFCD : ValueType
{
	private static readonly System.IntPtr NativeFieldInfoPtr__fcStack;

	private static readonly System.IntPtr NativeFieldInfoPtr__intStack;

	private static readonly System.IntPtr NativeFieldInfoPtr__skipAllChildren;

	private static readonly System.IntPtr NativeFieldInfoPtr__skipchild;

	private static readonly System.IntPtr NativeFieldInfoPtr__failed;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FirstChars_Public_Static_Nullable_1_RegexPrefix_RegexTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Prefix_Public_Static_RegexPrefix_RegexTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Anchors_Public_Static_Int32_RegexTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushInt_Private_Void_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopInt_Private_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_PopFC_Private_RegexFC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_TopFC_Private_RegexFC_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SkipChild_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0;

	public unsafe List<RegexFC> _fcStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fcStack);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<List<RegexFC>>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__fcStack)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ValueListBuilder<int> _intStack
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__intStack);
			return new ValueListBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueListBuilder<int>>.NativeClassPtr, (System.IntPtr)num));
		}
		set
		{
			// IL cpblk instruction
			Unsafe.CopyBlock((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__intStack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueListBuilder<int>>.NativeClassPtr, ref *(uint*)null));
		}
	}

	public unsafe bool _skipAllChildren
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipAllChildren);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipAllChildren)) = value;
		}
	}

	public unsafe bool _skipchild
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipchild);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__skipchild)) = value;
		}
	}

	public unsafe bool _failed
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failed);
			return *(bool*)num;
		}
		set
		{
			*(bool*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr__failed)) = value;
		}
	}

	static RegexFCD()
	{
		Il2CppClassPointerStore<RegexFCD>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexFCD");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr);
		NativeFieldInfoPtr__fcStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_fcStack");
		NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_intStack");
		NativeFieldInfoPtr__skipAllChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipAllChildren");
		NativeFieldInfoPtr__skipchild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_skipchild");
		NativeFieldInfoPtr__failed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, "_failed");
		NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664622);
		NativeMethodInfoPtr_FirstChars_Public_Static_Nullable_1_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664623);
		NativeMethodInfoPtr_Prefix_Public_Static_RegexPrefix_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664624);
		NativeMethodInfoPtr_Anchors_Public_Static_Int32_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664625);
		NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664626);
		NativeMethodInfoPtr_PushInt_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664627);
		NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664628);
		NativeMethodInfoPtr_PopInt_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664629);
		NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664630);
		NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664631);
		NativeMethodInfoPtr_PopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664632);
		NativeMethodInfoPtr_TopFC_Private_RegexFC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664633);
		NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664634);
		NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664635);
		NativeMethodInfoPtr_SkipChild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664636);
		NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr, 100664637);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875082, XrefRangeEnd = 875091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexFCD(Span<int> intStack)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr))
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)intStack));
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Private_Void_Span_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875127, RefRangeEnd = 875128, XrefRangeStart = 875091, XrefRangeEnd = 875127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Nullable<RegexPrefix> FirstChars(RegexTree t)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)t);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FirstChars_Public_Static_Nullable_1_RegexPrefix_RegexTree_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Nullable<RegexPrefix>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875138, RefRangeEnd = 875139, XrefRangeStart = 875128, XrefRangeEnd = 875138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static RegexPrefix Prefix(RegexTree tree)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Prefix_Public_Static_RegexPrefix_RegexTree_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new RegexPrefix(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875151, RefRangeEnd = 875152, XrefRangeStart = 875139, XrefRangeEnd = 875151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int Anchors(RegexTree tree)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Anchors_Public_Static_Int32_RegexTree_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	public unsafe static int AnchorFromType(int type)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&type);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AnchorFromType_Private_Static_Int32_Int32_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875152, XrefRangeEnd = 875157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushInt(int i)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&i);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushInt_Private_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875157, XrefRangeEnd = 875158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IntIsEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_IntIsEmpty_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875158, XrefRangeEnd = 875159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int PopInt()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopInt_Private_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875165, RefRangeEnd = 875166, XrefRangeStart = 875159, XrefRangeEnd = 875165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PushFC(RegexFC fc)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)fc);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PushFC_Private_Void_RegexFC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875166, XrefRangeEnd = 875167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool FCIsEmpty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_FCIsEmpty_Private_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875175, RefRangeEnd = 875176, XrefRangeStart = 875167, XrefRangeEnd = 875175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexFC PopFC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_PopFC_Private_RegexFC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexFC>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875176, XrefRangeEnd = 875181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexFC TopFC()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_TopFC_Private_RegexFC_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexFC>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875181, XrefRangeEnd = 875184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Dispose()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 875203, RefRangeEnd = 875204, XrefRangeStart = 875184, XrefRangeEnd = 875203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RegexFC RegexFCFromRegexTree(RegexTree tree)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)tree);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_RegexFCFromRegexTree_Private_RegexFC_RegexTree_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<RegexFC>(intPtr2) : null;
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 419044, RefRangeEnd = 419045, XrefRangeStart = 419044, XrefRangeEnd = 419045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SkipChild()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SkipChild_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 875252, RefRangeEnd = 875255, XrefRangeStart = 875204, XrefRangeEnd = 875252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CalculateFC(int NodeType, RegexNode node, int CurIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[3];
		*ptr = (nint)(&NodeType);
		*(System.IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)node);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &CurIndex;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_CalculateFC_Private_Void_Int32_RegexNode_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public RegexFCD(System.IntPtr pointer)
		: base(pointer)
	{
	}

	public RegexFCD()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexFCD>.NativeClassPtr))
	{
	}
}
