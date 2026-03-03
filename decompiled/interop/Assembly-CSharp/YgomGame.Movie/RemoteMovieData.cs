using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Video;

namespace YgomGame.Movie;

[Token(Token = "0x20016BF")]
internal class RemoteMovieData : MovieData
{
	[Token(Token = "0x400D85B")]
	[FieldOffset(Offset = "0x30")]
	public string folder;

	[Token(Token = "0x400D85C")]
	[FieldOffset(Offset = "0x38")]
	private string url;

	[Token(Token = "0x1700157B")]
	public override MovieWidget.LoadType type
	{
		[Token(Token = "0x6008D8F")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10", Slot = "4")]
		get
		{
			return default(MovieWidget.LoadType);
		}
	}

	[Token(Token = "0x6008D90")]
	[Address(RVA = "0xD80160", Offset = "0xD7F360", VA = "0x180D80160")]
	public RemoteMovieData(string name, string folder, string url, Color initColor)
	{
	}

	[Token(Token = "0x6008D91")]
	[Address(RVA = "0xD801E0", Offset = "0xD7F3E0", VA = "0x180D801E0")]
	public RemoteMovieData(string url)
	{
	}

	[Token(Token = "0x6008D92")]
	[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "5")]
	public override string GetPath()
	{
		return null;
	}

	[Token(Token = "0x6008D93")]
	[Address(RVA = "0xD800A0", Offset = "0xD7F2A0", VA = "0x180D800A0", Slot = "6")]
	public override bool SetMovie(MDVideoPlayer vp)
	{
		return default(bool);
	}
}
