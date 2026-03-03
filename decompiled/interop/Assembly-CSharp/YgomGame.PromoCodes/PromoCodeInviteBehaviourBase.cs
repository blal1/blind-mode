using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;
using YgomSystem.Network;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B50")]
public abstract class PromoCodeInviteBehaviourBase : PromoCodeBehaviourBase, IPromoCodeSupportedScroll, IPromoCodeBehaviourSupportedFooter
{
	[Token(Token = "0x2000B51")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass52_0
	{
		[Token(Token = "0x400969C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PromoCodeInviteBehaviourBase _003C_003E4__this;

		[Token(Token = "0x400969D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mmaPath;

		[Token(Token = "0x6004566")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass52_0()
		{
		}

		[Token(Token = "0x6004567")]
		[Address(RVA = "0x8FA4D0", Offset = "0x8F96D0", VA = "0x1808FA4D0")]
		internal void _003COnProgressUpdate_003Eb__0(UnityEngine.Object widgetGob)
		{
		}

		[Token(Token = "0x6004568")]
		[Address(RVA = "0x8FA570", Offset = "0x8F9770", VA = "0x1808FA570")]
		internal void _003COnProgressUpdate_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000B56")]
	[CompilerGenerated]
	private sealed class _003COnProgressUpdate_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40096A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40096A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40096AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PromoCodeInviteBehaviourBase _003C_003E4__this;

		[Token(Token = "0x40096AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass52_0 _003C_003E8__1;

		[Token(Token = "0x17000948")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004575")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000949")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004577")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004572")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressUpdate_003Ed__52(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004573")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004574")]
		[Address(RVA = "0x8F88C0", Offset = "0x8F7AC0", VA = "0x1808F88C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6004576")]
		[Address(RVA = "0x8F9220", Offset = "0x8F8420", VA = "0x1808F9220", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009670")]
	internal const string k_Args_InvitationId = "InvitationId";

	[Token(Token = "0x4009671")]
	internal const string k_Args_OnLaunchSuccess = "onLaunchSuccess";

	[Token(Token = "0x4009672")]
	internal const string k_Args_OnLaunchFailed = "onLaunchFailed";

	[Token(Token = "0x4009673")]
	private const string k_ELabel_InfinityScrollWidget = "InfinityScrollWidget";

	[Token(Token = "0x4009674")]
	protected const string k_ALabel_DetailMMA = "detailMMA";

	[Token(Token = "0x4009675")]
	protected const string k_ALabel_TemplateKey_BannerTemplate = "BannerTemplate";

	[Token(Token = "0x4009676")]
	protected const string k_ALabel_TemplateKey_TextLine1 = "Text_Line1Template";

	[Token(Token = "0x4009677")]
	protected const string k_ALabel_TemplateKey_TextLine1_Split2Template = "Text_Line1_Split2Template";

	[Token(Token = "0x4009678")]
	protected const string k_ALabel_TemplateKey_TextLine2 = "Text_Line2Template";

	[Token(Token = "0x4009679")]
	protected const string k_ALabel_TemplateKey_Text = "MMA_TextTemplate";

	[Token(Token = "0x400967A")]
	protected const string k_ALabel_TemplateKey_H1 = "MMA_T1Template";

	[Token(Token = "0x400967B")]
	protected const string k_ALabel_TemplateKey_H2 = "MMA_T2Template";

	[Token(Token = "0x400967C")]
	protected const string k_ALabel_TemplateKey_Separator = "MMA_SeparatorTemplate";

	[Token(Token = "0x400967D")]
	protected const string k_ALabel_TemplateKey_Spacer = "SpacerTemplate";

	[Token(Token = "0x400967E")]
	protected const string k_ALabel_TemplateKey_CodeInputTemplate = "CodeInputTemplate";

	[Token(Token = "0x400967F")]
	protected const string k_ALabel_TemplateKey_CodeViewTemplate = "CodeViewTemplate";

	[Token(Token = "0x4009680")]
	protected const string k_ALabel_TemplateKey_RewardRecordTemplate = "RewardRecordTemplate";

	[Token(Token = "0x4009681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected int m_TemplateIdx_Banner;

	[Token(Token = "0x4009682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	protected int m_TemplateIdx_TextLine1;

	[Token(Token = "0x4009683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected int m_TemplateIdx_TextLine1_Split2;

	[Token(Token = "0x4009684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	protected int m_TemplateIdx_TextLine2;

	[Token(Token = "0x4009685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected int m_TemplateIdx_Text;

	[Token(Token = "0x4009686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	protected int m_TemplateIdx_CodeView;

	[Token(Token = "0x4009687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected int m_TemplateIdx_CodeInput;

	[Token(Token = "0x4009688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	protected int m_TemplateIdx_H1;

	[Token(Token = "0x4009689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected int m_TemplateIdx_H2;

	[Token(Token = "0x400968A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected int m_TemplateIdx_Separator;

	[Token(Token = "0x400968B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected int m_TemplateIdx_Spacer;

	[Token(Token = "0x400968C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	protected int m_TemplateIdx_Reward;

	[Token(Token = "0x400968D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected int m_InvitationId;

	[Token(Token = "0x400968E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected Dictionary<string, object> m_OnHomeWork;

	[Token(Token = "0x400968F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected Dictionary<string, object> m_DetailWork;

	[Token(Token = "0x4009690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int m_DefaultIdx;

	[Token(Token = "0x4009691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private ElementObjectManager m_DialogWidget_SoloLinkPref;

	[Token(Token = "0x4009692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private InfinityScrollWidget m_ScrollWidget;

	[Token(Token = "0x4009693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<int> m_TemplateIdxs;

	[Token(Token = "0x4009694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<IWidgetSource> m_EntrySources;

	[Token(Token = "0x4009695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<int> m_SelectableTemplateIdxs;

	[Token(Token = "0x4009696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private List<IWidgetSourceItemButton> m_ItemButtonSources;

	[Token(Token = "0x4009697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Dictionary<IWidgetSourceItemButton, int> m_CardItemButtonSourceIdxMap;

	[Token(Token = "0x4009698")]
	private const string k_AL_DialogWidget_SoloLink = "DialogWidget_SoloLink";

	[Token(Token = "0x4009699")]
	private const int k_OpenRoutineStep_ReceiveResult = 0;

	[Token(Token = "0x400969A")]
	private const int k_OpenRoutineStep_RewardAction = 1;

	[Token(Token = "0x400969B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private List<int> m_CardDetailMrks;

	[Token(Token = "0x17000944")]
	public sealed override string viewLabel
	{
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x8E9C60", Offset = "0x8E8E60", VA = "0x1808E9C60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000945")]
	public sealed override string titleCategoryText
	{
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x8E9BA0", Offset = "0x8E8DA0", VA = "0x1808E9BA0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000946")]
	public sealed override bool useInputCoolTime
	{
		[Token(Token = "0x600454C")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000947")]
	public ScrollRect scrollRect
	{
		[Token(Token = "0x600454D")]
		[Address(RVA = "0x8E9B40", Offset = "0x8E8D40", VA = "0x1808E9B40", Slot = "29")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6004549")]
	[Address(RVA = "0x8E9950", Offset = "0x8E8B50", VA = "0x1808E9950")]
	public PromoCodeInviteBehaviourBase(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600454E")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "26")]
	public sealed override bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x600454F")]
	[Address(RVA = "0x8E89A0", Offset = "0x8E7BA0", VA = "0x1808E89A0")]
	public static string MakeOnErrorText(InvitationCode resultCode)
	{
		return null;
	}

	[Token(Token = "0x6004550")]
	[Address(RVA = "0x8E9170", Offset = "0x8E8370", VA = "0x1808E9170", Slot = "27")]
	[IteratorStateMachine(typeof(_003COnProgressUpdate_003Ed__52))]
	protected override IEnumerator OnProgressUpdate()
	{
		return null;
	}

	[Token(Token = "0x6004551")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "31")]
	protected virtual void OnSetupScrollWidget(InfinityScrollWidget scrollWidget)
	{
	}

	[Token(Token = "0x6004552")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "32")]
	protected virtual void OnPostProgress()
	{
	}

	[Token(Token = "0x6004553")]
	[Address(RVA = "0x8E9250", Offset = "0x8E8450", VA = "0x1808E9250", Slot = "30")]
	public bool OnSetupFooter(ElementObjectManager footerEom, IPromoCodeBehaviourFooterHandler handler)
	{
		return default(bool);
	}

	[Token(Token = "0x6004554")]
	[Address(RVA = "0x8E8810", Offset = "0x8E7A10", VA = "0x1808E8810")]
	private Action MakeFooterAction(string actionScheme, string label, object source)
	{
		return null;
	}

	[Token(Token = "0x6004555")]
	[Address(RVA = "0x8E8AB0", Offset = "0x8E7CB0", VA = "0x1808E8AB0", Slot = "33")]
	protected virtual Action MakeSchemeAction(string scheme, object source)
	{
		return null;
	}

	[Token(Token = "0x6004556")]
	[Address(RVA = "0x8E8470", Offset = "0x8E7670", VA = "0x1808E8470")]
	private IEntryData MakeDialogBodyEntry(object source)
	{
		return null;
	}

	[Token(Token = "0x6004557")]
	[Address(RVA = "0x8E91E0", Offset = "0x8E83E0", VA = "0x1808E91E0", Slot = "28")]
	public override void OnReady()
	{
	}

	[Token(Token = "0x6004558")]
	[Address(RVA = "0x8E79F0", Offset = "0x8E6BF0", VA = "0x1808E79F0")]
	private void CheckOpenDialogs(Dictionary<string, object> resultWork, int step = 0)
	{
	}

	[Token(Token = "0x6004559")]
	protected abstract void OnAssignTemplate(List<InfinityScrollWidget.Source.TemplateInfo> templateInfos);

	[Token(Token = "0x600455A")]
	protected abstract void OnAssignData(Dictionary<string, object> detailWork);

	[Token(Token = "0x600455B")]
	[Address(RVA = "0x8E7450", Offset = "0x8E6650", VA = "0x1808E7450")]
	protected void AssignRewardData(string label, List<object> rewardListWork)
	{
	}

	[Token(Token = "0x600455C")]
	protected int AssignTemplate<T>(List<InfinityScrollWidget.Source.TemplateInfo> templateInfos, string templateLabel) where T : IWidget
	{
		return default(int);
	}

	[Token(Token = "0x600455D")]
	[Address(RVA = "0x8E7060", Offset = "0x8E6260", VA = "0x1808E7060")]
	protected void AssignData(int templateIdx, IWidgetSource source)
	{
	}

	[Token(Token = "0x600455E")]
	[Address(RVA = "0x8E7B30", Offset = "0x8E6D30", VA = "0x1808E7B30")]
	protected void CheckOpenReceiveResultDialog([Optional] Action callback)
	{
	}

	[Token(Token = "0x600455F")]
	[Address(RVA = "0x8E8200", Offset = "0x8E7400", VA = "0x1808E8200")]
	protected void CheckResultAction(Dictionary<string, object> resultWork, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6004560")]
	[Address(RVA = "0x8E9710", Offset = "0x8E8910", VA = "0x1808E9710")]
	protected void RefreshScrollData()
	{
	}

	[Token(Token = "0x6004561")]
	[Address(RVA = "0x8E98A0", Offset = "0x8E8AA0", VA = "0x1808E98A0")]
	protected void RefreshView()
	{
	}

	[Token(Token = "0x6004562")]
	[Address(RVA = "0x8E9060", Offset = "0x8E8260", VA = "0x1808E9060")]
	private void OnCreatedWidget(IWidget widget)
	{
	}

	[Token(Token = "0x6004563")]
	[Address(RVA = "0x8E8B60", Offset = "0x8E7D60", VA = "0x1808E8B60")]
	private void OnClickItemButton(IWidgetSourceItemButton itemButtonSource)
	{
	}

	[Token(Token = "0x6004564")]
	[Address(RVA = "0x8E83D0", Offset = "0x8E75D0", VA = "0x1808E83D0")]
	private bool IsSelectableDataIndex(int idx)
	{
		return default(bool);
	}

	[Token(Token = "0x6004565")]
	[Address(RVA = "0x8E9630", Offset = "0x8E8830", VA = "0x1808E9630")]
	private void OnUpdateWidget(IWidget widget, int idx)
	{
	}
}
