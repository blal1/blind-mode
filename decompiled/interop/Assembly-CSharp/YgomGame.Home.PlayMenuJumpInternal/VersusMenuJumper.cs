using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Colosseum;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D7F")]
public class VersusMenuJumper : PlayMenuJumperBase
{
	[Token(Token = "0x2000D80")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4009F0C")]
		[FieldOffset(Offset = "0x10")]
		public bool apiFlag;

		[Token(Token = "0x4009F0D")]
		[FieldOffset(Offset = "0x14")]
		public int apiNum;

		[Token(Token = "0x4009F0E")]
		[FieldOffset(Offset = "0x18")]
		public VersusMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F0F")]
		[FieldOffset(Offset = "0x20")]
		public Action<bool> callback;

		[Token(Token = "0x6005133")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6005134")]
		[Address(RVA = "0x997160", Offset = "0x996360", VA = "0x180997160")]
		internal void _003CcheckCoroutine_003Eb__0(Handle handle)
		{
		}

		[Token(Token = "0x6005135")]
		[Address(RVA = "0x997190", Offset = "0x996390", VA = "0x180997190")]
		internal void _003CcheckCoroutine_003Eb__1(int group_id, ViewController selectView)
		{
		}
	}

	[Token(Token = "0x2000D81")]
	[CompilerGenerated]
	private sealed class _003CcheckCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009F10")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009F11")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009F12")]
		[FieldOffset(Offset = "0x20")]
		public VersusMenuJumper _003C_003E4__this;

		[Token(Token = "0x4009F13")]
		[FieldOffset(Offset = "0x28")]
		public Action<bool> callback;

		[Token(Token = "0x4009F14")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		[Token(Token = "0x17000BBF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005139")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BC0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600513B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005136")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcheckCoroutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005137")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005138")]
		[Address(RVA = "0x9986F0", Offset = "0x9978F0", VA = "0x1809986F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600513A")]
		[Address(RVA = "0x998C00", Offset = "0x997E00", VA = "0x180998C00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009F08")]
	[FieldOffset(Offset = "0x10")]
	private bool _isCalledDetailAPI;

	[Token(Token = "0x4009F09")]
	[FieldOffset(Offset = "0x14")]
	private int _id;

	[Token(Token = "0x4009F0A")]
	[FieldOffset(Offset = "0x18")]
	private int m_eventID;

	[Token(Token = "0x4009F0B")]
	[FieldOffset(Offset = "0x20")]
	private string path;

	[Token(Token = "0x17000BBD")]
	protected override ColosseumUtil.PlayMode playMode
	{
		[Token(Token = "0x600512D")]
		[Address(RVA = "0x3FC090", Offset = "0x3FB290", VA = "0x1803FC090", Slot = "4")]
		get
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x17000BBE")]
	protected override string prefabPath
	{
		[Token(Token = "0x600512E")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600512F")]
	[Address(RVA = "0x99BC30", Offset = "0x99AE30", VA = "0x18099BC30", Slot = "6")]
	protected override void ExtendArgs(ref Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6005130")]
	[Address(RVA = "0x99BD40", Offset = "0x99AF40", VA = "0x18099BD40")]
	public VersusMenuJumper(int eventID)
	{
	}

	[Token(Token = "0x6005131")]
	[Address(RVA = "0x99BBA0", Offset = "0x99ADA0", VA = "0x18099BBA0", Slot = "7")]
	public override void Check(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6005132")]
	[Address(RVA = "0x99BDA0", Offset = "0x99AFA0", VA = "0x18099BDA0")]
	[IteratorStateMachine(typeof(_003CcheckCoroutine_003Ed__11))]
	private IEnumerator checkCoroutine(Action<bool> callback)
	{
		return null;
	}
}
