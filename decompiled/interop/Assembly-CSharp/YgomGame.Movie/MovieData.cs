using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Video;

namespace YgomGame.Movie;

[Token(Token = "0x20016BE")]
internal class MovieData
{
	[Token(Token = "0x400D858")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400D859")]
	[FieldOffset(Offset = "0x18")]
	public Color initColor;

	[Token(Token = "0x1700157A")]
	public virtual MovieWidget.LoadType type
	{
		[Token(Token = "0x6008D89")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(MovieWidget.LoadType);
		}
		[Token(Token = "0x6008D8A")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008D8B")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "5")]
	public virtual string GetPath()
	{
		return null;
	}

	[Token(Token = "0x6008D8C")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "6")]
	public virtual bool SetMovie(MDVideoPlayer vp)
	{
		return default(bool);
	}

	[Token(Token = "0x6008D8D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	public virtual void ReleaceMovie(MDVideoPlayer vp)
	{
	}

	[Token(Token = "0x6008D8E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public MovieData()
	{
	}
}
