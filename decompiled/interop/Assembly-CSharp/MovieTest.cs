using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

[Token(Token = "0x2000017")]
public class MovieTest : MonoBehaviour
{
	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x20")]
	private int url_index;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x24")]
	private int counter_up;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x28")]
	private string now_url;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x30")]
	private bool isPlay;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x38")]
	private string BaseURL;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x40")]
	private string Folder;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x48")]
	private List<string> url_list;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject counter;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x60")]
	private Text text;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x3E1F70", Offset = "0x3E1170", VA = "0x1803E1F70")]
	private void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x3E2060", Offset = "0x3E1260", VA = "0x1803E2060")]
	private void Update()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x3E1ED0", Offset = "0x3E10D0", VA = "0x1803E1ED0")]
	private void PrepareCompleted(VideoPlayer vp)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3E1E00", Offset = "0x3E1000", VA = "0x1803E1E00")]
	private void PlayVideo(string url)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x3E2190", Offset = "0x3E1390", VA = "0x1803E2190")]
	public MovieTest()
	{
	}
}
