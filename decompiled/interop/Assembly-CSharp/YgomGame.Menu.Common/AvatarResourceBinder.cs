using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x2001413")]
public class AvatarResourceBinder : ResourceBinderBase, IItemAvatarBinder
{
	[Serializable]
	[Token(Token = "0x2001414")]
	public class AvatarResourcePathData
	{
		[Token(Token = "0x400C503")]
		[FieldOffset(Offset = "0x10")]
		public string m_AvatarResourcePath;

		[Token(Token = "0x6007CCF")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AvatarResourcePathData()
		{
		}
	}

	[Token(Token = "0x400C502")]
	[FieldOffset(Offset = "0x10")]
	private AvatarResourcePathData m_AvaterPath;

	[Token(Token = "0x6007CCB")]
	[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
	public void Initialize(AvatarResourcePathData iconPath)
	{
	}

	[Token(Token = "0x6007CCC")]
	[Address(RVA = "0xC55370", Offset = "0xC54570", VA = "0x180C55370")]
	public string GetIconPath(string mateId, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007CCD")]
	[Address(RVA = "0xC553D0", Offset = "0xC545D0", VA = "0x180C553D0", Slot = "4")]
	private Component YgomGame_002EMenu_002ECommon_002EIItemAvatarBinder_002EBindItem(GameObject target, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6007CCE")]
	[Address(RVA = "0xC553E0", Offset = "0xC545E0", VA = "0x180C553E0")]
	public AvatarResourceBinder()
	{
	}
}
