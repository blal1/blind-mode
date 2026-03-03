using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000005")]
public class CameraTest : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text counterText;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text readText;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Text successText;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RawImage capturedImage;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Button button;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x48")]
	private string capturedString;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x50")]
	private int counter;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x54")]
	private int span;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x58")]
	private bool isSuccess;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x3D4950", Offset = "0x3D3B50", VA = "0x1803D4950")]
	private void Start()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3D4A90", Offset = "0x3D3C90", VA = "0x1803D4A90")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3D48E0", Offset = "0x3D3AE0", VA = "0x1803D48E0")]
	private void RestartCapture()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x3D4D70", Offset = "0x3D3F70", VA = "0x1803D4D70")]
	public CameraTest()
	{
	}
}
