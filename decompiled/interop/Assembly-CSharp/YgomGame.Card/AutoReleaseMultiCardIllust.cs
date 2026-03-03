using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x2001640")]
public class AutoReleaseMultiCardIllust : MonoBehaviour
{
	[Token(Token = "0x400D581")]
	[FieldOffset(Offset = "0x20")]
	private int refCardSystemId;

	[Token(Token = "0x400D582")]
	[FieldOffset(Offset = "0x28")]
	private CardIllustManager cardIllustManager;

	[Token(Token = "0x400D583")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Dictionary<int, Texture2D> requestCardIdTask;

	[Token(Token = "0x400D584")]
	[FieldOffset(Offset = "0x38")]
	private UnityAction<int, Texture2D> onFinish;

	[Token(Token = "0x400D585")]
	[FieldOffset(Offset = "0x40")]
	private UnityAction<Dictionary<int, Texture2D>> onFinishAll;

	[Token(Token = "0x17001525")]
	private bool isTaskComplete
	{
		[Token(Token = "0x6008A64")]
		[Address(RVA = "0xD45C40", Offset = "0xD44E40", VA = "0x180D45C40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008A65")]
	[Address(RVA = "0xD45BA0", Offset = "0xD44DA0", VA = "0x180D45BA0")]
	public AutoReleaseMultiCardIllust()
	{
	}

	[Token(Token = "0x6008A66")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void SetCardIllustManager(CardIllustManager cardIllustManager)
	{
	}

	[Token(Token = "0x6008A67")]
	[Address(RVA = "0xD458C0", Offset = "0xD44AC0", VA = "0x180D458C0")]
	public void SetCardidList(List<int> cardidlist, UnityAction<int, Texture2D> onFinish, UnityAction<Dictionary<int, Texture2D>> onFinishAll)
	{
	}

	[Token(Token = "0x6008A68")]
	[Address(RVA = "0xD45510", Offset = "0xD44710", VA = "0x180D45510")]
	private void LoadCardIllust()
	{
	}

	[Token(Token = "0x6008A69")]
	[Address(RVA = "0xD456C0", Offset = "0xD448C0", VA = "0x180D456C0")]
	private void ReleaseCardIllust()
	{
	}

	[Token(Token = "0x6008A6A")]
	[Address(RVA = "0xD456B0", Offset = "0xD448B0", VA = "0x180D456B0")]
	private void OnDestroy()
	{
	}
}
