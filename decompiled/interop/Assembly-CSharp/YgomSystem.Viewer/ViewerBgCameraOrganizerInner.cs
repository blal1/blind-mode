using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSystem.Viewer;

[Token(Token = "0x2000626")]
public class ViewerBgCameraOrganizerInner : MainCameraOrganizer
{
	[Token(Token = "0x2000627")]
	public new enum ViewMode
	{
		[Token(Token = "0x4001DD5")]
		DuelTop,
		[Token(Token = "0x4001DD6")]
		DuelTopFar
	}

	[Token(Token = "0x2000628")]
	public enum DisplayType
	{
		[Token(Token = "0x4001DD8")]
		Vista,
		[Token(Token = "0x4001DD9")]
		Standard,
		[Token(Token = "0x4001DDA")]
		MobileDevice
	}

	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0x148")]
	private Action externalOperator;

	[Token(Token = "0x4001DC1")]
	[FieldOffset(Offset = "0x150")]
	private Dictionary<DisplayType, Dictionary<ViewMode, CameraViewSetting.ViewInfo>> views;

	[Token(Token = "0x4001DC2")]
	[FieldOffset(Offset = "0x158")]
	private ViewMode currentViewerBgViewMode;

	[Token(Token = "0x4001DC3")]
	[FieldOffset(Offset = "0x15C")]
	private DisplayType currentViewerBgDisplayType;

	[Token(Token = "0x4001DC4")]
	[FieldOffset(Offset = "0x160")]
	private Vector3 ViewerBgCamShakedPos;

	[Token(Token = "0x4001DC5")]
	[FieldOffset(Offset = "0x16C")]
	private Vector3 ViewerBgCamPos;

	[Token(Token = "0x4001DC6")]
	[FieldOffset(Offset = "0x178")]
	private Quaternion ViewerBgCamRot;

	[Token(Token = "0x4001DC7")]
	[FieldOffset(Offset = "0x188")]
	private float ViewerBgCamFov;

	[Token(Token = "0x4001DC8")]
	[FieldOffset(Offset = "0x18C")]
	private float ViewerBgCamNearClip;

	[Token(Token = "0x4001DC9")]
	[FieldOffset(Offset = "0x190")]
	private float ViewerBgCamFarClip;

	[Token(Token = "0x4001DCA")]
	[FieldOffset(Offset = "0x198")]
	public new Camera camera3D;

	[Token(Token = "0x4001DCB")]
	[FieldOffset(Offset = "0x1A0")]
	public Camera ViewerBgSubCamera3D;

	[Token(Token = "0x4001DCC")]
	[FieldOffset(Offset = "0x1A8")]
	public Camera ViewerBgSubCamera2D;

	[Token(Token = "0x4001DCD")]
	[FieldOffset(Offset = "0x1B0")]
	public Camera ViewerBgScreenCamera3D;

	[Token(Token = "0x4001DCE")]
	[FieldOffset(Offset = "0x1B8")]
	public Camera ViewerBgScreenCamera2D;

	[Token(Token = "0x4001DCF")]
	[FieldOffset(Offset = "0x1C0")]
	public Camera ViewerBgPerformCamera3D;

	[Token(Token = "0x4001DD0")]
	[FieldOffset(Offset = "0x1C8")]
	public new Camera uiCameraContent;

	[Token(Token = "0x4001DD1")]
	[FieldOffset(Offset = "0x1D0")]
	public new Camera uiCameraOverlay;

	[Token(Token = "0x4001DD3")]
	[FieldOffset(Offset = "0x0")]
	private static ViewerBgCameraOrganizerInner _instance;

	[Token(Token = "0x17000513")]
	public new CameraViewSetting.ViewInfo view
	{
		[Token(Token = "0x600288C")]
		[Address(RVA = "0x6B8AF0", Offset = "0x6B7CF0", VA = "0x1806B8AF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000514")]
	public bool cameraWorkStart
	{
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x6B8890", Offset = "0x6B7A90", VA = "0x1806B8890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x6B8B70", Offset = "0x6B7D70", VA = "0x1806B8B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000515")]
	public new static ViewerBgCameraOrganizerInner instance
	{
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x6B88A0", Offset = "0x6B7AA0", VA = "0x1806B88A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002890")]
	[Address(RVA = "0x6B7730", Offset = "0x6B6930", VA = "0x1806B7730")]
	public new void Initialize()
	{
	}

	[Token(Token = "0x6002891")]
	[Address(RVA = "0x6B80F0", Offset = "0x6B72F0", VA = "0x1806B80F0")]
	public new void SetupViews()
	{
	}

	[Token(Token = "0x6002892")]
	[Address(RVA = "0x6B7680", Offset = "0x6B6880", VA = "0x1806B7680")]
	public void InitializeToDuel()
	{
	}

	[Token(Token = "0x6002893")]
	[Address(RVA = "0x6B8040", Offset = "0x6B7240", VA = "0x1806B8040")]
	public void SetViewMode(ViewMode viewMode, bool immediate = true)
	{
	}

	[Token(Token = "0x6002894")]
	[Address(RVA = "0x6B7F70", Offset = "0x6B7170", VA = "0x1806B7F70")]
	public void SetDisplayType(DisplayType displayType, bool immediate = true)
	{
	}

	[Token(Token = "0x6002895")]
	[Address(RVA = "0x6B7EC0", Offset = "0x6B70C0", VA = "0x1806B7EC0")]
	public void SetActivePostProcessing(bool active)
	{
	}

	[Token(Token = "0x6002896")]
	[Address(RVA = "0x6B8020", Offset = "0x6B7220", VA = "0x1806B8020")]
	public void SetExternalOperator(Action externalOperator)
	{
	}

	[Token(Token = "0x6002897")]
	[Address(RVA = "0x6B8660", Offset = "0x6B7860", VA = "0x1806B8660")]
	private void Update()
	{
	}

	[Token(Token = "0x6002898")]
	[Address(RVA = "0x6B83C0", Offset = "0x6B75C0", VA = "0x1806B83C0")]
	private void UpdateGameCam(float lerpT = 0.5f)
	{
	}

	[Token(Token = "0x6002899")]
	[Address(RVA = "0x6B8810", Offset = "0x6B7A10", VA = "0x1806B8810")]
	public ViewerBgCameraOrganizerInner()
	{
	}
}
