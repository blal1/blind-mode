using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Video;
using YgomSystem.Video;

namespace YgomGame.Movie;

[Token(Token = "0x20016C0")]
internal class LocalMovieData : MovieData
{
	[Token(Token = "0x400D85D")]
	[FieldOffset(Offset = "0x30")]
	public VideoClip videoClip;

	[Token(Token = "0x400D85E")]
	[FieldOffset(Offset = "0x38")]
	public string path;

	[Token(Token = "0x1700157C")]
	public override MovieWidget.LoadType type
	{
		[Token(Token = "0x6008D94")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "4")]
		get
		{
			return default(MovieWidget.LoadType);
		}
	}

	[Token(Token = "0x6008D95")]
	[Address(RVA = "0xD7A3E0", Offset = "0xD795E0", VA = "0x180D7A3E0")]
	public LocalMovieData(string name, VideoClip vc, Color initColor)
	{
	}

	[Token(Token = "0x6008D96")]
	[Address(RVA = "0xD7A1D0", Offset = "0xD793D0", VA = "0x180D7A1D0")]
	public LocalMovieData(string name, VideoClip vc, string path, Color initColor)
	{
	}

	[Token(Token = "0x6008D97")]
	[Address(RVA = "0xD79FD0", Offset = "0xD791D0", VA = "0x180D79FD0")]
	public LocalMovieData(VideoClip vc, string path, Color initColor)
	{
	}

	[Token(Token = "0x6008D98")]
	[Address(RVA = "0xD79F00", Offset = "0xD79100", VA = "0x180D79F00", Slot = "6")]
	public override bool SetMovie(MDVideoPlayer vp)
	{
		return default(bool);
	}

	[Token(Token = "0x6008D99")]
	[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "5")]
	public override string GetPath()
	{
		return null;
	}

	[Token(Token = "0x6008D9A")]
	[Address(RVA = "0xD79EA0", Offset = "0xD790A0", VA = "0x180D79EA0", Slot = "7")]
	public override void ReleaceMovie(MDVideoPlayer vp)
	{
	}
}
