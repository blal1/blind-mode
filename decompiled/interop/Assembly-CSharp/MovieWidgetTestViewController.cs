using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomGame.Menu;
using YgomGame.Movie;

[Token(Token = "0x2000018")]
public class MovieWidgetTestViewController : BaseMenuViewController
{
	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class _003CInitialize_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x20")]
		public MovieWidgetTestViewController _003C_003E4__this;

		[Token(Token = "0x17000008")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitialize_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x3E94E0", Offset = "0x3E86E0", VA = "0x1803E94E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3E9700", Offset = "0x3E8900", VA = "0x1803E9700", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0xD0")]
	private MovieWidget movie;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0xD8")]
	private Slider slider;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x3E2840", Offset = "0x3E1A40", VA = "0x1803E2840")]
	public void Awake()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x3E2920", Offset = "0x3E1B20", VA = "0x1803E2920", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x3E28B0", Offset = "0x3E1AB0", VA = "0x1803E28B0")]
	[IteratorStateMachine(typeof(_003CInitialize_003Ed__4))]
	private IEnumerator Initialize()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x3E29E0", Offset = "0x3E1BE0", VA = "0x1803E29E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x3E3250", Offset = "0x3E2450", VA = "0x1803E3250")]
	private void Update()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public MovieWidgetTestViewController()
	{
	}
}
