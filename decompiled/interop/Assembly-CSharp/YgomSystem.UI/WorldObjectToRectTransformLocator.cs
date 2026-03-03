using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using YgomSystem.Effect;

namespace YgomSystem.UI;

[Token(Token = "0x200054D")]
[ExecuteInEditMode]
public class WorldObjectToRectTransformLocator : UIBehaviour
{
	[Token(Token = "0x40019B4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Camera m_TargetRenderCamera;

	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ScreenEffect.ViewType m_CameraViewType;

	[Token(Token = "0x40019B6")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool m_CameraOverUI;

	[Token(Token = "0x40019B7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform m_TargetWorldObject;

	[Token(Token = "0x40019B8")]
	[FieldOffset(Offset = "0x38")]
	private Canvas m_OwnerCanvasCache;

	[Token(Token = "0x40019B9")]
	[FieldOffset(Offset = "0x40")]
	private RectTransform m_RectTransformCache;

	[Token(Token = "0x170003A1")]
	public Camera targetRenderCamera
	{
		[Token(Token = "0x6002261")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002262")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x170003A2")]
	public Transform targetWorldObject
	{
		[Token(Token = "0x6002263")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002264")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		set
		{
		}
	}

	[Token(Token = "0x6002265")]
	[Address(RVA = "0x65AF80", Offset = "0x65A180", VA = "0x18065AF80", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6002266")]
	[Address(RVA = "0x65B040", Offset = "0x65A240", VA = "0x18065B040")]
	private void Update()
	{
	}

	[Token(Token = "0x6002267")]
	[Address(RVA = "0x65B280", Offset = "0x65A480", VA = "0x18065B280")]
	public WorldObjectToRectTransformLocator()
	{
	}
}
