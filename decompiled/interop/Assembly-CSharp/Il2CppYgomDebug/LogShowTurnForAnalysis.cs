using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppYgomSystem.ElementSystem;
using UnityEngine;

namespace Il2CppYgomDebug;

public class LogShowTurnForAnalysis : LogItemBaseForAnalysis
{
	private static readonly IntPtr NativeFieldInfoPtr_SINGALCHARWIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_TEXT_TURN;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_PLAERICON;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_FaceIconL;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_FaceIconR;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_FaceIcon;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_FaceIconCursor;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_LPValueL;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_LPValueR;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_TurnText;

	private static readonly IntPtr NativeFieldInfoPtr_m_Label_TurnBg;

	private static readonly IntPtr NativeFieldInfoPtr_m_Color_Team0;

	private static readonly IntPtr NativeFieldInfoPtr_m_Color_Team1;

	private static readonly IntPtr NativeFieldInfoPtr_m_IconIDL;

	private static readonly IntPtr NativeFieldInfoPtr_m_IconIDR;

	private static readonly IntPtr NativeFieldInfoPtr_m_EOManager_Origin;

	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowTurnDataForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetFaceIcon_Protected_Void_Int32_GameObject_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLP_Protected_Void_String_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetTurn_Protected_Void_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int SINGALCHARWIDTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_SINGALCHARWIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_SINGALCHARWIDTH, (void*)(&value));
		}
	}

	public unsafe static string TEXT_TURN
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_TEXT_TURN, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_TEXT_TURN, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_PLAERICON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_PLAERICON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_PLAERICON)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_FaceIconL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIconL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIconL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_FaceIconR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIconR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIconR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_FaceIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIcon);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_FaceIconCursor
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIconCursor);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_FaceIconCursor)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_LPValueL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_LPValueL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_LPValueL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_LPValueR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_LPValueR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_LPValueR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_TurnText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_TurnText);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_TurnText)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string m_Label_TurnBg
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_TurnBg);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Label_TurnBg)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Color m_Color_Team0
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Color_Team0);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Color_Team0)) = value;
		}
	}

	public unsafe Color m_Color_Team1
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Color_Team1);
			return *(Color*)num;
		}
		set
		{
			*(Color*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_Color_Team1)) = value;
		}
	}

	public unsafe int m_IconIDL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IconIDL);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IconIDL)) = value;
		}
	}

	public unsafe int m_IconIDR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IconIDR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_IconIDR)) = value;
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
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 53881, RefRangeEnd = 53889, XrefRangeStart = 53873, XrefRangeEnd = 53881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static LogShowTurnForAnalysis()
	{
		Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogShowTurnForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_SINGALCHARWIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "SINGALCHARWIDTH");
		NativeFieldInfoPtr_TEXT_TURN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "TEXT_TURN");
		NativeFieldInfoPtr_LABEL_EO_PLAERICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "LABEL_EO_PLAERICON");
		NativeFieldInfoPtr_m_Label_FaceIconL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_FaceIconL");
		NativeFieldInfoPtr_m_Label_FaceIconR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_FaceIconR");
		NativeFieldInfoPtr_m_Label_FaceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_FaceIcon");
		NativeFieldInfoPtr_m_Label_FaceIconCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_FaceIconCursor");
		NativeFieldInfoPtr_m_Label_LPValueL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_LPValueL");
		NativeFieldInfoPtr_m_Label_LPValueR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_LPValueR");
		NativeFieldInfoPtr_m_Label_TurnText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_TurnText");
		NativeFieldInfoPtr_m_Label_TurnBg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Label_TurnBg");
		NativeFieldInfoPtr_m_Color_Team0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Color_Team0");
		NativeFieldInfoPtr_m_Color_Team1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_Color_Team1");
		NativeFieldInfoPtr_m_IconIDL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_IconIDL");
		NativeFieldInfoPtr_m_IconIDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_IconIDR");
		NativeFieldInfoPtr_m_EOManager_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, "m_EOManager_Origin");
		NativeMethodInfoPtr_SetData_Public_Void_ShowTurnDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, 100665331);
		NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, 100665332);
		NativeMethodInfoPtr_SetFaceIcon_Protected_Void_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, 100665333);
		NativeMethodInfoPtr_SetLP_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, 100665334);
		NativeMethodInfoPtr_SetTurn_Protected_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, 100665335);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr, 100665336);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53859, XrefRangeEnd = 53873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShowTurnDataForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_ShowTurnDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53899, RefRangeEnd = 53903, XrefRangeStart = 53889, XrefRangeEnd = 53899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFaceIcon(int playerid, GameObject root)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&playerid);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)root);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFaceIcon_Protected_Void_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 53908, RefRangeEnd = 53912, XrefRangeStart = 53903, XrefRangeEnd = 53908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLP(string lplabel, int value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(lplabel);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &value;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLP_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53943, RefRangeEnd = 53945, XrefRangeStart = 53912, XrefRangeEnd = 53943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetTurn(int value, int playerid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&value);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &playerid;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetTurn_Protected_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53945, XrefRangeEnd = 53950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogShowTurnForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogShowTurnForAnalysis>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogShowTurnForAnalysis(IntPtr pointer)
		: base(pointer)
	{
	}
}
