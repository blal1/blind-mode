using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using YgomGame.Effect;
using YgomGame.Menu;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Solo;

[Token(Token = "0x20008BB")]
public class SoloSelectChapterViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x20008BC")]
	internal abstract class AccessDialog
	{
		[Token(Token = "0x40087E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string BTN_PLAY_LABEL;

		[Token(Token = "0x40087E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string BTN_DECK_LABEL;

		[Token(Token = "0x40087E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string BTN_ENEMY_DECK_LABEL;

		[Token(Token = "0x40087E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string BTN_STORY_DECK_LABEL;

		[Token(Token = "0x40087E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string BTN_STORY_CARD_LABEL;

		[Token(Token = "0x40087E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string BTN_SKIP_LABEL;

		[Token(Token = "0x40087E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string IMG_CHAPTER_LABEL;

		[Token(Token = "0x40087E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string IMG_REWARD_LABEL;

		[Token(Token = "0x40087E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string IMG_REWARD_GET_LABEL;

		[Token(Token = "0x40087E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected readonly string IMG_DECK_LABEL;

		[Token(Token = "0x40087EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected readonly string IMG_DECK_EMPTY_LABEL;

		[Token(Token = "0x40087EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected readonly string IMG_DECK_DISABLED_LABEL;

		[Token(Token = "0x40087EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected readonly string TXT_CHAPTER_NAME_LABEL;

		[Token(Token = "0x40087ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected readonly string TXT_DECK_LABEL;

		[Token(Token = "0x40087EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected readonly string TXT_OVERVIEW_LABEL;

		[Token(Token = "0x40087EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected readonly string TXT_QUANTITY_LABEL;

		[Token(Token = "0x40087F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected readonly string TXT_CLEAR_LABEL;

		[Token(Token = "0x40087F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected readonly string TXT_COMPLETE_LABEL;

		[Token(Token = "0x40087F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected readonly string OBJ_REWARD_CLEAR_LABEL;

		[Token(Token = "0x40087F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		protected readonly string OBJ_VOICE_ACTOR_LABEL;

		[Token(Token = "0x40087F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected readonly string OBJ_REWARD_COMPLETE_LABEL;

		[Token(Token = "0x40087F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x40087F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		internal ElementObjectManager eom;

		[Token(Token = "0x40087F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected readonly ViewControllerManager manager;

		[Token(Token = "0x40087F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected readonly AccessDialogManager adManager;

		[Token(Token = "0x40087F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		protected readonly int selectorPriority;

		[Token(Token = "0x40087FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		protected readonly DefinitionSetting soloDefine;

		[Token(Token = "0x60034C3")]
		[Address(RVA = "0x79E650", Offset = "0x79D850", VA = "0x18079E650")]
		protected AccessDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
		{
		}

		[Token(Token = "0x60034C4")]
		internal abstract void UpdateDisp(Chapter data);

		[Token(Token = "0x60034C5")]
		[Address(RVA = "0x79E460", Offset = "0x79D660", VA = "0x18079E460", Slot = "5")]
		protected internal virtual void Open(Chapter data)
		{
		}

		[Token(Token = "0x60034C6")]
		internal abstract void Play(Chapter data);

		[Token(Token = "0x60034C7")]
		[Address(RVA = "0x79E290", Offset = "0x79D490", VA = "0x18079E290", Slot = "7")]
		internal virtual void Close()
		{
		}

		[Token(Token = "0x60034C8")]
		[Address(RVA = "0x79E190", Offset = "0x79D390", VA = "0x18079E190")]
		protected void CallApiSoloStart(Chapter data, [Optional] Action onOverrideSuccess)
		{
		}

		[Token(Token = "0x60034C9")]
		[Address(RVA = "0x79E3B0", Offset = "0x79D5B0", VA = "0x18079E3B0")]
		protected void OnClickRewardButton(int itemID, string numText = "1")
		{
		}
	}

	[Token(Token = "0x20008BE")]
	internal class ScenarioDialog : AccessDialog
	{
		[Token(Token = "0x60034CC")]
		[Address(RVA = "0x7A9450", Offset = "0x7A8650", VA = "0x1807A9450")]
		public ScenarioDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
		{
		}

		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x7A82E0", Offset = "0x7A74E0", VA = "0x1807A82E0", Slot = "4")]
		internal override void UpdateDisp(Chapter data)
		{
		}

		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x7A82A0", Offset = "0x7A74A0", VA = "0x1807A82A0", Slot = "6")]
		internal override void Play(Chapter data)
		{
		}
	}

	[Token(Token = "0x20008C2")]
	internal class DuelDialog : AccessDialog
	{
		[Token(Token = "0x4008808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected readonly string TAB_GROUP_LABEL;

		[Token(Token = "0x4008809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected readonly string TAB_RENTAL_LABEL;

		[Token(Token = "0x400880A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected readonly string TAB_MYDECK_LABEL;

		[Token(Token = "0x400880B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		protected readonly string ROOT_RENTAL_LABEL;

		[Token(Token = "0x400880C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		protected readonly string ROOT_MYDECK_LABEL;

		[Token(Token = "0x400880D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected readonly string ROOT_LEVEL_LABEL;

		[Token(Token = "0x400880E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		protected DirectionalToggleGroupWidget toggleGroup;

		[Token(Token = "0x400880F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		protected ElementObjectManager rootRentalEom;

		[Token(Token = "0x4008810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected ElementObjectManager rootMydeckEom;

		[Token(Token = "0x4008811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected ElementObjectManager tabGroupEom;

		[Token(Token = "0x4008812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		protected ElementObjectManager tabRentalEom;

		[Token(Token = "0x4008813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		protected ElementObjectManager tabMydeckEom;

		[Token(Token = "0x60034DB")]
		[Address(RVA = "0x7A51E0", Offset = "0x7A43E0", VA = "0x1807A51E0")]
		public DuelDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
		{
		}

		[Token(Token = "0x60034DC")]
		[Address(RVA = "0x7A3020", Offset = "0x7A2220", VA = "0x1807A3020", Slot = "5")]
		protected internal override void Open(Chapter data)
		{
		}

		[Token(Token = "0x60034DD")]
		[Address(RVA = "0x7A3A50", Offset = "0x7A2C50", VA = "0x1807A3A50", Slot = "4")]
		internal override void UpdateDisp(Chapter data)
		{
		}

		[Token(Token = "0x60034DE")]
		[Address(RVA = "0x7A3170", Offset = "0x7A2370", VA = "0x1807A3170", Slot = "6")]
		internal override void Play(Chapter data)
		{
		}

		[Token(Token = "0x60034DF")]
		[Address(RVA = "0x7A2EF0", Offset = "0x7A20F0", VA = "0x1807A2EF0")]
		protected void CallApiSoloSetUseDeckType(Chapter data, SoloModeUtil.DeckType deckType, [Optional] UnityAction onSuccess)
		{
		}

		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x7A3430", Offset = "0x7A2630", VA = "0x1807A3430", Slot = "8")]
		internal virtual void UpdateDeck(Chapter data, SoloModeUtil.DeckType deckType = SoloModeUtil.DeckType.POSSESSION)
		{
		}
	}

	[Token(Token = "0x20008CB")]
	internal class TutorialDialog : AccessDialog
	{
		[Token(Token = "0x400882A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool isWhileTutorial;

		[Token(Token = "0x400882B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected readonly string ROOT_LEVEL_LABEL;

		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x7ADF40", Offset = "0x7AD140", VA = "0x1807ADF40")]
		public TutorialDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
		{
		}

		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x7AD2E0", Offset = "0x7AC4E0", VA = "0x1807AD2E0", Slot = "4")]
		internal override void UpdateDisp(Chapter data)
		{
		}

		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x7ACF90", Offset = "0x7AC190", VA = "0x1807ACF90", Slot = "6")]
		internal override void Play(Chapter data)
		{
		}

		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x7ACEF0", Offset = "0x7AC0F0", VA = "0x1807ACEF0")]
		internal void CallApiSoloSkip(Chapter data)
		{
		}

		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x7ACE00", Offset = "0x7AC000", VA = "0x1807ACE00")]
		protected void CallApiSoloSetUseDeckType(Chapter data, SoloModeUtil.DeckType deckType, [Optional] UnityAction onSuccess)
		{
		}
	}

	[Token(Token = "0x20008CF")]
	internal class RewardDialog : AccessDialog
	{
		[Token(Token = "0x4008833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly string TXT_PLAY_LABEL;

		[Token(Token = "0x6003509")]
		[Address(RVA = "0x7A8210", Offset = "0x7A7410", VA = "0x1807A8210")]
		public RewardDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
		{
		}

		[Token(Token = "0x600350A")]
		[Address(RVA = "0x7A7910", Offset = "0x7A6B10", VA = "0x1807A7910", Slot = "4")]
		internal override void UpdateDisp(Chapter data)
		{
		}

		[Token(Token = "0x600350B")]
		[Address(RVA = "0x7A7880", Offset = "0x7A6A80", VA = "0x1807A7880", Slot = "6")]
		internal override void Play(Chapter data)
		{
		}
	}

	[Token(Token = "0x20008D2")]
	internal class LockDialog : AccessDialog
	{
		[Token(Token = "0x4008839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly string ROOT_UNLOCK_ITEM_LABEL;

		[Token(Token = "0x400883A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly string ROOT_UNLOCK_HASITEM_LABEL;

		[Token(Token = "0x400883B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly string TXT_PLAY_LABEL;

		[Token(Token = "0x400883C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private readonly string TXT_COST_LABEL;

		[Token(Token = "0x400883D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly string TXT_HAVE_LABEL;

		[Token(Token = "0x400883E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly string TXT_CATEGORY_LABEL;

		[Token(Token = "0x400883F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly string TXT_NAME_LABEL;

		[Token(Token = "0x4008840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly string OBJ_TEXTLABEL_LABEL;

		[Token(Token = "0x4008841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly string OBJ_NOT_ENOUGH_LABEL;

		[Token(Token = "0x4008842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly string IMG_LABEL;

		[Token(Token = "0x4008843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly string IMG_LOCK_LABEL;

		[Token(Token = "0x4008844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private readonly string IMG_UNLOCK_LABEL;

		[Token(Token = "0x4008845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private List<GameObject> lockItems;

		[Token(Token = "0x4008846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private List<GameObject> lockHasItems;

		[Token(Token = "0x6003510")]
		[Address(RVA = "0x7A7600", Offset = "0x7A6800", VA = "0x1807A7600")]
		public LockDialog(ElementObjectManager eom, ViewControllerManager manager, AccessDialogManager adManager, int selectorPriority)
		{
		}

		[Token(Token = "0x6003511")]
		[Address(RVA = "0x7A5750", Offset = "0x7A4950", VA = "0x1807A5750", Slot = "5")]
		protected internal override void Open(Chapter data)
		{
		}

		[Token(Token = "0x6003512")]
		[Address(RVA = "0x7A5980", Offset = "0x7A4B80", VA = "0x1807A5980", Slot = "4")]
		internal override void UpdateDisp(Chapter data)
		{
		}

		[Token(Token = "0x6003513")]
		[Address(RVA = "0x7A58F0", Offset = "0x7A4AF0", VA = "0x1807A58F0", Slot = "6")]
		internal override void Play(Chapter data)
		{
		}
	}

	[Token(Token = "0x20008D4")]
	public class AccessDialogManager
	{
		[Token(Token = "0x20008D6")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_0
		{
			[Token(Token = "0x4008863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AccessDialogManager _003C_003E4__this;

			[Token(Token = "0x4008864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isInvokedRefleshCallback;

			[Token(Token = "0x4008865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool isFinish;

			[Token(Token = "0x4008866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action _003C_003E9__4;

			[Token(Token = "0x600352B")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600352C")]
			[Address(RVA = "0x7B3570", Offset = "0x7B2770", VA = "0x1807B3570")]
			internal void _003COpenRewardDialog_003Eb__2()
			{
			}

			[Token(Token = "0x600352D")]
			[Address(RVA = "0x7B3570", Offset = "0x7B2770", VA = "0x1807B3570")]
			internal void _003COpenRewardDialog_003Eb__4()
			{
			}
		}

		[Token(Token = "0x20008D7")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_1
		{
			[Token(Token = "0x4008867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isFinish;

			[Token(Token = "0x4008868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action _003C_003E9__1;

			[Token(Token = "0x600352E")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass39_1()
			{
			}

			[Token(Token = "0x600352F")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003COpenRewardDialog_003Eb__0()
			{
			}

			[Token(Token = "0x6003530")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003COpenRewardDialog_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20008D8")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_2
		{
			[Token(Token = "0x4008869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Queue<ElementObjectManager> queueEom;

			[Token(Token = "0x400886A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public _003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals1;

			[Token(Token = "0x400886B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<EffectHandler> _003C_003E9__3;

			[Token(Token = "0x6003531")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass39_2()
			{
			}

			[Token(Token = "0x6003532")]
			[Address(RVA = "0x7B3580", Offset = "0x7B2780", VA = "0x1807B3580")]
			internal void _003COpenRewardDialog_003Eb__3(EffectHandler effect)
			{
			}
		}

		[Token(Token = "0x20008D9")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_3
		{
			[Token(Token = "0x400886C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isFinish;

			[Token(Token = "0x6003533")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass39_3()
			{
			}

			[Token(Token = "0x6003534")]
			[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
			internal void _003COpenRewardDialog_003Eb__6()
			{
			}
		}

		[Token(Token = "0x20008DA")]
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass39_4
		{
			[Token(Token = "0x400886D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int shopId;

			[Token(Token = "0x400886E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool isFinishPack;

			[Token(Token = "0x6003535")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public _003C_003Ec__DisplayClass39_4()
			{
			}

			[Token(Token = "0x6003536")]
			[Address(RVA = "0x4784A0", Offset = "0x4776A0", VA = "0x1804784A0")]
			internal void _003COpenRewardDialog_003Eb__7()
			{
			}

			[Token(Token = "0x6003537")]
			[Address(RVA = "0x7B38B0", Offset = "0x7B2AB0", VA = "0x1807B38B0")]
			internal void _003COpenRewardDialog_003Eb__8()
			{
			}

			[Token(Token = "0x6003538")]
			[Address(RVA = "0x4784A0", Offset = "0x4776A0", VA = "0x1804784A0")]
			internal void _003COpenRewardDialog_003Eb__9()
			{
			}
		}

		[Token(Token = "0x20008DB")]
		[CompilerGenerated]
		private sealed class _003COpenRewardDialog_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400886F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4008870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4008871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AccessDialogManager _003C_003E4__this;

			[Token(Token = "0x4008872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private _003C_003Ec__DisplayClass39_1 _003C_003E8__1;

			[Token(Token = "0x4008873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private _003C_003Ec__DisplayClass39_0 _003C_003E8__2;

			[Token(Token = "0x4008874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private _003C_003Ec__DisplayClass39_2 _003C_003E8__3;

			[Token(Token = "0x4008875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private _003C_003Ec__DisplayClass39_3 _003C_003E8__4;

			[Token(Token = "0x4008876")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private _003C_003Ec__DisplayClass39_4 _003C_003E8__5;

			[Token(Token = "0x4008877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Action onComplete;

			[Token(Token = "0x4008878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool _003CisPlayOpendChapterPerformance_003E5__2;

			[Token(Token = "0x4008879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Selector _003CperformanceSelector_003E5__3;

			[Token(Token = "0x400887A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private List<object> _003CrewardsList_003E5__4;

			[Token(Token = "0x400887B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Dictionary<string, object> _003CgateClearDic_003E5__5;

			[Token(Token = "0x400887C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private int _003Cindex_003E5__6;

			[Token(Token = "0x400887D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private List<object>.Enumerator _003C_003E7__wrap6;

			[Token(Token = "0x17000682")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600353D")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000683")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600353F")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6003539")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003COpenRewardDialog_003Ed__39(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600353A")]
			[Address(RVA = "0x7AFB40", Offset = "0x7AED40", VA = "0x1807AFB40", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600353B")]
			[Address(RVA = "0x7AE110", Offset = "0x7AD310", VA = "0x1807AE110", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600353C")]
			[Address(RVA = "0x7AFBD0", Offset = "0x7AEDD0", VA = "0x1807AFBD0")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x600353E")]
			[Address(RVA = "0x7AFB00", Offset = "0x7AED00", VA = "0x1807AFB00", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x4008849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string BTN_BACK_LABEL;

		[Token(Token = "0x400884A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly string OBJ_ACCESS_LABEL;

		[Token(Token = "0x400884B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly string OBJ_DIALOG_SCENARIO_LABEL;

		[Token(Token = "0x400884C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly string OBJ_DIALOG_DUEL_LABEL;

		[Token(Token = "0x400884D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly string OBJ_DIALOG_REWARD_LABEL;

		[Token(Token = "0x400884E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string OBJ_DIALOG_LOCK_LABEL;

		[Token(Token = "0x400884F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly string OBJ_DIALOG_TUTORIAL_LABEL;

		[Token(Token = "0x4008850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string OBJ_CLEAR_LABEL;

		[Token(Token = "0x4008851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SoloSelectChapterViewController soloVC;

		[Token(Token = "0x4008852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject rootAccessDialog;

		[Token(Token = "0x4008853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ElementObjectManager parentViewEom;

		[Token(Token = "0x4008854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ScenarioDialog scenarioDialog;

		[Token(Token = "0x4008855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DuelDialog duelDialog;

		[Token(Token = "0x4008856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private LockDialog lockDialog;

		[Token(Token = "0x4008857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RewardDialog rewardDialog;

		[Token(Token = "0x4008858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TutorialDialog tutorialDialog;

		[Token(Token = "0x4008859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Chapter targetChapter;

		[Token(Token = "0x400885A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<Chapter> childChapters;

		[Token(Token = "0x400885B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private UnityAction<Chapter> openedCallback;

		[Token(Token = "0x400885C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UnityAction<Chapter> closedCallback;

		[Token(Token = "0x400885D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UnityAction refleshCallback;

		[Token(Token = "0x400885E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int selectorPriority;

		[Token(Token = "0x400885F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private (int chapterId, SoloModeUtil.ChapterStatus beforeStatus) beforeIdStatus;

		[Token(Token = "0x4008860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		internal bool isPlayingPerformance;

		[Token(Token = "0x6003516")]
		[Address(RVA = "0x79D950", Offset = "0x79CB50", VA = "0x18079D950")]
		internal AccessDialogManager(ElementObjectManager eom, int selectorPriority, ViewControllerManager manager, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x6003517")]
		[Address(RVA = "0x79D050", Offset = "0x79C250", VA = "0x18079D050")]
		private void DispCanvas(bool isDisp)
		{
		}

		[Token(Token = "0x6003518")]
		[Address(RVA = "0x79D8B0", Offset = "0x79CAB0", VA = "0x18079D8B0")]
		internal void UpdateAccessDialog([Optional] Chapter chapter)
		{
		}

		[Token(Token = "0x6003519")]
		[Address(RVA = "0x79D130", Offset = "0x79C330", VA = "0x18079D130")]
		internal void OpenAccessDialog([Optional] Chapter chapter, [Optional] List<Chapter> childs)
		{
		}

		[Token(Token = "0x600351A")]
		[Address(RVA = "0x79CEF0", Offset = "0x79C0F0", VA = "0x18079CEF0")]
		internal void CloseAccessDialog()
		{
		}

		[Token(Token = "0x600351B")]
		[Address(RVA = "0x79D380", Offset = "0x79C580", VA = "0x18079D380")]
		internal void RefleshDialog()
		{
		}

		[Token(Token = "0x600351C")]
		[Address(RVA = "0x79D110", Offset = "0x79C310", VA = "0x18079D110")]
		internal void InvokeRefleshCallback()
		{
		}

		[Token(Token = "0x600351D")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		internal void SetOpenedCallback(UnityAction<Chapter> callback)
		{
		}

		[Token(Token = "0x600351E")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		internal void SetClosedCallback(UnityAction<Chapter> callback)
		{
		}

		[Token(Token = "0x600351F")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		internal void SetRefleshCallback(UnityAction callback)
		{
		}

		[Token(Token = "0x6003520")]
		[Address(RVA = "0x79D6D0", Offset = "0x79C8D0", VA = "0x18079D6D0")]
		internal void StartChapter()
		{
		}

		[Token(Token = "0x6003521")]
		[Address(RVA = "0x79D540", Offset = "0x79C740", VA = "0x18079D540")]
		internal void SkipChapter()
		{
		}

		[Token(Token = "0x6003522")]
		[Address(RVA = "0x79D460", Offset = "0x79C660", VA = "0x18079D460")]
		internal void SkipAnimChapter()
		{
		}

		[Token(Token = "0x6003523")]
		[Address(RVA = "0x79E130", Offset = "0x79D330", VA = "0x18079E130")]
		internal bool isOpen()
		{
			return default(bool);
		}

		[Token(Token = "0x6003524")]
		[Address(RVA = "0x79D0D0", Offset = "0x79C2D0", VA = "0x18079D0D0")]
		private AccessDialog GetAccessDialog(SoloModeUtil.DialogType type)
		{
			return null;
		}

		[Token(Token = "0x6003525")]
		[Address(RVA = "0x79D2F0", Offset = "0x79C4F0", VA = "0x18079D2F0")]
		[IteratorStateMachine(typeof(_003COpenRewardDialog_003Ed__39))]
		internal IEnumerator OpenRewardDialog([Optional] Action onComplete)
		{
			return null;
		}
	}

	[Token(Token = "0x20008DC")]
	internal class ChapterMap
	{
		[Token(Token = "0x400887E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x400887F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string IMG_ACCESS_LABEL;

		[Token(Token = "0x4008880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string SCROLL_LABEL;

		[Token(Token = "0x4008881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string OBJ_CHAPTER_MAP_LABEL;

		[Token(Token = "0x4008882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string TMP_GATE_LABEL;

		[Token(Token = "0x4008883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string ROOT_GATE_LABEL;

		[Token(Token = "0x4008884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x4008885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly string IMG_ICON_LABEL;

		[Token(Token = "0x4008886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly string IMG_EDGE_LABEL;

		[Token(Token = "0x4008887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly string ROOT_EDGES_LABEL;

		[Token(Token = "0x4008888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected int currentChapterID;

		[Token(Token = "0x4008889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected ElementObjectManager parentViewEom;

		[Token(Token = "0x400888A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Dictionary<int, Chapter> chapterDataDic;

		[Token(Token = "0x400888B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected AccessDialogManager adManager;

		[Token(Token = "0x400888C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected int gateID;

		[Token(Token = "0x400888D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected GameObject gateGO;

		[Token(Token = "0x400888E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly float PADING_X;

		[Token(Token = "0x400888F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private readonly float PADING_Y;

		[Token(Token = "0x4008890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Dictionary<Chapter, Node> chapterNodeMap;

		[Token(Token = "0x4008891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		protected NodeMapCreater nodeMapCreater;

		[Token(Token = "0x4008892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float defaultPositionX;

		[Token(Token = "0x4008893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject playerIconGo;

		[Token(Token = "0x4008894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int m_FrameId;

		[Token(Token = "0x4008895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int m_IconId;

		[Token(Token = "0x4008896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private SoloSelectChapterViewController soloVC;

		[Token(Token = "0x6003540")]
		[Address(RVA = "0x7A2CA0", Offset = "0x7A1EA0", VA = "0x1807A2CA0")]
		internal ChapterMap(SoloSelectChapterViewController soloVC, ElementObjectManager parentViewEom, AccessDialogManager adManager, int gateID, float padingX = 300f, float padingY = 300f)
		{
		}

		[Token(Token = "0x6003541")]
		[Address(RVA = "0x79F3C0", Offset = "0x79E5C0", VA = "0x18079F3C0")]
		internal void Create()
		{
		}

		[Token(Token = "0x6003542")]
		[Address(RVA = "0x7A2490", Offset = "0x7A1690", VA = "0x1807A2490")]
		public void UpdatePlayerIcon()
		{
		}

		[Token(Token = "0x6003543")]
		[Address(RVA = "0x7A1E90", Offset = "0x7A1090", VA = "0x1807A1E90")]
		internal void SetChaptersData()
		{
		}

		[Token(Token = "0x6003544")]
		[Address(RVA = "0x7A0F90", Offset = "0x7A0190", VA = "0x1807A0F90")]
		private void InitChapter(int chapterID, Dictionary<string, object> chapterData)
		{
		}

		[Token(Token = "0x6003545")]
		[Address(RVA = "0x7A1430", Offset = "0x7A0630", VA = "0x1807A1430")]
		internal void OnClickChapter(SelectionButton sb, Chapter data)
		{
		}

		[Token(Token = "0x6003546")]
		[Address(RVA = "0x7A22B0", Offset = "0x7A14B0", VA = "0x1807A22B0")]
		internal void UpdateMap()
		{
		}

		[Token(Token = "0x6003547")]
		[Address(RVA = "0x7A1CA0", Offset = "0x7A0EA0", VA = "0x1807A1CA0")]
		internal void SelectedChapter(int x)
		{
		}

		[Token(Token = "0x6003548")]
		[Address(RVA = "0x7A26B0", Offset = "0x7A18B0", VA = "0x1807A26B0")]
		internal void ZoomChapter(SelectionItem si)
		{
		}

		[Token(Token = "0x6003549")]
		[Address(RVA = "0x7A19D0", Offset = "0x7A0BD0", VA = "0x1807A19D0")]
		internal void ResetZoom()
		{
		}

		[Token(Token = "0x600354A")]
		[Address(RVA = "0x7A2180", Offset = "0x7A1380", VA = "0x1807A2180")]
		private void SetTransition(Chapter chapter, PadInputDirection direction, SelectionButton settingBtn)
		{
		}

		[Token(Token = "0x600354B")]
		[Address(RVA = "0x79EB30", Offset = "0x79DD30", VA = "0x18079EB30")]
		private NodeMapCreater CreateNodeMap()
		{
			return null;
		}

		[Token(Token = "0x600354C")]
		[Address(RVA = "0x7A2290", Offset = "0x7A1490", VA = "0x1807A2290")]
		private int TransYtoMapY(int y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20008E0")]
	public abstract class Chapter
	{
		[Token(Token = "0x400889F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected readonly string TXT_CLEAR_LABEL;

		[Token(Token = "0x40088A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly string TXT_COMPLETE_LABEL;

		[Token(Token = "0x40088A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly string IMG_LOCK_LABEL;

		[Token(Token = "0x40088A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected readonly string IMG_UNLOCK_LABEL;

		[Token(Token = "0x40088A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected readonly string IMG_UNOPEN_LABEL;

		[Token(Token = "0x40088A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected readonly string IMG_ICON_LABEL;

		[Token(Token = "0x40088A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly string IMG_GOAL_LABEL;

		[Token(Token = "0x40088A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected readonly string k_EDefaultBG;

		[Token(Token = "0x40088A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly string k_EClearBG;

		[Token(Token = "0x40088A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int id;

		[Token(Token = "0x40088A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		internal string strChapter;

		[Token(Token = "0x40088AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal string strExplanation;

		[Token(Token = "0x40088AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal int parentID;

		[Token(Token = "0x40088AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		internal SoloModeUtil.ChapterStatus status;

		[Token(Token = "0x40088AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		internal SoloModeUtil.DialogType dType;

		[Token(Token = "0x40088AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal GameObject go;

		[Token(Token = "0x40088AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		internal int myDeckSetID;

		[Token(Token = "0x40088B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		internal int setID;

		[Token(Token = "0x40088B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal int unlockID;

		[Token(Token = "0x40088B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		internal int npcID;

		[Token(Token = "0x40088B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal string scenarioName;

		[Token(Token = "0x6003553")]
		[Address(RVA = "0x7B8360", Offset = "0x7B7560", VA = "0x1807B8360")]
		protected Chapter()
		{
		}

		[Token(Token = "0x6003554")]
		[Address(RVA = "0x7B8550", Offset = "0x7B7750", VA = "0x1807B8550")]
		public Chapter(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x6003555")]
		internal abstract string GetElementLabel();

		[Token(Token = "0x6003556")]
		internal abstract void Update(Chapter parent);

		[Token(Token = "0x6003557")]
		[Address(RVA = "0x7B8050", Offset = "0x7B7250", VA = "0x1807B8050", Slot = "6")]
		internal virtual bool IsCleared()
		{
			return default(bool);
		}

		[Token(Token = "0x6003558")]
		[Address(RVA = "0x7B8090", Offset = "0x7B7290", VA = "0x1807B8090", Slot = "7")]
		internal virtual bool IsCompleted()
		{
			return default(bool);
		}

		[Token(Token = "0x6003559")]
		[Address(RVA = "0x7B80A0", Offset = "0x7B72A0", VA = "0x1807B80A0", Slot = "8")]
		internal virtual void SetData(Dictionary<string, object> chapterData)
		{
		}

		[Token(Token = "0x600355A")]
		[Address(RVA = "0x7B8260", Offset = "0x7B7460", VA = "0x1807B8260")]
		internal void SetIcon(GameObject gameObject)
		{
		}

		[Token(Token = "0x600355B")]
		[Address(RVA = "0x7B81A0", Offset = "0x7B73A0", VA = "0x1807B81A0")]
		internal void SetGoalIcon(ElementObjectManager eom, bool isGoal)
		{
		}
	}

	[Token(Token = "0x20008E1")]
	internal class ChapterDuel : Chapter, IChapterLevel
	{
		[Token(Token = "0x40088B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int level;

		[Token(Token = "0x600355C")]
		[Address(RVA = "0x7B5470", Offset = "0x7B4670", VA = "0x1807B5470", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x600355D")]
		[Address(RVA = "0x7B5A20", Offset = "0x7B4C20", VA = "0x1807B5A20")]
		public ChapterDuel(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x600355E")]
		[Address(RVA = "0x7B5680", Offset = "0x7B4880", VA = "0x1807B5680", Slot = "5")]
		internal override void Update(Chapter parent)
		{
		}

		[Token(Token = "0x600355F")]
		[Address(RVA = "0x7B54A0", Offset = "0x7B46A0", VA = "0x1807B54A0", Slot = "8")]
		internal override void SetData(Dictionary<string, object> chapterData)
		{
		}

		[Token(Token = "0x6003560")]
		[Address(RVA = "0x662060", Offset = "0x661260", VA = "0x180662060", Slot = "9")]
		public int GetChapterLevel()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20008E2")]
	internal class ChapterPractice : ChapterDuel
	{
		[Token(Token = "0x6003561")]
		[Address(RVA = "0x7B74E0", Offset = "0x7B66E0", VA = "0x1807B74E0", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x6003562")]
		[Address(RVA = "0x7B7510", Offset = "0x7B6710", VA = "0x1807B7510")]
		public ChapterPractice(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}
	}

	[Token(Token = "0x20008E3")]
	internal class ChapterScenario : Chapter
	{
		[Token(Token = "0x40088B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly string IMG_VOICE_LABEL;

		[Token(Token = "0x40088B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal int voiceActorSetID;

		[Token(Token = "0x17000684")]
		internal bool isVoiceChapter
		{
			[Token(Token = "0x6003564")]
			[Address(RVA = "0x7B5460", Offset = "0x7B4660", VA = "0x1807B5460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003563")]
		[Address(RVA = "0x7B7A90", Offset = "0x7B6C90", VA = "0x1807B7A90", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x6003565")]
		[Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80")]
		public ChapterScenario(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x6003566")]
		[Address(RVA = "0x7B7CA0", Offset = "0x7B6EA0", VA = "0x1807B7CA0", Slot = "5")]
		internal override void Update(Chapter parent)
		{
		}

		[Token(Token = "0x6003567")]
		[Address(RVA = "0x7B7AC0", Offset = "0x7B6CC0", VA = "0x1807B7AC0", Slot = "8")]
		internal override void SetData(Dictionary<string, object> chapterData)
		{
		}
	}

	[Token(Token = "0x20008E4")]
	internal class ChapterReward : Chapter
	{
		[Token(Token = "0x6003568")]
		[Address(RVA = "0x7B7610", Offset = "0x7B6810", VA = "0x1807B7610", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x6003569")]
		[Address(RVA = "0x7B79F0", Offset = "0x7B6BF0", VA = "0x1807B79F0")]
		public ChapterReward(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x600356A")]
		[Address(RVA = "0x7B7760", Offset = "0x7B6960", VA = "0x1807B7760", Slot = "5")]
		internal override void Update(Chapter parent)
		{
		}

		[Token(Token = "0x600356B")]
		[Address(RVA = "0x7B7640", Offset = "0x7B6840", VA = "0x1807B7640", Slot = "8")]
		internal override void SetData(Dictionary<string, object> chapterData)
		{
		}
	}

	[Token(Token = "0x20008E5")]
	internal class ChapterLock : Chapter
	{
		[Token(Token = "0x600356C")]
		[Address(RVA = "0x7B6440", Offset = "0x7B5640", VA = "0x1807B6440", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x600356D")]
		[Address(RVA = "0x7B7280", Offset = "0x7B6480", VA = "0x1807B7280")]
		public ChapterLock(int chapterID)
		{
		}

		[Token(Token = "0x600356E")]
		[Address(RVA = "0x7B6530", Offset = "0x7B5730", VA = "0x1807B6530", Slot = "5")]
		internal override void Update(Chapter parent)
		{
		}

		[Token(Token = "0x600356F")]
		[Address(RVA = "0x7B6470", Offset = "0x7B5670", VA = "0x1807B6470", Slot = "8")]
		internal override void SetData(Dictionary<string, object> chapterData)
		{
		}
	}

	[Token(Token = "0x20008E6")]
	internal class ChapterGoal : Chapter, IChapterLevel
	{
		[Token(Token = "0x40088B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly string IMG_VOICE_LABEL;

		[Token(Token = "0x40088B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal int voiceActorSetID;

		[Token(Token = "0x40088B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private int level;

		[Token(Token = "0x40088BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string m_ElementLabel;

		[Token(Token = "0x17000685")]
		internal bool isVoiceChapter
		{
			[Token(Token = "0x6003571")]
			[Address(RVA = "0x7B5460", Offset = "0x7B4660", VA = "0x1807B5460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003570")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x6003572")]
		[Address(RVA = "0x7B6350", Offset = "0x7B5550", VA = "0x1807B6350")]
		public ChapterGoal(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x6003573")]
		[Address(RVA = "0x7B5F60", Offset = "0x7B5160", VA = "0x1807B5F60", Slot = "5")]
		internal override void Update(Chapter parent)
		{
		}

		[Token(Token = "0x6003574")]
		[Address(RVA = "0x7B5AC0", Offset = "0x7B4CC0", VA = "0x1807B5AC0", Slot = "8")]
		internal override void SetData(Dictionary<string, object> chapterData)
		{
		}

		[Token(Token = "0x6003575")]
		[Address(RVA = "0x42D5F0", Offset = "0x42C7F0", VA = "0x18042D5F0", Slot = "9")]
		public int GetChapterLevel()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20008E7")]
	internal class ChapterAnimation : Chapter
	{
		[Token(Token = "0x40088BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly string IMG_VOICE_LABEL;

		[Token(Token = "0x40088BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		internal int voiceActorSetID;

		[Token(Token = "0x17000686")]
		internal bool isVoiceChapter
		{
			[Token(Token = "0x6003577")]
			[Address(RVA = "0x7B5460", Offset = "0x7B4660", VA = "0x1807B5460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6003576")]
		[Address(RVA = "0x7B4EA0", Offset = "0x7B40A0", VA = "0x1807B4EA0", Slot = "4")]
		internal override string GetElementLabel()
		{
			return null;
		}

		[Token(Token = "0x6003578")]
		[Address(RVA = "0x7B5390", Offset = "0x7B4590", VA = "0x1807B5390")]
		public ChapterAnimation(int chapterID, SoloSelectChapterViewController soloVC)
		{
		}

		[Token(Token = "0x6003579")]
		[Address(RVA = "0x7B50B0", Offset = "0x7B42B0", VA = "0x1807B50B0", Slot = "5")]
		internal override void Update(Chapter parent)
		{
		}

		[Token(Token = "0x600357A")]
		[Address(RVA = "0x7B4ED0", Offset = "0x7B40D0", VA = "0x1807B4ED0", Slot = "8")]
		internal override void SetData(Dictionary<string, object> chapterData)
		{
		}
	}

	[Token(Token = "0x20008E8")]
	internal interface IChapterLevel
	{
		[Token(Token = "0x600357B")]
		int GetChapterLevel();
	}

	[Token(Token = "0x20008E9")]
	internal class NodeMapCreater
	{
		[Token(Token = "0x40088BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<int, int> map;

		[Token(Token = "0x40088BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal int maxX;

		[Token(Token = "0x40088BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		internal int maxY;

		[Token(Token = "0x600357C")]
		[Address(RVA = "0x7C5A90", Offset = "0x7C4C90", VA = "0x1807C5A90")]
		internal void SortPositionPostOrder(Node node, int x = 0, bool isFirstChild = false)
		{
		}

		[Token(Token = "0x600357D")]
		[Address(RVA = "0x7C5E50", Offset = "0x7C5050", VA = "0x1807C5E50")]
		public NodeMapCreater()
		{
		}
	}

	[Token(Token = "0x20008EA")]
	internal class Node
	{
		[Token(Token = "0x40088C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Node parent;

		[Token(Token = "0x40088C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int id;

		[Token(Token = "0x40088C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Node> childs;

		[Token(Token = "0x40088C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int x;

		[Token(Token = "0x40088C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int y;

		[Token(Token = "0x40088C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool isRelatedGoal;

		[Token(Token = "0x600357E")]
		[Address(RVA = "0x7C6130", Offset = "0x7C5330", VA = "0x1807C6130")]
		public Node(int id)
		{
		}

		[Token(Token = "0x600357F")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		internal Node GetParent()
		{
			return null;
		}

		[Token(Token = "0x6003580")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void SetParent(Node parent)
		{
		}

		[Token(Token = "0x6003581")]
		[Address(RVA = "0x7C5EE0", Offset = "0x7C50E0", VA = "0x1807C5EE0")]
		internal void SetChild(Node child)
		{
		}

		[Token(Token = "0x6003582")]
		[Address(RVA = "0x7C5FE0", Offset = "0x7C51E0", VA = "0x1807C5FE0")]
		internal void SetIsRelatedGoal()
		{
		}

		[Token(Token = "0x6003583")]
		[Address(RVA = "0x7C6020", Offset = "0x7C5220", VA = "0x1807C6020")]
		internal void SlideY(int y)
		{
		}
	}

	[Token(Token = "0x40087CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float chapterSpaceX;

	[Token(Token = "0x40087CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float chapterSpaceY;

	[Token(Token = "0x40087D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private float chapterSpaceMobileX;

	[Token(Token = "0x40087D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private float chapterSpaceMobileY;

	[Token(Token = "0x40087D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string TXT_TITLE_LABEL;

	[Token(Token = "0x40087D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string OBJ_ORB_PLATE_LABEL;

	[Token(Token = "0x40087D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string ROOT_GATE_LABEL;

	[Token(Token = "0x40087D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private DefinitionSetting soloDefine;

	[Token(Token = "0x40087D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private GameObject rootGate;

	[Token(Token = "0x40087D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private AccessDialogManager adManager;

	[Token(Token = "0x40087D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ChapterMap chapterMap;

	[Token(Token = "0x40087D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private OrbPlateWidget orbPlate;

	[Token(Token = "0x40087DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isWhileTutorial;

	[Token(Token = "0x40087DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private int m_GateId;

	[Token(Token = "0x40087DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private SoloModeUtil.EntranceType m_EntranceType;

	[Token(Token = "0x40087DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int m_ListCategory;

	[Token(Token = "0x40087DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private SoloModeUtil.PortalButton m_PortalButton;

	[Token(Token = "0x40087DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string soloBGMLabel;

	[Token(Token = "0x1700067E")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x44E380", Offset = "0x44D580", VA = "0x18044E380", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700067F")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x7ACC40", Offset = "0x7ABE40", VA = "0x1807ACC40", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000680")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000681")]
	public string SoloBGMLabel
	{
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x7ACC30", Offset = "0x7ABE30", VA = "0x1807ACC30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x7ACDE0", Offset = "0x7ABFE0", VA = "0x1807ACDE0")]
		private set
		{
		}
	}

	[Token(Token = "0x60034AD")]
	[Address(RVA = "0x7AAF00", Offset = "0x7AA100", VA = "0x1807AAF00")]
	private void Awake()
	{
	}

	[Token(Token = "0x60034AE")]
	[Address(RVA = "0x7AB220", Offset = "0x7AA420", VA = "0x1807AB220", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x60034AF")]
	[Address(RVA = "0x7AB120", Offset = "0x7AA320", VA = "0x1807AB120", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60034B0")]
	[Address(RVA = "0x7AB1A0", Offset = "0x7AA3A0", VA = "0x1807AB1A0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60034B1")]
	[Address(RVA = "0x7AC580", Offset = "0x7AB780", VA = "0x1807AC580", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x60034B2")]
	[Address(RVA = "0x7AC4C0", Offset = "0x7AB6C0", VA = "0x1807AC4C0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x60034B3")]
	[Address(RVA = "0x7AB9C0", Offset = "0x7AABC0", VA = "0x1807AB9C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60034B4")]
	[Address(RVA = "0x7AB0A0", Offset = "0x7AA2A0", VA = "0x1807AB0A0")]
	private void InitDefine()
	{
	}

	[Token(Token = "0x60034B5")]
	[Address(RVA = "0x7AB690", Offset = "0x7AA890", VA = "0x1807AB690", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x60034B6")]
	[Address(RVA = "0x7AC6C0", Offset = "0x7AB8C0", VA = "0x1807AC6C0")]
	private void SetParallelTransition(bool isParallel)
	{
	}

	[Token(Token = "0x60034B7")]
	[Address(RVA = "0x7AAF80", Offset = "0x7AA180", VA = "0x1807AAF80")]
	private void CallAPISoloGateEntry(int gateID)
	{
	}

	[Token(Token = "0x60034B8")]
	[Address(RVA = "0x3EF010", Offset = "0x3EE210", VA = "0x1803EF010")]
	public Color FadeColor(TransitionType type)
	{
		return default(Color);
	}

	[Token(Token = "0x60034B9")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public SystemProgress.ProgressType FadeType(TransitionType type)
	{
		return default(SystemProgress.ProgressType);
	}

	[Token(Token = "0x60034BA")]
	[Address(RVA = "0x7AC5B0", Offset = "0x7AB7B0", VA = "0x1807AC5B0")]
	public static void RetryDuel(ViewControllerManager manager, ViewController swapTarget, int chapterId, bool isRental)
	{
	}

	[Token(Token = "0x60034BB")]
	[Address(RVA = "0x7ACB30", Offset = "0x7ABD30", VA = "0x1807ACB30")]
	public SoloSelectChapterViewController()
	{
	}
}
