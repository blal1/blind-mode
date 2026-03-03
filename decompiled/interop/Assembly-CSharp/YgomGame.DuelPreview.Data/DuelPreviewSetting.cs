using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.DuelPreview.Data;

[Token(Token = "0x2000E40")]
[CreateAssetMenu]
public class DuelPreviewSetting : ScriptableObject
{
	[Token(Token = "0x400A2C7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string m_DuelPreviewPathFormat;

	[Token(Token = "0x400A2C8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AssetPath(typeof(DuelPreviewAsset))]
	private string m_SummonPreviewAssetPath;

	[Token(Token = "0x400A2C9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string[] m_PreviewRequireAssetFormats;

	[Token(Token = "0x400A2CA")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 m_RivalCardRot;

	[Token(Token = "0x17000CFB")]
	public string summonPreviewAssetPath
	{
		[Token(Token = "0x600564D")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000CFC")]
	public Vector3 rivalCardRot
	{
		[Token(Token = "0x600564E")]
		[Address(RVA = "0x9B7060", Offset = "0x9B6260", VA = "0x1809B7060")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x600564F")]
	[Address(RVA = "0x9B6F30", Offset = "0x9B6130", VA = "0x1809B6F30")]
	public bool ExistsPreviewRequireAsset(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x6005650")]
	[Address(RVA = "0x9B6EF0", Offset = "0x9B60F0", VA = "0x1809B6EF0")]
	public bool ExistsDuelPreview(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x6005651")]
	[Address(RVA = "0x9898D0", Offset = "0x988AD0", VA = "0x1809898D0")]
	public string GetDuelPreviewAssetPath(int mrk)
	{
		return null;
	}

	[Token(Token = "0x6005652")]
	[Address(RVA = "0x9B6FD0", Offset = "0x9B61D0", VA = "0x1809B6FD0")]
	public DuelPreviewSetting()
	{
	}
}
