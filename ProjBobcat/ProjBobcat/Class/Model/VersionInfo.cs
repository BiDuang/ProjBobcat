﻿using System.Collections.Generic;

namespace ProjBobcat.Class.Model;

public class VersionInfo
{
    /// <summary>
    ///     为启动器引用准备的带有tag的名称。
    ///     A name with a tag provided for the launcher's reference.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     该版本的真实id，例如1.14-forge-xxx
    ///     The real id of this version, like 1.14-forge-xxx
    /// </summary>
    public string? Id { get; set; }

    public string DirName { get; set; }

    public JavaVersionModel? JavaVersion { get; set; }

    public string? MainClass { get; set; }
    public string Assets { get; set; }
    public Asset? AssetInfo { get; set; }
    public List<FileInfo>? Libraries { get; set; }
    public List<NativeFileInfo>? Natives { get; set; }
    public Logging Logging { get; set; }
    public IEnumerable<string> JvmArguments { get; set; }
    public IEnumerable<string> GameArguments { get; set; }
    public Dictionary<string, string> AvailableGameArguments { get; set; }

#nullable enable
    /// <summary>
    ///     在递归式继承中最古老的版本（递归终点）。
    ///     The oldest version inherited (recursive).
    /// </summary>
    public string? RootVersion { get; set; }
#nullable restore
}