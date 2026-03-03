using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Menu;

[Token(Token = "0x200129F")]
public class DuelResultViewController_Solo : BaseMenuViewController
{
	[Token(Token = "0x20012A0")]
	public interface IResultPlayer
	{
		[Token(Token = "0x60073D8")]
		IEnumerator Play();
	}

	[Serializable]
	[Token(Token = "0x20012A1")]
	private class LevelUpPlayer : TweenResultPlayer
	{
		[Token(Token = "0x20012A2")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BCB8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BCB9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BCBA")]
			[FieldOffset(Offset = "0x20")]
			public LevelUpPlayer _003C_003E4__this;

			[Token(Token = "0x400BCBB")]
			[FieldOffset(Offset = "0x28")]
			private Image _003CexpGaugeImage_003E5__2;

			[Token(Token = "0x400BCBC")]
			[FieldOffset(Offset = "0x30")]
			private Image _003CexpGaugeFrame_003E5__3;

			[Token(Token = "0x400BCBD")]
			[FieldOffset(Offset = "0x38")]
			private ExtendedTextMeshProUGUI _003ClevelText_003E5__4;

			[Token(Token = "0x400BCBE")]
			[FieldOffset(Offset = "0x40")]
			private GameObject _003ClevelUpText_003E5__5;

			[Token(Token = "0x400BCBF")]
			[FieldOffset(Offset = "0x48")]
			private int _003CupLevel_003E5__6;

			[Token(Token = "0x400BCC0")]
			[FieldOffset(Offset = "0x4C")]
			private bool _003CisLevelUp_003E5__7;

			[Token(Token = "0x400BCC1")]
			[FieldOffset(Offset = "0x50")]
			private float _003Cduration_003E5__8;

			[Token(Token = "0x400BCC2")]
			[FieldOffset(Offset = "0x54")]
			private float _003CpastSec_003E5__9;

			[Token(Token = "0x400BCC3")]
			[FieldOffset(Offset = "0x58")]
			private float _003Cnorm_003E5__10;

			[Token(Token = "0x1700123C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60073E3")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700123D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60073E5")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60073E0")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60073E1")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60073E2")]
			[Address(RVA = "0xBB4850", Offset = "0xBB3A50", VA = "0x180BB4850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60073E4")]
			[Address(RVA = "0xBB4E60", Offset = "0xBB4060", VA = "0x180BB4E60", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BCB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GaugeSpeedPerUnitLevel;

		[Token(Token = "0x400BCB1")]
		[FieldOffset(Offset = "0x34")]
		private float m_increasedExpAmount;

		[Token(Token = "0x400BCB2")]
		[FieldOffset(Offset = "0x38")]
		private int m_bLevel;

		[Token(Token = "0x400BCB3")]
		[FieldOffset(Offset = "0x3C")]
		private float m_bExpPercent;

		[Token(Token = "0x400BCB4")]
		[FieldOffset(Offset = "0x40")]
		private int m_aLevel;

		[Token(Token = "0x400BCB5")]
		[FieldOffset(Offset = "0x44")]
		private int m_aExp;

		[Token(Token = "0x400BCB6")]
		[FieldOffset(Offset = "0x48")]
		private int m_aNeedExp;

		[Token(Token = "0x400BCB7")]
		[FieldOffset(Offset = "0x4C")]
		private bool m_isFinish;

		[Token(Token = "0x1700123A")]
		protected override bool isFinish
		{
			[Token(Token = "0x60073D9")]
			[Address(RVA = "0xB95E50", Offset = "0xB95050", VA = "0x180B95E50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700123B")]
		protected override Selector selector
		{
			[Token(Token = "0x60073DA")]
			[Address(RVA = "0xBB40F0", Offset = "0xBB32F0", VA = "0x180BB40F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60073DB")]
		[Address(RVA = "0xBB3A20", Offset = "0xBB2C20", VA = "0x180BB3A20", Slot = "7")]
		public override void Initialize(ElementObjectManager eom, int selectorGroupPriority)
		{
		}

		[Token(Token = "0x60073DC")]
		[Address(RVA = "0xBB3680", Offset = "0xBB2880", VA = "0x180BB3680", Slot = "8")]
		public override void ImportWork(object workData)
		{
		}

		[Token(Token = "0x60073DD")]
		[Address(RVA = "0xBB3FD0", Offset = "0xBB31D0", VA = "0x180BB3FD0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__14))]
		public override IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x60073DE")]
		[Address(RVA = "0xBB3C60", Offset = "0xBB2E60", VA = "0x180BB3C60", Slot = "10")]
		protected override void OnClickClose()
		{
		}

		[Token(Token = "0x60073DF")]
		[Address(RVA = "0xBB4040", Offset = "0xBB3240", VA = "0x180BB4040")]
		public LevelUpPlayer()
		{
		}
	}

	[Token(Token = "0x20012A3")]
	private abstract class TweenResultPlayer : IResultPlayer
	{
		[Token(Token = "0x20012A4")]
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400BCC8")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400BCC9")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400BCCA")]
			[FieldOffset(Offset = "0x20")]
			public TweenResultPlayer _003C_003E4__this;

			[Token(Token = "0x17001240")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60073F0")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17001241")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60073F2")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60073ED")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003CPlay_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60073EE")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60073EF")]
			[Address(RVA = "0xBB46D0", Offset = "0xBB38D0", VA = "0x180BB46D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60073F1")]
			[Address(RVA = "0xBB4810", Offset = "0xBB3A10", VA = "0x180BB4810", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x400BCC4")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string k_TweenOpenKey;

		[Token(Token = "0x400BCC5")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string k_TweenCloseKey;

		[Token(Token = "0x400BCC6")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string k_CloseButtonLabel;

		[Token(Token = "0x400BCC7")]
		[FieldOffset(Offset = "0x28")]
		protected ElementObjectManager m_Eom;

		[Token(Token = "0x1700123E")]
		protected virtual Selector selector
		{
			[Token(Token = "0x60073E6")]
			[Address(RVA = "0xBB44E0", Offset = "0xBB36E0", VA = "0x180BB44E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700123F")]
		protected virtual bool isFinish
		{
			[Token(Token = "0x60073E7")]
			[Address(RVA = "0xB98BD0", Offset = "0xB97DD0", VA = "0x180B98BD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60073E8")]
		[Address(RVA = "0xBB4150", Offset = "0xBB3350", VA = "0x180BB4150", Slot = "7")]
		public virtual void Initialize(ElementObjectManager eom, int selectorGroupPriority)
		{
		}

		[Token(Token = "0x60073E9")]
		public abstract void ImportWork(object workData);

		[Token(Token = "0x60073EA")]
		[Address(RVA = "0xBB43D0", Offset = "0xBB35D0", VA = "0x180BB43D0", Slot = "9")]
		[IteratorStateMachine(typeof(_003CPlay_003Ed__10))]
		public virtual IEnumerator Play()
		{
			return null;
		}

		[Token(Token = "0x60073EB")]
		[Address(RVA = "0xBB4340", Offset = "0xBB3540", VA = "0x180BB4340", Slot = "10")]
		protected virtual void OnClickClose()
		{
		}

		[Token(Token = "0x60073EC")]
		[Address(RVA = "0xBB4440", Offset = "0xBB3640", VA = "0x180BB4440")]
		protected TweenResultPlayer()
		{
		}
	}

	[Token(Token = "0x20012A6")]
	[CompilerGenerated]
	private sealed class _003CStartResult_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BCCC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BCCD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BCCE")]
		[FieldOffset(Offset = "0x20")]
		public DuelResultViewController_Solo _003C_003E4__this;

		[Token(Token = "0x400BCCF")]
		[FieldOffset(Offset = "0x28")]
		private Queue<IResultPlayer> _003CresultPlayerQueue_003E5__2;

		[Token(Token = "0x400BCD0")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, object> _003Cresult_003E5__3;

		[Token(Token = "0x400BCD1")]
		[FieldOffset(Offset = "0x38")]
		private IEnumerator _003CplayHandle_003E5__4;

		[Token(Token = "0x17001242")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60073F8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001243")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60073FA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60073F5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStartResult_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60073F6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60073F7")]
		[Address(RVA = "0xBB5B40", Offset = "0xBB4D40", VA = "0x180BB5B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60073F9")]
		[Address(RVA = "0xBB6470", Offset = "0xBB5670", VA = "0x180BB6470", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BCA5")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string LEVELINFO_LABEL;

	[Token(Token = "0x400BCA6")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string BTN_RETRY_LABEL;

	[Token(Token = "0x400BCA7")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string BTN_SAVE_LABEL;

	[Token(Token = "0x400BCA8")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string BTN_BACK_LABEL;

	[Token(Token = "0x400BCA9")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private LevelUpPlayer m_LevelupPlayer;

	[Token(Token = "0x400BCAA")]
	[FieldOffset(Offset = "0xF8")]
	private SelectionButton RetryButton;

	[Token(Token = "0x400BCAB")]
	[FieldOffset(Offset = "0x100")]
	private SelectionButton SaveButton;

	[Token(Token = "0x400BCAC")]
	[FieldOffset(Offset = "0x108")]
	private SelectionButton BackButton;

	[Token(Token = "0x400BCAD")]
	[FieldOffset(Offset = "0x110")]
	private Util.GameMode m_GameMode;

	[Token(Token = "0x400BCAE")]
	[FieldOffset(Offset = "0x0")]
	private static IEnumerator coroutine;

	[Token(Token = "0x400BCAF")]
	[FieldOffset(Offset = "0x114")]
	private int remainAddRangeCount;

	[Token(Token = "0x17001238")]
	protected override Type[] textIds
	{
		[Token(Token = "0x60073CF")]
		[Address(RVA = "0xB9E820", Offset = "0xB9DA20", VA = "0x180B9E820", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001239")]
	protected override int selectorPriorityAddRange
	{
		[Token(Token = "0x60073D0")]
		[Address(RVA = "0x4465B0", Offset = "0x4457B0", VA = "0x1804465B0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60073D1")]
	[Address(RVA = "0xB9E2F0", Offset = "0xB9D4F0", VA = "0x180B9E2F0")]
	private int GetRemainAddRange()
	{
		return default(int);
	}

	[Token(Token = "0x60073D2")]
	[Address(RVA = "0xB9E310", Offset = "0xB9D510", VA = "0x180B9E310", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x60073D3")]
	[Address(RVA = "0xB9E4A0", Offset = "0xB9D6A0", VA = "0x180B9E4A0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x60073D4")]
	[Address(RVA = "0xB9E410", Offset = "0xB9D610", VA = "0x180B9E410", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x60073D5")]
	[Address(RVA = "0xB9E6D0", Offset = "0xB9D8D0", VA = "0x180B9E6D0")]
	[IteratorStateMachine(typeof(_003CStartResult_003Ed__22))]
	public IEnumerator StartResult()
	{
		return null;
	}

	[Token(Token = "0x60073D6")]
	[Address(RVA = "0xB9E740", Offset = "0xB9D940", VA = "0x180B9E740")]
	public DuelResultViewController_Solo()
	{
	}
}
