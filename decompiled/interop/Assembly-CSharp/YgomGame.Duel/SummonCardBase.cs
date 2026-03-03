using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomGame.Duel;

[Token(Token = "0x2001A9A")]
public abstract class SummonCardBase
{
	[Token(Token = "0x400F4ED")]
	[FieldOffset(Offset = "0x10")]
	protected Texture2D textureFront;

	[Token(Token = "0x400F4EE")]
	[FieldOffset(Offset = "0x18")]
	protected Material protectorMaterial;

	[Token(Token = "0x400F4F0")]
	[FieldOffset(Offset = "0x24")]
	protected int loadCounter;

	[Token(Token = "0x400F4F1")]
	[FieldOffset(Offset = "0x28")]
	protected GameObject autoReleaseCardPicture;

	[Token(Token = "0x17001ACB")]
	public bool finished
	{
		[Token(Token = "0x600AD01")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600AD02")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001ACC")]
	protected abstract string timelinePath
	{
		[Token(Token = "0x600AD03")]
		get;
	}

	[Token(Token = "0x17001ACD")]
	protected abstract string seLabel
	{
		[Token(Token = "0x600AD04")]
		get;
	}

	[Token(Token = "0x17001ACE")]
	protected abstract string trailOffsetLabel
	{
		[Token(Token = "0x600AD05")]
		get;
	}

	[Token(Token = "0x17001ACF")]
	protected bool isLoading
	{
		[Token(Token = "0x600AD06")]
		[Address(RVA = "0x4473E0", Offset = "0x4465E0", VA = "0x1804473E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AD07")]
	[Address(RVA = "0x4465C0", Offset = "0x4457C0", VA = "0x1804465C0")]
	protected void Initialize(int cardID, int uniqueID, int rareID, Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
	}

	[Token(Token = "0x600AD08")]
	[Address(RVA = "0x446A90", Offset = "0x445C90", VA = "0x180446A90")]
	private void LoadCardFront(int cardID, int rareID, Action<Texture2D> onFinished)
	{
	}

	[Token(Token = "0x600AD09")]
	[Address(RVA = "0x4469C0", Offset = "0x445BC0", VA = "0x1804469C0")]
	private void LoadCardBack(int sleeveID, UnityAction<Material> onFinished)
	{
	}

	[Token(Token = "0x600AD0A")]
	[Address(RVA = "0x446B90", Offset = "0x445D90", VA = "0x180446B90")]
	public void LoadTimeline(string path, int materialNum, Action<bool> onLoaded)
	{
	}

	[Token(Token = "0x600AD0B")]
	[Address(RVA = "0x446C20", Offset = "0x445E20", VA = "0x180446C20")]
	protected void OnLoadFinished(Vector3 position, Quaternion rotation, CardRoot.ModelType modelType, Action onLoadFinished, Action onPlayFinished)
	{
	}

	[Token(Token = "0x600AD0C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected SummonCardBase()
	{
	}
}
