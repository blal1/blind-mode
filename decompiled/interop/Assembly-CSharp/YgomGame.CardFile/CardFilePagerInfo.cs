using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.CardFile;

[Token(Token = "0x20015A7")]
public class CardFilePagerInfo : MonoBehaviour
{
	[Token(Token = "0x400CE34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool m_FlickFlag;

	[Token(Token = "0x400CE35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector2 m_StartLoc;

	[Token(Token = "0x400CE36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector2 m_EndLoc;

	[Token(Token = "0x1700149E")]
	public CardFileManager cfManager
	{
		[Token(Token = "0x6008621")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008622")]
		[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700149F")]
	public int currentPage
	{
		[Token(Token = "0x6008623")]
		[Address(RVA = "0x5FA7B0", Offset = "0x5F99B0", VA = "0x1805FA7B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008624")]
		[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170014A0")]
	public Action<Dictionary<int, Dictionary<int, int>>> updateSecretPacks
	{
		[Token(Token = "0x6008626")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008625")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170014A1")]
	public Action<int, List<int>> shopTransitionCallback
	{
		[Token(Token = "0x6008628")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008627")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6008629")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void SetCraftResultCallback([Optional] Action<Dictionary<int, Dictionary<int, int>>> action)
	{
	}

	[Token(Token = "0x600862A")]
	[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
	public void SetShopTransitionCallback([Optional] Action<int, List<int>> action)
	{
	}

	[Token(Token = "0x600862B")]
	public static T Create<T>(CardFileManager cfManager, GameObject root, string name, Action onFinished) where T : CardFilePagerInfo
	{
		return null;
	}

	[Token(Token = "0x600862C")]
	[Address(RVA = "0xCEE820", Offset = "0xCEDA20", VA = "0x180CEE820")]
	private void Initialize(Action onFinished)
	{
	}

	[Token(Token = "0x600862D")]
	[Address(RVA = "0xCEF0F0", Offset = "0xCEE2F0", VA = "0x180CEF0F0")]
	public void ShowCardInfo(CardFileDefinition.Location location, int position)
	{
	}

	[Token(Token = "0x600862E")]
	[Address(RVA = "0xCEE7E0", Offset = "0xCED9E0", VA = "0x180CEE7E0")]
	public bool FlickPageDragStarter(Vector2 start, Vector2 end)
	{
		return default(bool);
	}

	[Token(Token = "0x600862F")]
	[Address(RVA = "0xCEE840", Offset = "0xCEDA40", VA = "0x180CEE840")]
	public void OnDrag(SelectionItem.DragStatus status, Vector2 pos)
	{
	}

	[Token(Token = "0x6008630")]
	[Address(RVA = "0xCEEAE0", Offset = "0xCEDCE0", VA = "0x180CEEAE0")]
	private void OpenCardBrowser(int page, int position, CardFileDefinition.OpenType openType)
	{
	}

	[Token(Token = "0x6008631")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardFilePagerInfo()
	{
	}
}
