using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Notification;

[Token(Token = "0x200023C")]
public class FirebaseManager : MonoBehaviour
{
	[Token(Token = "0x1700016C")]
	public static bool IsEnable
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700016D")]
	public static FirebaseManager Instance
	{
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0xD37BD0", Offset = "0xD36DD0", VA = "0x180D37BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xD37C70", Offset = "0xD36E70", VA = "0x180D37C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700016E")]
	public static string Token
	{
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0xD37C20", Offset = "0xD36E20", VA = "0x180D37C20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0xD37CE0", Offset = "0xD36EE0", VA = "0x180D37CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0xD379D0", Offset = "0xD36BD0", VA = "0x180D379D0")]
	[Conditional("UNUSED_FIREBASE_METHOD")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0xD37AF0", Offset = "0xD36CF0", VA = "0x180D37AF0")]
	[Conditional("UNUSED_FIREBASE_METHOD")]
	public static void SetAnalyticsCollection()
	{
	}

	[Token(Token = "0x6000D40")]
	[Address(RVA = "0xD37A50", Offset = "0xD36C50", VA = "0x180D37A50")]
	[Conditional("UNUSED_FIREBASE_METHOD")]
	public static void SendTrackLaunch()
	{
	}

	[Token(Token = "0x6000D41")]
	[Address(RVA = "0xD37AA0", Offset = "0xD36CA0", VA = "0x180D37AA0")]
	[Conditional("UNUSED_FIREBASE_METHOD")]
	public static void SendTrackTutorialComp()
	{
	}

	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FirebaseManager()
	{
	}
}
