using Il2CppDummyDll;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

[Token(Token = "0x200002C")]
public class GrabTransparentFeature : ScriptableRendererFeature
{
	[Token(Token = "0x200002D")]
	private class CustomRenderPass : ScriptableRenderPass
	{
		[Token(Token = "0x200002E")]
		private class PassData
		{
			[Token(Token = "0x40000BD")]
			[FieldOffset(Offset = "0x10")]
			internal TextureHandle srcHandle;

			[Token(Token = "0x40000BE")]
			[FieldOffset(Offset = "0x20")]
			internal TextureHandle destHandle;

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
			public PassData()
			{
			}
		}

		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string cameraTransparentTextureName;

		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string grabPassName;

		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		private static int cameraTransparentTextureID;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xB8")]
		private int m_tmpTextureID;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xC0")]
		private ScriptableRenderer m_renderer;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x3DAF80", Offset = "0x3DA180", VA = "0x1803DAF80")]
		public CustomRenderPass()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x3DA7D0", Offset = "0x3D99D0", VA = "0x1803DA7D0", Slot = "11")]
		public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		public void SetRenderer(ScriptableRenderer renderer)
		{
		}
	}

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string grabTransparentTag;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x20")]
	private CustomRenderPass m_ScriptablePass;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x3DE080", Offset = "0x3DD280", VA = "0x1803DE080", Slot = "5")]
	public override void Create()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x3DDF40", Offset = "0x3DD140", VA = "0x1803DDF40", Slot = "7")]
	public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x3DE1C0", Offset = "0x3DD3C0", VA = "0x1803DE1C0")]
	public GrabTransparentFeature()
	{
	}
}
