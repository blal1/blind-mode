using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using YgomGame.Certification;
using YgomGame.Colosseum;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Duel;
using YgomGame.Effect;
using YgomGame.Menu.Common;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x2001269")]
public class DuelResultViewController : BaseMenuViewController
{
	[Token(Token = "0x200126A")]
	public class CertificationPracticalResult : IResultPlayer
	{
		[Token(Token = "0x200126B")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BBD4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BBD5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BBD6")]
			[FieldOffset(Offset = "0x20")]
			public CertificationPracticalResult _003C_003E4__this;

			[Token(Token = "0x17001219")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60072F1")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700121A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60072F3")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60072EE")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60072EF")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60072F0")]
			[Address(RVA = "0xB9ABC0", Offset = "0xB99DC0", VA = "0x180B9ABC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60072F2")]
			[Address(RVA = "0xB9AD50", Offset = "0xB99F50", VA = "0x180B9AD50", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BBD0")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsFinish;

		[Token(Token = "0x400BBD1")]
		[FieldOffset(Offset = "0x18")]
		private ViewControllerManager m_Manager;

		[Token(Token = "0x400BBD2")]
		[FieldOffset(Offset = "0x20")]
		private int m_Grade;

		[Token(Token = "0x400BBD3")]
		[FieldOffset(Offset = "0x24")]
		private CertificationUtil.ProgressState m_ProgressState;

		[Token(Token = "0x60072EA")]
		[Address(RVA = "0xB87290", Offset = "0xB86490", VA = "0x180B87290", Slot = "4")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__4))]
		public IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x60072EB")]
		[Address(RVA = "0xB87250", Offset = "0xB86450", VA = "0x180B87250")]
		public void Init(ViewControllerManager vcm, int grade, CertificationUtil.ProgressState progressState)
		{
		}

		[Token(Token = "0x60072EC")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CertificationPracticalResult()
		{
		}
	}

	[Token(Token = "0x200126C")]
	private class ClassChange : TweenResultPlayer
	{
		[Token(Token = "0x200126F")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BBE4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BBE5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BBE6")]
			[FieldOffset(Offset = "0x20")]
			public ClassChange _003C_003E4__this;

			[Token(Token = "0x1700121C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600730A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700121D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600730C")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007307")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007308")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007309")]
			[Address(RVA = "0xB9B2A0", Offset = "0xB9A4A0", VA = "0x180B9B2A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600730B")]
			[Address(RVA = "0xB9B4B0", Offset = "0xB9A6B0", VA = "0x180B9B4B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BBD7")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_MessageTextLabel;

		[Token(Token = "0x400BBD8")]
		[FieldOffset(Offset = "0x38")]
		private readonly string k_NextRankTextLabel;

		[Token(Token = "0x400BBD9")]
		[FieldOffset(Offset = "0x40")]
		private readonly string k_RankChangeInfoTextLabel;

		[Token(Token = "0x400BBDA")]
		[FieldOffset(Offset = "0x48")]
		private readonly string k_RankIconBeforeLabel;

		[Token(Token = "0x400BBDB")]
		[FieldOffset(Offset = "0x50")]
		private readonly string k_RankIconAfterLabel;

		[Token(Token = "0x400BBDC")]
		[FieldOffset(Offset = "0x58")]
		private bool m_IsFinish;

		[Token(Token = "0x400BBDD")]
		[FieldOffset(Offset = "0x60")]
		private PlayableDirector m_Timeline;

		[Token(Token = "0x1700121B")]
		protected override bool isFinish
		{
			[Token(Token = "0x60072F4")]
			[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60072F5")]
		[Address(RVA = "0xB880F0", Offset = "0xB872F0", VA = "0x180B880F0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__9))]
		public override IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x60072F6")]
		[Address(RVA = "0xB87E60", Offset = "0xB87060", VA = "0x180B87E60", Slot = "10")]
		protected override void OnClickClose()
		{
		}

		[Token(Token = "0x60072F7")]
		[Address(RVA = "0xB87670", Offset = "0xB86870", VA = "0x180B87670", Slot = "8")]
		public override void ImportWork(object workData)
		{
		}

		[Token(Token = "0x60072F8")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		internal void SetTimeline(PlayableDirector timeline)
		{
		}

		[Token(Token = "0x60072F9")]
		[Address(RVA = "0xB87300", Offset = "0xB86500", VA = "0x180B87300")]
		private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
		{
			return null;
		}

		[Token(Token = "0x60072FA")]
		[Address(RVA = "0xB88520", Offset = "0xB87720", VA = "0x180B88520")]
		public ClassChange()
		{
		}
	}

	[Token(Token = "0x2001270")]
	private class CommonDialogResultPlayer : IResultPlayer
	{
		[Token(Token = "0x2001271")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BBE9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BBEA")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BBEB")]
			[FieldOffset(Offset = "0x20")]
			public CommonDialogResultPlayer _003C_003E4__this;

			[Token(Token = "0x1700121E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007314")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700121F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007316")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007311")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007312")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007313")]
			[Address(RVA = "0xB9AAF0", Offset = "0xB99CF0", VA = "0x180B9AAF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007315")]
			[Address(RVA = "0xB9AB80", Offset = "0xB99D80", VA = "0x180B9AB80", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BBE7")]
		[FieldOffset(Offset = "0x10")]
		private IEntryData[] m_DialogEntries;

		[Token(Token = "0x400BBE8")]
		[FieldOffset(Offset = "0x18")]
		private bool m_IsFinish;

		[Token(Token = "0x600730D")]
		[Address(RVA = "0xB88610", Offset = "0xB87810", VA = "0x180B88610")]
		public static CommonDialogResultPlayer CreateConfirm(string title, string message, string buttonLabel)
		{
			return null;
		}

		[Token(Token = "0x600730E")]
		[Address(RVA = "0xB888C0", Offset = "0xB87AC0", VA = "0x180B888C0", Slot = "4")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__3))]
		public IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x600730F")]
		[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
		private void DialogCallback()
		{
		}

		[Token(Token = "0x6007310")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CommonDialogResultPlayer()
		{
		}
	}

	[Token(Token = "0x2001272")]
	private class DLvChange : TweenResultPlayer
	{
		[Token(Token = "0x2001274")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BBF8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BBF9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BBFA")]
			[FieldOffset(Offset = "0x20")]
			public DLvChange _003C_003E4__this;

			[Token(Token = "0x17001221")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600732B")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001222")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600732D")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007328")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007329")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600732A")]
			[Address(RVA = "0xB9B090", Offset = "0xB9A290", VA = "0x180B9B090", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600732C")]
			[Address(RVA = "0xB9B430", Offset = "0xB9A630", VA = "0x180B9B430", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BBEC")]
		[FieldOffset(Offset = "0x30")]
		private readonly string TEXT_MESSAGE_LABEL;

		[Token(Token = "0x400BBED")]
		[FieldOffset(Offset = "0x38")]
		private readonly string TEXT_RANK_BEFORE_LABEL;

		[Token(Token = "0x400BBEE")]
		[FieldOffset(Offset = "0x40")]
		private readonly string TEXT_RANK_AFTER_LABEL;

		[Token(Token = "0x400BBEF")]
		[FieldOffset(Offset = "0x48")]
		private bool m_IsFinish;

		[Token(Token = "0x400BBF0")]
		[FieldOffset(Offset = "0x50")]
		private PlayableDirector m_Timeline;

		[Token(Token = "0x400BBF1")]
		[FieldOffset(Offset = "0x58")]
		private Util.GameMode mode;

		[Token(Token = "0x400BBF2")]
		[FieldOffset(Offset = "0x60")]
		private string modeName;

		[Token(Token = "0x17001220")]
		protected override bool isFinish
		{
			[Token(Token = "0x6007317")]
			[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6007318")]
		[Address(RVA = "0xB89560", Offset = "0xB88760", VA = "0x180B89560", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__9))]
		public override IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x6007319")]
		[Address(RVA = "0xB892D0", Offset = "0xB884D0", VA = "0x180B892D0", Slot = "10")]
		protected override void OnClickClose()
		{
		}

		[Token(Token = "0x600731A")]
		[Address(RVA = "0xB89650", Offset = "0xB88850", VA = "0x180B89650")]
		internal void SetTimeline(PlayableDirector timeline)
		{
		}

		[Token(Token = "0x600731B")]
		[Address(RVA = "0xB88DD0", Offset = "0xB87FD0", VA = "0x180B88DD0", Slot = "8")]
		public override void ImportWork(object workData)
		{
		}

		[Token(Token = "0x600731C")]
		[Address(RVA = "0xB895D0", Offset = "0xB887D0", VA = "0x180B895D0")]
		public void SetGameMode(Util.GameMode gameMode)
		{
		}

		[Token(Token = "0x600731D")]
		[Address(RVA = "0xB88A60", Offset = "0xB87C60", VA = "0x180B88A60")]
		private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
		{
			return null;
		}

		[Token(Token = "0x600731E")]
		[Address(RVA = "0xB89850", Offset = "0xB88A50", VA = "0x180B89850")]
		public DLvChange()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001275")]
	private class GetScoreReward : TweenResultPlayer
	{
		[Token(Token = "0x2001278")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			[Token(Token = "0x400BC0D")]
			[FieldOffset(Offset = "0x10")]
			public bool isMoving;

			[Token(Token = "0x600733B")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass19_0()
			{
			}

			[Token(Token = "0x600733C")]
			[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
			internal void _003CPlay_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2001279")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BC0E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BC0F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BC10")]
			[FieldOffset(Offset = "0x20")]
			public GetScoreReward _003C_003E4__this;

			[Token(Token = "0x400BC11")]
			[FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

			[Token(Token = "0x400BC12")]
			[FieldOffset(Offset = "0x30")]
			private Image _003CexpGaugeImage_003E5__2;

			[Token(Token = "0x400BC13")]
			[FieldOffset(Offset = "0x38")]
			private bool _003CisGet_003E5__3;

			[Token(Token = "0x400BC14")]
			[FieldOffset(Offset = "0x3C")]
			private float _003Cduration_003E5__4;

			[Token(Token = "0x400BC15")]
			[FieldOffset(Offset = "0x40")]
			private float _003CpastSec_003E5__5;

			[Token(Token = "0x400BC16")]
			[FieldOffset(Offset = "0x44")]
			private float _003Cnorm_003E5__6;

			[Token(Token = "0x400BC17")]
			[FieldOffset(Offset = "0x48")]
			private int _003CgetCount_003E5__7;

			[Token(Token = "0x400BC18")]
			[FieldOffset(Offset = "0x4C")]
			private float _003CeffectSec_003E5__8;

			[Token(Token = "0x400BC19")]
			[FieldOffset(Offset = "0x50")]
			private bool _003CisDispEffect_003E5__9;

			[Token(Token = "0x400BC1A")]
			[FieldOffset(Offset = "0x51")]
			private bool _003CisFocus_003E5__10;

			[Token(Token = "0x17001225")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007340")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001226")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007342")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600733D")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__19(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600733E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600733F")]
			[Address(RVA = "0xB99C90", Offset = "0xB98E90", VA = "0x180B99C90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007341")]
			[Address(RVA = "0xB9A960", Offset = "0xB99B60", VA = "0x180B9A960", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BBFB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_OpenChestIntervalSeconds;

		[Token(Token = "0x400BBFC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BezierMotionContainer bezierCraftCreate;

		[Token(Token = "0x400BBFD")]
		[FieldOffset(Offset = "0x40")]
		private readonly string k_PrefabPathTrailEffect;

		[Token(Token = "0x400BBFE")]
		[FieldOffset(Offset = "0x48")]
		private readonly string k_EImgTotalChest;

		[Token(Token = "0x400BBFF")]
		[FieldOffset(Offset = "0x50")]
		private readonly string k_ETextEmpty;

		[Token(Token = "0x400BC00")]
		[FieldOffset(Offset = "0x58")]
		private int m_TotalScore;

		[Token(Token = "0x400BC01")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int m_NeedScore;

		[Token(Token = "0x400BC02")]
		[FieldOffset(Offset = "0x60")]
		private ResultInfoItems m_ResultInfoItem;

		[Token(Token = "0x400BC03")]
		[FieldOffset(Offset = "0x68")]
		private ChainedBezierMotion motion;

		[Token(Token = "0x400BC04")]
		[FieldOffset(Offset = "0x70")]
		private EffectHandler m_EffectTrail;

		[Token(Token = "0x400BC05")]
		[FieldOffset(Offset = "0x78")]
		private Transform m_OriginTrans;

		[Token(Token = "0x400BC06")]
		[FieldOffset(Offset = "0x80")]
		private Dictionary<int, object> m_RewardMap;

		[Token(Token = "0x400BC07")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isFinish;

		[Token(Token = "0x17001223")]
		protected override bool isFinish
		{
			[Token(Token = "0x600732E")]
			[Address(RVA = "0x422F90", Offset = "0x422190", VA = "0x180422F90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17001224")]
		protected override Selector selector
		{
			[Token(Token = "0x600732F")]
			[Address(RVA = "0xB95230", Offset = "0xB94430", VA = "0x180B95230", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007330")]
		[Address(RVA = "0xB94BC0", Offset = "0xB93DC0", VA = "0x180B94BC0", Slot = "7")]
		public override void Initialize(ElementObjectManager eom, int selectorGroupPriority)
		{
		}

		[Token(Token = "0x6007331")]
		[Address(RVA = "0xB94130", Offset = "0xB93330", VA = "0x180B94130", Slot = "8")]
		public override void ImportWork(object workData)
		{
		}

		[Token(Token = "0x6007332")]
		[Address(RVA = "0xB94EF0", Offset = "0xB940F0", VA = "0x180B94EF0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__19))]
		public override IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x6007333")]
		[Address(RVA = "0xB94E90", Offset = "0xB94090", VA = "0x180B94E90", Slot = "10")]
		protected override void OnClickClose()
		{
		}

		[Token(Token = "0x6007334")]
		[Address(RVA = "0xB94F60", Offset = "0xB94160", VA = "0x180B94F60")]
		public GetScoreReward()
		{
		}
	}

	[Token(Token = "0x200127A")]
	public interface IResultPlayer
	{
		[Token(Token = "0x6007343")]
		IEnumerator Play();
	}

	[Token(Token = "0x200127B")]
	private class ItemReceiveDialogResultPlayer : IResultPlayer
	{
		[Token(Token = "0x200127C")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BC1F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BC20")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BC21")]
			[FieldOffset(Offset = "0x20")]
			public ItemReceiveDialogResultPlayer _003C_003E4__this;

			[Token(Token = "0x17001227")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600734B")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001228")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600734D")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007348")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007349")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600734A")]
			[Address(RVA = "0xB9AD90", Offset = "0xB99F90", VA = "0x180B9AD90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600734C")]
			[Address(RVA = "0xB9AEC0", Offset = "0xB9A0C0", VA = "0x180B9AEC0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BC1B")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsFinish;

		[Token(Token = "0x400BC1C")]
		[FieldOffset(Offset = "0x18")]
		private string title;

		[Token(Token = "0x400BC1D")]
		[FieldOffset(Offset = "0x20")]
		private EntryItemListData receiveItemListData;

		[Token(Token = "0x400BC1E")]
		[FieldOffset(Offset = "0x28")]
		private bool isSendPresent;

		[Token(Token = "0x6007344")]
		[Address(RVA = "0xB95350", Offset = "0xB94550", VA = "0x180B95350")]
		public static ItemReceiveDialogResultPlayer CreateItemReceive(string title, EntryItemListData receiveItemListData, bool isSendPresent)
		{
			return null;
		}

		[Token(Token = "0x6007345")]
		[Address(RVA = "0xB95420", Offset = "0xB94620", VA = "0x180B95420", Slot = "4")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__5))]
		public IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x6007346")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		private void DialogCallback()
		{
		}

		[Token(Token = "0x6007347")]
		[Address(RVA = "0xB95490", Offset = "0xB94690", VA = "0x180B95490")]
		public ItemReceiveDialogResultPlayer()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200127D")]
	private class LevelUpPlayer : TweenResultPlayer
	{
		[Token(Token = "0x200127E")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BC2A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BC2B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BC2C")]
			[FieldOffset(Offset = "0x20")]
			public LevelUpPlayer _003C_003E4__this;

			[Token(Token = "0x400BC2D")]
			[FieldOffset(Offset = "0x28")]
			private Image _003CexpGaugeImage_003E5__2;

			[Token(Token = "0x400BC2E")]
			[FieldOffset(Offset = "0x30")]
			private Image _003CexpGaugeFrame_003E5__3;

			[Token(Token = "0x400BC2F")]
			[FieldOffset(Offset = "0x38")]
			private ExtendedTextMeshProUGUI _003ClevelText_003E5__4;

			[Token(Token = "0x400BC30")]
			[FieldOffset(Offset = "0x40")]
			private GameObject _003ClevelUpText_003E5__5;

			[Token(Token = "0x400BC31")]
			[FieldOffset(Offset = "0x48")]
			private int _003CupLevel_003E5__6;

			[Token(Token = "0x400BC32")]
			[FieldOffset(Offset = "0x4C")]
			private bool _003CisLevelUp_003E5__7;

			[Token(Token = "0x400BC33")]
			[FieldOffset(Offset = "0x50")]
			private float _003Cduration_003E5__8;

			[Token(Token = "0x400BC34")]
			[FieldOffset(Offset = "0x54")]
			private float _003CpastSec_003E5__9;

			[Token(Token = "0x400BC35")]
			[FieldOffset(Offset = "0x58")]
			private float _003Cnorm_003E5__10;

			[Token(Token = "0x1700122B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6007358")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700122C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600735A")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6007355")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6007356")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6007357")]
			[Address(RVA = "0xB99640", Offset = "0xB98840", VA = "0x180B99640", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007359")]
			[Address(RVA = "0xB99C50", Offset = "0xB98E50", VA = "0x180B99C50", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BC22")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GaugeSpeedPerUnitLevel;

		[Token(Token = "0x400BC23")]
		[FieldOffset(Offset = "0x34")]
		private float m_increasedExpAmount;

		[Token(Token = "0x400BC24")]
		[FieldOffset(Offset = "0x38")]
		private int m_bLevel;

		[Token(Token = "0x400BC25")]
		[FieldOffset(Offset = "0x3C")]
		private float m_bExpPercent;

		[Token(Token = "0x400BC26")]
		[FieldOffset(Offset = "0x40")]
		private int m_aLevel;

		[Token(Token = "0x400BC27")]
		[FieldOffset(Offset = "0x44")]
		private int m_aExp;

		[Token(Token = "0x400BC28")]
		[FieldOffset(Offset = "0x48")]
		private int m_aNeedExp;

		[Token(Token = "0x400BC29")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isFinish;

		[Token(Token = "0x17001229")]
		protected override bool isFinish
		{
			[Token(Token = "0x600734E")]
			[Address(RVA = "0xB95E50", Offset = "0xB95050", VA = "0x180B95E50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700122A")]
		protected override Selector selector
		{
			[Token(Token = "0x600734F")]
			[Address(RVA = "0xB95E60", Offset = "0xB95060", VA = "0x180B95E60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007350")]
		[Address(RVA = "0xB95880", Offset = "0xB94A80", VA = "0x180B95880", Slot = "7")]
		public override void Initialize(ElementObjectManager eom, int selectorGroupPriority)
		{
		}

		[Token(Token = "0x6007351")]
		[Address(RVA = "0xB954E0", Offset = "0xB946E0", VA = "0x180B954E0", Slot = "8")]
		public override void ImportWork(object workData)
		{
		}

		[Token(Token = "0x6007352")]
		[Address(RVA = "0xB95DD0", Offset = "0xB94FD0", VA = "0x180B95DD0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__14))]
		public override IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x6007353")]
		[Address(RVA = "0xB95AC0", Offset = "0xB94CC0", VA = "0x180B95AC0", Slot = "10")]
		protected override void OnClickClose()
		{
		}

		[Token(Token = "0x6007354")]
		[Address(RVA = "0xB95E40", Offset = "0xB95040", VA = "0x180B95E40")]
		public LevelUpPlayer()
		{
		}
	}

	[Token(Token = "0x200127F")]
	private class RankChange : TweenResultPlayer
	{
		[Token(Token = "0x2001282")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BC43")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BC44")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BC45")]
			[FieldOffset(Offset = "0x20")]
			public RankChange _003C_003E4__this;

			[Token(Token = "0x1700122E")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600736F")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700122F")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6007371")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600736C")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600736D")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600736E")]
			[Address(RVA = "0xB9AF00", Offset = "0xB9A100", VA = "0x180B9AF00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6007370")]
			[Address(RVA = "0xB9B470", Offset = "0xB9A670", VA = "0x180B9B470", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BC36")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_MessageTextLabel;

		[Token(Token = "0x400BC37")]
		[FieldOffset(Offset = "0x38")]
		private readonly string k_NextRankTextLabel;

		[Token(Token = "0x400BC38")]
		[FieldOffset(Offset = "0x40")]
		private readonly string k_RankChangeInfoTextLabel;

		[Token(Token = "0x400BC39")]
		[FieldOffset(Offset = "0x48")]
		private readonly string k_RankIconBeforeLabel;

		[Token(Token = "0x400BC3A")]
		[FieldOffset(Offset = "0x50")]
		private readonly string k_RankIconAfterLabel;

		[Token(Token = "0x400BC3B")]
		[FieldOffset(Offset = "0x58")]
		private bool m_IsFinish;

		[Token(Token = "0x400BC3C")]
		[FieldOffset(Offset = "0x60")]
		private PlayableDirector m_Timeline;

		[Token(Token = "0x1700122D")]
		protected override bool isFinish
		{
			[Token(Token = "0x600735B")]
			[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600735C")]
		[Address(RVA = "0xB96CF0", Offset = "0xB95EF0", VA = "0x180B96CF0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__9))]
		public override IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x600735D")]
		[Address(RVA = "0xB96A60", Offset = "0xB95C60", VA = "0x180B96A60", Slot = "10")]
		protected override void OnClickClose()
		{
		}

		[Token(Token = "0x600735E")]
		[Address(RVA = "0xB96230", Offset = "0xB95430", VA = "0x180B96230", Slot = "8")]
		public override void ImportWork(object workData)
		{
		}

		[Token(Token = "0x600735F")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		internal void SetTimeline(PlayableDirector timeline)
		{
		}

		[Token(Token = "0x6007360")]
		[Address(RVA = "0xB95EC0", Offset = "0xB950C0", VA = "0x180B95EC0")]
		private EventPlayableAsset GetEventPlayableAsset(PlayableDirector timeline)
		{
			return null;
		}

		[Token(Token = "0x6007361")]
		[Address(RVA = "0xB96F20", Offset = "0xB96120", VA = "0x180B96F20")]
		public RankChange()
		{
		}
	}

	[Token(Token = "0x2001283")]
	public class ResultInfoItems
	{
		[Token(Token = "0x2001284")]
		public enum ChestType
		{
			[Token(Token = "0x400BC56")]
			NORMAL = 1,
			[Token(Token = "0x400BC57")]
			RARE
		}

		[Token(Token = "0x2001285")]
		public enum ChestStatus
		{
			[Token(Token = "0x400BC59")]
			INVISIBLE,
			[Token(Token = "0x400BC5A")]
			UNOPEN,
			[Token(Token = "0x400BC5B")]
			OPEN
		}

		[Token(Token = "0x2001286")]
		public class Entity
		{
			[Token(Token = "0x400BC5C")]
			[FieldOffset(Offset = "0x10")]
			public int m_Num;

			[Token(Token = "0x400BC5D")]
			[FieldOffset(Offset = "0x14")]
			public int m_ItemId;

			[Token(Token = "0x400BC5E")]
			[FieldOffset(Offset = "0x18")]
			public readonly ChestType m_Type;

			[Token(Token = "0x400BC5F")]
			[FieldOffset(Offset = "0x1C")]
			public ChestStatus m_Status;

			[Token(Token = "0x6007380")]
			[Address(RVA = "0xB94020", Offset = "0xB93220", VA = "0x180B94020")]
			public Entity(int num, int itemId, ChestType type)
			{
			}
		}

		[Token(Token = "0x400BC46")]
		[FieldOffset(Offset = "0x10")]
		private readonly string k_ItemNumLabel;

		[Token(Token = "0x400BC47")]
		[FieldOffset(Offset = "0x18")]
		private readonly string k_ItemIconLabel;

		[Token(Token = "0x400BC48")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ItemOpenLabel;

		[Token(Token = "0x400BC49")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ItemUnopenLabel;

		[Token(Token = "0x400BC4A")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_ScrollLabel;

		[Token(Token = "0x400BC4B")]
		[FieldOffset(Offset = "0x38")]
		private readonly string k_BtnLabel;

		[Token(Token = "0x400BC4C")]
		[FieldOffset(Offset = "0x40")]
		private readonly string k_PrefabPathDispEffect;

		[Token(Token = "0x400BC4D")]
		[FieldOffset(Offset = "0x48")]
		private readonly string k_PrefabPathOpenEffect;

		[Token(Token = "0x400BC4E")]
		[FieldOffset(Offset = "0x50")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400BC4F")]
		[FieldOffset(Offset = "0x58")]
		private InfinityScrollView m_Isv;

		[Token(Token = "0x400BC50")]
		[FieldOffset(Offset = "0x60")]
		private List<Entity> m_EntityList;

		[Token(Token = "0x400BC51")]
		[FieldOffset(Offset = "0x68")]
		private int m_DispCount;

		[Token(Token = "0x400BC52")]
		[FieldOffset(Offset = "0x6C")]
		private int m_OpenCount;

		[Token(Token = "0x400BC53")]
		[FieldOffset(Offset = "0x70")]
		private bool isMobile;

		[Token(Token = "0x400BC54")]
		[FieldOffset(Offset = "0x71")]
		private bool m_IsSkip;

		[Token(Token = "0x6007372")]
		[Address(RVA = "0xB97680", Offset = "0xB96880", VA = "0x180B97680")]
		public void Initialize(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6007373")]
		[Address(RVA = "0xB974F0", Offset = "0xB966F0", VA = "0x180B974F0")]
		private void InitializeScroll()
		{
		}

		[Token(Token = "0x6007374")]
		[Address(RVA = "0xB97880", Offset = "0xB96A80", VA = "0x180B97880")]
		private void OnCreatedEntity(GameObject go)
		{
		}

		[Token(Token = "0x6007375")]
		[Address(RVA = "0xB97A40", Offset = "0xB96C40", VA = "0x180B97A40")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x6007376")]
		[Address(RVA = "0xB98050", Offset = "0xB97250", VA = "0x180B98050")]
		public void SetItems(List<Entity> entitys)
		{
		}

		[Token(Token = "0x6007377")]
		[Address(RVA = "0xB97250", Offset = "0xB96450", VA = "0x180B97250")]
		public Vector3 GetCurrentEntityPosition(int correctionValue = 0)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6007378")]
		[Address(RVA = "0xB97380", Offset = "0xB96580", VA = "0x180B97380")]
		public Quaternion GetCurrentEntityRotation(int correctionValue = 0)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6007379")]
		[Address(RVA = "0xB974B0", Offset = "0xB966B0", VA = "0x180B974B0")]
		public int GetEntityCount()
		{
			return default(int);
		}

		[Token(Token = "0x600737A")]
		[Address(RVA = "0xB97840", Offset = "0xB96A40", VA = "0x180B97840")]
		public void MoveChest()
		{
		}

		[Token(Token = "0x600737B")]
		[Address(RVA = "0xB97010", Offset = "0xB96210", VA = "0x180B97010")]
		public void DispChest()
		{
		}

		[Token(Token = "0x600737C")]
		[Address(RVA = "0xB97D60", Offset = "0xB96F60", VA = "0x180B97D60")]
		public void OpenChest(bool isFocus)
		{
		}

		[Token(Token = "0x600737D")]
		[Address(RVA = "0xB97F30", Offset = "0xB97130", VA = "0x180B97F30")]
		public void OpenRemainChest()
		{
		}

		[Token(Token = "0x600737E")]
		[Address(RVA = "0xB97FC0", Offset = "0xB971C0", VA = "0x180B97FC0")]
		public void ScrollFirstIndex(Action onComplete)
		{
		}

		[Token(Token = "0x600737F")]
		[Address(RVA = "0xB980B0", Offset = "0xB972B0", VA = "0x180B980B0")]
		public ResultInfoItems()
		{
		}
	}

	[Token(Token = "0x200128D")]
	public class ResultInfoScores
	{
		[Token(Token = "0x200128E")]
		public class Entity
		{
			[Token(Token = "0x400BC75")]
			[FieldOffset(Offset = "0x10")]
			public string label;

			[Token(Token = "0x400BC76")]
			[FieldOffset(Offset = "0x18")]
			public int point;

			[Token(Token = "0x400BC77")]
			[FieldOffset(Offset = "0x1C")]
			public Color color;

			[Token(Token = "0x6007397")]
			[Address(RVA = "0xB94070", Offset = "0xB93270", VA = "0x180B94070")]
			public Entity(string label, int point)
			{
			}

			[Token(Token = "0x6007398")]
			[Address(RVA = "0xB940C0", Offset = "0xB932C0", VA = "0x180B940C0")]
			public Entity(string label, int point, Color color)
			{
			}
		}

		[Token(Token = "0x400BC6D")]
		[FieldOffset(Offset = "0x10")]
		private readonly string k_TotalPointLabel;

		[Token(Token = "0x400BC6E")]
		[FieldOffset(Offset = "0x18")]
		private readonly string k_TotalPointTextLabel;

		[Token(Token = "0x400BC6F")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ScrollLabel;

		[Token(Token = "0x400BC70")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ItemPointLabel;

		[Token(Token = "0x400BC71")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_ItemTextLabel;

		[Token(Token = "0x400BC72")]
		[FieldOffset(Offset = "0x38")]
		private ElementObjectManager m_Eom;

		[Token(Token = "0x400BC73")]
		[FieldOffset(Offset = "0x40")]
		private InfinityScrollView m_Isv;

		[Token(Token = "0x400BC74")]
		[FieldOffset(Offset = "0x48")]
		private List<Entity> m_EntityList;

		[Token(Token = "0x6007391")]
		[Address(RVA = "0xB982B0", Offset = "0xB974B0", VA = "0x180B982B0")]
		public void Initialize(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6007392")]
		[Address(RVA = "0xB98260", Offset = "0xB97460", VA = "0x180B98260")]
		private void InitializeScroll()
		{
		}

		[Token(Token = "0x6007393")]
		[Address(RVA = "0xB98410", Offset = "0xB97610", VA = "0x180B98410")]
		private void OnUpdateEntity(GameObject go, int index)
		{
		}

		[Token(Token = "0x6007394")]
		[Address(RVA = "0xB98590", Offset = "0xB97790", VA = "0x180B98590")]
		public void SetTotalPoint(int point)
		{
		}

		[Token(Token = "0x6007395")]
		[Address(RVA = "0xB98530", Offset = "0xB97730", VA = "0x180B98530")]
		public void SetOtherPoints(List<Entity> entitys)
		{
		}

		[Token(Token = "0x6007396")]
		[Address(RVA = "0xB98640", Offset = "0xB97840", VA = "0x180B98640")]
		public ResultInfoScores()
		{
		}
	}

	[Token(Token = "0x200128F")]
	private class ReviewResultPlayer : IResultPlayer
	{
		[Token(Token = "0x2001290")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BC79")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BC7A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BC7B")]
			[FieldOffset(Offset = "0x20")]
			public ReviewResultPlayer _003C_003E4__this;

			[Token(Token = "0x17001230")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60073A0")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001231")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60073A2")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600739D")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600739E")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600739F")]
			[Address(RVA = "0xB9A9A0", Offset = "0xB99BA0", VA = "0x180B9A9A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60073A1")]
			[Address(RVA = "0xB9AAB0", Offset = "0xB99CB0", VA = "0x180B9AAB0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BC78")]
		[FieldOffset(Offset = "0x10")]
		private bool m_IsFinish;

		[Token(Token = "0x6007399")]
		[Address(RVA = "0xB98780", Offset = "0xB97980", VA = "0x180B98780")]
		public static ReviewResultPlayer OpenReview()
		{
			return null;
		}

		[Token(Token = "0x600739A")]
		[Address(RVA = "0xB987D0", Offset = "0xB979D0", VA = "0x180B987D0", Slot = "4")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__2))]
		public IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x600739B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ReviewResultPlayer()
		{
		}
	}

	[Token(Token = "0x2001291")]
	private abstract class TweenResultPlayer : IResultPlayer
	{
		[Token(Token = "0x2001292")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BC80")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BC81")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BC82")]
			[FieldOffset(Offset = "0x20")]
			public TweenResultPlayer _003C_003E4__this;

			[Token(Token = "0x17001234")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60073AD")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001235")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60073AF")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60073AA")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60073AB")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60073AC")]
			[Address(RVA = "0xB994C0", Offset = "0xB986C0", VA = "0x180B994C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60073AE")]
			[Address(RVA = "0xB99600", Offset = "0xB98800", VA = "0x180B99600", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BC7C")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string k_TweenOpenKey;

		[Token(Token = "0x400BC7D")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string k_TweenCloseKey;

		[Token(Token = "0x400BC7E")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string k_CloseButtonLabel;

		[Token(Token = "0x400BC7F")]
		[FieldOffset(Offset = "0x28")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x17001232")]
		protected virtual Selector selector
		{
			[Token(Token = "0x60073A3")]
			[Address(RVA = "0xB98C00", Offset = "0xB97E00", VA = "0x180B98C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001233")]
		protected virtual bool isFinish
		{
			[Token(Token = "0x60073A4")]
			[Address(RVA = "0xB98BD0", Offset = "0xB97DD0", VA = "0x180B98BD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60073A5")]
		[Address(RVA = "0xB98840", Offset = "0xB97A40", VA = "0x180B98840", Slot = "7")]
		public virtual void Initialize(ElementObjectManager eom, int selectorGroupPriority)
		{
		}

		[Token(Token = "0x60073A6")]
		public abstract void ImportWork(object workData);

		[Token(Token = "0x60073A7")]
		[Address(RVA = "0xB98AC0", Offset = "0xB97CC0", VA = "0x180B98AC0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__10))]
		public virtual IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x60073A8")]
		[Address(RVA = "0xB98A30", Offset = "0xB97C30", VA = "0x180B98A30", Slot = "10")]
		protected virtual void OnClickClose()
		{
		}

		[Token(Token = "0x60073A9")]
		[Address(RVA = "0xB98B30", Offset = "0xB97D30", VA = "0x180B98B30")]
		protected TweenResultPlayer()
		{
		}
	}

	[Token(Token = "0x2001294")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		[Token(Token = "0x400BC87")]
		[FieldOffset(Offset = "0x10")]
		public DuelResultViewController _003C_003E4__this;

		[Token(Token = "0x400BC88")]
		[FieldOffset(Offset = "0x18")]
		public Engine.ResultType resultType;

		[Token(Token = "0x400BC89")]
		[FieldOffset(Offset = "0x1C")]
		public int eventID;

		[Token(Token = "0x60073B5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_0()
		{
		}

		[Token(Token = "0x60073B6")]
		[Address(RVA = "0x9B01D0", Offset = "0x9AF3D0", VA = "0x1809B01D0")]
		internal void _003CStartResult_003Eb__10()
		{
		}
	}

	[Token(Token = "0x2001299")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_5
	{
		[Token(Token = "0x400BC91")]
		[FieldOffset(Offset = "0x10")]
		public bool isfinished;

		[Token(Token = "0x60073BF")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_5()
		{
		}

		[Token(Token = "0x60073C0")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CStartResult_003Eb__7()
		{
		}
	}

	[Token(Token = "0x200129A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_6
	{
		[Token(Token = "0x400BC92")]
		[FieldOffset(Offset = "0x10")]
		public bool isfinished;

		[Token(Token = "0x60073C1")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_6()
		{
		}

		[Token(Token = "0x60073C2")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CStartResult_003Eb__8()
		{
		}
	}

	[Token(Token = "0x200129E")]
	[CompilerGenerated]
	private sealed class _003CStartResult_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BC99")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BC9A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BC9B")]
		[FieldOffset(Offset = "0x20")]
		public DuelResultViewController _003C_003E4__this;

		[Token(Token = "0x400BC9C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		[Token(Token = "0x400BC9D")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass44_5 _003C_003E8__2;

		[Token(Token = "0x400BC9E")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass44_6 _003C_003E8__3;

		[Token(Token = "0x400BC9F")]
		[FieldOffset(Offset = "0x40")]
		private Queue<IResultPlayer> _003CresultPlayerQueue_003E5__2;

		[Token(Token = "0x400BCA0")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, object> _003Cresult_003E5__3;

		[Token(Token = "0x400BCA1")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<string, object> _003CresultInfo_003E5__4;

		[Token(Token = "0x400BCA2")]
		[FieldOffset(Offset = "0x58")]
		private ColosseumUtil.StatusDuelistCup _003Cstatus_003E5__5;

		[Token(Token = "0x400BCA3")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, object> _003CduelMenuDic_003E5__6;

		[Token(Token = "0x400BCA4")]
		[FieldOffset(Offset = "0x68")]
		private IEnumerator _003CplayHandle_003E5__7;

		[Token(Token = "0x17001236")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60073CC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001237")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60073CE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60073C9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStartResult_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60073CA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60073CB")]
		[Address(RVA = "0xBB64B0", Offset = "0xBB56B0", VA = "0x180BB64B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60073CD")]
		[Address(RVA = "0xBB9310", Offset = "0xBB8510", VA = "0x180BB9310", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BBBA")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string AVATARMODEL_ROOT_LABEL;

	[Token(Token = "0x400BBBB")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string LEVELINFO_LABEL;

	[Token(Token = "0x400BBBC")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string RESULTINFO_SCORE_REWARD_LABEL;

	[Token(Token = "0x400BBBD")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string ROOT_RANK_LABEL;

	[Token(Token = "0x400BBBE")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string BTN_RETRY_LABEL;

	[Token(Token = "0x400BBBF")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string BTN_SAVE_LABEL;

	[Token(Token = "0x400BBC0")]
	[FieldOffset(Offset = "0x100")]
	private readonly string BTN_BACK_LABEL;

	[Token(Token = "0x400BBC1")]
	[FieldOffset(Offset = "0x108")]
	private readonly string SCROLLREWARD_LABEL;

	[Token(Token = "0x400BBC2")]
	[FieldOffset(Offset = "0x110")]
	private readonly string TEMPLATENORMAL_LABEL;

	[Token(Token = "0x400BBC3")]
	[FieldOffset(Offset = "0x118")]
	private readonly string TEMPLATERARE_LABEL;

	[Token(Token = "0x400BBC4")]
	[FieldOffset(Offset = "0x120")]
	[SerializeField]
	private LevelUpPlayer m_LevelupPlayer;

	[Token(Token = "0x400BBC5")]
	[FieldOffset(Offset = "0x128")]
	[SerializeField]
	private GetScoreReward m_GetScoreReward;

	[Token(Token = "0x400BBC6")]
	[FieldOffset(Offset = "0x130")]
	[SerializeField]
	[Tooltip("遷移後リザルト演出が始まるまでの待ち時間")]
	private float m_WaitResult;

	[Token(Token = "0x400BBC7")]
	[FieldOffset(Offset = "0x138")]
	private Character2D m_AvatarModel;

	[Token(Token = "0x400BBC8")]
	[FieldOffset(Offset = "0x140")]
	private SelectionButton RetryButton;

	[Token(Token = "0x400BBC9")]
	[FieldOffset(Offset = "0x148")]
	private SelectionButton SaveButton;

	[Token(Token = "0x400BBCA")]
	[FieldOffset(Offset = "0x150")]
	private SelectionButton BackButton;

	[Token(Token = "0x400BBCB")]
	[FieldOffset(Offset = "0x158")]
	private IEnumerator yAnimateRank;

	[Token(Token = "0x400BBCC")]
	[FieldOffset(Offset = "0x160")]
	private Util.GameMode m_GameMode;

	[Token(Token = "0x400BBCD")]
	[FieldOffset(Offset = "0x0")]
	private static IEnumerator coroutine;

	[Token(Token = "0x400BBCE")]
	[FieldOffset(Offset = "0x168")]
	private readonly string k_PathModelLocateSettings;

	[Token(Token = "0x400BBCF")]
	[FieldOffset(Offset = "0x170")]
	private int remainAddRangeCount;

	[Token(Token = "0x17001217")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60072DB")]
		[Address(RVA = "0xB93C80", Offset = "0xB92E80", VA = "0x180B93C80", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001218")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60072DC")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60072DD")]
	[Address(RVA = "0xB92800", Offset = "0xB91A00", VA = "0x180B92800")]
	private int GetRemainAddRange()
	{
		return default(int);
	}

	[Token(Token = "0x60072DE")]
	[Address(RVA = "0xB92820", Offset = "0xB91A20", VA = "0x180B92820", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60072DF")]
	[Address(RVA = "0xB92AB0", Offset = "0xB91CB0", VA = "0x180B92AB0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60072E0")]
	[Address(RVA = "0xB92920", Offset = "0xB91B20", VA = "0x180B92920", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60072E1")]
	[Address(RVA = "0xB92DD0", Offset = "0xB91FD0", VA = "0x180B92DD0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60072E2")]
	[Address(RVA = "0xB934D0", Offset = "0xB926D0", VA = "0x180B934D0")]
	[IteratorStateMachine(typeof(_003CStartResult_003Ed__44))]
	public IEnumerator StartResult()
	{
		return null;
	}

	[Token(Token = "0x60072E3")]
	[Address(RVA = "0xB92E10", Offset = "0xB92010", VA = "0x180B92E10")]
	private void SetMate(Engine.ResultType resultType, int avatarId, DefinitionSetting matchingDefine, MateTransformSetting modelLocateSettings)
	{
	}

	[Token(Token = "0x60072E4")]
	[Address(RVA = "0xB93540", Offset = "0xB92740", VA = "0x180B93540")]
	private void ToRetryDuel(Util.GameMode gameMode, int tid = 0)
	{
	}

	[Token(Token = "0x60072E5")]
	[Address(RVA = "0xB936B0", Offset = "0xB928B0", VA = "0x180B936B0")]
	private void ToRetryMatching(PvpMenuDefine.MatchingType matchingType, int tid = 0)
	{
	}

	[Token(Token = "0x60072E6")]
	[Address(RVA = "0xB929B0", Offset = "0xB91BB0", VA = "0x180B929B0")]
	public void OnClickRetry(Util.GameMode gameMode, int tournamentId)
	{
	}

	[Token(Token = "0x60072E7")]
	[Address(RVA = "0xB92A20", Offset = "0xB91C20", VA = "0x180B92A20")]
	public void OnClickSave(Util.GameMode mode, long did, int eventID)
	{
	}

	[Token(Token = "0x60072E8")]
	[Address(RVA = "0xB93A50", Offset = "0xB92C50", VA = "0x180B93A50")]
	public DuelResultViewController()
	{
	}
}
