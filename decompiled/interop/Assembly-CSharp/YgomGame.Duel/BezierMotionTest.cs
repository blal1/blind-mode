using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x200174F")]
public class BezierMotionTest : MonoBehaviour
{
	[Token(Token = "0x2001750")]
	private enum CameraMode
	{
		[Token(Token = "0x400DB99")]
		Top,
		[Token(Token = "0x400DB9A")]
		Motion
	}

	[Token(Token = "0x400DB89")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BezierMotionSetting[] setting;

	[Token(Token = "0x400DB8A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private CameraViewSetting cameraViewSetting;

	[Token(Token = "0x400DB8B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject originPositionObj;

	[Token(Token = "0x400DB8C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject targetPositionObj;

	[Token(Token = "0x400DB8D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject startObj;

	[Token(Token = "0x400DB8E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject viaObj;

	[Token(Token = "0x400DB8F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject endObj;

	[Token(Token = "0x400DB90")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject motionObj;

	[Token(Token = "0x400DB91")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float timer;

	[Token(Token = "0x400DB92")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool autoUpdateTimer;

	[Token(Token = "0x400DB93")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private GameObject[] prefabBg;

	[Token(Token = "0x400DB94")]
	[FieldOffset(Offset = "0x70")]
	private ChainedBezierMotion motion;

	[Token(Token = "0x400DB95")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CameraMode cameraMode;

	[Token(Token = "0x400DB96")]
	[FieldOffset(Offset = "0x7C")]
	private CameraMode preCameraMode;

	[Token(Token = "0x400DB97")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool loop;

	[Token(Token = "0x6009224")]
	[Address(RVA = "0xDC3F70", Offset = "0xDC3170", VA = "0x180DC3F70")]
	private void Start()
	{
	}

	[Token(Token = "0x6009225")]
	[Address(RVA = "0xDC41D0", Offset = "0xDC33D0", VA = "0x180DC41D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009226")]
	[Address(RVA = "0xDC4B20", Offset = "0xDC3D20", VA = "0x180DC4B20")]
	public BezierMotionTest()
	{
	}
}
