using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Utility;

[Token(Token = "0x200091F")]
public class TextGroupLoadHolder : MonoBehaviour
{
	[Token(Token = "0x40089BE")]
	[FieldOffset(Offset = "0x20")]
	private List<string> m_LoadedTextGroups;

	[Token(Token = "0x60036AA")]
	[Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60036AB")]
	[Address(RVA = "0x7C9A40", Offset = "0x7C8C40", VA = "0x1807C9A40")]
	public bool IsDoneAll()
	{
		return default(bool);
	}

	[Token(Token = "0x60036AC")]
	public void LoadCheck<T>()
	{
	}

	[Token(Token = "0x60036AD")]
	[Address(RVA = "0x7C9D00", Offset = "0x7C8F00", VA = "0x1807C9D00")]
	public void LoadCheck(Type textGroupType)
	{
	}

	[Token(Token = "0x60036AE")]
	[Address(RVA = "0x7C9D40", Offset = "0x7C8F40", VA = "0x1807C9D40")]
	public void LoadCheck(string groupId)
	{
	}

	[Token(Token = "0x60036AF")]
	public void LoadCheckAsync<T>()
	{
	}

	[Token(Token = "0x60036B0")]
	[Address(RVA = "0x7C9B80", Offset = "0x7C8D80", VA = "0x1807C9B80")]
	public void LoadCheckAsync(Type textGroupType)
	{
	}

	[Token(Token = "0x60036B1")]
	[Address(RVA = "0x7C9C50", Offset = "0x7C8E50", VA = "0x1807C9C50")]
	public void LoadCheckAsync(string groupId)
	{
	}

	[Token(Token = "0x60036B2")]
	[Address(RVA = "0x7C9F10", Offset = "0x7C9110", VA = "0x1807C9F10")]
	public TextGroupLoadHolder()
	{
	}
}
