using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000FB0")]
public class DiceResultViewController : BaseMenuViewController
{
	[Token(Token = "0x2000FB1")]
	[CompilerGenerated]
	private sealed class _003CResultAnimation_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AA4B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AA4C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AA4D")]
		[FieldOffset(Offset = "0x20")]
		public DiceResultViewController _003C_003E4__this;

		[Token(Token = "0x400AA4E")]
		[FieldOffset(Offset = "0x28")]
		public Image gauge;

		[Token(Token = "0x400AA4F")]
		[FieldOffset(Offset = "0x30")]
		public ExtendedTextMeshProUGUI point;

		[Token(Token = "0x400AA50")]
		[FieldOffset(Offset = "0x38")]
		public ExtendedTextMeshProUGUI gaugeInfo;

		[Token(Token = "0x400AA51")]
		[FieldOffset(Offset = "0x40")]
		public ElementObjectManager stockEOM;

		[Token(Token = "0x400AA52")]
		[FieldOffset(Offset = "0x48")]
		public Image diceImage;

		[Token(Token = "0x400AA53")]
		[FieldOffset(Offset = "0x50")]
		public GameObject button;

		[Token(Token = "0x400AA54")]
		[FieldOffset(Offset = "0x58")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x17000EFD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005F53")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EFE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005F55")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005F50")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CResultAnimation_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005F52")]
		[Address(RVA = "0xA6BBF0", Offset = "0xA6ADF0", VA = "0x180A6BBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005F54")]
		[Address(RVA = "0xA6BDB0", Offset = "0xA6AFB0", VA = "0x180A6BDB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AA41")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x400AA42")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string k_DicePoint;

	[Token(Token = "0x400AA43")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string k_DicePointMax;

	[Token(Token = "0x400AA44")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string k_AddDicePoint;

	[Token(Token = "0x400AA45")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string k_DetailList;

	[Token(Token = "0x400AA46")]
	[FieldOffset(Offset = "0xD8")]
	private Coroutine m_ResultAnimation;

	[Token(Token = "0x400AA47")]
	[FieldOffset(Offset = "0xE0")]
	private int m_Point;

	[Token(Token = "0x400AA48")]
	[FieldOffset(Offset = "0xE4")]
	private int m_PointMax;

	[Token(Token = "0x400AA49")]
	[FieldOffset(Offset = "0xE8")]
	private int m_PointDelta;

	[Token(Token = "0x400AA4A")]
	[FieldOffset(Offset = "0xF0")]
	private List<object> m_DetailList;

	[Token(Token = "0x6005F48")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6005F49")]
	[Address(RVA = "0xA69CD0", Offset = "0xA68ED0", VA = "0x180A69CD0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6005F4A")]
	[Address(RVA = "0xA6A7A0", Offset = "0xA699A0", VA = "0x180A6A7A0")]
	[IteratorStateMachine(typeof(_003CResultAnimation_003Ed__12))]
	private IEnumerator ResultAnimation(Image gauge, ExtendedTextMeshProUGUI point, ExtendedTextMeshProUGUI gaugeInfo, ElementObjectManager stockEOM, Image diceImage, GameObject button)
	{
		return null;
	}

	[Token(Token = "0x6005F4B")]
	[Address(RVA = "0xA6A8A0", Offset = "0xA69AA0", VA = "0x180A6A8A0")]
	private void UpdateGauge(Image gauge, ExtendedTextMeshProUGUI point, ExtendedTextMeshProUGUI gaugeInfo, ElementObjectManager stockEOM, Image diceImage)
	{
	}

	[Token(Token = "0x6005F4C")]
	[Address(RVA = "0xA69AA0", Offset = "0xA68CA0", VA = "0x180A69AA0")]
	private void AddDiceIcon(ElementObjectManager stockEOM, Image diceImage)
	{
	}

	[Token(Token = "0x6005F4D")]
	[Address(RVA = "0xA69C80", Offset = "0xA68E80", VA = "0x180A69C80")]
	private void OnClicked()
	{
	}

	[Token(Token = "0x6005F4E")]
	[Address(RVA = "0xA6AAE0", Offset = "0xA69CE0", VA = "0x180A6AAE0")]
	public DiceResultViewController()
	{
	}
}
