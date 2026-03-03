using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002D8")]
public class LocalFileAssetBundleLoadRequest
{
	[Token(Token = "0x20002D9")]
	private enum Step
	{
		[Token(Token = "0x4000FA7")]
		Idle,
		[Token(Token = "0x4000FA8")]
		Start,
		[Token(Token = "0x4000FA9")]
		ReadFile,
		[Token(Token = "0x4000FAA")]
		LoadAssetBundle,
		[Token(Token = "0x4000FAB")]
		End
	}

	[Token(Token = "0x20002DA")]
	public enum Result
	{
		[Token(Token = "0x4000FAD")]
		None,
		[Token(Token = "0x4000FAE")]
		Success,
		[Token(Token = "0x4000FAF")]
		Failed,
		[Token(Token = "0x4000FB0")]
		Canceled
	}

	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x10")]
	private Step m_step;

	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x14")]
	private bool m_reqCancel;

	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x18")]
	private LocalFileStream m_fileStream;

	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x20")]
	private AssetBundleCreateRequest m_assetBundleRequest;

	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x28")]
	private ReadRequest m_fileReadRequest;

	[Token(Token = "0x4000FA3")]
	[FieldOffset(Offset = "0x30")]
	public string nativePath;

	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x38")]
	public AssetBundle assetBundle;

	[Token(Token = "0x4000FA5")]
	[FieldOffset(Offset = "0x40")]
	public Result result;

	[Token(Token = "0x170001CB")]
	public bool isEmpty
	{
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x4098D0", Offset = "0x408AD0", VA = "0x1804098D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CC")]
	public bool isDone
	{
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x4098C0", Offset = "0x408AC0", VA = "0x1804098C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CD")]
	public bool isSuccess
	{
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x4098F0", Offset = "0x408AF0", VA = "0x1804098F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CE")]
	public bool isError
	{
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x4098E0", Offset = "0x408AE0", VA = "0x1804098E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170001CF")]
	public bool isCanceled
	{
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x4098B0", Offset = "0x408AB0", VA = "0x1804098B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600116F")]
	[Address(RVA = "0x4097B0", Offset = "0x4089B0", VA = "0x1804097B0")]
	private void clear()
	{
	}

	[Token(Token = "0x6001175")]
	[Address(RVA = "0x409790", Offset = "0x408990", VA = "0x180409790")]
	public LocalFileAssetBundleLoadRequest()
	{
	}

	[Token(Token = "0x6001176")]
	[Address(RVA = "0x4094A0", Offset = "0x4086A0", VA = "0x1804094A0")]
	public void SetStart(string nativePath)
	{
	}

	[Token(Token = "0x6001177")]
	[Address(RVA = "0x409400", Offset = "0x408600", VA = "0x180409400")]
	public void SetCancel()
	{
	}

	[Token(Token = "0x6001178")]
	[Address(RVA = "0x4094E0", Offset = "0x4086E0", VA = "0x1804094E0")]
	public void Update()
	{
	}
}
