using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.DuelPreview.Controller;

[Token(Token = "0x2000E98")]
[RequireComponent(typeof(Camera))]
public class PreviewCameraRunner : MonoBehaviour
{
	[Token(Token = "0x400A3BA")]
	[FieldOffset(Offset = "0x20")]
	private Camera m_PreviewCameraCache;

	[Token(Token = "0x400A3BB")]
	[FieldOffset(Offset = "0x28")]
	private CameraShaker m_CameraShakerCache;

	[Token(Token = "0x400A3BC")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_PreviewCameraDefaultLocalBos;

	[Token(Token = "0x17000D85")]
	private Camera previewCamera
	{
		[Token(Token = "0x6005823")]
		[Address(RVA = "0x9BF4E0", Offset = "0x9BE6E0", VA = "0x1809BF4E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D86")]
	private CameraShaker cameraShaker
	{
		[Token(Token = "0x6005824")]
		[Address(RVA = "0x9BF3C0", Offset = "0x9BE5C0", VA = "0x1809BF3C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000D87")]
	public bool isShaking
	{
		[Token(Token = "0x6005825")]
		[Address(RVA = "0x9BF460", Offset = "0x9BE660", VA = "0x1809BF460")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005826")]
	[Address(RVA = "0x9BF220", Offset = "0x9BE420", VA = "0x1809BF220")]
	private void Update()
	{
	}

	[Token(Token = "0x6005827")]
	[Address(RVA = "0x9BF1D0", Offset = "0x9BE3D0", VA = "0x1809BF1D0")]
	public void Shake(string label)
	{
	}

	[Token(Token = "0x6005828")]
	[Address(RVA = "0x9BF0E0", Offset = "0x9BE2E0", VA = "0x1809BF0E0")]
	public void FinishShake()
	{
	}

	[Token(Token = "0x6005829")]
	[Address(RVA = "0x9BF360", Offset = "0x9BE560", VA = "0x1809BF360")]
	public PreviewCameraRunner()
	{
	}
}
