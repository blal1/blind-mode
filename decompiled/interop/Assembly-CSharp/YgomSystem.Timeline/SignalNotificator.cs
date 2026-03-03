using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace YgomSystem.Timeline;

[Token(Token = "0x200021A")]
public class SignalNotificator : MonoBehaviour, INotificationReceiver
{
	[Token(Token = "0x1400000D")]
	public event Action<string, double> callback
	{
		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0xD39610", Offset = "0xD38810", VA = "0x180D39610")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000C80")]
		[Address(RVA = "0xD396C0", Offset = "0xD388C0", VA = "0x180D396C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000C81")]
	[Address(RVA = "0xD39450", Offset = "0xD38650", VA = "0x180D39450", Slot = "4")]
	public void OnNotify(Playable origin, INotification notification, object context)
	{
	}

	[Token(Token = "0x6000C82")]
	[Address(RVA = "0x615660", Offset = "0x614860", VA = "0x180615660")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000C83")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SignalNotificator()
	{
	}
}
