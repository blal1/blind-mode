using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppYgomGame.DiceRally;
using Il2CppYgomSystem.ElementSystem;
using Il2CppYgomSystem.UI;
using Il2CppYgomSystem.YGomTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2Cpp;

public class DiceInfomationWidget : MonoBehaviour
{
	private static readonly IntPtr NativeFieldInfoPtr_IMG_DICEGAUGE_LABEL;

	private static readonly IntPtr NativeFieldInfoPtr_TXT_DICEGAUGEINFO_LABEL;

	private static readonly IntPtr NativeFieldInfoPtr_IMG_REWARD_LABEL;

	private static readonly IntPtr NativeFieldInfoPtr_TXT_REWARD_LABEL;

	private static readonly IntPtr NativeFieldInfoPtr_BTN_REWARDSHORTCUT_LABEL;

	private static readonly IntPtr NativeFieldInfoPtr_m_DicePoint;

	private static readonly IntPtr NativeFieldInfoPtr_m_DicePointMax;

	private static readonly IntPtr NativeFieldInfoPtr_m_WidgetEOM;

	private static readonly IntPtr NativeFieldInfoPtr_m_DiceGaugeEOM;

	private static readonly IntPtr NativeFieldInfoPtr_m_NextRewardEOM;

	private static readonly IntPtr NativeFieldInfoPtr_m_RewardShortcutButton;

	private static readonly IntPtr NativeFieldInfoPtr_m_GaugeImage;

	private static readonly IntPtr NativeFieldInfoPtr_m_NextReward;

	private static readonly IntPtr NativeFieldInfoPtr_m_NextText;

	private static readonly IntPtr NativeFieldInfoPtr_m_RewardText;

	private static readonly IntPtr NativeFieldInfoPtr_m_GaugeInfoText;

	private static readonly IntPtr NativeMethodInfoPtr_Initalize_Public_Void_Int32_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_ResetReward_Public_Void_0;

	private static readonly IntPtr NativeMethodInfoPtr_UpdateReward_Public_Void_Int32_DiceRallyReward_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetDicePoint_Public_Void_Int32_0;

	private static readonly IntPtr NativeMethodInfoPtr_SetOnClickedCallback_Public_Void_UnityAction_0;

	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	public unsafe string IMG_DICEGAUGE_LABEL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IMG_DICEGAUGE_LABEL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IMG_DICEGAUGE_LABEL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string TXT_DICEGAUGEINFO_LABEL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TXT_DICEGAUGEINFO_LABEL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TXT_DICEGAUGEINFO_LABEL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string IMG_REWARD_LABEL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IMG_REWARD_LABEL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_IMG_REWARD_LABEL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string TXT_REWARD_LABEL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TXT_REWARD_LABEL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_TXT_REWARD_LABEL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe string BTN_REWARDSHORTCUT_LABEL
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BTN_REWARDSHORTCUT_LABEL);
			return IL2CPP.Il2CppStringToManaged(*(IntPtr*)num);
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_BTN_REWARDSHORTCUT_LABEL)), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	public unsafe int m_DicePoint
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DicePoint);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DicePoint)) = value;
		}
	}

	public unsafe int m_DicePointMax
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DicePointMax);
			return *(int*)num;
		}
		set
		{
			*(int*)((nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DicePointMax)) = value;
		}
	}

	public unsafe ElementObjectManager m_WidgetEOM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WidgetEOM);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_WidgetEOM)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager m_DiceGaugeEOM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DiceGaugeEOM);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_DiceGaugeEOM)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ElementObjectManager m_NextRewardEOM
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextRewardEOM);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ElementObjectManager>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextRewardEOM)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe SelectionButton m_RewardShortcutButton
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RewardShortcutButton);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<SelectionButton>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RewardShortcutButton)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe Image m_GaugeImage
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GaugeImage);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<Image>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GaugeImage)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe GameObject m_NextReward
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextReward);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<GameObject>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextReward)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ExtendedTextMeshProUGUI m_NextText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ExtendedTextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_NextText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ExtendedTextMeshProUGUI m_RewardText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RewardText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ExtendedTextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_RewardText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	public unsafe ExtendedTextMeshProUGUI m_GaugeInfoText
	{
		get
		{
			nint num = (nint)IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this) + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GaugeInfoText);
			IntPtr intPtr = *(IntPtr*)num;
			return (intPtr != (IntPtr)0) ? Il2CppObjectPool.Get<ExtendedTextMeshProUGUI>(intPtr) : null;
		}
		set
		{
			IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(num, (IntPtr)((nint)num + (int)IL2CPP.il2cpp_field_get_offset(NativeFieldInfoPtr_m_GaugeInfoText)), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)value));
		}
	}

	static DiceInfomationWidget()
	{
		Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DiceInfomationWidget");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr);
		NativeFieldInfoPtr_IMG_DICEGAUGE_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "IMG_DICEGAUGE_LABEL");
		NativeFieldInfoPtr_TXT_DICEGAUGEINFO_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "TXT_DICEGAUGEINFO_LABEL");
		NativeFieldInfoPtr_IMG_REWARD_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "IMG_REWARD_LABEL");
		NativeFieldInfoPtr_TXT_REWARD_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "TXT_REWARD_LABEL");
		NativeFieldInfoPtr_BTN_REWARDSHORTCUT_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "BTN_REWARDSHORTCUT_LABEL");
		NativeFieldInfoPtr_m_DicePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_DicePoint");
		NativeFieldInfoPtr_m_DicePointMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_DicePointMax");
		NativeFieldInfoPtr_m_WidgetEOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_WidgetEOM");
		NativeFieldInfoPtr_m_DiceGaugeEOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_DiceGaugeEOM");
		NativeFieldInfoPtr_m_NextRewardEOM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_NextRewardEOM");
		NativeFieldInfoPtr_m_RewardShortcutButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_RewardShortcutButton");
		NativeFieldInfoPtr_m_GaugeImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_GaugeImage");
		NativeFieldInfoPtr_m_NextReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_NextReward");
		NativeFieldInfoPtr_m_NextText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_NextText");
		NativeFieldInfoPtr_m_RewardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_RewardText");
		NativeFieldInfoPtr_m_GaugeInfoText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, "m_GaugeInfoText");
		NativeMethodInfoPtr_Initalize_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, 100663559);
		NativeMethodInfoPtr_ResetReward_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, 100663560);
		NativeMethodInfoPtr_UpdateReward_Public_Void_Int32_DiceRallyReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, 100663561);
		NativeMethodInfoPtr_SetDicePoint_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, 100663562);
		NativeMethodInfoPtr_SetOnClickedCallback_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, 100663563);
		NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr, 100663564);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32529, RefRangeEnd = 32530, XrefRangeStart = 32481, XrefRangeEnd = 32529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initalize(int dicePoint = 0, int dicePointMax = 500)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&dicePoint);
		*(int**)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = &dicePointMax;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_Initalize_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32536, RefRangeEnd = 32537, XrefRangeStart = 32530, XrefRangeEnd = 32536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ResetReward()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_ResetReward_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32558, RefRangeEnd = 32559, XrefRangeStart = 32537, XrefRangeEnd = 32558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateReward(int next, DiceRallyReward reward)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[2];
		*ptr = (nint)(&next);
		*(IntPtr*)((byte*)ptr + checked((nuint)1u * unchecked((nuint)sizeof(IntPtr)))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)reward);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_UpdateReward_Public_Void_Int32_DiceRallyReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32571, RefRangeEnd = 32572, XrefRangeStart = 32559, XrefRangeEnd = 32571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDicePoint(int point)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = (nint)(&point);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetDicePoint_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 32574, RefRangeEnd = 32575, XrefRangeStart = 32572, XrefRangeEnd = 32574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOnClickedCallback(UnityAction action)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this);
		IntPtr* ptr = stackalloc IntPtr[1];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase)(object)action);
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr_SetOnClickedCallback_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32575, XrefRangeEnd = 32596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DiceInfomationWidget()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiceInfomationWidget>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		Unsafe.SkipInit(out IntPtr intPtr);
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase)(object)this), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
	}

	public DiceInfomationWidget(IntPtr pointer)
		: base(pointer)
	{
	}
}
