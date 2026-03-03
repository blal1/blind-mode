using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomSystem.ElementSystem;

namespace Il2CppYgomDebug;

public class LogShowTextForAnalysis : LogItemBaseForAnalysis
{
	private static readonly IntPtr NativeFieldInfoPtr_m_TextTable;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CONTENT;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM0;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM1;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_TEXT;

	private static readonly IntPtr NativeFieldInfoPtr_m_EOManager_Origin;

	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowTextDataForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static List<string> m_TextTable
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_TextTable, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_TextTable, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe string LABEL_EO_CONTENT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CONTENT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CONTENT)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COLORBARTEAM0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM0);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM0)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COLORBARTEAM1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM1);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM1)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_TEXT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_TEXT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_TEXT)), IL2CPP.ManagedStringToIl2Cpp(value));
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
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 53834, RefRangeEnd = 53838, XrefRangeStart = 53826, XrefRangeEnd = 53834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static LogShowTextForAnalysis()
	{
		Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogShowTextForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_m_TextTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, "m_TextTable");
		NativeFieldInfoPtr_LABEL_EO_CONTENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, "LABEL_EO_CONTENT");
		NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, "LABEL_EO_COLORBARTEAM0");
		NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, "LABEL_EO_COLORBARTEAM1");
		NativeFieldInfoPtr_LABEL_EO_TEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, "LABEL_EO_TEXT");
		NativeFieldInfoPtr_m_EOManager_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, "m_EOManager_Origin");
		NativeMethodInfoPtr_SetData_Public_Void_ShowTextDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, 100665322);
		NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, 100665323);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr, 100665324);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53799, XrefRangeEnd = 53826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShowTextDataForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_ShowTextDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53838, XrefRangeEnd = 53855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogShowTextForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogShowTextForAnalysis>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogShowTextForAnalysis(IntPtr pointer)
		: base(pointer)
	{
	}
}
