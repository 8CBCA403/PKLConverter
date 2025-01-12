using PKHeX.Core;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PKLConverter;

class PKLConverter
{
    private string wcType;
    
    public PKLConverter(string wcType)
    {
        this.wcType = wcType;
    }

    
    public PCD[] MGDB_G4(string pklOpenPath) => EncounterEvent.GetPCDDB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 5</summary>
    public PGF[] MGDB_G5(string pklOpenPath) => EncounterEvent.GetPGFDB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 6</summary>
   // public WC6[] MGDB_G6(string pklOpenPath) => EncounterEvent.GetWC6DB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 7</summary>
    //public WC7[] MGDB_G7(string pklOpenPath) => EncounterEvent.GetWC7DB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 7 <see cref="GameVersion.GG"/></summary>
    public WB7[] MGDB_G7GG(string pklOpenPath) => EncounterEvent.GetWB7DB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 8</summary>
    public WC8[] MGDB_G8(string pklOpenPath) => EncounterEvent.GetWC8DB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 8 <see cref="GameVersion.PLA"/></summary>
    public WA8[] MGDB_G8A(string pklOpenPath) => EncounterEvent.GetWA8DB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 8 <see cref="GameVersion.BDSP"/></summary>
    public WB8[] MGDB_G8B(string pklOpenPath) => EncounterEvent.GetWB8DB(File.ReadAllBytes(pklOpenPath));

    /// <summary>Event Database for Generation 9 <see cref="GameVersion.SV"/></summary>
    public WC9[] MGDB_G9(string pklOpenPath) => EncounterEvent.GetWC9DB(File.ReadAllBytes(pklOpenPath));

    public void UnPack(string pklOpenPath, string wcsSavePath)
    {
        DataMysteryGift[] wcArray = this.wcType.ToUpper() switch
        {
            "WC9" => MGDB_G9(pklOpenPath),
            "WB8" => MGDB_G8(pklOpenPath),
            "WA8" => MGDB_G8A(pklOpenPath),
            "WC8" => MGDB_G8(pklOpenPath),
            "WB7" => MGDB_G7GG(pklOpenPath),
            // "WC7" => MGDB_G7(pklOpenPath),
            // "WC6" => MGDB_G6(pklOpenPath),
            "PGF" => MGDB_G5(pklOpenPath),
            "PCD" => MGDB_G4(pklOpenPath),
            _ => MGDB_G9(pklOpenPath),
        };

        
        int unPackCount = 0;
        foreach (var wc in wcArray)  
        {
            string fildPath = $"({unPackCount})# {wc.CardID}.{this.wcType.ToLower()}";
            File.WriteAllBytesAsync(Path.Join(wcsSavePath, fildPath), wc.Data);
            unPackCount ++ ;
            //MessageBox.Show(fildPath);
        }
        MessageBox.Show("PKL解包完毕！");
        MessageBox.Show($"本次解包{wcArray.Count()}个{this.wcType.ToUpper()}文件！实际保存{unPackCount}个{this.wcType.ToUpper()}文件！");
        
    }

    public void Pack(string[] WCOpenPaths, string pklSavePath)
    {
        byte[] wc = [];
        int packCount = 0;
        foreach (string wcFile in WCOpenPaths)
        {
            if (!wcFile.Contains(this.wcType.ToLower()))
            {
                MessageBox.Show($"{wcFile}处理失败！");
                continue;
            }
                
            wc = wc.Concat(File.ReadAllBytes(wcFile)).ToArray();
            packCount ++;
        }
        File.WriteAllBytesAsync(Path.Join(pklSavePath, $"{this.wcType.ToUpper()}(new).pkl"), wc);
        MessageBox.Show("PKL打包完成！");
        MessageBox.Show($"本次传入{WCOpenPaths.Count()}个{this.wcType.ToUpper()}文件，成功打包{packCount}个{this.wcType.ToUpper()}文件为PKL！");
    }
}



public static class EncounterEvent
{
    #region Locally Loaded Data
    /// <summary>Event Database for Generation 4</summary>
    public static PCD[] EGDB_G4 { get; private set; } = [];

    /// <summary>Event Database for Generation 5</summary>
    public static PGF[] EGDB_G5 { get; private set; } = [];

    /// <summary>Event Database for Generation 6</summary>
    public static WC6[] EGDB_G6 { get; private set; } = [];

    /// <summary>Event Database for Generation 7</summary>
    public static WC7[] EGDB_G7 { get; private set; } = [];

    /// <summary>Event Database for Generation 7 <see cref="GameVersion.GG"/></summary>
    public static WB7[] EGDB_G7GG { get; private set; } = [];

    /// <summary>Event Database for Generation 8</summary>
    public static WC8[] EGDB_G8 { get; private set; } = [];

    /// <summary>Event Database for Generation 8 <see cref="GameVersion.PLA"/></summary>
    public static WA8[] EGDB_G8A { get; private set; } = [];

    /// <summary>Event Database for Generation 8 <see cref="GameVersion.BDSP"/></summary>
    public static WB8[] EGDB_G8B { get; private set; } = [];

    /// <summary>Event Database for Generation 9 <see cref="GameVersion.SV"/></summary>
    public static WC9[] EGDB_G9 { get; private set; } = [];
    #endregion

    public static PCD[] GetPCDDB(ReadOnlySpan<byte> bin) => Get(bin, PCD.Size, static d => new PCD(d));
    public static PGF[] GetPGFDB(ReadOnlySpan<byte> bin) => Get(bin, PGF.Size, static d => new PGF(d));

    public static WC6[] GetWC6DB(ReadOnlySpan<byte> wc6bin, ReadOnlySpan<byte> wc6full) => WC6Full.GetArray(wc6full, wc6bin);
    public static WC7[] GetWC7DB(ReadOnlySpan<byte> wc7bin, ReadOnlySpan<byte> wc7full) => WC7Full.GetArray(wc7full, wc7bin);

    public static WB7[] GetWB7DB(ReadOnlySpan<byte> bin) => Get(bin, WB7.Size, static d => new WB7(d));
    public static WC8[] GetWC8DB(ReadOnlySpan<byte> bin) => Get(bin, WC8.Size, static d => new WC8(d));
    public static WB8[] GetWB8DB(ReadOnlySpan<byte> bin) => Get(bin, WB8.Size, static d => new WB8(d));
    public static WA8[] GetWA8DB(ReadOnlySpan<byte> bin) => Get(bin, WA8.Size, static d => new WA8(d));
    public static WC9[] GetWC9DB(ReadOnlySpan<byte> bin) => Get(bin, WC9.Size, static d => new WC9(d));

    private static T[] Get<T>(ReadOnlySpan<byte> bin, int size, Func<byte[], T> ctor)
    {
        // bin is a multiple of size
        // bin.Length % size == 0
        var result = new T[bin.Length / size];
        Debug.Assert(result.Length * size == bin.Length);
        for (int i = 0; i < result.Length; i++)
        {
            var offset = i * size;
            var slice = bin.Slice(offset, size).ToArray();
            result[i] = ctor(slice);
        }
        return result;
    }

    /// <summary>
    /// Reloads the locally stored event templates.
    /// </summary>
    /// <param name="paths">External folder(s) to source individual mystery gift template files from.</param>
    public static void RefreshMGDB(params ReadOnlySpan<string> paths)
    {
        // If no paths are provided, clear the arrays. See the bottom of this method.
        HashSet<PCD>? g4 = null; List<PCD>? lg4 = null;
        HashSet<PGF>? g5 = null; List<PGF>? lg5 = null;
        HashSet<WC6>? g6 = null; List<WC6>? lg6 = null;
        HashSet<WC7>? g7 = null; List<WC7>? lg7 = null;
        HashSet<WB7>? b7 = null; List<WB7>? lb7 = null;
        HashSet<WC8>? g8 = null; List<WC8>? lg8 = null;
        HashSet<WB8>? b8 = null; List<WB8>? lb8 = null;
        HashSet<WA8>? a8 = null; List<WA8>? la8 = null;
        HashSet<WC9>? g9 = null; List<WC9>? lg9 = null;

        // Load external files
        // For each file, load the gift object into the appropriate list.
        foreach (var path in paths)
        {
            if (!Directory.Exists(path))
                continue;
            var gifts = MysteryUtil.GetGiftsFromFolder(path);
            foreach (var gift in gifts)
            {
                var added = gift switch
                {
                    PCD pcd => AddOrExpand(ref g4, ref lg4, pcd),
                    PGF pgf => AddOrExpand(ref g5, ref lg5, pgf),
                    WC6 wc6 => AddOrExpand(ref g6, ref lg6, wc6),
                    WC7 wc7 => AddOrExpand(ref g7, ref lg7, wc7),
                    WB7 wb7 => AddOrExpand(ref b7, ref lb7, wb7),
                    WC8 wc8 => AddOrExpand(ref g8, ref lg8, wc8),
                    WB8 wb8 => AddOrExpand(ref b8, ref lb8, wb8),
                    WA8 wa8 => AddOrExpand(ref a8, ref la8, wa8),
                    WC9 wc9 => AddOrExpand(ref g9, ref lg9, wc9),
                    _ => false,
                };
                if (!added)
                    Trace.WriteLine($"Failed to add gift in {Path.GetDirectoryName(path)}: {gift.FileName}");

                static bool AddOrExpand<T>(ref HashSet<T>? arr, ref List<T>? extra, T obj)
                {
                    if (arr is null)
                    {
                        // Most users won't be adding more than 1-2 gifts
                        // Save memory by initializing the HashSet and List minimally.
                        arr = new HashSet<T>(1);
                        extra = new List<T>(1);
                    }
                    if (arr.Add(obj))
                        extra!.Add(obj);
                    return true;
                }
            }
            EGDB_G4 = SetArray(lg4);
            EGDB_G5 = SetArray(lg5);
            EGDB_G6 = SetArray(lg6);
            EGDB_G7 = SetArray(lg7);
            EGDB_G7GG = SetArray(lb7);
            EGDB_G8 = SetArray(lg8);
            EGDB_G8A = SetArray(la8);
            EGDB_G8B = SetArray(lb8);
            EGDB_G9 = SetArray(lg9);
            continue;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static T[] SetArray<T>(List<T>? update) => update is null ? [] : update.ToArray();
        }
    }

    
}

