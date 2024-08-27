﻿using NetWare.Attributes;
using UnityEngine;

namespace NetWare.Configuration.Subtypes.Visual;

public sealed class SkeletonConfig : IBindable
{
    [ConfigProperty] public bool Enabled { get; set; } = false;

    [ConfigProperty] public string TeamColor { get; set; } = "#00FF00";
    [ConfigProperty] public string EnemyColor { get; set; } = "#FF0000";
    [ConfigProperty] public string BotColor { get; set; } = "#FFFFFF";

    [ConfigProperty] public KeyCode? KeyBind { get; set; } = KeyCode.None;
}
