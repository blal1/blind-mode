using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppYgomGame.Menu;
using UnityEngine;
using UnityEngine.UI;

namespace Il2Cpp;

public class IconViewerViewController : BaseMenuViewController
{
	private static readonly System.IntPtr NativeFieldInfoPtr_isChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_onOcgFlagChanged;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HasOcg;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_ICONID;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_ICONSIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_FRAMEID;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_FRAMESIZE;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_BACKGROUND;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_BACKSELECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_DISCONNECT;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_DXFRAME;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_USE_MATERIALTEXTURE;

	private static readonly System.IntPtr NativeFieldInfoPtr_KEY_USE_OCG;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShopBackNormalPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ShopBackDXPath;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_CenterIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_HeaderIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_BackImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RootPC;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_RootMobile;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_FarIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_NearIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DuelIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DisconnectIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ProfileEditIcon;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_ProfileEditFrame;

	private static readonly System.IntPtr NativeFieldInfoPtr_k_DXIconLocater;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_CenterIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_HeaderIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DuelFarIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DuelNearIconHolder;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DuelFarDisconnect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DuelNearDisconnect;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfileEditIconImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ProfileEditFrameImage;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_DXIconLocater;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_BackGround;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameMat;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShopBackNormal;

	private static readonly System.IntPtr NativeFieldInfoPtr_m_ShopBackDX;

	private static readonly System.IntPtr NativeMethodInfoPtr_get_hasOcg_Public_Static_get_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_set_hasOcg_Public_Static_set_Void_Boolean_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnCreatedView_Protected_Virtual_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_OnChanged_Private_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeIconPath_Private_ValueTuple_2_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_MakeFramePath_Private_ValueTuple_2_String_String_Int32_Int32_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_SaveColor_Public_Static_Void_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr_LoadColor_Public_Static_Color_String_Color_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__NotificationStackEntry_b__43_0_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__NotificationStackEntry_b__43_1_Private_Void_String_0;

	private static readonly System.IntPtr NativeMethodInfoPtr__OnChanged_b__47_0_Private_Void_String_0;

	public unsafe static bool isChanged
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_isChanged, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_isChanged, (void*)(&value));
		}
	}

	public unsafe static Il2CppSystem.Action onOcgFlagChanged
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_onOcgFlagChanged, (void*)(&intPtr));
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != (System.IntPtr)0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_onOcgFlagChanged, (void*)IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool m_HasOcg
	{
		get
		{
			Unsafe.SkipInit(out bool result);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_m_HasOcg, (void*)(&result));
			return result;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_m_HasOcg, (void*)(&value));
		}
	}

	public unsafe static string KEY_ICONID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_ICONID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_ICONID, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_ICONSIZE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_ICONSIZE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_ICONSIZE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_FRAMEID
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_FRAMEID, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_FRAMEID, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_FRAMESIZE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_FRAMESIZE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_FRAMESIZE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_BACKGROUND
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_BACKGROUND, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_BACKGROUND, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_BACKSELECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_BACKSELECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_BACKSELECT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_DISCONNECT
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_DISCONNECT, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_DISCONNECT, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_DXFRAME
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_DXFRAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_DXFRAME, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_USE_MATERIALTEXTURE
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_USE_MATERIALTEXTURE, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_USE_MATERIALTEXTURE, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe static string KEY_USE_OCG
	{
		get
		{
			Unsafe.SkipInit(out System.IntPtr intPtr);
			IL2CPP.il2cpp_field_static_get_value(NativeFieldInfoPtr_KEY_USE_OCG, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(NativeFieldInfoPtr_KEY_USE_OCG, (void*)IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_ShopBackNormalPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ShopBackNormalPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ShopBackNormalPath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_ShopBackDXPath
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ShopBackDXPath);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ShopBackDXPath)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_CenterIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_CenterIconHolder);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_CenterIconHolder)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_HeaderIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_HeaderIconHolder);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_HeaderIconHolder)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_BackImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_BackImage);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_BackImage)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_RootPC
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_RootPC);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_RootPC)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_RootMobile
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_RootMobile);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_RootMobile)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_FarIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_FarIcon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_FarIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_NearIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_NearIcon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_NearIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_DuelIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_DuelIconHolder);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_DuelIconHolder)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_DisconnectIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_DisconnectIcon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_DisconnectIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_ProfileEditIcon
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ProfileEditIcon);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ProfileEditIcon)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_ProfileEditFrame
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ProfileEditFrame);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_ProfileEditFrame)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string k_DXIconLocater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_DXIconLocater);
			return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*)num);
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_k_DXIconLocater)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe Image m_CenterIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterIconHolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_CenterIconHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_HeaderIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HeaderIconHolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_HeaderIconHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_DuelFarIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelFarIconHolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelFarIconHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_DuelNearIconHolder
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelNearIconHolder);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelNearIconHolder)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_DuelFarDisconnect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelFarDisconnect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelFarDisconnect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_DuelNearDisconnect
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelNearDisconnect);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DuelNearDisconnect)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_ProfileEditIconImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfileEditIconImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfileEditIconImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_ProfileEditFrameImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfileEditFrameImage);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ProfileEditFrameImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_DXIconLocater
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DXIconLocater);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DXIconLocater)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Image m_BackGround
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BackGround);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_BackGround)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Material m_FrameMat
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameMat);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Material>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_FrameMat)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Sprite m_ShopBackNormal
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShopBackNormal);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShopBackNormal)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Sprite m_ShopBackDX
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShopBackDX);
			System.IntPtr intPtr = *(System.IntPtr*)num;
			return (intPtr != (System.IntPtr)0) ? Il2CppObjectPool.Get<Sprite>(intPtr) : null;
		}
		set
		{
			System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (System.IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_ShopBackDX)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe static bool hasOcg
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26028, XrefRangeEnd = 26032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			System.IntPtr* ptr = null;
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_get_hasOcg_Public_Static_get_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return *(bool*)IL2CPP.il2cpp_object_unbox(intPtr2);
		}
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 26039, RefRangeEnd = 26041, XrefRangeStart = 26032, XrefRangeEnd = 26039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[1];
			*ptr = (nint)(&value);
			Unsafe.SkipInit(out System.IntPtr intPtr);
			System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_set_hasOcg_Public_Static_set_Void_Boolean_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
		}
	}

	static IconViewerViewController()
	{
		Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "IconViewerViewController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr);
		NativeFieldInfoPtr_isChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "isChanged");
		NativeFieldInfoPtr_onOcgFlagChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "onOcgFlagChanged");
		NativeFieldInfoPtr_m_HasOcg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_HasOcg");
		NativeFieldInfoPtr_KEY_ICONID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_ICONID");
		NativeFieldInfoPtr_KEY_ICONSIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_ICONSIZE");
		NativeFieldInfoPtr_KEY_FRAMEID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_FRAMEID");
		NativeFieldInfoPtr_KEY_FRAMESIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_FRAMESIZE");
		NativeFieldInfoPtr_KEY_BACKGROUND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_BACKGROUND");
		NativeFieldInfoPtr_KEY_BACKSELECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_BACKSELECT");
		NativeFieldInfoPtr_KEY_DISCONNECT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_DISCONNECT");
		NativeFieldInfoPtr_KEY_DXFRAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_DXFRAME");
		NativeFieldInfoPtr_KEY_USE_MATERIALTEXTURE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_USE_MATERIALTEXTURE");
		NativeFieldInfoPtr_KEY_USE_OCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "KEY_USE_OCG");
		NativeFieldInfoPtr_k_ShopBackNormalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_ShopBackNormalPath");
		NativeFieldInfoPtr_k_ShopBackDXPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_ShopBackDXPath");
		NativeFieldInfoPtr_k_CenterIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_CenterIconHolder");
		NativeFieldInfoPtr_k_HeaderIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_HeaderIconHolder");
		NativeFieldInfoPtr_k_BackImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_BackImage");
		NativeFieldInfoPtr_k_RootPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_RootPC");
		NativeFieldInfoPtr_k_RootMobile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_RootMobile");
		NativeFieldInfoPtr_k_FarIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_FarIcon");
		NativeFieldInfoPtr_k_NearIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_NearIcon");
		NativeFieldInfoPtr_k_DuelIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_DuelIconHolder");
		NativeFieldInfoPtr_k_DisconnectIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_DisconnectIcon");
		NativeFieldInfoPtr_k_ProfileEditIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_ProfileEditIcon");
		NativeFieldInfoPtr_k_ProfileEditFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_ProfileEditFrame");
		NativeFieldInfoPtr_k_DXIconLocater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "k_DXIconLocater");
		NativeFieldInfoPtr_m_CenterIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_CenterIconHolder");
		NativeFieldInfoPtr_m_HeaderIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_HeaderIconHolder");
		NativeFieldInfoPtr_m_DuelFarIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_DuelFarIconHolder");
		NativeFieldInfoPtr_m_DuelNearIconHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_DuelNearIconHolder");
		NativeFieldInfoPtr_m_DuelFarDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_DuelFarDisconnect");
		NativeFieldInfoPtr_m_DuelNearDisconnect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_DuelNearDisconnect");
		NativeFieldInfoPtr_m_ProfileEditIconImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_ProfileEditIconImage");
		NativeFieldInfoPtr_m_ProfileEditFrameImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_ProfileEditFrameImage");
		NativeFieldInfoPtr_m_DXIconLocater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_DXIconLocater");
		NativeFieldInfoPtr_m_BackGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_BackGround");
		NativeFieldInfoPtr_m_FrameMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_FrameMat");
		NativeFieldInfoPtr_m_ShopBackNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_ShopBackNormal");
		NativeFieldInfoPtr_m_ShopBackDX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, "m_ShopBackDX");
		NativeMethodInfoPtr_get_hasOcg_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663382);
		NativeMethodInfoPtr_set_hasOcg_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663383);
		NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663384);
		NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663385);
		NativeMethodInfoPtr_OnCreatedView_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663386);
		NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663387);
		NativeMethodInfoPtr_OnChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663388);
		NativeMethodInfoPtr_MakeIconPath_Private_ValueTuple_2_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663389);
		NativeMethodInfoPtr_MakeFramePath_Private_ValueTuple_2_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663390);
		NativeMethodInfoPtr_SaveColor_Public_Static_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663391);
		NativeMethodInfoPtr_LoadColor_Public_Static_Color_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663392);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663393);
		NativeMethodInfoPtr__NotificationStackEntry_b__43_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663395);
		NativeMethodInfoPtr__NotificationStackEntry_b__43_1_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663396);
		NativeMethodInfoPtr__OnChanged_b__47_0_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr, 100663397);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26041, XrefRangeEnd = 26069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void NotificationStackEntry()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_NotificationStackEntry_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26069, XrefRangeEnd = 26076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26076, XrefRangeEnd = 26134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnCreatedView()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)this), NativeMethodInfoPtr_OnCreatedView_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26134, XrefRangeEnd = 26142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26340, RefRangeEnd = 26341, XrefRangeStart = 26142, XrefRangeEnd = 26340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_OnChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 26388, RefRangeEnd = 26389, XrefRangeStart = 26341, XrefRangeEnd = 26388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<string, string> MakeIconPath(int id, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeIconPath_Private_ValueTuple_2_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<string, string>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26389, XrefRangeEnd = 26413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Il2CppSystem.ValueTuple<string, string> MakeFramePath(int id, int size)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = (nint)(&id);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &size;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_MakeFramePath_Private_ValueTuple_2_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new Il2CppSystem.ValueTuple<string, string>(pointer);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26413, XrefRangeEnd = 26429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SaveColor(string key, Color color)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &color;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SaveColor_Public_Static_Void_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26429, XrefRangeEnd = 26436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Color LoadColor(string key, Color defaultColor)
	{
		System.IntPtr* ptr = stackalloc System.IntPtr[2];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
		*(Color**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(System.IntPtr)))) = &defaultColor;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_LoadColor_Public_Static_Color_String_Color_0, (System.IntPtr)0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return *(Color*)IL2CPP.il2cpp_object_unbox(intPtr2);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26436, XrefRangeEnd = 26493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IconViewerViewController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconViewerViewController>.NativeClassPtr))
	{
		System.IntPtr* ptr = null;
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26493, XrefRangeEnd = 26500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NotificationStackEntry_b__43_0(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NotificationStackEntry_b__43_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26500, XrefRangeEnd = 26507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NotificationStackEntry_b__43_1(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__NotificationStackEntry_b__43_1_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26507, XrefRangeEnd = 26514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnChanged_b__47_0(string path)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		System.IntPtr* ptr = stackalloc System.IntPtr[1];
		*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
		Unsafe.SkipInit(out System.IntPtr intPtr);
		System.IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__OnChanged_b__47_0_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public IconViewerViewController(System.IntPtr pointer)
		: base(pointer)
	{
	}
}
