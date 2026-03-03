using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Serializable]
[Token(Token = "0x2000465")]
public class ScrollColorBar : MonoBehaviour
{
	[Token(Token = "0x2000466")]
	private class ColorBar : MonoBehaviour
	{
		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x20")]
		public int index;

		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x24")]
		public Color color;

		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x34")]
		public float length;

		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0x38")]
		public RectTransform rect;

		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x40")]
		public Image image;

		[Token(Token = "0x6001C69")]
		[Address(RVA = "0x5FAC00", Offset = "0x5F9E00", VA = "0x1805FAC00")]
		public ColorBar(string name, int index, Color color, float length)
		{
		}

		[Token(Token = "0x6001C6A")]
		[Address(RVA = "0x5FAB10", Offset = "0x5F9D10", VA = "0x1805FAB10")]
		public void Initialize(string name, int index, Color color, float length)
		{
		}
	}

	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0x20")]
	private bool isIni;

	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool isVertical;

	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager m_Eom;

	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform m_Root;

	[Token(Token = "0x400157F")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_Template;

	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0x40")]
	private float m_RootLength;

	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0x44")]
	private float m_TotalLength;

	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x48")]
	private List<ColorBar> m_ColorBarList;

	[Token(Token = "0x170002BB")]
	public int numBar
	{
		[Token(Token = "0x6001C61")]
		[Address(RVA = "0x605440", Offset = "0x604640", VA = "0x180605440")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6001C62")]
	[Address(RVA = "0x604E50", Offset = "0x604050", VA = "0x180604E50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C63")]
	[Address(RVA = "0x604FF0", Offset = "0x6041F0", VA = "0x180604FF0")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001C64")]
	[Address(RVA = "0x604BD0", Offset = "0x603DD0", VA = "0x180604BD0")]
	public void AddColorBar(Color color, float initialLength, string name)
	{
	}

	[Token(Token = "0x6001C65")]
	[Address(RVA = "0x605150", Offset = "0x604350", VA = "0x180605150")]
	public void StretchBarLength(int index, float length)
	{
	}

	[Token(Token = "0x6001C66")]
	[Address(RVA = "0x6051F0", Offset = "0x6043F0", VA = "0x1806051F0")]
	private void UpdateLength()
	{
	}

	[Token(Token = "0x6001C67")]
	[Address(RVA = "0x604E60", Offset = "0x604060", VA = "0x180604E60")]
	public void ClearAll()
	{
	}

	[Token(Token = "0x6001C68")]
	[Address(RVA = "0x6053C0", Offset = "0x6045C0", VA = "0x1806053C0")]
	public ScrollColorBar()
	{
	}
}
