using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomGame.Duel;

namespace Il2CppYgomDebug;

[System.Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct LogDataCenterForAnalysis
{
	private static readonly System.IntPtr NativeFieldInfoPtr_dataint0;

	private static readonly System.IntPtr NativeFieldInfoPtr_dataint1;

	private static readonly System.IntPtr NativeFieldInfoPtr_boolbits;

	private static readonly System.IntPtr NativeFieldInfoPtr_databyte0;

	private static readonly System.IntPtr NativeFieldInfoPtr_databyte1;

	private static readonly System.IntPtr NativeFieldInfoPtr_datatype;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_show_Private_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LogDataCenter_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_LOGACTIONTYPE_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_LOGACTIONTYPE_Boolean_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_DamageType_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Boolean_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_AddEfxNoInfo_Public_Void_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isActDataShow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isIndent_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_team_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_extendinfo_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_acttype_Public_get_LOGACTIONTYPE_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_efxbegin_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_efxend_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isLPCDataShow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_changevalue_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_restLP_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_lpctype_Public_get_DamageType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCCDataShow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numpre_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_numaft_Public_get_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_countertype_Public_get_CounterType_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetActionData_Public_ValueTuple_2_LOGACTIONTYPE_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetLPChangeData_Public_ValueTuple_4_Int32_Int32_DamageType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCounterChangeData_Public_ValueTuple_4_Int32_Int32_CounterType_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SetBmgVisible_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isDiceDataShow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetDiceData_Public_ValueTuple_2_Boolean_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_isCoinDataShow_Public_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_GetCoinResults_Public_ValueTuple_2_Boolean_List_1_Boolean_0;

	[FieldOffset(0)]
	public int dataint0;

	[FieldOffset(4)]
	public int dataint1;

	[FieldOffset(8)]
	public byte boolbits;

	[FieldOffset(9)]
	public byte databyte0;

	[FieldOffset(10)]
	public byte databyte1;

	[FieldOffset(11)]
	public byte datatype;

	public unsafe bool show
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 52648, RefRangeEnd = 52649, XrefRangeStart = 52648, XrefRangeEnd = 52648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_show_Private_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isActDataShow
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 52666, RefRangeEnd = 52670, XrefRangeStart = 52666, XrefRangeEnd = 52666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isActDataShow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isIndent
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52670, XrefRangeEnd = 52671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isIndent_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool team
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52671, XrefRangeEnd = 52672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_team_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool extendinfo
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52672, XrefRangeEnd = 52673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_extendinfo_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe LOGACTIONTYPE acttype
	{
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 52673, RefRangeEnd = 52681, XrefRangeStart = 52673, XrefRangeEnd = 52673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_acttype_Public_get_LOGACTIONTYPE_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(LOGACTIONTYPE*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int efxbegin
	{
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 52424, RefRangeEnd = 52442, XrefRangeStart = 52424, XrefRangeEnd = 52442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_efxbegin_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int efxend
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_efxend_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isLPCDataShow
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isLPCDataShow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int changevalue
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_changevalue_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int restLP
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_restLP_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Engine.DamageType lpctype
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_lpctype_Public_get_DamageType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Engine.DamageType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isCCDataShow
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCCDataShow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int numpre
	{
		[CallerCount(175)]
		[CachedScanResults(RefRangeStart = 52464, RefRangeEnd = 52639, XrefRangeStart = 52464, XrefRangeEnd = 52639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numpre_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe int numaft
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_numaft_Public_get_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(int*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe Engine.CounterType countertype
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52681, XrefRangeEnd = 52685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_countertype_Public_get_CounterType_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(Engine.CounterType*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isDiceDataShow
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isDiceDataShow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	public unsafe bool isCoinDataShow
	{
		[CallerCount(0)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_isCoinDataShow_Public_get_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
	}

	static LogDataCenterForAnalysis()
	{
		Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogDataCenterForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_dataint0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, "dataint0");
		NativeFieldInfoPtr_dataint1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, "dataint1");
		NativeFieldInfoPtr_boolbits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, "boolbits");
		NativeFieldInfoPtr_databyte0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, "databyte0");
		NativeFieldInfoPtr_databyte1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, "databyte1");
		NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, "datatype");
		NativeMethodInfoPtr_get_show_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665249);
		NativeMethodInfoPtr__ctor_Public_Void_LogDataCenter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665250);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_LOGACTIONTYPE_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665251);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_LOGACTIONTYPE_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665252);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_DamageType_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665253);
		NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665254);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665255);
		NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665256);
		NativeMethodInfoPtr_AddEfxNoInfo_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665257);
		NativeMethodInfoPtr_get_isActDataShow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665258);
		NativeMethodInfoPtr_get_isIndent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665259);
		NativeMethodInfoPtr_get_team_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665260);
		NativeMethodInfoPtr_get_extendinfo_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665261);
		NativeMethodInfoPtr_get_acttype_Public_get_LOGACTIONTYPE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665262);
		NativeMethodInfoPtr_get_efxbegin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665263);
		NativeMethodInfoPtr_get_efxend_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665264);
		NativeMethodInfoPtr_get_isLPCDataShow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665265);
		NativeMethodInfoPtr_get_changevalue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665266);
		NativeMethodInfoPtr_get_restLP_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665267);
		NativeMethodInfoPtr_get_lpctype_Public_get_DamageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665268);
		NativeMethodInfoPtr_get_isCCDataShow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665269);
		NativeMethodInfoPtr_get_numpre_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665270);
		NativeMethodInfoPtr_get_numaft_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665271);
		NativeMethodInfoPtr_get_countertype_Public_get_CounterType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665272);
		NativeMethodInfoPtr_GetActionData_Public_ValueTuple_2_LOGACTIONTYPE_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665273);
		NativeMethodInfoPtr_GetLPChangeData_Public_ValueTuple_4_Int32_Int32_DamageType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665274);
		NativeMethodInfoPtr_GetCounterChangeData_Public_ValueTuple_4_Int32_Int32_CounterType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665275);
		NativeMethodInfoPtr_SetBmgVisible_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665276);
		NativeMethodInfoPtr_get_isDiceDataShow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665277);
		NativeMethodInfoPtr_GetDiceData_Public_ValueTuple_2_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665278);
		NativeMethodInfoPtr_get_isCoinDataShow_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665279);
		NativeMethodInfoPtr_GetCoinResults_Public_ValueTuple_2_Boolean_List_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, 100665280);
	}

	[CallerCount(0)]
	public unsafe LogDataCenterForAnalysis(LogDataCenter logDataCenter)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = (nint)(&logDataCenter);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_LogDataCenter_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(14)]
	[CachedScanResults(RefRangeStart = 52649, RefRangeEnd = 52663, XrefRangeStart = 52649, XrefRangeEnd = 52649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogDataCenterForAnalysis(bool show, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[5];
		*ptr = (nint)(&show);
		*(LOGACTIONTYPE**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(bool**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &isIndent;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &team;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &extendinfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_LOGACTIONTYPE_Boolean_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe LogDataCenterForAnalysis(bool show, int efxbegin, int efxend, LOGACTIONTYPE type, bool isIndent, bool team, bool extendinfo = false)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[7];
		*ptr = (nint)(&show);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &efxbegin;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &efxend;
		*(LOGACTIONTYPE**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &type;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isIndent;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &team;
		*(bool**)((byte*)ptr + checked((nuint)6u * unchecked((nuint)sizeof(System.IntPtr)))) = &extendinfo;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_LOGACTIONTYPE_Boolean_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52663, RefRangeEnd = 52664, XrefRangeStart = 52663, XrefRangeEnd = 52663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogDataCenterForAnalysis(bool show, int changevalue, int restLP, Engine.DamageType lpctype, bool isIndent, bool team)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&show);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &changevalue;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &restLP;
		*(Engine.DamageType**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &lpctype;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isIndent;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &team;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_DamageType_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52664, RefRangeEnd = 52665, XrefRangeStart = 52664, XrefRangeEnd = 52664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogDataCenterForAnalysis(bool show, int numpre, int numaft, int countertype, bool isIndent, bool team)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[6];
		*ptr = (nint)(&show);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &numpre;
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(System.IntPtr)))) = &numaft;
		*(int**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(System.IntPtr)))) = &countertype;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(System.IntPtr)))) = &isIndent;
		*(bool**)((byte*)ptr + checked((nuint)5u * unchecked((nuint)sizeof(System.IntPtr)))) = &team;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_Int32_Int32_Boolean_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe LogDataCenterForAnalysis(int coincount, int resultbits)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&coincount);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &resultbits;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52665, RefRangeEnd = 52666, XrefRangeStart = 52665, XrefRangeEnd = 52665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogDataCenterForAnalysis(int dicenum, bool team)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&dicenum);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &team;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe void AddEfxNoInfo(int efxbegin, int efxend)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&efxbegin);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &efxend;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_AddEfxNoInfo_Public_Void_Int32_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52685, XrefRangeEnd = 52689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<LOGACTIONTYPE, bool> GetActionData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetActionData_Public_ValueTuple_2_LOGACTIONTYPE_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<LOGACTIONTYPE, bool>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52689, XrefRangeEnd = 52693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<int, int, Engine.DamageType, bool> GetLPChangeData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetLPChangeData_Public_ValueTuple_4_Int32_Int32_DamageType_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<int, int, Engine.DamageType, bool>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52693, XrefRangeEnd = 52701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<int, int, Engine.CounterType, bool> GetCounterChangeData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCounterChangeData_Public_ValueTuple_4_Int32_Int32_CounterType_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<int, int, Engine.CounterType, bool>(pointer);
	}

	[CallerCount(0)]
	public unsafe void SetBmgVisible()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetBmgVisible_Public_Void_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52701, XrefRangeEnd = 52705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<bool, int> GetDiceData()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetDiceData_Public_ValueTuple_2_Boolean_Int32_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<bool, int>(pointer);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52720, RefRangeEnd = 52721, XrefRangeStart = 52705, XrefRangeEnd = 52720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<bool, List<bool>> GetCoinResults()
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_GetCoinResults_Public_ValueTuple_2_Boolean_List_1_Boolean_0, (System.IntPtr)(nint)Unsafe.AsPointer(ref this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<bool, List<bool>>(pointer);
	}

	public unsafe Il2CppSystem.Object BoxIl2CppObject()
	{
		return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogDataCenterForAnalysis>.NativeClassPtr, (System.IntPtr)(nint)Unsafe.AsPointer(ref this)));
	}
}
