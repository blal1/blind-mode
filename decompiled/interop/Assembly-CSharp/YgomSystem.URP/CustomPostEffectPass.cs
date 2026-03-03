using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.Universal;

namespace YgomSystem.URP;

[Token(Token = "0x2000317")]
public class CustomPostEffectPass : ScriptableRenderPass
{
	[Serializable]
	[Token(Token = "0x2000318")]
	public class Context
	{
		[Token(Token = "0x40010F5")]
		[FieldOffset(Offset = "0x10")]
		public string passName;

		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x18")]
		[Header("任意：直接描画カメラを指定する場合に設定")]
		public Camera targetCamera;

		[Token(Token = "0x40010F7")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x40010F8")]
		[FieldOffset(Offset = "0x28")]
		public MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40010F9")]
		[FieldOffset(Offset = "0x30")]
		public int passIndex;

		[Token(Token = "0x40010FA")]
		[FieldOffset(Offset = "0x34")]
		[Header("CustomPostEffectVolumeを適用するかどうか")]
		public bool supportedVolume;

		[Token(Token = "0x40010FB")]
		[FieldOffset(Offset = "0x38")]
		private string m_PassName_Blit_Cache;

		[Token(Token = "0x40010FC")]
		[FieldOffset(Offset = "0x40")]
		private string m_PassName_Draw_Cache;

		[Token(Token = "0x170001E7")]
		public string passName_Blit
		{
			[Token(Token = "0x6001353")]
			[Address(RVA = "0x403630", Offset = "0x402830", VA = "0x180403630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E8")]
		public string passName_Draw
		{
			[Token(Token = "0x6001354")]
			[Address(RVA = "0x4036A0", Offset = "0x4028A0", VA = "0x1804036A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001355")]
		[Address(RVA = "0x4034C0", Offset = "0x4026C0", VA = "0x1804034C0")]
		public static string MakePassName_Blit(string passName)
		{
			return null;
		}

		[Token(Token = "0x6001356")]
		[Address(RVA = "0x403500", Offset = "0x402700", VA = "0x180403500")]
		public static string MakePassName_Draw(string passName)
		{
			return null;
		}

		[Token(Token = "0x6001357")]
		[Address(RVA = "0x403540", Offset = "0x402740", VA = "0x180403540")]
		public bool Valid()
		{
			return default(bool);
		}

		[Token(Token = "0x6001358")]
		[Address(RVA = "0x403400", Offset = "0x402600", VA = "0x180403400")]
		public void EmbedContextOnExecute(Context other)
		{
		}

		[Token(Token = "0x6001359")]
		[Address(RVA = "0x403190", Offset = "0x402390", VA = "0x180403190")]
		private bool EmbedContextByVolume(Context other)
		{
			return default(bool);
		}

		[Token(Token = "0x600135A")]
		[Address(RVA = "0x403100", Offset = "0x402300", VA = "0x180403100")]
		private void EmbedContextByFields(Context other)
		{
		}

		[Token(Token = "0x600135B")]
		[Address(RVA = "0x4035E0", Offset = "0x4027E0", VA = "0x1804035E0")]
		public Context()
		{
		}
	}

	[Token(Token = "0x40010F2")]
	internal const string k_DefaultPassName = "CustomPostEffectPass";

	[Token(Token = "0x40010F3")]
	[FieldOffset(Offset = "0xB8")]
	private readonly Context m_SourceContext;

	[Token(Token = "0x40010F4")]
	[FieldOffset(Offset = "0xC0")]
	private readonly Context m_RuntimeContext;

	[Token(Token = "0x6001351")]
	[Address(RVA = "0x404F20", Offset = "0x404120", VA = "0x180404F20")]
	public CustomPostEffectPass(Context context)
	{
	}

	[Token(Token = "0x6001352")]
	[Address(RVA = "0x404A20", Offset = "0x403C20", VA = "0x180404A20", Slot = "11")]
	public override void RecordRenderGraph(RenderGraph renderGraph, ContextContainer frameData)
	{
	}
}
