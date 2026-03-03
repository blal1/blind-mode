using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppYgomGame.Duel;
using Il2CppYgomSystem.ElementSystem;
using Il2CppYgomSystem.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppYgomDebug;

public class LogShowActionForAnalysis : LogItemBaseForAnalysis
{
	private static readonly IntPtr NativeFieldInfoPtr_FULLWIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_FULLWIDTH_WIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_INDENTWIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_INDENTWIDTH_WIDTH;

	private static readonly IntPtr NativeFieldInfoPtr_m_Color_Team0;

	private static readonly IntPtr NativeFieldInfoPtr_m_Color_Team1;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDTEX;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDMASK;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CURSOR;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CTRICONL;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CTRICONR;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_POSICONL;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_POSICONR;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_PLAYERICON;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDL;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDR;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_ACTION;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_ACTTEXT;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COIN;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COINICON;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_DICE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_DICEICON;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_ARROW;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_FACEICONL;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_FACEICONR;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_FACEICON;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_FACEICONFRAME;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_LPCHANGE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CHANGEVALUE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_RESTLP;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CHANGETYPE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COUNTERCHANGE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COUNTERNUMPRE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COUNTERNUMAFT;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COUNTERTYPE;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COUNTERICON;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_LINETOP;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_LINEBOTTOM;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_BACKGROUND;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDNAME;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CARDNAMELAYER;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_BATTLEARROW;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM0;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM1;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_CONTENT;

	private static readonly IntPtr NativeFieldInfoPtr_LABEL_EO_POSITIONICONROOT;

	private static readonly IntPtr NativeFieldInfoPtr_m_CardIdL;

	private static readonly IntPtr NativeFieldInfoPtr_m_CardIdR;

	private static readonly IntPtr NativeFieldInfoPtr_m_ActTypeStrDict;

	private static readonly IntPtr NativeFieldInfoPtr_m_DmgTypeStrDict;

	private static readonly IntPtr NativeFieldInfoPtr_m_EOManager_Origin;

	private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_ShowActionDataForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetWordTable_Public_Static_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_IconSprites_Protected_get_DuelIconSprites_0;

	private static readonly IntPtr NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCards_Protected_Void_ShowActionDataForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCard_Protected_Void_LogDataSideForAnalysis_byref_Int32_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetPositionIcon_Protected_Void_ShowActionDataForAnalysis_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetFaceIcon_Protected_SelectionButton_LogDataSideForAnalysis_ElementObjectManager_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetAction_Protected_Void_LogDataCenterForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDiceResult_Protected_Void_LogDataCenterForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCoinResult_Protected_Void_LogDataCenterForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetLPChange_Protected_Void_LogDataCenterForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCounterChange_Protected_Void_LogDataCenterForAnalysis_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetCardTexture_Private_Void_RawImage_GameObject_Int32_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetWidth_Protected_Void_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetColor_Protected_Void_Boolean_Boolean_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnAdded_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_OnRemoved_Public_Virtual_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe static int FULLWIDTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FULLWIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FULLWIDTH, (void*)(&value));
		}
	}

	public unsafe static int FULLWIDTH_WIDTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_FULLWIDTH_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_FULLWIDTH_WIDTH, (void*)(&value));
		}
	}

	public unsafe static int INDENTWIDTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDENTWIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDENTWIDTH, (void*)(&value));
		}
	}

	public unsafe static int INDENTWIDTH_WIDTH
	{
		get
		{
			Unsafe.SkipInit(out int result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_INDENTWIDTH_WIDTH, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_INDENTWIDTH_WIDTH, (void*)(&value));
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

	public unsafe string LABEL_EO_CARDTEX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDTEX);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDTEX)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CARDMASK
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDMASK);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDMASK)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CURSOR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CURSOR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CURSOR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CTRICONL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CTRICONL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CTRICONL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CTRICONR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CTRICONR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CTRICONR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_POSICONL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_POSICONL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_POSICONL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_POSICONR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_POSICONR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_POSICONR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_PLAYERICON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_PLAYERICON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_PLAYERICON)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CARDL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CARDR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_ACTION
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_ACTION);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_ACTION)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_ACTTEXT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_ACTTEXT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_ACTTEXT)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COIN
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COIN);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COIN)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COINICON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COINICON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COINICON)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_DICE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_DICE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_DICE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_DICEICON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_DICEICON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_DICEICON)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_ARROW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_ARROW);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_ARROW)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_FACEICONL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICONL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICONL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_FACEICONR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICONR);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICONR)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_FACEICON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICON)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_FACEICONFRAME
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICONFRAME);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_FACEICONFRAME)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_LPCHANGE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_LPCHANGE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_LPCHANGE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CHANGEVALUE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHANGEVALUE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHANGEVALUE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_RESTLP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_RESTLP);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_RESTLP)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_CHANGETYPE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHANGETYPE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CHANGETYPE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COUNTERCHANGE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERCHANGE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERCHANGE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COUNTERNUMPRE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERNUMPRE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERNUMPRE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COUNTERNUMAFT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERNUMAFT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERNUMAFT)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COUNTERTYPE
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERTYPE);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERTYPE)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_COUNTERICON
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERICON);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_COUNTERICON)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_LINETOP
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_LINETOP);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_LINETOP)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_LINEBOTTOM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_LINEBOTTOM);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_LINEBOTTOM)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_BACKGROUND
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_BACKGROUND);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_BACKGROUND)), IL2CPP.ManagedStringToIl2Cpp(value));
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

	public unsafe string LABEL_EO_CARDNAMELAYER
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDNAMELAYER);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_CARDNAMELAYER)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string LABEL_EO_BATTLEARROW
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_BATTLEARROW);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_BATTLEARROW)), IL2CPP.ManagedStringToIl2Cpp(value));
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

	public unsafe string LABEL_EO_POSITIONICONROOT
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_POSITIONICONROOT);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_LABEL_EO_POSITIONICONROOT)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int m_CardIdL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CardIdL);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CardIdL)) = value;
		}
	}

	public unsafe int m_CardIdR
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CardIdR);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CardIdR)) = value;
		}
	}

	public unsafe static Dictionary<LOGACTIONTYPE, string> m_ActTypeStrDict
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_ActTypeStrDict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<LOGACTIONTYPE, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_ActTypeStrDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static Dictionary<Engine.DamageType, string> m_DmgTypeStrDict
	{
		get
		{
			Unsafe.SkipInit(out IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_DmgTypeStrDict, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<Dictionary<Engine.DamageType, string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_DmgTypeStrDict, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
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

	public unsafe DuelIconSprites m_IconSprites
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53050, XrefRangeEnd = 53051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IntPtr* ptr = null;
			Unsafe.SkipInit(out IntPtr intPtr);
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_m_IconSprites_Protected_get_DuelIconSprites_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<DuelIconSprites>(intPtr2) : null;
		}
	}

	public unsafe ElementObjectManager m_EOManager
	{
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 53059, RefRangeEnd = 53079, XrefRangeStart = 53051, XrefRangeEnd = 53059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

	static LogShowActionForAnalysis()
	{
		Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "YgomDebug", "LogShowActionForAnalysis");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr);
		NativeFieldInfoPtr_FULLWIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "FULLWIDTH");
		NativeFieldInfoPtr_FULLWIDTH_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "FULLWIDTH_WIDTH");
		NativeFieldInfoPtr_INDENTWIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "INDENTWIDTH");
		NativeFieldInfoPtr_INDENTWIDTH_WIDTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "INDENTWIDTH_WIDTH");
		NativeFieldInfoPtr_m_Color_Team0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_Color_Team0");
		NativeFieldInfoPtr_m_Color_Team1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_Color_Team1");
		NativeFieldInfoPtr_LABEL_EO_CARDTEX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CARDTEX");
		NativeFieldInfoPtr_LABEL_EO_CARDMASK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CARDMASK");
		NativeFieldInfoPtr_LABEL_EO_CURSOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CURSOR");
		NativeFieldInfoPtr_LABEL_EO_CTRICONL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CTRICONL");
		NativeFieldInfoPtr_LABEL_EO_CTRICONR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CTRICONR");
		NativeFieldInfoPtr_LABEL_EO_POSICONL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_POSICONL");
		NativeFieldInfoPtr_LABEL_EO_POSICONR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_POSICONR");
		NativeFieldInfoPtr_LABEL_EO_PLAYERICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_PLAYERICON");
		NativeFieldInfoPtr_LABEL_EO_CARDL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CARDL");
		NativeFieldInfoPtr_LABEL_EO_CARDR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CARDR");
		NativeFieldInfoPtr_LABEL_EO_ACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_ACTION");
		NativeFieldInfoPtr_LABEL_EO_ACTTEXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_ACTTEXT");
		NativeFieldInfoPtr_LABEL_EO_COIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COIN");
		NativeFieldInfoPtr_LABEL_EO_COINICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COINICON");
		NativeFieldInfoPtr_LABEL_EO_DICE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_DICE");
		NativeFieldInfoPtr_LABEL_EO_DICEICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_DICEICON");
		NativeFieldInfoPtr_LABEL_EO_ARROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_ARROW");
		NativeFieldInfoPtr_LABEL_EO_FACEICONL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_FACEICONL");
		NativeFieldInfoPtr_LABEL_EO_FACEICONR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_FACEICONR");
		NativeFieldInfoPtr_LABEL_EO_FACEICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_FACEICON");
		NativeFieldInfoPtr_LABEL_EO_FACEICONFRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_FACEICONFRAME");
		NativeFieldInfoPtr_LABEL_EO_LPCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_LPCHANGE");
		NativeFieldInfoPtr_LABEL_EO_CHANGEVALUE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CHANGEVALUE");
		NativeFieldInfoPtr_LABEL_EO_RESTLP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_RESTLP");
		NativeFieldInfoPtr_LABEL_EO_CHANGETYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CHANGETYPE");
		NativeFieldInfoPtr_LABEL_EO_COUNTERCHANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COUNTERCHANGE");
		NativeFieldInfoPtr_LABEL_EO_COUNTERNUMPRE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COUNTERNUMPRE");
		NativeFieldInfoPtr_LABEL_EO_COUNTERNUMAFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COUNTERNUMAFT");
		NativeFieldInfoPtr_LABEL_EO_COUNTERTYPE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COUNTERTYPE");
		NativeFieldInfoPtr_LABEL_EO_COUNTERICON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COUNTERICON");
		NativeFieldInfoPtr_LABEL_EO_LINETOP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_LINETOP");
		NativeFieldInfoPtr_LABEL_EO_LINEBOTTOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_LINEBOTTOM");
		NativeFieldInfoPtr_LABEL_EO_BACKGROUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_BACKGROUND");
		NativeFieldInfoPtr_LABEL_EO_CARDNAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CARDNAME");
		NativeFieldInfoPtr_LABEL_EO_CARDNAMELAYER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CARDNAMELAYER");
		NativeFieldInfoPtr_LABEL_EO_BATTLEARROW = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_BATTLEARROW");
		NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COLORBARTEAM0");
		NativeFieldInfoPtr_LABEL_EO_COLORBARTEAM1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_COLORBARTEAM1");
		NativeFieldInfoPtr_LABEL_EO_CONTENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_CONTENT");
		NativeFieldInfoPtr_LABEL_EO_POSITIONICONROOT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "LABEL_EO_POSITIONICONROOT");
		NativeFieldInfoPtr_m_CardIdL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_CardIdL");
		NativeFieldInfoPtr_m_CardIdR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_CardIdR");
		NativeFieldInfoPtr_m_ActTypeStrDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_ActTypeStrDict");
		NativeFieldInfoPtr_m_DmgTypeStrDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_DmgTypeStrDict");
		NativeFieldInfoPtr_m_EOManager_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, "m_EOManager_Origin");
		NativeMethodInfoPtr_SetData_Public_Void_ShowActionDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665282);
		NativeMethodInfoPtr_ResetWordTable_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665283);
		NativeMethodInfoPtr_get_m_IconSprites_Protected_get_DuelIconSprites_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665284);
		NativeMethodInfoPtr_get_m_EOManager_Protected_get_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665285);
		NativeMethodInfoPtr_SetCards_Protected_Void_ShowActionDataForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665286);
		NativeMethodInfoPtr_SetCard_Protected_Void_LogDataSideForAnalysis_byref_Int32_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665287);
		NativeMethodInfoPtr_SetPositionIcon_Protected_Void_ShowActionDataForAnalysis_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665288);
		NativeMethodInfoPtr_SetFaceIcon_Protected_SelectionButton_LogDataSideForAnalysis_ElementObjectManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665289);
		NativeMethodInfoPtr_SetAction_Protected_Void_LogDataCenterForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665290);
		NativeMethodInfoPtr_SetDiceResult_Protected_Void_LogDataCenterForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665291);
		NativeMethodInfoPtr_SetCoinResult_Protected_Void_LogDataCenterForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665292);
		NativeMethodInfoPtr_SetLPChange_Protected_Void_LogDataCenterForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665293);
		NativeMethodInfoPtr_SetCounterChange_Protected_Void_LogDataCenterForAnalysis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665294);
		NativeMethodInfoPtr_SetCardTexture_Private_Void_RawImage_GameObject_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665295);
		NativeMethodInfoPtr_SetWidth_Protected_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665296);
		NativeMethodInfoPtr_SetColor_Protected_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665297);
		NativeMethodInfoPtr_OnAdded_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665298);
		NativeMethodInfoPtr_OnRemoved_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665299);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr, 100665300);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 52790, RefRangeEnd = 52791, XrefRangeStart = 52721, XrefRangeEnd = 52790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetData(ShowActionDataForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetData_Public_Void_ShowActionDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53049, RefRangeEnd = 53050, XrefRangeStart = 52791, XrefRangeEnd = 53049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ResetWordTable()
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetWordTable_Public_Static_Void_0, (IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53109, RefRangeEnd = 53110, XrefRangeStart = 53079, XrefRangeEnd = 53109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCards(ShowActionDataForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCards_Protected_Void_ShowActionDataForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 53137, RefRangeEnd = 53140, XrefRangeStart = 53110, XrefRangeEnd = 53137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCard(LogDataSideForAnalysis data, ref int cardidpre, ElementObjectManager cardeom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[3];
		*ptr = (nint)(&data);
		*(void**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = Unsafe.AsPointer(ref cardidpre);
		*(IntPtr*)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cardeom);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCard_Protected_Void_LogDataSideForAnalysis_byref_Int32_ElementObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53201, RefRangeEnd = 53202, XrefRangeStart = 53140, XrefRangeEnd = 53201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetPositionIcon(ShowActionDataForAnalysis data, ElementObjectManager poseom)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&data);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)poseom);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetPositionIcon_Protected_Void_ShowActionDataForAnalysis_ElementObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 53217, RefRangeEnd = 53219, XrefRangeStart = 53202, XrefRangeEnd = 53217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SelectionButton SetFaceIcon(LogDataSideForAnalysis data, ElementObjectManager eomface)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&data);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)eomface);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetFaceIcon_Protected_SelectionButton_LogDataSideForAnalysis_ElementObjectManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return (intPtr2 != (IntPtr)0) ? Il2CppObjectPool.Get<SelectionButton>(intPtr2) : null;
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53219, XrefRangeEnd = 53240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAction(LogDataCenterForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetAction_Protected_Void_LogDataCenterForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53240, XrefRangeEnd = 53260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDiceResult(LogDataCenterForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDiceResult_Protected_Void_LogDataCenterForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53292, RefRangeEnd = 53293, XrefRangeStart = 53260, XrefRangeEnd = 53292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCoinResult(LogDataCenterForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCoinResult_Protected_Void_LogDataCenterForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53323, RefRangeEnd = 53324, XrefRangeStart = 53293, XrefRangeEnd = 53323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetLPChange(LogDataCenterForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetLPChange_Protected_Void_LogDataCenterForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 53360, RefRangeEnd = 53361, XrefRangeStart = 53324, XrefRangeEnd = 53360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCounterChange(LogDataCenterForAnalysis data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&data);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCounterChange_Protected_Void_LogDataCenterForAnalysis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53361, XrefRangeEnd = 53373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTexture(RawImage cardtexture, GameObject cardmask, int cardid, bool face, bool insight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[5];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cardtexture);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)cardmask);
		*(int**)((byte*)ptr + checked((nuint)2u * unchecked((nuint)sizeof(IntPtr)))) = &cardid;
		*(bool**)((byte*)ptr + checked((nuint)3u * unchecked((nuint)sizeof(IntPtr)))) = &face;
		*(bool**)((byte*)ptr + checked((nuint)4u * unchecked((nuint)sizeof(IntPtr)))) = &insight;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetCardTexture_Private_Void_RawImage_GameObject_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53373, XrefRangeEnd = 53398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetWidth(bool isIndent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&isIndent);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetWidth_Protected_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53398, XrefRangeEnd = 53411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetColor(bool team, bool indent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&team);
		*(bool**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &indent;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetColor_Protected_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(19883)]
	[CachedScanResults(RefRangeStart = 152, RefRangeEnd = 20035, XrefRangeStart = 152, XrefRangeEnd = 20035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnAdded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnAdded_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	public unsafe override void OnRemoved()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnRemoved_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53411, XrefRangeEnd = 53572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LogShowActionForAnalysis()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogShowActionForAnalysis>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public LogShowActionForAnalysis(IntPtr pointer)
		: base(pointer)
	{
	}
}
