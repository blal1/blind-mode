using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.SocialSystem;

[Token(Token = "0x2000330")]
public class SocialPlatform
{
	[Token(Token = "0x2000333")]
	[CompilerGenerated]
	private sealed class _003CyStartWatchAuthenticate_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400116A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isAuthenticated;

		[Token(Token = "0x400116B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds _003Cwait_003E5__2;

		[Token(Token = "0x17000212")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600140B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600140D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001408")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyStartWatchAuthenticate_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001409")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600140A")]
		[Address(RVA = "0x5337B0", Offset = "0x5329B0", VA = "0x1805337B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600140C")]
		[Address(RVA = "0x533930", Offset = "0x532B30", VA = "0x180533930", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ISocialSystem s_instance;

	[Token(Token = "0x4001164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Coroutine yWatchObserver;

	[Token(Token = "0x1700020D")]
	public static bool IsEnable
	{
		[Token(Token = "0x60013F0")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700020E")]
	public static bool IsAuthenticated
	{
		[Token(Token = "0x60013F1")]
		[Address(RVA = "0x52A360", Offset = "0x529560", VA = "0x18052A360")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700020F")]
	public static string socialId
	{
		[Token(Token = "0x60013F2")]
		[Address(RVA = "0x52A500", Offset = "0x529700", VA = "0x18052A500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000210")]
	public static string socialHashId
	{
		[Token(Token = "0x60013F3")]
		[Address(RVA = "0x52A430", Offset = "0x529630", VA = "0x18052A430")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000211")]
	private static bool IsEnableAutoLogin
	{
		[Token(Token = "0x60013F4")]
		[Address(RVA = "0x52A3B0", Offset = "0x5295B0", VA = "0x18052A3B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60013EF")]
	[Address(RVA = "0x52A2E0", Offset = "0x5294E0", VA = "0x18052A2E0")]
	static SocialPlatform()
	{
	}

	[Token(Token = "0x60013F5")]
	[Address(RVA = "0x529CC0", Offset = "0x528EC0", VA = "0x180529CC0")]
	private static bool IsInitAutoLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x60013F6")]
	[Address(RVA = "0x529C80", Offset = "0x528E80", VA = "0x180529C80")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60013F7")]
	[Address(RVA = "0x529B80", Offset = "0x528D80", VA = "0x180529B80")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void Activate()
	{
	}

	[Token(Token = "0x60013F8")]
	[Address(RVA = "0x529BD0", Offset = "0x528DD0", VA = "0x180529BD0")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void Authenticate([Optional] Action<bool> callback)
	{
	}

	[Token(Token = "0x60013F9")]
	[Address(RVA = "0x52A050", Offset = "0x529250", VA = "0x18052A050")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void SignOut()
	{
	}

	[Token(Token = "0x60013FA")]
	[Address(RVA = "0x52A290", Offset = "0x529490", VA = "0x18052A290")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void UpdateSocialId()
	{
	}

	[Token(Token = "0x60013FB")]
	[Address(RVA = "0x52A0E0", Offset = "0x5292E0", VA = "0x18052A0E0")]
	private static void StartWatchAuthenticate()
	{
	}

	[Token(Token = "0x60013FC")]
	[Address(RVA = "0x52A5A0", Offset = "0x5297A0", VA = "0x18052A5A0")]
	[IteratorStateMachine(typeof(_003CyStartWatchAuthenticate_003Ed__20))]
	private static IEnumerator yStartWatchAuthenticate(bool isAuthenticated)
	{
		return null;
	}

	[Token(Token = "0x60013FD")]
	[Address(RVA = "0x52A1E0", Offset = "0x5293E0", VA = "0x18052A1E0")]
	private static void UpdateLoginStatus(bool isAutheticated)
	{
	}

	[Token(Token = "0x60013FE")]
	[Address(RVA = "0x529E50", Offset = "0x529050", VA = "0x180529E50")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void ShowAchievementUI()
	{
	}

	[Token(Token = "0x60013FF")]
	[Address(RVA = "0x529DB0", Offset = "0x528FB0", VA = "0x180529DB0")]
	private static void SetAchievementNotificator()
	{
	}

	[Token(Token = "0x6001400")]
	[Address(RVA = "0x529930", Offset = "0x528B30", VA = "0x180529930")]
	private static void AchievementNotificator(object value)
	{
	}

	[Token(Token = "0x6001401")]
	[Address(RVA = "0x52A130", Offset = "0x529330", VA = "0x18052A130")]
	[Conditional("UNUSED_SOCIAL_PLATFORM_METHOD")]
	public static void UnlockAchievement(string id, [Optional] Action<bool> callback)
	{
	}

	[Token(Token = "0x6001402")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SocialPlatform()
	{
	}
}
