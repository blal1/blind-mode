using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Card;

[Token(Token = "0x200163E")]
public class AutoReleaseCardPicture : MonoBehaviour
{
	[Token(Token = "0x400D578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int refCardSystemId;

	[Token(Token = "0x400D579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private CardPictureManager cardPictureManager;

	[Token(Token = "0x400D57A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<int> cardidList;

	[Token(Token = "0x400D57B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<int> taskidList;

	[Token(Token = "0x400D57C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<UnityAction<Texture2D>> onFinishList;

	[Token(Token = "0x400D57D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private UnityAction onFinishAll;

	[Token(Token = "0x400D57E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int loadingCount;

	[Token(Token = "0x6008A5B")]
	[Address(RVA = "0xD45410", Offset = "0xD44610", VA = "0x180D45410")]
	public AutoReleaseCardPicture()
	{
	}

	[Token(Token = "0x6008A5C")]
	[Address(RVA = "0xD450C0", Offset = "0xD442C0", VA = "0x180D450C0")]
	public void SetCardMaterialManager(CardPictureManager cardPictureManager)
	{
	}

	[Token(Token = "0x6008A5D")]
	[Address(RVA = "0xD44FB0", Offset = "0xD441B0", VA = "0x180D44FB0")]
	public void SetCardList(List<int> cardidList, List<UnityAction<Texture2D>> onFinishList, [Optional] UnityAction onFinishAll)
	{
	}

	[Token(Token = "0x6008A5E")]
	[Address(RVA = "0xD45230", Offset = "0xD44430", VA = "0x180D45230")]
	public void SetCard(int cardid, UnityAction<Texture2D> onFinish)
	{
	}

	[Token(Token = "0x6008A5F")]
	[Address(RVA = "0xD44E50", Offset = "0xD44050", VA = "0x180D44E50")]
	private void ReleaseCardPicture()
	{
	}

	[Token(Token = "0x6008A60")]
	[Address(RVA = "0xD44C40", Offset = "0xD43E40", VA = "0x180D44C40")]
	private void LoadCardPicture()
	{
	}

	[Token(Token = "0x6008A61")]
	[Address(RVA = "0xD44E40", Offset = "0xD44040", VA = "0x180D44E40")]
	private void OnDestroy()
	{
	}
}
