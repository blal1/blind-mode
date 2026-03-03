using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct StencilState
{
	private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteMask;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompareFunctionFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassOperationFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FailOperationFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ZFailOperationFront;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CompareFunctionBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_PassOperationBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FailOperationBack;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ZFailOperationBack;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_readMask_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	[FieldOffset(0)]
	public byte m_Enabled;

	[FieldOffset(1)]
	public byte m_ReadMask;

	[FieldOffset(2)]
	public byte m_WriteMask;

	[FieldOffset(3)]
	public byte m_Padding;

	[FieldOffset(4)]
	public byte m_CompareFunctionFront;

	[FieldOffset(5)]
	public byte m_PassOperationFront;

	[FieldOffset(6)]
	public byte m_FailOperationFront;

	[FieldOffset(7)]
	public byte m_ZFailOperationFront;

	[FieldOffset(8)]
	public byte m_CompareFunctionBack;

	[FieldOffset(9)]
	public byte m_PassOperationBack;

	[FieldOffset(10)]
	public byte m_FailOperationBack;

	[FieldOffset(11)]
	public byte m_ZFailOperationBack;

	public unsafe static StencilState defaultValue
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1239842, RefRangeEnd = 1239845, XrefRangeStart = 1239838, XrefRangeEnd = 1239842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilState*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool enabled
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1239858, RefRangeEnd = 1239861, XrefRangeStart = 1239854, XrefRangeEnd = 1239858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1239865, RefRangeEnd = 1239869, XrefRangeStart = 1239861, XrefRangeEnd = 1239865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe byte readMask
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239869, RefRangeEnd = 1239871, XrefRangeStart = 1239869, XrefRangeEnd = 1239869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_readMask_Public_get_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 968653, RefRangeEnd = 968654, XrefRangeStart = 968653, XrefRangeEnd = 968654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe byte writeMask
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239871, RefRangeEnd = 1239873, XrefRangeStart = 1239871, XrefRangeEnd = 1239871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(byte*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 968573, RefRangeEnd = 968575, XrefRangeStart = 968573, XrefRangeEnd = 968575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CompareFunction compareFunctionFront
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1239885, RefRangeEnd = 1239889, XrefRangeStart = 1239885, XrefRangeEnd = 1239885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CompareFunction*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584882, RefRangeEnd = 584883, XrefRangeStart = 584882, XrefRangeEnd = 584883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilOp passOperationFront
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239889, RefRangeEnd = 1239891, XrefRangeStart = 1239889, XrefRangeEnd = 1239889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilOp*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584883, RefRangeEnd = 584884, XrefRangeStart = 584883, XrefRangeEnd = 584884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilOp failOperationFront
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239891, RefRangeEnd = 1239893, XrefRangeStart = 1239891, XrefRangeEnd = 1239891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilOp*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584884, RefRangeEnd = 584885, XrefRangeStart = 584884, XrefRangeEnd = 584885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilOp zFailOperationFront
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239893, RefRangeEnd = 1239895, XrefRangeStart = 1239893, XrefRangeEnd = 1239893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilOp*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584885, RefRangeEnd = 584886, XrefRangeStart = 584885, XrefRangeEnd = 584886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe CompareFunction compareFunctionBack
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1239895, RefRangeEnd = 1239899, XrefRangeStart = 1239895, XrefRangeEnd = 1239895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(CompareFunction*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 376359, RefRangeEnd = 376360, XrefRangeStart = 376359, XrefRangeEnd = 376360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilOp passOperationBack
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239899, RefRangeEnd = 1239901, XrefRangeStart = 1239899, XrefRangeEnd = 1239899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilOp*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584896, RefRangeEnd = 584897, XrefRangeStart = 584896, XrefRangeEnd = 584897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilOp failOperationBack
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239901, RefRangeEnd = 1239903, XrefRangeStart = 1239901, XrefRangeEnd = 1239901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilOp*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584897, RefRangeEnd = 584898, XrefRangeStart = 584897, XrefRangeEnd = 584898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	public unsafe StencilOp zFailOperationBack
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1239903, RefRangeEnd = 1239905, XrefRangeStart = 1239903, XrefRangeEnd = 1239903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(StencilOp*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584898, RefRangeEnd = 584899, XrefRangeStart = 584898, XrefRangeEnd = 584899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static StencilState()
	{
		Il2CppClassPointerStore<StencilState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "StencilState");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilState>.NativeClassPtr);
		NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_Enabled");
		NativeFieldInfoPtr_m_ReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ReadMask");
		NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_WriteMask");
		NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_Padding");
		NativeFieldInfoPtr_m_CompareFunctionFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_CompareFunctionFront");
		NativeFieldInfoPtr_m_PassOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_PassOperationFront");
		NativeFieldInfoPtr_m_FailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_FailOperationFront");
		NativeFieldInfoPtr_m_ZFailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ZFailOperationFront");
		NativeFieldInfoPtr_m_CompareFunctionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_CompareFunctionBack");
		NativeFieldInfoPtr_m_PassOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_PassOperationBack");
		NativeFieldInfoPtr_m_FailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_FailOperationBack");
		NativeFieldInfoPtr_m_ZFailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, "m_ZFailOperationBack");
		NativeMethodInfoPtr_get_defaultValue_Public_Static_get_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668761);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668762);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668763);
		NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668764);
		NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668765);
		NativeMethodInfoPtr_get_readMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668766);
		NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668767);
		NativeMethodInfoPtr_get_writeMask_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668768);
		NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668769);
		NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668770);
		NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668771);
		NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668772);
		NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668773);
		NativeMethodInfoPtr_get_compareFunctionFront_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668774);
		NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668775);
		NativeMethodInfoPtr_get_passOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668776);
		NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668777);
		NativeMethodInfoPtr_get_failOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668778);
		NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668779);
		NativeMethodInfoPtr_get_zFailOperationFront_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668780);
		NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668781);
		NativeMethodInfoPtr_get_compareFunctionBack_Public_get_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668782);
		NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668783);
		NativeMethodInfoPtr_get_passOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668784);
		NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668785);
		NativeMethodInfoPtr_get_failOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668786);
		NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668787);
		NativeMethodInfoPtr_get_zFailOperationBack_Public_get_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668788);
		NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668789);
		NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668790);
		NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668791);
		NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100668792);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239845, XrefRangeEnd = 1239846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StencilState(bool enabled = true, byte readMask = byte.MaxValue, byte writeMask = byte.MaxValue, CompareFunction compareFunction = CompareFunction.Always, StencilOp passOperation = StencilOp.Keep, StencilOp failOperation = StencilOp.Keep, StencilOp zFailOperation = StencilOp.Keep)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&enabled);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readMask;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &writeMask;
		*(CompareFunction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &compareFunction;
		*(StencilOp**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &passOperation;
		*(StencilOp**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &failOperation;
		*(StencilOp**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &zFailOperation;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 1239850, RefRangeEnd = 1239854, XrefRangeStart = 1239846, XrefRangeEnd = 1239850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe StencilState(bool enabled, byte readMask, byte writeMask, CompareFunction compareFunctionFront, StencilOp passOperationFront, StencilOp failOperationFront, StencilOp zFailOperationFront, CompareFunction compareFunctionBack, StencilOp passOperationBack, StencilOp failOperationBack, StencilOp zFailOperationBack)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[11];
		*ptr = (nint)(&enabled);
		*(byte**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &readMask;
		*(byte**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &writeMask;
		*(CompareFunction**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &compareFunctionFront;
		*(StencilOp**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &passOperationFront;
		*(StencilOp**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &failOperationFront;
		*(StencilOp**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &zFailOperationFront;
		*(CompareFunction**)((byte*)ptr + checked((nuint)7u * unchecked((nuint)sizeof(System.IntPtr)))) = &compareFunctionBack;
		*(StencilOp**)((byte*)ptr + checked((nuint)8u * unchecked((nuint)sizeof(System.IntPtr)))) = &passOperationBack;
		*(StencilOp**)((byte*)ptr + checked((nuint)9u * unchecked((nuint)sizeof(System.IntPtr)))) = &failOperationBack;
		*(StencilOp**)((byte*)ptr + checked((nuint)10u * unchecked((nuint)sizeof(System.IntPtr)))) = &zFailOperationBack;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Byte_Byte_CompareFunction_StencilOp_StencilOp_StencilOp_CompareFunction_StencilOp_StencilOp_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239873, RefRangeEnd = 1239876, XrefRangeStart = 1239873, XrefRangeEnd = 1239873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCompareFunction(CompareFunction value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCompareFunction_Public_Void_CompareFunction_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239876, RefRangeEnd = 1239879, XrefRangeStart = 1239876, XrefRangeEnd = 1239876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPassOperation(StencilOp value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPassOperation_Public_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239879, RefRangeEnd = 1239882, XrefRangeStart = 1239879, XrefRangeEnd = 1239879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFailOperation(StencilOp value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFailOperation_Public_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 1239882, RefRangeEnd = 1239885, XrefRangeStart = 1239882, XrefRangeEnd = 1239882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetZFailOperation(StencilOp value)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&value);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetZFailOperation_Public_Void_StencilOp_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe virtual bool Equals(StencilState other)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&other);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1239905, XrefRangeEnd = 1239909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Il2CppSystem.Object obj)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)obj);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 1239920, RefRangeEnd = 1239921, XrefRangeStart = 1239909, XrefRangeEnd = 1239920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StencilState>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}

	public static bool operator ==(StencilState left, StencilState right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(StencilState left, StencilState right)
	{
		return !left.Equals(right);
	}
}
