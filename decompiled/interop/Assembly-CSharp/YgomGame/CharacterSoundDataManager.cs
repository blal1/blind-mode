using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Bg;

namespace YgomGame;

[Token(Token = "0x20006EE")]
public class CharacterSoundDataManager
{
	[Token(Token = "0x20006F0")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x10")]
		public int id;

		[Token(Token = "0x6002E22")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6002E23")]
		[Address(RVA = "0x726870", Offset = "0x725A70", VA = "0x180726870")]
		internal void _003CLoadAudioClipCoroutine_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20006F1")]
	[CompilerGenerated]
	private sealed class _003CLoadAudioClipCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x20")]
		public int id;

		[Token(Token = "0x40022E1")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x170005B2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E27")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E29")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E24")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAudioClipCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E25")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E26")]
		[Address(RVA = "0x724BC0", Offset = "0x723DC0", VA = "0x180724BC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E28")]
		[Address(RVA = "0x724D40", Offset = "0x723F40", VA = "0x180724D40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20006F2")]
	[CompilerGenerated]
	private sealed class _003CUnloadAudioClipCroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40022E2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40022E3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170005B4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E2D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005B5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E2F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E2A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUnloadAudioClipCroutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E2B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E2C")]
		[Address(RVA = "0x726D20", Offset = "0x725F20", VA = "0x180726D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E2E")]
		[Address(RVA = "0x727020", Offset = "0x726220", VA = "0x180727020", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40022D8")]
	[FieldOffset(Offset = "0x0")]
	private static int characterSoundLoadCount;

	[Token(Token = "0x40022D9")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, int> loadIdDic;

	[Token(Token = "0x40022DA")]
	[FieldOffset(Offset = "0x10")]
	private static List<int> loadedId;

	[Token(Token = "0x170005B1")]
	public static AvatarModelSetting ModelSetting
	{
		[Token(Token = "0x6002E16")]
		[Address(RVA = "0x3D7C10", Offset = "0x3D6E10", VA = "0x1803D7C10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x7194C0", Offset = "0x7186C0", VA = "0x1807194C0")]
	public static bool IsLoaded(int id, Character.SubAvatarChange condition = Character.SubAvatarChange.None)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E18")]
	[Address(RVA = "0x7197C0", Offset = "0x7189C0", VA = "0x1807197C0")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002E19")]
	[Address(RVA = "0x7195C0", Offset = "0x7187C0", VA = "0x1807195C0")]
	public static void LoadAudioClip(int modelId)
	{
	}

	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x719560", Offset = "0x718760", VA = "0x180719560")]
	[IteratorStateMachine(typeof(_003CLoadAudioClipCoroutine_003Ed__8))]
	private static IEnumerator LoadAudioClipCoroutine(int id)
	{
		return null;
	}

	[Token(Token = "0x6002E1B")]
	[Address(RVA = "0x7199A0", Offset = "0x718BA0", VA = "0x1807199A0")]
	public static void UnloadAudioClip()
	{
	}

	[Token(Token = "0x6002E1C")]
	[Address(RVA = "0x719950", Offset = "0x718B50", VA = "0x180719950")]
	[IteratorStateMachine(typeof(_003CUnloadAudioClipCroutine_003Ed__10))]
	private static IEnumerator UnloadAudioClipCroutine()
	{
		return null;
	}

	[Token(Token = "0x6002E1D")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CharacterSoundDataManager()
	{
	}
}
