using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomSystem.ElementSystem;

namespace Il2CppYgomDebug;

public class LogShowChainForAnalysis : LogItemBaseForAnalysis
{
	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CHAINNUM;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CHAINTEXT;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_MINICARD;

	private static readonly IntPtr NativeFieldInfoPtr_m_ChainLabelDict;

	private static readonly IntPtr NativeFieldInfoPtr_m_EOManager_Origin;

	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowChainDataForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetWordTable_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string LABEL_EO_CHAINNUM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHAINNUM);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHAINNUM)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CHAINTEXT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHAINTEXT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHAINTEXT)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_MINICARD
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_MINICARD);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_MINICARD)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static Dictionary<ShowChainDataForAnalysis.ChainDataTypeForAnalysis, string> m_ChainLabelDict
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ChainLabelDict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<ShowChainDataForAnalysis.ChainDataTypeForAnalysis, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ChainLabelDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager m_EOManager_Origin
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EOManager_Origin);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_EOManager_Origin)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager m_EOManager
	{
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 53687, RefRangeEnd = 53690, XrefRangeStart = 53679, XrefRangeEnd = 53687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr2) : null;
		}
	}

	static LogShowChainForAnalysis()
	{
		Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogShowChainForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_LABEL_EO_CHAINNUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, "LABEL_EO_CHAINNUM");
		NativeFieldInfoPtr_LABEL_EO_CHAINTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, "LABEL_EO_CHAINTEXT");
		NativeFieldInfoPtr_LABEL_EO_MINICARD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, "LABEL_EO_MINICARD");
		NativeFieldInfoPtr_m_ChainLabelDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, "m_ChainLabelDict");
		NativeFieldInfoPtr_m_EOManager_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, "m_EOManager_Origin");
		NativeMethodInfoPtr_SetData_Public_Void_ShowChainDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, 100665307);
		NativeMethodInfoPtr_ResetWordTable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, 100665308);
		NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, 100665309);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr, 100665310);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53655, RefRangeEnd = 53656, XrefRangeStart = 53632, XrefRangeEnd = 53655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShowChainDataForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_ShowChainDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53656, XrefRangeEnd = 53679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetWordTable()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetWordTable_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53690, XrefRangeEnd = 53703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogShowChainForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogShowChainForAnalysis>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogShowChainForAnalysis(IntPtr pointer)
		: base(pointer)
	{
	}
}
