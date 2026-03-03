using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Menu.Common;

[Token(Token = "0x200141E")]
public class BindingComponentsJson : MonoBehaviour, IBindingModifiyByArgsHandler
{
	[Serializable]
	[Token(Token = "0x200141F")]
	public class BindingData
	{
		[Token(Token = "0x400C522")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		[Token(Token = "0x400C523")]
		[FieldOffset(Offset = "0x18")]
		[ComponentSelector(true)]
		public MonoBehaviour component;

		[Token(Token = "0x400C524")]
		[FieldOffset(Offset = "0x20")]
		public string writePath;

		[Token(Token = "0x400C525")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("入力された値を文字列フォーマットする場合に指定")]
		public string valueFormat;

		[Token(Token = "0x6007D24")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BindingData()
		{
		}
	}

	[Token(Token = "0x400C521")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<BindingData> m_BindingDatas;

	[Token(Token = "0x6007D21")]
	[Address(RVA = "0xC56E30", Offset = "0xC56030", VA = "0x180C56E30", Slot = "4")]
	public void OnPostModifiyByArgs(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007D22")]
	[Address(RVA = "0xC56C20", Offset = "0xC55E20", VA = "0x180C56C20")]
	public static string GenerateJson(string path, object value)
	{
		return null;
	}

	[Token(Token = "0x6007D23")]
	[Address(RVA = "0xC57160", Offset = "0xC56360", VA = "0x180C57160")]
	public BindingComponentsJson()
	{
	}
}
