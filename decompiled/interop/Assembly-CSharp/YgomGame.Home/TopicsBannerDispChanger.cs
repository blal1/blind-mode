using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Home;

[Token(Token = "0x2000D67")]
public class TopicsBannerDispChanger : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D68")]
	private class DeluxeItemDispChanger
	{
		[Token(Token = "0x4009EE1")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_IsDeluxe;

		[Token(Token = "0x4009EE2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Transform> m_DeluxeObjects;

		[Token(Token = "0x4009EE3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Transform> m_NotDeluxeObjects;

		[Token(Token = "0x4009EE4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("trueならScaleを0にして見えなくさせます(処理負荷軽減のため)")]
		private bool m_IsScaleZero;

		[Token(Token = "0x60050D9")]
		[Address(RVA = "0x96ADF0", Offset = "0x969FF0", VA = "0x18096ADF0")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x60050DA")]
		[Address(RVA = "0x96B6E0", Offset = "0x96A8E0", VA = "0x18096B6E0")]
		public DeluxeItemDispChanger()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D69")]
	private class EmphasisDateDispChanger
	{
		[Token(Token = "0x2000D6A")]
		private enum EmphasisType
		{
			[Token(Token = "0x4009EEB")]
			MATERIAL_RED,
			[Token(Token = "0x4009EEC")]
			COLOR
		}

		[Token(Token = "0x4009EE5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_IsEmphasis;

		[Token(Token = "0x4009EE6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private EmphasisType m_EmphasisType;

		[Token(Token = "0x4009EE7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TMP_Text m_NormalText;

		[Token(Token = "0x4009EE8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text m_EmphasisText;

		[Token(Token = "0x4009EE9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color m_EmphasisColor;

		[Token(Token = "0x60050DB")]
		[Address(RVA = "0x97ED80", Offset = "0x97DF80", VA = "0x18097ED80")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x97EF10", Offset = "0x97E110", VA = "0x18097EF10")]
		public EmphasisDateDispChanger()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D6B")]
	private class ImageColorDispChanger
	{
		[Token(Token = "0x4009EED")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<Image> m_Images;

		[Token(Token = "0x4009EEE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color m_Color;

		[Token(Token = "0x60050DD")]
		[Address(RVA = "0x992F40", Offset = "0x992140", VA = "0x180992F40")]
		public void UpdateDisp()
		{
		}

		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ImageColorDispChanger()
		{
		}
	}

	[Token(Token = "0x4009EDE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DeluxeItemDispChanger m_DeluxeItemDispChanger;

	[Token(Token = "0x4009EDF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private EmphasisDateDispChanger m_EmphasisDateDispChanger;

	[Token(Token = "0x4009EE0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ImageColorDispChanger m_ImageColorDispChanger;

	[Token(Token = "0x60050D7")]
	[Address(RVA = "0x9793D0", Offset = "0x9785D0", VA = "0x1809793D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60050D8")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TopicsBannerDispChanger()
	{
	}
}
