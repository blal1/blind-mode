using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using YgomGame.Menu;

namespace YgomSample.TestLauncher;

[Token(Token = "0x2001DC6")]
public class ActionSheetEditScene : MonoBehaviour
{
	[Token(Token = "0x4010537")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject m_CustomPositiveButton;

	[Token(Token = "0x4010538")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject m_CustomDestructiveButton;

	[Token(Token = "0x4010539")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject m_CustomDisableButton;

	[Token(Token = "0x401053A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject m_EmbedGameObject;

	[Token(Token = "0x401053B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string m_Title;

	[Token(Token = "0x401053C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private string m_Messages;

	[Token(Token = "0x401053D")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	[FormerlySerializedAs("m_Entrys")]
	private string[] m_EntryTexts;

	[Token(Token = "0x401053E")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private int m_DestructiveLength;

	[Token(Token = "0x401053F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private ActionSheetViewController.EntryData[] m_EntryDatas;

	[Token(Token = "0x600BE4E")]
	[Address(RVA = "0x57D280", Offset = "0x57C480", VA = "0x18057D280")]
	[ContextMenu("OpenWithEmbedObject")]
	public void OpenWithEmbedObject()
	{
	}

	[Token(Token = "0x600BE4F")]
	[Address(RVA = "0x57D130", Offset = "0x57C330", VA = "0x18057D130")]
	[ContextMenu("OpenEntitys")]
	public void OpenEntitys()
	{
	}

	[Token(Token = "0x600BE50")]
	[Address(RVA = "0x57CD00", Offset = "0x57BF00", VA = "0x18057CD00")]
	[ContextMenu("OpenCustomSheet")]
	public void OpenCustomSheet()
	{
	}

	[Token(Token = "0x600BE51")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ActionSheetEditScene()
	{
	}
}
