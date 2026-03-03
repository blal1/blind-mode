using System;
using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002F8")]
public class StandardStorageIO : StorageIO
{
	[Token(Token = "0x4001015")]
	private const int HASHDIRNUM = 256;

	[Token(Token = "0x4001016")]
	private const string PLAINROOTDIR = "root";

	[Token(Token = "0x600127A")]
	[Address(RVA = "0x4173B0", Offset = "0x4165B0", VA = "0x1804173B0")]
	protected void setupStorageDirectory(Storage storage, string mountPath)
	{
	}

	[Token(Token = "0x600127B")]
	[Address(RVA = "0x417120", Offset = "0x416320", VA = "0x180417120")]
	protected static void createStorageDirectory(string hashRoot, string plainRoot)
	{
	}

	[Token(Token = "0x600127C")]
	[Address(RVA = "0x416FD0", Offset = "0x4161D0", VA = "0x180416FD0", Slot = "4")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x600127D")]
	[Address(RVA = "0x416BA0", Offset = "0x415DA0", VA = "0x180416BA0", Slot = "6")]
	public override bool ExistsFile(string nativePath)
	{
		return default(bool);
	}

	[Token(Token = "0x600127E")]
	[Address(RVA = "0x416B80", Offset = "0x415D80", VA = "0x180416B80", Slot = "7")]
	public override void DeleteFile(string nativePath)
	{
	}

	[Token(Token = "0x600127F")]
	[Address(RVA = "0x416D20", Offset = "0x415F20", VA = "0x180416D20", Slot = "8")]
	public override long GetFileSize(string nativePath)
	{
		return default(long);
	}

	[Token(Token = "0x6001280")]
	[Address(RVA = "0x416FB0", Offset = "0x4161B0", VA = "0x180416FB0", Slot = "9")]
	public override void MoveFile(string srcNativePath, string dstNativePath)
	{
	}

	[Token(Token = "0x6001281")]
	[Address(RVA = "0x416B90", Offset = "0x415D90", VA = "0x180416B90", Slot = "10")]
	public override bool ExistsDirectory(string nativePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6001282")]
	[Address(RVA = "0x416B60", Offset = "0x415D60", VA = "0x180416B60", Slot = "11")]
	public override void CreateDirectory(string nativePath)
	{
	}

	[Token(Token = "0x6001283")]
	[Address(RVA = "0x416BE0", Offset = "0x415DE0", VA = "0x180416BE0", Slot = "12")]
	public override string[] GetDirectories(string nativePath)
	{
		return null;
	}

	[Token(Token = "0x6001284")]
	[Address(RVA = "0x416D90", Offset = "0x415F90", VA = "0x180416D90", Slot = "13")]
	public override string[] GetFiles(string nativePath, string searchPattern)
	{
		return null;
	}

	[Token(Token = "0x6001285")]
	[Address(RVA = "0x416B70", Offset = "0x415D70", VA = "0x180416B70", Slot = "14")]
	public override void DeleteDirectory(string nativePath)
	{
	}

	[Token(Token = "0x6001286")]
	[Address(RVA = "0x416F90", Offset = "0x416190", VA = "0x180416F90", Slot = "15")]
	public override void MoveDirectory(string srcNativePath, string dstNativePath)
	{
	}

	[Token(Token = "0x6001287")]
	[Address(RVA = "0x416F00", Offset = "0x416100", VA = "0x180416F00", Slot = "16")]
	public override string GetStreamingAssetNativePath(string name)
	{
		return null;
	}

	[Token(Token = "0x6001288")]
	[Address(RVA = "0x416BB0", Offset = "0x415DB0", VA = "0x180416BB0", Slot = "17")]
	public override bool ExistsStreamingAsset(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6001289")]
	[Address(RVA = "0x4170F0", Offset = "0x4162F0", VA = "0x1804170F0", Slot = "18")]
	public override byte[] ReadStreamingAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x600128A")]
	[Address(RVA = "0x417080", Offset = "0x416280", VA = "0x180417080", Slot = "19")]
	public override void ReadStreamingAssetCallback(string name, Action<byte[]> readCallback)
	{
	}

	[Token(Token = "0x600128B")]
	[Address(RVA = "0x416720", Offset = "0x415920", VA = "0x180416720", Slot = "20")]
	public override void ClearLocalDataStorage(Action finishCallback)
	{
	}

	[Token(Token = "0x600128C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public StandardStorageIO()
	{
	}
}
