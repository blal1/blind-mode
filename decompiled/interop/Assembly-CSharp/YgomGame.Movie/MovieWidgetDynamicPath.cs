using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Movie;

[Token(Token = "0x20016D1")]
public class MovieWidgetDynamicPath : MovieWidget
{
	[Token(Token = "0x20016D3")]
	[CompilerGenerated]
	private sealed class _003CGetMoviePath_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400D8CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400D8D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400D8D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string scheme;

		[Token(Token = "0x400D8D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x1700158F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6008E17")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001590")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6008E19")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6008E14")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetMoviePath_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6008E15")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6008E16")]
		[Address(RVA = "0xDA6170", Offset = "0xDA5370", VA = "0x180DA6170", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6008E18")]
		[Address(RVA = "0xDA6250", Offset = "0xDA5450", VA = "0x180DA6250", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x6008E0E")]
	[Address(RVA = "0xDA4A50", Offset = "0xDA3C50", VA = "0x180DA4A50")]
	[IteratorStateMachine(typeof(_003CGetMoviePath_003Ed__0))]
	private IEnumerator GetMoviePath(string scheme, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6008E0F")]
	[Address(RVA = "0xDA4AE0", Offset = "0xDA3CE0", VA = "0x180DA4AE0", Slot = "4")]
	public override void SetMovie(string path, LoadType type, Color initColor)
	{
	}

	[Token(Token = "0x6008E10")]
	[Address(RVA = "0xDA4CA0", Offset = "0xDA3EA0", VA = "0x180DA4CA0")]
	public MovieWidgetDynamicPath()
	{
	}
}
