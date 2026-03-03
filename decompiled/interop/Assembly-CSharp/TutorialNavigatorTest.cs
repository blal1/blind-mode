using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

[Token(Token = "0x2000026")]
public class TutorialNavigatorTest : MonoBehaviour
{
	[Token(Token = "0x4000098")]
	private const string MSG_STACK_BTN_LABEL = "Stack";

	[Token(Token = "0x4000099")]
	private const string STACK_MSG_AREA_TEXT_LABEL = "StackMsg";

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _centerMsgDelay;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager _eoManager;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager _inputFieldMgr;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x38")]
	private ExtendedInputField _inputField;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x40")]
	private Text _stackMsgText;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x48")]
	private IList<string> _messages;

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x3E78D0", Offset = "0x3E6AD0", VA = "0x1803E78D0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x3E7620", Offset = "0x3E6820", VA = "0x1803E7620")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3E7660", Offset = "0x3E6860", VA = "0x1803E7660")]
	private void PushMessage(string message)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3E7570", Offset = "0x3E6770", VA = "0x1803E7570")]
	private void ClearMessages()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3E7CF0", Offset = "0x3E6EF0", VA = "0x1803E7CF0")]
	public TutorialNavigatorTest()
	{
	}
}
