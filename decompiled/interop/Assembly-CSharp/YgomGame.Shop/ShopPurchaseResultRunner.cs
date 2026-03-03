using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomGame.Shop;

[Token(Token = "0x20009B8")]
public static class ShopPurchaseResultRunner
{
	[Token(Token = "0x20009B9")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x4008D6E")]
		[FieldOffset(Offset = "0x10")]
		public GameObject effectPref;

		[Token(Token = "0x4008D6F")]
		[FieldOffset(Offset = "0x18")]
		public bool loading;

		[Token(Token = "0x6003B4D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x81F820", Offset = "0x81EA20", VA = "0x18081F820")]
		internal void _003CyPlayObtainEffectBody_003Eb__0(string path)
		{
		}
	}

	[Token(Token = "0x20009BA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4008D70")]
		[FieldOffset(Offset = "0x10")]
		public bool inDialog;

		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CyPlayObtainItemDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20009BB")]
	[CompilerGenerated]
	private sealed class _003CyPlayObtainEffect_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008D71")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008D72")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008D73")]
		[FieldOffset(Offset = "0x20")]
		public string effectKey;

		[Token(Token = "0x4008D74")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, object> resultInfo;

		[Token(Token = "0x4008D75")]
		[FieldOffset(Offset = "0x30")]
		private GameObject _003CeffectRoot_003E5__2;

		[Token(Token = "0x170007CE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003B54")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007CF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B56")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayObtainEffect_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x820400", Offset = "0x81F600", VA = "0x180820400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B55")]
		[Address(RVA = "0x820620", Offset = "0x81F820", VA = "0x180820620", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20009BC")]
	[CompilerGenerated]
	private sealed class _003CyPlayObtainEffectBody_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008D76")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008D77")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008D78")]
		[FieldOffset(Offset = "0x20")]
		public string effectKey;

		[Token(Token = "0x4008D79")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		[Token(Token = "0x4008D7A")]
		[FieldOffset(Offset = "0x30")]
		public GameObject effectRoot;

		[Token(Token = "0x4008D7B")]
		[FieldOffset(Offset = "0x38")]
		private PlayableDirector _003CplayableDirector_003E5__2;

		[Token(Token = "0x170007D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003B5A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B5C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B57")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayObtainEffectBody_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003B58")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003B59")]
		[Address(RVA = "0x8200A0", Offset = "0x81F2A0", VA = "0x1808200A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B5B")]
		[Address(RVA = "0x8203C0", Offset = "0x81F5C0", VA = "0x1808203C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20009BD")]
	[CompilerGenerated]
	private sealed class _003CyPlayObtainItemDialog_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008D7C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008D7D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008D7E")]
		[FieldOffset(Offset = "0x20")]
		public List<object> obtainItems;

		[Token(Token = "0x4008D7F")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, object> resultInfo;

		[Token(Token = "0x4008D80")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x170007D2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003B60")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B62")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B5D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayObtainItemDialog_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003B5E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003B5F")]
		[Address(RVA = "0x820660", Offset = "0x81F860", VA = "0x180820660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B61")]
		[Address(RVA = "0x820A90", Offset = "0x81FC90", VA = "0x180820A90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20009BE")]
	[CompilerGenerated]
	private sealed class _003CyPlayResultRoutine_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008D81")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008D82")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008D83")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> result;

		[Token(Token = "0x4008D84")]
		[FieldOffset(Offset = "0x28")]
		public Action complete;

		[Token(Token = "0x4008D85")]
		[FieldOffset(Offset = "0x30")]
		private List<object>.Enumerator _003C_003E7__wrap1;

		[Token(Token = "0x170007D4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003B67")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007D5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003B69")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003B63")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayResultRoutine_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003B64")]
		[Address(RVA = "0x821230", Offset = "0x820430", VA = "0x180821230", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003B65")]
		[Address(RVA = "0x820EB0", Offset = "0x8200B0", VA = "0x180820EB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003B66")]
		[Address(RVA = "0x8212C0", Offset = "0x8204C0", VA = "0x1808212C0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6003B68")]
		[Address(RVA = "0x8211F0", Offset = "0x8203F0", VA = "0x1808211F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6003B48")]
	[Address(RVA = "0x81A740", Offset = "0x819940", VA = "0x18081A740")]
	private static string GetObtainEffectPath(string effectKey)
	{
		return null;
	}

	[Token(Token = "0x6003B49")]
	[Address(RVA = "0x81A950", Offset = "0x819B50", VA = "0x18081A950")]
	[IteratorStateMachine(typeof(_003CyPlayResultRoutine_003Ed__1))]
	public static IEnumerator yPlayResultRoutine(Dictionary<string, object> result, Action complete)
	{
		return null;
	}

	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0x81A830", Offset = "0x819A30", VA = "0x18081A830")]
	[IteratorStateMachine(typeof(_003CyPlayObtainEffect_003Ed__2))]
	private static IEnumerator yPlayObtainEffect(string effectKey, Dictionary<string, object> resultInfo)
	{
		return null;
	}

	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0x81A7A0", Offset = "0x8199A0", VA = "0x18081A7A0")]
	[IteratorStateMachine(typeof(_003CyPlayObtainEffectBody_003Ed__3))]
	private static IEnumerator yPlayObtainEffectBody(string effectKey, GameObject effectRoot)
	{
		return null;
	}

	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0x81A8C0", Offset = "0x819AC0", VA = "0x18081A8C0")]
	[IteratorStateMachine(typeof(_003CyPlayObtainItemDialog_003Ed__4))]
	private static IEnumerator yPlayObtainItemDialog(List<object> obtainItems, Dictionary<string, object> resultInfo)
	{
		return null;
	}
}
