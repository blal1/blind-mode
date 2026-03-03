using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppYgomSystem.ElementSystem;

namespace Il2CppYgomDebug;

public class LogShowPhaseForAnalysis : LogItemBaseForAnalysis
{
	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_PHASETEXT;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDNAME;

	private static readonly IntPtr NativeFieldInfoPtr_m_EOManager_Origin;

	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowPhaseDataForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string LABEL_EO_PHASETEXT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_PHASETEXT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_PHASETEXT)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CARDNAME
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDNAME);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDNAME)), IL2CPP.ManagedStringToIl2Cpp(value));
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
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 53735, RefRangeEnd = 53736, XrefRangeStart = 53727, XrefRangeEnd = 53735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static LogShowPhaseForAnalysis()
	{
		Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogShowPhaseForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_LABEL_EO_PHASETEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr, "LABEL_EO_PHASETEXT");
		NativeFieldInfoPtr_LABEL_EO_CARDNAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr, "LABEL_EO_CARDNAME");
		NativeFieldInfoPtr_m_EOManager_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr, "m_EOManager_Origin");
		NativeMethodInfoPtr_SetData_Public_Void_ShowPhaseDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr, 100665313);
		NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr, 100665314);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr, 100665315);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53726, RefRangeEnd = 53727, XrefRangeStart = 53715, XrefRangeEnd = 53726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShowPhaseDataForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_ShowPhaseDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53736, XrefRangeEnd = 53745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogShowPhaseForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogShowPhaseForAnalysis>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogShowPhaseForAnalysis(IntPtr pointer)
		: base(pointer)
	{
	}
}
