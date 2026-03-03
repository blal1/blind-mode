using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.HeaderFooter;

[Token(Token = "0x2000D9A")]
public class OutGameFooter : MonoBehaviour
{
	[Token(Token = "0x4009F70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string ROOT_LABEL;

	[Token(Token = "0x4009F71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string TMP_LABEL;

	[Token(Token = "0x4009F72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string TXT_LABEL;

	[Token(Token = "0x4009F73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string IMG_LABEL;

	[Token(Token = "0x4009F74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ElementObjectManager elementObjectManager;

	[Token(Token = "0x4009F75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Dictionary<SelectorManager.KeyType, GameObject> shortcutDic;

	[Token(Token = "0x17000BDB")]
	private ElementObjectManager eom
	{
		[Token(Token = "0x60051BD")]
		[Address(RVA = "0x993980", Offset = "0x992B80", VA = "0x180993980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60051BE")]
	[Address(RVA = "0x9934E0", Offset = "0x9926E0", VA = "0x1809934E0")]
	public static void Create(Transform parent, [Optional] Action<OutGameFooter> onComplete)
	{
	}

	[Token(Token = "0x60051BF")]
	[Address(RVA = "0x9936C0", Offset = "0x9928C0", VA = "0x1809936C0")]
	public void SetShortcut(SelectorManager.KeyType keyType, string label, [Optional] Action onComplete, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00)
	{
	}

	[Token(Token = "0x60051C0")]
	[Address(RVA = "0x993600", Offset = "0x992800", VA = "0x180993600")]
	public void RemoveShortcut(SelectorManager.KeyType keyType)
	{
	}

	[Token(Token = "0x60051C1")]
	[Address(RVA = "0x9931D0", Offset = "0x9923D0", VA = "0x1809931D0")]
	private GameObject CreateTemplate(SelectorManager.KeyType keyType, string label, [Optional] Action onComplete, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00)
	{
		return null;
	}

	[Token(Token = "0x60051C2")]
	[Address(RVA = "0x9938B0", Offset = "0x992AB0", VA = "0x1809938B0")]
	public OutGameFooter()
	{
	}
}
