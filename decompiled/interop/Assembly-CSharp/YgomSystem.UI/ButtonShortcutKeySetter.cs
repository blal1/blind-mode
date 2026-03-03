using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000565")]
[RequireComponent(typeof(SelectionButton))]
public class ButtonShortcutKeySetter : MonoBehaviour
{
	[Token(Token = "0x2000566")]
	public enum InputType
	{
		[Token(Token = "0x4001A64")]
		Always,
		[Token(Token = "0x4001A65")]
		OnSelected
	}

	[Serializable]
	[Token(Token = "0x2000567")]
	public class Setting
	{
		[Token(Token = "0x4001A66")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputType m_InputType;

		[Token(Token = "0x4001A67")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Tooltip("ショートカットキーの指定")]
		private SelectorManager.KeyType m_KeyType;

		[Token(Token = "0x4001A68")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("ショートカットキー(サブ)の指定")]
		private SelectorManager.KeyType m_KeyTypeSub;

		[Token(Token = "0x170003C1")]
		public InputType inputType
		{
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(InputType);
			}
			[Token(Token = "0x600230D")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			set
			{
			}
		}

		[Token(Token = "0x170003C2")]
		public SelectorManager.KeyType keyType
		{
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			get
			{
				return default(SelectorManager.KeyType);
			}
			[Token(Token = "0x600230F")]
			[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
			set
			{
			}
		}

		[Token(Token = "0x170003C3")]
		public SelectorManager.KeyType keyTypeSub
		{
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			get
			{
				return default(SelectorManager.KeyType);
			}
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
			set
			{
			}
		}

		[Token(Token = "0x6002312")]
		[Address(RVA = "0x6524F0", Offset = "0x6516F0", VA = "0x1806524F0")]
		public Setting()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000568")]
	public class MouseSetting
	{
		[Token(Token = "0x4001A69")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputType m_InputType;

		[Token(Token = "0x4001A6A")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SelectorManager.MouseType m_MouseType;

		[Token(Token = "0x170003C4")]
		public InputType inputType
		{
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
			get
			{
				return default(InputType);
			}
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
			set
			{
			}
		}

		[Token(Token = "0x170003C5")]
		public SelectorManager.MouseType mouseType
		{
			[Token(Token = "0x6002315")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
			get
			{
				return default(SelectorManager.MouseType);
			}
			[Token(Token = "0x6002316")]
			[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
			set
			{
			}
		}

		[Token(Token = "0x6002317")]
		[Address(RVA = "0x64B760", Offset = "0x64A960", VA = "0x18064B760")]
		public MouseSetting()
		{
		}
	}

	[Token(Token = "0x4001A60")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Setting[] m_Settings;

	[Token(Token = "0x4001A61")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private MouseSetting[] m_MouseSettings;

	[Token(Token = "0x4001A62")]
	[FieldOffset(Offset = "0x30")]
	private SelectionButton m_ButtonCache;

	[Token(Token = "0x170003C0")]
	private SelectionButton button
	{
		[Token(Token = "0x6002307")]
		[Address(RVA = "0x647C60", Offset = "0x646E60", VA = "0x180647C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002308")]
	[Address(RVA = "0x647A50", Offset = "0x646C50", VA = "0x180647A50")]
	private void Start()
	{
	}

	[Token(Token = "0x6002309")]
	[Address(RVA = "0x6479F0", Offset = "0x646BF0", VA = "0x1806479F0")]
	private bool OnSelectedKeyUp()
	{
		return default(bool);
	}

	[Token(Token = "0x600230A")]
	[Address(RVA = "0x647A20", Offset = "0x646C20", VA = "0x180647A20")]
	private void OnSelectedMounseUp(bool pointerEnter)
	{
	}

	[Token(Token = "0x600230B")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ButtonShortcutKeySetter()
	{
	}
}
